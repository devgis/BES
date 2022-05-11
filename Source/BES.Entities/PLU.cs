using System;
using System.Collections.Generic;
using System.Text;

namespace BES.Entities
{
    /// <summary>
    /// 图书类
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

        //新增
        private String _DuZheDingWei;
        private String _MaiDian;
        private String _ShangJiaJianYi;
        private String _JianJie;

        private Int32 _ISSaved;
	    private Int32 _ISUSED;
        //private Byte[] _CoverImage;

        /// <summary>
        /// 书号：ISBN
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
        /// 书名: TITLE
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
        /// 作者: AUTHOR
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
        /// 译者: TRANSLATOR
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
        /// 丛书名: SERIES
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
        /// 定价: PRICE
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
        /// 版次: EDITION
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
        /// 印次: NPRINT
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
        /// 营销分类: CLSCODE（小分类，下拉列表框）小分类信息表(CLASS)
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
        /// 出版社: PUBLISHER（下拉列表框选择）出版社信息表(COMPANY) ,要有出版社信息表(COMPANY)简称名显示
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
        /// 出版日期: PUBDATE （限制填入非法日期）
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
        /// 页数: PAGES
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
        /// 字数: WORDS
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
        /// 装帧: BINDING
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
        /// 创建日期: CREDATE(自动生成)
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
        /// 创建人: CREATBY(自动生成)
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
        /// 征订号: SIJIAOHAO(所填内容和货品代码: PLUCODE(主键)一样)
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
        /// 书号类: ISISBN（区分是ISBN还是其他自编代码）(0是ISBN，1不是)（下拉列表框选择）
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
        /// 货品代码: PLUCODE(主键)（自动生成）
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
        /// 是书类: ISABOOK（9是书，-1不是书）（下拉列表框）默认是书
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
        /// 书号延长码: EXTCODE
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
        /// 开本: BKSIZE
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
        /// CIP分类号: FULLCAT
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
        /// 版别
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
        /// 最后修改日期: MODDATE(自动生成)
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
        /// 最后修改人: MODBY(自动生成)
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
        /// 进价: HIPRICE
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
        /// 业务部门: DPTCODE（大分类，下拉列表框）没有默认项（大分类信息表(DEPARTMENT)\）
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
        /// 包装方法: PKSTYLE
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
        /// 包封数: PKPC
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
        /// 包册数: PKQTY
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
        /// 包重: PKWT
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
        /// 进货折扣: RDIS
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
        /// 总经销: FRANCHISEE(和登录号一样)要有出版社信息表(COMPANY),简称名显示
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
        /// 读者定位
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
        /// 卖点
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
        /// 上架建议
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
        /// 简介
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
        /// 是否已经加入正式库
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
        /// 本地数据是否已经保存在数据库
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
        ///// 封面图片
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
