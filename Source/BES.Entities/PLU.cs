using System;
using System.Collections.Generic;
using System.Text;

namespace BES.Entities
{
    /// <summary>
    /// ͼ����
    /// </summary>
    [Serializable]
    public class PLU
    {
        private List<PhotoFile> _ListPhotoFile;

        private String _ISBN;
	    private String _TITLE;
	    private String _AUTHOR;
	    private String _TRANSLATOR;
	    private String _SERIES;
	    private Decimal _PRICE;
	    private Int32  _EDITION;
	    private Int32 _NPRINT;
	    private String _CLSCODE;
        //private String _CATEGORY;
	    private String _PUBLISHER;
	    private DateTime _PUBDATE;
	    private Int32 _PAGES;
	    private Int32 _WORDS;
	    private String _BINDING;
	    private DateTime _CREDATE;
	    private String _CREATBY;
	    private String _SIJIAOHAO;
	    private Int32 _ISISBN;
	    private String _PLUCODE;
	    private Int32 _ISABOOK;
	    private String _EXTCODE;
	    private String _BKSIZE;
	    private String _FULLCAT;
	    private String _PYSTYPE;
	    private DateTime _MODDATE;
	    private String _MODBY;
        //private String _JP;
        private Decimal _HIPRICE;
        //private Decimal _AVPRICE;
        //private Decimal _LSPRICE;
        //private DateTime _LDATE;
	    private String _DPTCODE;
	    private String _PKSTYLE;
	    private Decimal _PKPC;
	    private Int32 _PKQTY;
	    private Decimal _PKWT;
        //private Decimal _WSDISC;
        private Decimal _RDISC;
        //private Decimal _PRICEA;
        //private Decimal _PRICEB;
        //private Decimal _PRICEC;
        //private Decimal _PRICED;
        //private Int32 _TYPE;
	    private String _FRANCHISEE;
        //private Decimal _PRICE1;
        //private Decimal _PRICE2;
        //private Decimal _PRICE3;
        //private String _ISBN10;
        //private Int32 _BKTYPE;
        //private Decimal _MINQTY;
        //private String _CATEGORY1;
        //private Decimal _SEM;
        //private String _LC1001;
        //private String _LC2001;
        //private Decimal _exceptional;
        //private Decimal _Special;
        //private String _MODBYspe;
        //private DateTime _MODDATEspe;
        //private String _BOOKID;

        //����
        private String _DuZheDingWei;
        private String _MaiDian;
        private String _ShangJiaJianYi;
        private String _JianJie;

        private Int32 _ISSaved;
	    private Int32 _ISUSED;
        //private Byte[] _CoverImage;

