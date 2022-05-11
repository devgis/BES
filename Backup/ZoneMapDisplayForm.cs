using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapApp.Forms.MapConfig;
using MapInfo.Mapping;
using MapInfo.Geometry;
using MapInfo.Tools;
using MapInfo.Styles;
using MapInfo.Data;
using System.IO;
using MapApp.Commons;
using System.Diagnostics;
using MapInfo.Printing;
using MapApp.Forms.Other;
using MapApp.Forms;

namespace MapApp.Other
{
    public partial class ZoneMapDisplayForm : Form
    {
        //private String SelectedPointID = "";
        private Feature SelectedFeature = null;
        //private String StationID = "";//楼层;
        private String StoreID = "";//书城;
        private String ShuGuiID = "";//柜号
        private String FloorName = "";//楼层;
        private String ZoneID = "";
        private readonly WaitForm _waitform = new WaitForm();

        private DPoint dpCenter;
        private double Scale;
        Timer t = new Timer();
        //使图元闪烁
        private IResultSetFeatureCollection ifs;
        private bool bFlash = false;
        MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
        MapInfo.Styles.SimpleLineStyle simpleLineStyle;

        public ZoneMapDisplayForm(String StoreID, String FloorName, String ZoneID, String ShuGuiID)
        {
            InitializeComponent();

            this.Text = StoreID + " " + FloorName + "楼 " + ZoneID + "区 平面图";
            this.StoreID = StoreID;
            //this.StationID = FloorID;
            this.FloorName = FloorName;
            this.ZoneID = ZoneID;
            this.ShuGuiID = ShuGuiID;
            
            mapControl1.Map.ViewChangedEvent += new MapInfo.Mapping.ViewChangedEventHandler(Map_ViewChangedEvent);
            Map_ViewChangedEvent(this, null);
            mapControl1.Tools.FeatureSelected += new FeatureSelectedEventHandler(Tools_FeatureSelected);
            mapControl1.Tools.FeatureSelecting += new FeatureSelectingEventHandler(Tools_FeatureSelecting);
            mapControl1.MouseMove += new MouseEventHandler(mapControl1_MouseMove);
        }

        void mapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm.ADTime = 0;
            System.Drawing.Point p3 = new System.Drawing.Point(e.X, e.Y);
            MapInfo.Geometry.DisplayTransform converter = mapControl1.Map.DisplayTransform;
            //converter.FromDisplay(p3, out p31);
        }

