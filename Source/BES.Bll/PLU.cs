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
        /// ����һ������
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(BES.Entities.PLU model)
        {
            return dalPLU.Add(model);
        }

        /// <summary>
        /// ����һ������
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
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dalPLU.GetList(strWhere);
        }

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <returns></returns>
        public BES.Entities.PLU GetModel(String PLUCODE)
        {
            return dalPLU.GetModel(PLUCODE);
        }

        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<BES.Entities.PLU> GetModelList(String Where)
        {
            return dalPLU.GetModelList(Where);
        }

        /// <summary>
        /// ��ȡ������ݼ�
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public DataSet GetModelDataSet(String Where)
        {
            return dalPLU.GetModelDataSet(Where);
        }
        /// <summary>
        /// ��ѯISBN����ͬ����
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public DataSet GetListByISBN(String ISBN)
        {
            return dalPLU.GetListByISBN(ISBN);
        }
        /// <summary>
        /// ��ȡͼƬ�б�
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public DataSet GetImageList(String BookID)
        {
            return dalPLU.GetImageList(BookID);
        }

        /// <summary>
        /// ����ͼƬ
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        public bool AddImageList(List<BES.Entities.PhotoFile> listPhotoFile)
        {
            return dalPLU.AddImageList(listPhotoFile);
        }

        /// <summary>
        /// ��ѯͼ����Ϣ
        /// </summary>
        public DataSet SearchBook(string strWhere)
        {
            return dalPLU.SearchBook(strWhere);
        }

        /// <summary>
        /// ��ȡ����ͼƬ
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public Byte[] GetCover(String BookID)
        {
            return dalPLU.GetCover(BookID);
        }
    }
}