        /// <summary>
        /// ��ţ�ISBN
        /// </summary>
        public String ISBN{
            set
            {
                _ISBN = value;
            }
            get
            {
                return _ISBN;
            }
        }
        /// <summary>
        /// ����: TITLE
        /// </summary>
        public String TITLE{
            set
            {
                _TITLE = value;
            }
            get
            {
                return _TITLE;
            }
        }
        /// <summary>
        /// ����: AUTHOR
        /// </summary>
        public String AUTHOR{
            set
            {
                _AUTHOR = value;
            }
            get
            {
                return _AUTHOR;
            }
        }
        /// <summary>
        /// ����: TRANSLATOR
        /// </summary>
        public String TRANSLATOR{
            set
            {
                _TRANSLATOR = value;
            }
            get
            {
                return _TRANSLATOR;
            }
        }
        /// <summary>
        /// ������: SERIES
        /// </summary>
        public String SERIES{
            set
            {
                _SERIES = value;
            }
            get
            {
                return _SERIES;
            }
        }
        /// <summary>
        /// ����: PRICE
        /// </summary>
        public Decimal PRICE{
            set
            {
                _PRICE = value;
            }
            get
            {
                return _PRICE;
            }
        }
        /// <summary>
        /// ���: EDITION
        /// </summary>
        public Int32 EDITION{
            set
            {
                _EDITION = value;
            }
            get
            {
                return _EDITION;
            }
        }
        /// <summary>
        /// ӡ��: NPRINT
        /// </summary>
        public Int32 NPRINT{
            set
            {
                _NPRINT = value;
            }
            get
            {
                return _NPRINT;
            }
        }
        /// <summary>
        /// Ӫ������: CLSCODE��С���࣬�����б��С������Ϣ��(CLASS)
        /// </summary>
        public String CLSCODE{
            set
            {
                _CLSCODE = value;
            }
            get
            {
                return _CLSCODE;
            }
        }
        //public String CATEGORY{}
        /// <summary>
        /// ������: PUBLISHER�������б��ѡ�񣩳�������Ϣ��(COMPANY) ,Ҫ�г�������Ϣ��(COMPANY)�������ʾ
        /// </summary>
        public String PUBLISHER{
            set
            {
                _PUBLISHER = value;
            }
            get
            {
                return _PUBLISHER;
            }
        }
        /// <summary>
        /// ��������: PUBDATE ����������Ƿ����ڣ�
        /// </summary>
        public DateTime PUBDATE{
            set
            {
                _PUBDATE = value;
            }
            get
            {
                return _PUBDATE;
            }
        }
        /// <summary>
        /// ҳ��: PAGES
        /// </summary>
        public Int32 PAGES{
            set
            {
                _PAGES = value;
            }
            get
            {
                return _PAGES;
            }
        }
        /// <summary>
        /// ����: WORDS
        /// </summary>
        public Int32 WORDS{
            set
            {
                _WORDS = value;
            }
            get
            {
                return _WORDS;
            }
        }
        /// <summary>
        /// װ֡: BINDING
        /// </summary>
        public String BINDING{
            set
            {
                _BINDING = value;
            }
            get
            {
                return _BINDING;
            }
        }
        /// <summary>
        /// ��������: CREDATE(�Զ�����)
        /// </summary>
        public DateTime CREDATE{
            set
            {
                _CREDATE = value;
            }
            get
            {
                return _CREDATE;
            }
        }
        /// <summary>
        /// ������: CREATBY(�Զ�����)
        /// </summary>
        public String CREATBY{
            set
            {
                _CREATBY = value;
            }
            get
            {
                return _CREATBY;
            }
        }
        /// <summary>
        /// ������: SIJIAOHAO(�������ݺͻ�Ʒ����: PLUCODE(����)һ��)
        /// </summary>
        public String SIJIAOHAO{
            set
            {
                _SIJIAOHAO = value;
            }
            get
            {
                return _SIJIAOHAO;
            }
        }
        /// <summary>
        /// �����: ISISBN��������ISBN���������Ա���룩(0��ISBN��1����)�������б��ѡ��
        /// </summary>
        public Int32 ISISBN{
            set
            {
                _ISISBN = value;
            }
            get
            {
                return _ISISBN;
            }
        }
        /// <summary>
        /// ��Ʒ����: PLUCODE(����)���Զ����ɣ�
        /// </summary>
        public String PLUCODE{
            set
            {
                _PLUCODE = value;
            }
            get
            {
                return _PLUCODE;
            }
        }
        /// <summary>
        /// ������: ISABOOK��9���飬-1�����飩�������б��Ĭ������
        /// </summary>
        public Int32 ISABOOK{
            set
            {
                _ISABOOK = value;
            }
            get
            {
                return _ISABOOK;
            }
        }
        /// <summary>
        /// ����ӳ���: EXTCODE
        /// </summary>
        public String EXTCODE{
            set
            {
                _EXTCODE = value;
            }
            get
            {
                return _EXTCODE;
            }
        }
        /// <summary>
        /// ����: BKSIZE
        /// </summary>
        public String BKSIZE{
            set
            {
                _BKSIZE = value;
            }
            get
            {
                return _BKSIZE;
            }
        }
        /// <summary>
        /// CIP�����: FULLCAT
        /// </summary>
        public String FULLCAT{
            set
            {
                _FULLCAT = value;
            }
            get
            {
                return _FULLCAT;
            }
        }
        /// <summary>
        /// ���
        /// </summary>
        public String PYSTYPE{
            set
            {
                _PYSTYPE = value;
            }
            get
            {
                return _PYSTYPE;
            }
        }
        /// <summary>
        /// ����޸�����: MODDATE(�Զ�����)
        /// </summary>
        public DateTime MODDATE{
            set
            {
                _MODDATE = value;
            }
            get
            {
                return _MODDATE;
            }
        }
        /// <summary>
        /// ����޸���: MODBY(�Զ�����)
        /// </summary>
        public String MODBY{
            set
            {
                _MODBY = value;
            }
            get
            {
                return _MODBY;
            }
        }
        //public String JP{}
        /// <summary>
        /// ����: HIPRICE
        /// </summary>
        public Decimal HIPRICE{
            set
            {
                _HIPRICE = value;
            }
            get
            {
                return _HIPRICE;
            }
        }
        //public Decimal AVPRICE{}
        //public Decimal LSPRICE{}
        //public DateTime LDATE{}
        /// <summary>
        /// ҵ����: DPTCODE������࣬�����б��û��Ĭ����������Ϣ��(DEPARTMENT)\��
        /// </summary>
        public String DPTCODE{
            set
            {
                _DPTCODE = value;
            }
            get
            {
                return _DPTCODE;
            }
        }
        /// <summary>
        /// ��װ����: PKSTYLE
        /// </summary>
        public String PKSTYLE{
            set
            {
                _PKSTYLE = value;
            }
            get
            {
                return _PKSTYLE;
            }
        }
        /// <summary>
        /// ������: PKPC
        /// </summary>
        public Decimal PKPC{
            set
            {
                _PKPC = value;
            }
            get
            {
                return _PKPC;
            }
        }
        /// <summary>
        /// ������: PKQTY
        /// </summary>
        public Int32 PKQTY{
            set
            {
                _PKQTY = value;
            }
            get
            {
                return _PKQTY;
            }
        }
        /// <summary>
        /// ����: PKWT
        /// </summary>
        public Decimal PKWT
        {
            set
            {
                _PKWT = value;
            }
            get
            {
                return _PKWT;
            }
        }
        //public Decimal WSDISC{}

