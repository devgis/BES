using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace BES.WebService
{
    /// <summary>
    /// PLUService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PLUService : System.Web.Services.WebService
    {
        BES.BLL.PLU bllPLU;
        public PLUService()
        {
            bllPLU = new BES.BLL.PLU();
        }

        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="strModel"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public bool Add(String strModel, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            BES.Entities.PLU model = Common.CommonHelper.DeSerialize(typeof(BES.Entities.PLU), strModel) as BES.Entities.PLU;
            return bllPLU.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="strModel"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public bool Update(String strModel, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            BES.Entities.PLU model = Common.CommonHelper.DeSerialize(typeof(BES.Entities.PLU), strModel) as BES.Entities.PLU;
            return bllPLU.Update(model);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public bool Delete(String PLUCODE, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.Delete(PLUCODE);
        }

        /// <summary>
        ///  获得数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetList(string strWhere, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.GetList(strWhere);
        }

        /// <summary>
        /// 获取单个对象
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public String GetModel(String PLUCODE, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return Common.CommonHelper.Serialize(bllPLU.GetModel(PLUCODE));
        }

        /// <summary>
        /// 获取多个对象
        /// </summary>
        /// <param name="Where"></param>
        /// <param name="WSPassword"></param>
        /// <returns></returns>
        [WebMethod]
        public String GetModelList(String Where, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return Common.CommonHelper.Serialize(bllPLU.GetModelList(Where));
        }

        /// <summary>
        /// 获取多个数据集
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetModelDataSet(String Where, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.GetModelDataSet(Where);
        }

        /// <summary>
        /// 查询ISBN号相同的书
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetListByISBN(String ISBN, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.GetListByISBN(ISBN);
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetImageList(String BookID, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.GetImageList(BookID);
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        [WebMethod]
        public bool AddImageList(String strListPhotoFile, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            List<BES.Entities.PhotoFile> listPhotoFile=Common.CommonHelper.DeSerialize(typeof(List<BES.Entities.PhotoFile>),strListPhotoFile) as List<BES.Entities.PhotoFile>;
            return bllPLU.AddImageList(listPhotoFile);
        }

        /// <summary>
        /// 查询图书信息
        /// </summary>
        [WebMethod]
        public DataSet SearchBook(string strWhere, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.SearchBook(strWhere);
        }

        /// <summary>
        /// 获取封面图片
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        [WebMethod]
        public Byte[] GetCover(String BookID, String WSPassword)
        {
            if (!WSHelper.CheckPassword(WSPassword)) throw new Exception("未授权使用服务！");
            return bllPLU.GetCover(BookID);
        }
    }
}