        void Tools_FeatureSelecting(object sender, FeatureSelectingEventArgs e)
        {
            try
            {
                if (e.Selection.Count > 1)
                {
                    e.Cancel = true;
                }
                else
                {
                    IResultSetFeatureCollection fSelectCollection = e.Selection[0];
                    if (fSelectCollection.Count > 1)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {
                e.Cancel = true;
            }
        }

        void Tools_FeatureSelected(object sender, FeatureSelectedEventArgs e)
        {
            try 
            {
                IResultSetFeatureCollection fSelectCollection = e.Selection[0];
                SelectedFeature = fSelectCollection[0];
                //OldX = (SelectedFeature.Geometry as MapInfo.Geometry.Point).Centroid.x;
                //OldY = (SelectedFeature.Geometry as MapInfo.Geometry.Point).Centroid.y;
            }
            catch
            {
                //SelectedPointID = "";
                SelectedFeature = null;
            }
        }

        void Map_ViewChangedEvent(object sender, MapInfo.Mapping.ViewChangedEventArgs e)
        {
            // Display the zoom level
            Double dblZoom = System.Convert.ToDouble(String.Format("{0:E2}", mapControl1.Map.Zoom.Value));
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = "缩放: " + dblZoom.ToString() + " " + MapInfo.Geometry.CoordSys.DistanceUnitAbbreviation(mapControl1.Map.Zoom.Unit);
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapForm_Load(object sender, EventArgs e)
        {
            //加载并定位数据
            this.LoadData();
        }


        private void LoadData()
        {
            _waitform.sValue = "加载中，请稍后......";
            _waitform.Show();
            mapControl1.Map.Layers.Clear();
            toolStripStatusLabel3.Text = "";

            //MapApp.Entities.Floor StationObject;
            try
            {
                DataSet ds = new MapApp.BLL.ZoneMapFile().GetZoneFile(this.StoreID,this.FloorName,this.ZoneID);
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    throw new Exception("地图数据不正确，请检查！");
                }

                String TempMapPath = Application.StartupPath + "\\temp\\zone\\";
                if (Directory.Exists(TempMapPath))
                {
                    String[] Files = Directory.GetFiles(TempMapPath);
                    String[] FilePaths = Directory.GetDirectories(TempMapPath);
                    foreach (String sFile in Files)
                    {
                        try
                        {
                            File.Delete(sFile);
                        }
                        catch
                        { }
                    }

                    foreach (String sFilePath in FilePaths)
                    {
                        try
                        {
                            Directory.Delete(sFilePath, true);
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    Directory.CreateDirectory(TempMapPath);
                }
                TempMapPath = Application.StartupPath + "\\temp\\zone\\" + (new Random().Next(100000, 999999).ToString()) + "\\";
                if (!Directory.Exists(TempMapPath))
                {
                    Directory.CreateDirectory(TempMapPath);
                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string FileName = TempMapPath + dr["FileName"].ToString();
                    //if (File.Exists(FileName))
                    //{
                    //    File.Delete(FileName);
                    //}

                    FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    Byte[] bByte = (Byte[])dr["FileContent"];
                    fs.Write(bByte, 0, Convert.ToInt32(bByte.Length));
                    fs.Close();
                }

                //if (!File.Exists(Application.StartupPath + "\\temp\\map.tab"))
                //{
                //    throw new Exception("地图数据不正确，请检查！");
                //}

                //string[] sTablePales ={ Application.StartupPath + "\\temp\\map.tab"};
                //MapTableLoader mapTableLoader = new MapTableLoader(sTablePales);
                //mapControl1.Map.Load(mapTableLoader);

                MapWorkSpaceLoader mwsLoader = new MapWorkSpaceLoader(TempMapPath+"zone.mws");
                mapControl1.Map.Load(mwsLoader);

                dpCenter = mapControl1.Map.Center;
                Scale=mapControl1.Map.Scale;

                ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2是面透明       
                //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                ////simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2表示填充//透明，即能够显示轮廓 
                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 0); //0表示全部透明，即连轮
                ////廓都看不到


                ////SimpleLineStyle lineStyle = new SimpleLineStyle(new LineWidth(4, LineWidthUnit.Pixel), Color.Black, Color.Red);

                //AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, new MapInfo.Styles.SimpleInterior(9, System.Drawing.Color.Blue, System.Drawing.Color.Blue, true));

                //MapInfo.Engine.Session.Current.Selections.DefaultSelection.Style.AreaStyle.ApplyStyle(areaStyle);
                ////MapInfo.Styles.AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, simpleInterior);
                ////simpleInterior.BackColor = Color.Red;
                ////simpleInterior.ForeColor = Color.Red;
                ////MapInfo.Styles.CompositeStyle compositeStyle = new MapInfo.Styles.CompositeStyle(areaStyle, null, null, null); 
                ////加载标签
                ////this.LoadLabel();

                //查询选中柜号需要做
                String Where = String.Format("name='{0}'", this.ShuGuiID);
                SearchInfo si = MapInfo.Data.SearchInfoFactory.SearchWhere(Where);
                si.QueryDefinition.Columns = null;
              //if (ifs!=null)
              //ifs.Clear();
                //String TableName = mapControl1.Map.Layers["shugui"].Alias;
                FeatureLayer fl = mapControl1.Map.Layers["shugui"] as FeatureLayer;
                this.ifs = MapInfo.Engine.Session.Current.Catalog.Search(fl.Table, si);
                //this.ifs = MapInfo.Engine.Session.Current.Catalog.Search(MapInfo.Engine.Session.Current.Catalog.GetTable("shugui"), si);
                if (ifs.Count <= 0)
                {
                    MessageBox.Show("没有符合条件的查询结果!", "图书查询系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception("没有符合条件的查询结果!");
                    //MessageBox.Show("没有符合条件的数据,请检查地图数据！", "图书查询系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //_waitform.Hide();
                    //return;
                }
                else
                {
                    mapControl1.Map.Center = ifs[0].Geometry.Centroid;//定位到当前图元
                    MapInfo.Engine.Session.Current.Selections.DefaultSelection.Clear();
                    MapInfo.Engine.Session.Current.Selections.DefaultSelection.Add(ifs);
               
                    mapControl1.Map.Center = dpCenter;
                    mapControl1.Map.Scale = Scale;

                    ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2是面透明       
                    //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                    //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                    ////simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2表示填充//透明，即能够显示轮廓 
                    //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0表示全部透明，即连轮
                    ////廓都看不到


                    ////SimpleLineStyle lineStyle = new SimpleLineStyle(new LineWidth(4, LineWidthUnit.Pixel), Color.Black, Color.Red);

                    //AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, new MapInfo.Styles.SimpleInterior(9, System.Drawing.Color.Blue, System.Drawing.Color.Blue, true));

                    //MapInfo.Engine.Session.Current.Selections.DefaultSelection.Style.AreaStyle.ApplyStyle(areaStyle);
                    ////MapInfo.Styles.AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, simpleInterior);
                    ////simpleInterior.BackColor = Color.Red;
                    ////simpleInterior.ForeColor = Color.Red;
                    ////MapInfo.Styles.CompositeStyle compositeStyle = new MapInfo.Styles.CompositeStyle(areaStyle, null, null, null); 

                    t.Tick += new EventHandler(t_Tick);
                    t.Enabled = true;
                    t.Interval = 500;
             
                }

               
                _waitform.Hide();
                //this.LoadMap(TempMapPath + "map.mws", StationId, StationName);
            
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载地图发生错误："+ex.Message, "图书查询系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //StationName = "";
                //StationObject = null;
                this.StoreID = String.Empty;
                _waitform.Hide();
                this.Dispose();
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            //使图元闪烁
            if (bFlash)
            {

                ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2是面透明       
                //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2表示填充//透明，即能够显示轮廓 
                simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0表示全部透明，即连轮
                //廓都看不到


                //SimpleLineStyle lineStyle = new SimpleLineStyle(new LineWidth(4, LineWidthUnit.Pixel), Color.Black, Color.Red);

                AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle,new MapInfo.Styles.SimpleInterior(9,Color.Blue));

                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Style.AreaStyle.ApplyStyle(areaStyle);
                //MapInfo.Styles.AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, simpleInterior);
                //simpleInterior.BackColor = Color.Red;
                //simpleInterior.ForeColor = Color.Red;
                //MapInfo.Styles.CompositeStyle compositeStyle = new MapInfo.Styles.CompositeStyle(areaStyle, null, null, null); 
                
                
                
                
                
                
                
                
                
                
              //MapInfo.Engine.Session.Current.Selections.DefaultSelection.Clear();
                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Clear();
                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Add(ifs);
                bFlash = false;
                mapControl1.Refresh();
            }
            else
            {
                //simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2是面透明       
          

                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2表示填充//透明，即能够显示轮廓 
                simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0表示全部透明，即连轮
                //廓都看不到


                //SimpleLineStyle lineStyle = new SimpleLineStyle(new LineWidth(4, LineWidthUnit.Pixel), Color.Black, Color.Red);

                AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, new MapInfo.Styles.SimpleInterior(9,Color.Red));

                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Style.AreaStyle.ApplyStyle(areaStyle);
                //MapInfo.Styles.AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, simpleInterior);
                //simpleInterior.BackColor = Color.Red;
                //simpleInterior.ForeColor = Color.Red;
                //MapInfo.Styles.CompositeStyle compositeStyle = new MapInfo.Styles.CompositeStyle(areaStyle, null, null, null); 


                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Clear();
                MapInfo.Engine.Session.Current.Selections.DefaultSelection.Add(ifs);
                bFlash = true;
                mapControl1.Refresh();
            }
        }

        private void mapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (SelectedFeature != null && !String.IsNullOrEmpty(SelectedFeature["name"].ToString()) && String.IsNullOrEmpty(SelectedFeature["selectable"].ToString()))
                {
                    cmsNodeManager.Show(e.Location);
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                DPoint dp = new DPoint();
                MapInfo.Geometry.DisplayTransform converter = mapControl1.Map.DisplayTransform;
                converter.FromDisplay(e.Location, out dp);

                SearchInfo si = MapInfo.Data.SearchInfoFactory.SearchIntersectsGeometry(new MapInfo.Geometry.Point(this.mapControl1.Map.GetDisplayCoordSys(), dp), IntersectType.Geometry);
                si.QueryDefinition.Columns = null;
                IResultSetFeatureCollection ifsResult = MapInfo.Engine.Session.Current.Catalog.Search(MapInfo.Engine.Session.Current.Catalog.GetTable("shugui"), si);
                if (ifsResult.Count > 0)
                {
                    try
                    {
                        BooksInfoList frmBooksInfoList = new BooksInfoList(this.StoreID, ifsResult[0]["name"].ToString());
                        frmBooksInfoList.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查询出错：" + ex.Message, "图书查询系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        //private void LoadLabel()
        //{
        //    LabelSource source = new LabelSource(MapInfo.Engine.Session.Current.Catalog.GetTable("map"));//绑定Table
        //    source.DefaultLabelProperties.Caption = "name";//指定哪个字段作为显示标注
        //    source.DefaultLabelProperties.Style.Font.ForeColor = Color.Red;
        //    ////标注样式等属性,指在一定的缩放比例范围内显示文本  //
        //    //source.DefaultLabelProperties.Visibility.Enabled = true;  //
        //    //source.DefaultLabelProperties.Visibility.VisibleRangeEnabled = true;  //
        //    //source.DefaultLabelProperties.Visibility.VisibleRange = new VisibleRange(0.01, 10, MapInfo.Geometry.DistanceUnit.Mile);  
        //    //source.DefaultLabelProperties.Visibility.AllowDuplicates = true;  //如果其标注属性将该属性设置为 true，即使是和其它较高优先权标注重复的标注也会生成。  
        //    //source.DefaultLabelProperties.Visibility.AllowOverlap = true;  
        //    //source.DefaultLabelProperties.Visibility.AllowOutOfView = true;  //如果要标注的图元有部分在视图内，标注引用位置超出当前视图时，设置 AllowOutOfView 为 true 会重新计算标注引用位置。   
        //    //source.Maximum = 50;  //控制为标注源自动生成的标注的最大数目。  //
        //    //source.DefaultLabelProperties.Layout.UseRelativeOrientation = true;  //该属性为 true 时，根据原始的参考几何体（要标注的几何体）确定标注的角度。  //
        //    //source.DefaultLabelProperties.Layout.RelativeOrientation = MapInfo.Text.RelativeOrientation.FollowPath;  //Parallel 绘制的文本与锚定的直线或折线段具有相同的角度。  //FollowPath 文本后跟锚定的折线段的轮廓。  
        //    //source.DefaultLabelProperties.Layout.Alignment =MapInfo.Text.Alignment.BottomRight;  
        //    //CenterCenter 文本在其锚定内居中。   
        //    //TopLeft 文本位于其锚定的左上方。   
        //    //TopCenter 文本在其锚定上方居中。  
        //    //TopRight 文本位于其锚定的右上方。   
        //    //CenterLeft 文本在其锚定左侧垂直居中。   
        //    //CenterRight 文本在其锚定右侧垂直居中。   
        //    //BottomLeft 文本位于其锚定的左下方。   
        //    //BottomCenter 文本在其锚定以下居中。   
        //    //BottomRight 文本位于其锚定的右下方。   
        //    source.DefaultLabelProperties.CalloutLine.Use = false;  //是否使用标注线  
        //    //
        //    //source.DefaultLabelProperties.CalloutLine.Type = CalloutLineType.Simple; 
        //    //Use 为 true 时，该属性按照源于已枚举 CalloutLineType 的值确定要使用的标注线类型  
        //    //Simple 指示文本使用简单的标注线（没有指向其参考几何体的指针）。  
        //    //Arrow 指示文本使用指向其参考几何体的箭头。   
        //    //
        //    ////source.DefaultLabelProperties.CalloutLine.Target=  //设置指向的可选位置。 为空时，文本位置按照 Point 由引用位置定义。  
        //    //MapInfo.Styles.SimpleLineStyle simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(0);      //标注注释线  //
        //    //source.DefaultLabelProperties.Style.CalloutLine.ApplyStyle(simpleLineStyle);  
        //    //source.DefaultLabelProperties.Layout.Angle = 33.0;  
        //    source.DefaultLabelProperties.Layout.Offset = 5;//标注偏移  
        //    //MapInfo.Styles.Font font = new MapInfo.Styles.Font("黑体", 12);  
        //    //MapInfo.Styles.Font font = new MapInfo.Styles.Font("宋体", 10); 
        //    //font.ForeColor =System.Drawing.Color.Red;  
        //    //source.DefaultLabelProperties.Style.Font =font;  //设置标注  
        //    LabelLayer labelLayer = new LabelLayer();
        //    labelLayer.Sources.Append(source);//加载指定数据
        //    mapControl1.Map.Layers.Add(labelLayer);

        //    mapControl1.Tools.LeftButtonTool = "Select";
        //    mapToolBarButtonSelect.Pushed = true;
        //}

        #region 右键菜单
        private void tsmiViewBooks_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(SelectedFeature["NAME"].ToString());
                BooksInfoList frmBooksInfoList = new BooksInfoList(this.StoreID, SelectedFeature["NAME"].ToString());
                frmBooksInfoList.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("查询出错：" + ex.Message, "图书查询系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void MapDisplayForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void mapControl1_DoubleClick(object sender, EventArgs e)
        {
            //BooksInfoList frmBooksInfoList = new BooksInfoList(this.StoreID, this.ShuGuiID);
            //frmBooksInfoList.ShowDialog();
        }

        private void ZoneMapDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            try
            {
                mapControl1.Map.Clear();
            }
            catch
            { }
        }
    }
}