        /// <summary>
        /// �����ۿ�: RDIS
        /// </summary>
        public Decimal RDISC{
            set
            {
                _RDISC = value;
            }
            get
            {
                return _RDISC;
            }
        }
        //public Decimal PRICEA{}
        //public Decimal PRICEB{}
        //public Decimal PRICEC{}
        //public Decimal PRICED{}
        //public Int32 TYPE{}
        /// <summary>
        /// �ܾ���: FRANCHISEE(�͵�¼��һ��)Ҫ�г�������Ϣ��(COMPANY),�������ʾ
        /// </summary>
        public String FRANCHISEE{
            set
            {
                _FRANCHISEE = value;
            }
            get
            {
                return _FRANCHISEE;
            }
        }
        //public Decimal PRICE1{}
        //public Decimal PRICE2{}
        //public Decimal PRICE3{}
        //public String ISBN10{}
        //public Int32 BKTYPE{}
        //public Decimal MINQTY{}
        //public String CATEGORY1{}
        //public Decimal SEM{}
        //public String LC1001{}
        //public String LC2001{}
        //public Decimal exceptional{}
        //public Decimal Special{}
        //public String MODBYspe{}
        //public DateTime MODDATEspe{}
        /// <summary>
        /// ���߶�λ
        /// </summary>
        public String DuZheDingWei
        {
            set
            {
                _DuZheDingWei = value;
            }
            get
            {
                return _DuZheDingWei;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public String MaiDian
        {
            set
            {
                _MaiDian = value;
            }
            get
            {
                return _MaiDian;
            }
        }
        /// <summary>
        /// �ϼܽ���
        /// </summary>
        public String ShangJiaJianYi
        {
            set
            {
                _ShangJiaJianYi = value;
            }
            get
            {
                return _ShangJiaJianYi;
            }
        }
        /// <summary>
        /// ���
        /// </summary>
        public String JianJie
        {
            set
            {
                _JianJie = value;
            }
            get
            {
                return _JianJie;
            }
        }

        /// <summary>
        /// �Ƿ��Ѿ�������ʽ��
        /// </summary>
        public Int32 ISUSED{
            set
            {
                _ISUSED = value;
            }
            get
            {
                return _ISUSED;
            }
        }
        /// <summary>
        /// ���������Ƿ��Ѿ����������ݿ�
        /// </summary>
        private Int32 ISSaved
        {
            set
            {
                _ISSaved = value;
            }
            get
            {
                return _ISSaved;
            }
        }

        public List<PhotoFile> ListPhotoFile
        {
            set
            {
                _ListPhotoFile = value;
            }
            get
            {
                return _ListPhotoFile;
            }
        }
        ///// <summary>
        ///// ����ͼƬ
        ///// </summary>
        //public Byte[] CoverImage
        //{
        //    set
        //    {
        //        _CoverImage = value;
        //    }
        //    get
        //    {
        //        return _CoverImage;
        //    }
        //}
    }
}
