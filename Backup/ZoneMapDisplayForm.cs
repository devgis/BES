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
        //private String StationID = "";//¥��;
        private String StoreID = "";//���;
        private String ShuGuiID = "";//���
        private String FloorName = "";//¥��;
        private String ZoneID = "";
        private readonly WaitForm _waitform = new WaitForm();

        private DPoint dpCenter;
        private double Scale;
        Timer t = new Timer();
        //ʹͼԪ��˸
        private IResultSetFeatureCollection ifs;
        private bool bFlash = false;
        MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
        MapInfo.Styles.SimpleLineStyle simpleLineStyle;

        public ZoneMapDisplayForm(String StoreID, String FloorName, String ZoneID, String ShuGuiID)
        {
            InitializeComponent();

            this.Text = StoreID + " " + FloorName + "¥ " + ZoneID + "�� ƽ��ͼ";
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
                statusStrip1.Items[0].Text = "����: " + dblZoom.ToString() + " " + MapInfo.Geometry.CoordSys.DistanceUnitAbbreviation(mapControl1.Map.Zoom.Unit);
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapForm_Load(object sender, EventArgs e)
        {
            //���ز���λ����
            this.LoadData();
        }


        private void LoadData()
        {
            _waitform.sValue = "�����У����Ժ�......";
            _waitform.Show();
            mapControl1.Map.Layers.Clear();
            toolStripStatusLabel3.Text = "";

            //MapApp.Entities.Floor StationObject;
            try
            {
                DataSet ds = new MapApp.BLL.ZoneMapFile().GetZoneFile(this.StoreID,this.FloorName,this.ZoneID);
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    throw new Exception("��ͼ���ݲ���ȷ�����飡");
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
                //    throw new Exception("��ͼ���ݲ���ȷ�����飡");
                //}

                //string[] sTablePales ={ Application.StartupPath + "\\temp\\map.tab"};
                //MapTableLoader mapTableLoader = new MapTableLoader(sTablePales);
                //mapControl1.Map.Load(mapTableLoader);

                MapWorkSpaceLoader mwsLoader = new MapWorkSpaceLoader(TempMapPath+"zone.mws");
                mapControl1.Map.Load(mwsLoader);

                dpCenter = mapControl1.Map.Center;
                Scale=mapControl1.Map.Scale;

                ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2����͸��       
                //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                ////simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2��ʾ���//͸�������ܹ���ʾ���� 
                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 0); //0��ʾȫ��͸����������
                ////����������


                ////SimpleLineStyle lineStyle = new SimpleLineStyle(new LineWidth(4, LineWidthUnit.Pixel), Color.Black, Color.Red);

                //AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, new MapInfo.Styles.SimpleInterior(9, System.Drawing.Color.Blue, System.Drawing.Color.Blue, true));

                //MapInfo.Engine.Session.Current.Selections.DefaultSelection.Style.AreaStyle.ApplyStyle(areaStyle);
                ////MapInfo.Styles.AreaStyle areaStyle = new MapInfo.Styles.AreaStyle(simpleLineStyle, simpleInterior);
                ////simpleInterior.BackColor = Color.Red;
                ////simpleInterior.ForeColor = Color.Red;
                ////MapInfo.Styles.CompositeStyle compositeStyle = new MapInfo.Styles.CompositeStyle(areaStyle, null, null, null); 
                ////���ر�ǩ
                ////this.LoadLabel();

                //��ѯѡ�й����Ҫ��
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
                    MessageBox.Show("û�з��������Ĳ�ѯ���!", "ͼ���ѯϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //throw new Exception("û�з��������Ĳ�ѯ���!");
                    //MessageBox.Show("û�з�������������,�����ͼ���ݣ�", "ͼ���ѯϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //_waitform.Hide();
                    //return;
                }
                else
                {
                    mapControl1.Map.Center = ifs[0].Geometry.Centroid;//��λ����ǰͼԪ
                    MapInfo.Engine.Session.Current.Selections.DefaultSelection.Clear();
                    MapInfo.Engine.Session.Current.Selections.DefaultSelection.Add(ifs);
               
                    mapControl1.Map.Center = dpCenter;
                    mapControl1.Map.Scale = Scale;

                    ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2����͸��       
                    //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                    //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                    ////simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2��ʾ���//͸�������ܹ���ʾ���� 
                    //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0��ʾȫ��͸����������
                    ////����������


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
                MessageBox.Show("���ص�ͼ��������"+ex.Message, "ͼ���ѯϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //StationName = "";
                //StationObject = null;
                this.StoreID = String.Empty;
                _waitform.Hide();
                this.Dispose();
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            //ʹͼԪ��˸
            if (bFlash)
            {

                ////simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2����͸��       
                //MapInfo.Styles.LineWidth lineWidth = new MapInfo.Styles.LineWidth(1, MapInfo.Styles.LineWidthUnit.Point);
                //MapInfo.Styles.SimpleLineStyle simpleLineStyle;

                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2��ʾ���//͸�������ܹ���ʾ���� 
                simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0��ʾȫ��͸����������
                //����������


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
                //simpleInterior = new MapInfo.Styles.SimpleInterior(2); //2����͸��       
          

                //simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 2, Color.Black); //2��ʾ���//͸�������ܹ���ʾ���� 
                simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(lineWidth, 1); //0��ʾȫ��͸����������
                //����������


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
                        MessageBox.Show("��ѯ����" + ex.Message, "ͼ���ѯϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        //private void LoadLabel()
        //{
        //    LabelSource source = new LabelSource(MapInfo.Engine.Session.Current.Catalog.GetTable("map"));//��Table
        //    source.DefaultLabelProperties.Caption = "name";//ָ���ĸ��ֶ���Ϊ��ʾ��ע
        //    source.DefaultLabelProperties.Style.Font.ForeColor = Color.Red;
        //    ////��ע��ʽ������,ָ��һ�������ű�����Χ����ʾ�ı�  //
        //    //source.DefaultLabelProperties.Visibility.Enabled = true;  //
        //    //source.DefaultLabelProperties.Visibility.VisibleRangeEnabled = true;  //
        //    //source.DefaultLabelProperties.Visibility.VisibleRange = new VisibleRange(0.01, 10, MapInfo.Geometry.DistanceUnit.Mile);  
        //    //source.DefaultLabelProperties.Visibility.AllowDuplicates = true;  //������ע���Խ�����������Ϊ true����ʹ�Ǻ������ϸ�����Ȩ��ע�ظ��ı�עҲ�����ɡ�  
        //    //source.DefaultLabelProperties.Visibility.AllowOverlap = true;  
        //    //source.DefaultLabelProperties.Visibility.AllowOutOfView = true;  //���Ҫ��ע��ͼԪ�в�������ͼ�ڣ���ע����λ�ó�����ǰ��ͼʱ������ AllowOutOfView Ϊ true �����¼����ע����λ�á�   
        //    //source.Maximum = 50;  //����Ϊ��עԴ�Զ����ɵı�ע�������Ŀ��  //
        //    //source.DefaultLabelProperties.Layout.UseRelativeOrientation = true;  //������Ϊ true ʱ������ԭʼ�Ĳο������壨Ҫ��ע�ļ����壩ȷ����ע�ĽǶȡ�  //
        //    //source.DefaultLabelProperties.Layout.RelativeOrientation = MapInfo.Text.RelativeOrientation.FollowPath;  //Parallel ���Ƶ��ı���ê����ֱ�߻����߶ξ�����ͬ�ĽǶȡ�  //FollowPath �ı����ê�������߶ε�������  
        //    //source.DefaultLabelProperties.Layout.Alignment =MapInfo.Text.Alignment.BottomRight;  
        //    //CenterCenter �ı�����ê���ھ��С�   
        //    //TopLeft �ı�λ����ê�������Ϸ���   
        //    //TopCenter �ı�����ê���Ϸ����С�  
        //    //TopRight �ı�λ����ê�������Ϸ���   
        //    //CenterLeft �ı�����ê����ഹֱ���С�   
        //    //CenterRight �ı�����ê���Ҳഹֱ���С�   
        //    //BottomLeft �ı�λ����ê�������·���   
        //    //BottomCenter �ı�����ê�����¾��С�   
        //    //BottomRight �ı�λ����ê�������·���   
        //    source.DefaultLabelProperties.CalloutLine.Use = false;  //�Ƿ�ʹ�ñ�ע��  
        //    //
        //    //source.DefaultLabelProperties.CalloutLine.Type = CalloutLineType.Simple; 
        //    //Use Ϊ true ʱ�������԰���Դ����ö�� CalloutLineType ��ֵȷ��Ҫʹ�õı�ע������  
        //    //Simple ָʾ�ı�ʹ�ü򵥵ı�ע�ߣ�û��ָ����ο��������ָ�룩��  
        //    //Arrow ָʾ�ı�ʹ��ָ����ο�������ļ�ͷ��   
        //    //
        //    ////source.DefaultLabelProperties.CalloutLine.Target=  //����ָ��Ŀ�ѡλ�á� Ϊ��ʱ���ı�λ�ð��� Point ������λ�ö��塣  
        //    //MapInfo.Styles.SimpleLineStyle simpleLineStyle = new MapInfo.Styles.SimpleLineStyle(0);      //��עע����  //
        //    //source.DefaultLabelProperties.Style.CalloutLine.ApplyStyle(simpleLineStyle);  
        //    //source.DefaultLabelProperties.Layout.Angle = 33.0;  
        //    source.DefaultLabelProperties.Layout.Offset = 5;//��עƫ��  
        //    //MapInfo.Styles.Font font = new MapInfo.Styles.Font("����", 12);  
        //    //MapInfo.Styles.Font font = new MapInfo.Styles.Font("����", 10); 
        //    //font.ForeColor =System.Drawing.Color.Red;  
        //    //source.DefaultLabelProperties.Style.Font =font;  //���ñ�ע  
        //    LabelLayer labelLayer = new LabelLayer();
        //    labelLayer.Sources.Append(source);//����ָ������
        //    mapControl1.Map.Layers.Add(labelLayer);

        //    mapControl1.Tools.LeftButtonTool = "Select";
        //    mapToolBarButtonSelect.Pushed = true;
        //}

        #region �Ҽ��˵�
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
                MessageBox.Show("��ѯ����" + ex.Message, "ͼ���ѯϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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