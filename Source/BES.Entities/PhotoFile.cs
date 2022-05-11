using System;
using System.Collections.Generic;
using System.Text;

namespace BES.Entities
{
    /// <summary>
    /// 图片文件类
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
        /// 文件ID
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
        /// 对应图片表ID
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
        /// 图片内容
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
        /// 图片文件名
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
        /// 备注信息
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
        /// 是否封面
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
