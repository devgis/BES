using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BES.BLL
{
    public class PLU
    {
        public BES.DAL.PLU dalPLU;
        public PLU()
        {
            dalPLU = new BES.DAL.PLU();
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(BES.Entities.PLU model)
        {
            return dalPLU.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(BES.Entities.PLU model)
        {
            return dalPLU.Update(model);
        }

        public bool Delete(String PLUCODE)
        {
            return dalPLU.Delete(PLUCODE);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dalPLU.GetList(strWhere);
        }

        /// <summary>
        /// 获取单个对象
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <returns></returns>
        public BES.Entities.PLU GetModel(String PLUCODE)
        {
            return dalPLU.GetModel(PLUCODE);
        }

        /// <summary>
        /// 获取多个对象
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<BES.Entities.PLU> GetModelList(String Where)
        {
            return dalPLU.GetModelList(Where);
        }

        /// <summary>
        /// 获取多个数据集
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public DataSet GetModelDataSet(String Where)
        {
            return dalPLU.GetModelDataSet(Where);
        }
        /// <summary>
        /// 查询ISBN号相同的书
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public DataSet GetListByISBN(String ISBN)
        {
            return dalPLU.GetListByISBN(ISBN);
        }
        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public DataSet GetImageList(String BookID)
        {
            return dalPLU.GetImageList(BookID);
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        public bool AddImageList(List<BES.Entities.PhotoFile> listPhotoFile)
        {
            return dalPLU.AddImageList(listPhotoFile);
        }

        /// <summary>
        /// 查询图书信息
        /// </summary>
        public DataSet SearchBook(string strWhere)
        {
            return dalPLU.SearchBook(strWhere);
        }

        /// <summary>
        /// 获取封面图片
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public Byte[] GetCover(String BookID)
        {
            return dalPLU.GetCover(BookID);
        }
    }
}
