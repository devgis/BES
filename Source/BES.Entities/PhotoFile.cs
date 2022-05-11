using System;
using System.Collections.Generic;
using System.Text;

namespace BES.Entities
{
    /// <summary>
    /// ͼƬ�ļ���
    /// </summary>
    [Serializable]
    public class PhotoFile
    {
        private String _FileID;
        private String _BookID;
        private Byte[] _Photo;
        private String _PhotoFileName;
        private String _Remarks;
        private Boolean _IsCover;
        /// <summary>
        /// �ļ�ID
        /// </summary>
        public String FileID
        {
            set
            {
                _FileID = value;
            }
            get
            {
                return _FileID;
            }
        }
        /// <summary>
        /// ��ӦͼƬ��ID
        /// </summary>
        public String BookID
        {
            set
            {
                _BookID = value;
            }
            get
            {
                return _BookID;
            }
        }
        /// <summary>
        /// ͼƬ����
        /// </summary>
        public Byte[] Photo
        {
            set
            {
                _Photo = value;
            }
            get
            {
                return _Photo;
            }
        }

        /// <summary>
        /// ͼƬ�ļ���
        /// </summary>
        public String PhotoFileName
        {
            set {
                _PhotoFileName = value;
            }
            get
            {
                return _PhotoFileName;
            }
        }

        /// <summary>
        /// ��ע��Ϣ
        /// </summary>
        public String Remarks
        {
            set
            {
                _Remarks = value;
            }
            get
            {
                return _Remarks;
            }
        }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public Boolean IsCover
        {
            set
            {
                _IsCover = value;
            }
            get
            {
                return _IsCover;
            }
        }
    }
}
