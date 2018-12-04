using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BES.Common;

namespace BES.DAL
{
    public class PLU
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(BES.Entities.PLU model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO T_PLU(");
            strSql.Append("AUTHOR,BINDING,BKSIZE,CLSCODE,CREATBY,CREDATE,DPTCODE,EDITION ,EXTCODE,FRANCHISEE,HIPRICE,ISABOOK,ISBN,ISISBN,ISUSED,NPRINT,PAGES,PKPC,PKQTY,PKSTYLE,PKWT,PLUCODE,PRICE,PUBDATE,PYSTYPE,RDISC,SERIES,SIJIAOHAO,TITLE,TRANSLATOR,WORDS,DUZHEDINGWEI,SHANGJIAJIANYI,MAIDIAN,JIANJIE,PUBLISHER)");
            strSql.Append(" VALUES (");
            strSql.Append("@AUTHOR,@BINDING,@BKSIZE,@CLSCODE,@CREATBY,@CREDATE,@DPTCODE,@EDITION,@EXTCODE,@FRANCHISEE,@HIPRICE,@ISABOOK,@ISBN,@ISISBN,@ISUSED,@NPRINT,@PAGES,@PKPC,@PKQTY,@PKSTYLE,@PKWT,@PLUCODE,@PRICE,@PUBDATE,@PYSTYPE,@RDISC,@SERIES,@SIJIAOHAO,@TITLE,@TRANSLATOR,@WORDS,@DUZHEDINGWEI,@SHANGJIAJIANYI,@MAIDIAN,@JIANJIE,@PUBLISHER)");
            SqlParameter[] parameters = {
                new SqlParameter("@AUTHOR",model.AUTHOR),
                new SqlParameter("@BINDING",model.BINDING),
                new SqlParameter("@BKSIZE", model.BKSIZE),
                new SqlParameter("@CLSCODE",model.CLSCODE),
                new SqlParameter("@CREATBY", model.CREATBY),
                new SqlParameter("@CREDATE",model.CREDATE),
                new SqlParameter("@DPTCODE", model.DPTCODE),
                new SqlParameter("@EDITION", model.EDITION),
                new SqlParameter("@EXTCODE",model.EXTCODE),
                new SqlParameter("@FRANCHISEE",model.FRANCHISEE),
                new SqlParameter("@HIPRICE",model.HIPRICE),
                new SqlParameter("@ISABOOK",model.ISABOOK),
                new SqlParameter("@ISBN", model.ISBN),
                new SqlParameter("@ISISBN", model.ISISBN),
                new SqlParameter("@ISUSED", model.ISUSED),
                new SqlParameter("@NPRINT", model.NPRINT),
                new SqlParameter("@PAGES", model.PAGES),
                new SqlParameter("@PKPC", model.PKPC),
                new SqlParameter("@PKQTY",model.PKQTY),
                new SqlParameter("@PKSTYLE",model.PKSTYLE),
                new SqlParameter("@PKWT", model.PKWT),
                new SqlParameter("@PLUCODE",model.PLUCODE),
                new SqlParameter("@PRICE", model.PRICE),
                new SqlParameter("@PUBDATE",model.PUBDATE),
                new SqlParameter("@PYSTYPE",model.PYSTYPE),
                new SqlParameter("@RDISC",model.RDISC),
                new SqlParameter("@SERIES", model.SERIES),
                new SqlParameter("@SIJIAOHAO",model.SIJIAOHAO),
                new SqlParameter("@TITLE",model.TITLE),
                new SqlParameter("@TRANSLATOR",model.TRANSLATOR),
                new SqlParameter("@WORDS", model.WORDS),
                new SqlParameter("@DUZHEDINGWEI", model.DuZheDingWei),
                new SqlParameter("@SHANGJIAJIANYI",model.ShangJiaJianYi),
                new SqlParameter("@MAIDIAN", model.MaiDian),
                new SqlParameter("@JIANJIE", model.JianJie),
                new SqlParameter("@PUBLISHER", model.PUBLISHER)};

            try
            {
                int i = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(BES.Entities.PLU model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE T_PLU SET ");
            strSql.Append("AUTHOR=@AUTHOR,BINDING=@BINDING,BKSIZE=@BKSIZE,CLSCODE=@CLSCODE,DPTCODE=@DPTCODE,EDITION=@EDITION ,EXTCODE=@EXTCODE,FRANCHISEE=@FRANCHISEE,");
            strSql.Append("HIPRICE=@HIPRICE,ISABOOK=@ISABOOK,ISBN=@ISBN,ISISBN=@ISISBN,MODBY=@MODBY,MODDATE=@MODDATE,NPRINT=@NPRINT,PAGES=@PAGES,PKPC=@PKPC,");
            strSql.Append("PKQTY=@PKQTY,PKSTYLE=@PKSTYLE,PKWT=@PKWT,PRICE=@PRICE,PUBDATE=@PUBDATE,PYSTYPE=@PYSTYPE,RDISC=@RDISC,SERIES=@SERIES,SIJIAOHAO=@SIJIAOHAO,");
            strSql.Append("TITLE=@TITLE,TRANSLATOR=@TRANSLATOR,WORDS=@WORDS,DUZHEDINGWEI=@DUZHEDINGWEI,SHANGJIAJIANYI=@SHANGJIAJIANYI,MAIDIAN=@MAIDIAN,JIANJIE=@JIANJIE ");
            strSql.Append("WHERE PLUCODE=@PLUCODE");
            SqlParameter[] parameters = {
                new SqlParameter("@AUTHOR",model.AUTHOR),
                new SqlParameter("@BINDING",model.BINDING),
                new SqlParameter("@BKSIZE", model.BKSIZE),
                new SqlParameter("@CLSCODE",model.CLSCODE),
                new SqlParameter("@DPTCODE", model.DPTCODE),
                new SqlParameter("@EDITION", model.EDITION),
                new SqlParameter("@EXTCODE",model.EXTCODE),
                new SqlParameter("@FRANCHISEE",model.FRANCHISEE),
                new SqlParameter("@HIPRICE",model.HIPRICE),
                new SqlParameter("@ISABOOK",model.ISABOOK),
                new SqlParameter("@ISBN", model.ISBN),
                new SqlParameter("@ISISBN", model.ISISBN),
                new SqlParameter("@ISUSED", model.ISUSED),
                new SqlParameter("@MODBY", model.MODBY),
                new SqlParameter("@MODDATE", model.MODDATE),
                new SqlParameter("@NPRINT", model.NPRINT),
                new SqlParameter("@PAGES", model.PAGES),
                new SqlParameter("@PKPC", model.PKPC),
                new SqlParameter("@PKQTY",model.PKQTY),
                new SqlParameter("@PKSTYLE",model.PKSTYLE),
                new SqlParameter("@PKWT", model.PKWT),
                new SqlParameter("@PLUCODE",model.PLUCODE),
                new SqlParameter("@PRICE", model.PRICE),
                new SqlParameter("@PUBDATE",model.PUBDATE),
                new SqlParameter("@PYSTYPE",model.PYSTYPE),
                new SqlParameter("@RDISC",model.RDISC),
                new SqlParameter("@SERIES", model.SERIES),
                new SqlParameter("@SIJIAOHAO",model.SIJIAOHAO),
                new SqlParameter("@TITLE",model.TITLE),
                new SqlParameter("@TRANSLATOR",model.TRANSLATOR),
                new SqlParameter("@WORDS", model.WORDS),
                new SqlParameter("@DuZheDingWei", model.DuZheDingWei),
                new SqlParameter("@ShangJiaJianYi",model.ShangJiaJianYi),
                new SqlParameter("@MaiDian", model.MaiDian),
                new SqlParameter("@JianJie", model.JianJie)};

            try
            {
                int i = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(String PLUCODE)
        {
            SqlCommand sc1 = new SqlCommand("DELETE FROM T_PLU WHERE PLUCODE=@PLUCODE");
            sc1.Parameters.Add(new SqlParameter("@PLUCODE",PLUCODE));
            SqlCommand sc2 = new SqlCommand("DELETE FROM T_PHOTOFILE WHERE BOOKID=@BOOKID");
            sc2.Parameters.Add(new SqlParameter("@BOOKID", PLUCODE));
            List<SqlCommand> lisSqlCommand = new List<SqlCommand>();
            lisSqlCommand.Add(sc1);
            lisSqlCommand.Add(sc2);
            try
            {
                DbHelperSQL.ExecuteSqlTran(lisSqlCommand);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取单个对象
        /// </summary>
        /// <param name="PLUCODE"></param>
        /// <returns></returns>
        public BES.Entities.PLU GetModel(String PLUCODE)
        {
            String Sql = "SELECT * FROM T_PLU WHERE PLUCODE='" + PLUCODE + "'";
            DataSet ds = DbHelperSQL.Query(Sql);
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                BES.Entities.PLU model = new BES.Entities.PLU();
                if (ds.Tables[0].Rows[0]["AUTHOR"] != null && ds.Tables[0].Rows[0]["AUTHOR"].ToString() != "")
                {
                    model.AUTHOR = ds.Tables[0].Rows[0]["AUTHOR"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BINDING"] != null && ds.Tables[0].Rows[0]["BINDING"].ToString() != "")
                {
                    model.BINDING = ds.Tables[0].Rows[0]["BINDING"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BKSIZE"] != null && ds.Tables[0].Rows[0]["BKSIZE"].ToString() != "")
                {
                    model.BKSIZE = ds.Tables[0].Rows[0]["BKSIZE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CLSCODE"] != null && ds.Tables[0].Rows[0]["CLSCODE"].ToString() != "")
                {
                    model.CLSCODE = ds.Tables[0].Rows[0]["CLSCODE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CREATBY"] != null && ds.Tables[0].Rows[0]["CREATBY"].ToString() != "")
                {
                    model.CREATBY = ds.Tables[0].Rows[0]["CREATBY"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CREDATE"] != null && ds.Tables[0].Rows[0]["CREDATE"].ToString() != "")
                {
                    model.CREDATE =  Convert.ToDateTime(ds.Tables[0].Rows[0]["CREDATE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DPTCODE"] != null && ds.Tables[0].Rows[0]["DPTCODE"].ToString() != "")
                {
                    model.DPTCODE = ds.Tables[0].Rows[0]["DPTCODE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DuZheDingWei"] != null && ds.Tables[0].Rows[0]["DuZheDingWei"].ToString() != "")
                {
                    model.DuZheDingWei = ds.Tables[0].Rows[0]["DuZheDingWei"].ToString();
                }
                if (ds.Tables[0].Rows[0]["EDITION"] != null && ds.Tables[0].Rows[0]["EDITION"].ToString() != "")
                {
                    model.EDITION = int.Parse(ds.Tables[0].Rows[0]["EDITION"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EXTCODE"] != null && ds.Tables[0].Rows[0]["EXTCODE"].ToString() != "")
                {
                    model.EXTCODE = ds.Tables[0].Rows[0]["EXTCODE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FRANCHISEE"] != null && ds.Tables[0].Rows[0]["FRANCHISEE"].ToString() != "")
                {
                    model.FRANCHISEE = ds.Tables[0].Rows[0]["FRANCHISEE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FULLCAT"] != null && ds.Tables[0].Rows[0]["FULLCAT"].ToString() != "")
                {
                    model.FULLCAT = ds.Tables[0].Rows[0]["FULLCAT"].ToString();
                }
                if (ds.Tables[0].Rows[0]["HIPRICE"] != null && ds.Tables[0].Rows[0]["HIPRICE"].ToString() != "")
                {
                    model.HIPRICE = Convert.ToDecimal(ds.Tables[0].Rows[0]["HIPRICE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ISABOOK"] != null && ds.Tables[0].Rows[0]["ISABOOK"].ToString() != "")
                {
                    model.ISABOOK = int.Parse(ds.Tables[0].Rows[0]["ISABOOK"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ISBN"] != null && ds.Tables[0].Rows[0]["ISBN"].ToString() != "")
                {
                    model.ISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ISISBN"] != null && ds.Tables[0].Rows[0]["ISISBN"].ToString() != "")
                {
                    model.ISISBN = int.Parse(ds.Tables[0].Rows[0]["ISISBN"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ISUSED"] != null && ds.Tables[0].Rows[0]["ISUSED"].ToString() != "")
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["ISUSED"].ToString()))
                    {
                        model.ISUSED = 1;
                    }
                    else
                    {
                        model.ISUSED = 0;
                    }
                }
                if (ds.Tables[0].Rows[0]["JianJie"] != null && ds.Tables[0].Rows[0]["JianJie"].ToString() != "")
                {
                    model.JianJie = ds.Tables[0].Rows[0]["JianJie"].ToString();
                }
                //if (ds.Tables[0].Rows[0]["AUTHOR"] != null && ds.Tables[0].Rows[0]["AUTHOR"].ToString() != "")
                //{
                //    model.ListPhotoFile = int.Parse(ds.Tables[0].Rows[0]["AUTHOR"].ToString());
                //}
                if (ds.Tables[0].Rows[0]["MaiDian"] != null && ds.Tables[0].Rows[0]["MaiDian"].ToString() != "")
                {
                    model.MaiDian = ds.Tables[0].Rows[0]["MaiDian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MODBY"] != null && ds.Tables[0].Rows[0]["MODBY"].ToString() != "")
                {
                    model.MODBY = ds.Tables[0].Rows[0]["MODBY"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MODDATE"] != null && ds.Tables[0].Rows[0]["MODDATE"].ToString() != "")
                {
                    model.MODDATE = Convert.ToDateTime(ds.Tables[0].Rows[0]["MODDATE"].ToString()).Date;
                }
                if (ds.Tables[0].Rows[0]["NPRINT"] != null && ds.Tables[0].Rows[0]["NPRINT"].ToString() != "")
                {
                    model.NPRINT = int.Parse(ds.Tables[0].Rows[0]["NPRINT"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PAGES"] != null && ds.Tables[0].Rows[0]["PAGES"].ToString() != "")
                {
                    model.PAGES = int.Parse(ds.Tables[0].Rows[0]["PAGES"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PKPC"] != null && ds.Tables[0].Rows[0]["PKPC"].ToString() != "")
                {
                    model.PKPC = int.Parse(ds.Tables[0].Rows[0]["PKPC"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PKQTY"] != null && ds.Tables[0].Rows[0]["PKQTY"].ToString() != "")
                {
                    model.PKQTY = int.Parse(ds.Tables[0].Rows[0]["PKQTY"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PKSTYLE"] != null && ds.Tables[0].Rows[0]["PKSTYLE"].ToString() != "")
                {
                    model.PKSTYLE = ds.Tables[0].Rows[0]["PKSTYLE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PKWT"] != null && ds.Tables[0].Rows[0]["PKWT"].ToString() != "")
                {
                    model.PKWT = int.Parse(ds.Tables[0].Rows[0]["PKWT"].ToString());
                }

                if (ds.Tables[0].Rows[0]["PLUCODE"] != null && ds.Tables[0].Rows[0]["PLUCODE"].ToString() != "")
                {
                    model.PLUCODE = ds.Tables[0].Rows[0]["PLUCODE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PRICE"] != null && ds.Tables[0].Rows[0]["PRICE"].ToString() != "")
                {
                    model.PRICE = Convert.ToDecimal(ds.Tables[0].Rows[0]["PRICE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PUBDATE"] != null && ds.Tables[0].Rows[0]["PUBDATE"].ToString() != "")
                {
                    model.PUBDATE =  Convert.ToDateTime(ds.Tables[0].Rows[0]["PUBDATE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PUBLISHER"] != null && ds.Tables[0].Rows[0]["PUBLISHER"].ToString() != "")
                {
                    model.PUBLISHER = ds.Tables[0].Rows[0]["PUBLISHER"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PYSTYPE"] != null && ds.Tables[0].Rows[0]["PYSTYPE"].ToString() != "")
                {
                    model.PYSTYPE = ds.Tables[0].Rows[0]["PYSTYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RDISC"] != null && ds.Tables[0].Rows[0]["RDISC"].ToString() != "")
                {
                    model.RDISC = int.Parse(ds.Tables[0].Rows[0]["RDISC"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SERIES"] != null && ds.Tables[0].Rows[0]["SERIES"].ToString() != "")
                {
                    model.SERIES = ds.Tables[0].Rows[0]["SERIES"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ShangJiaJianYi"] != null && ds.Tables[0].Rows[0]["ShangJiaJianYi"].ToString() != "")
                {
                    model.ShangJiaJianYi = ds.Tables[0].Rows[0]["ShangJiaJianYi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SIJIAOHAO"] != null && ds.Tables[0].Rows[0]["SIJIAOHAO"].ToString() != "")
                {
                    model.SIJIAOHAO = ds.Tables[0].Rows[0]["SIJIAOHAO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TITLE"] != null && ds.Tables[0].Rows[0]["TITLE"].ToString() != "")
                {
                    model.TITLE = ds.Tables[0].Rows[0]["TITLE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TRANSLATOR"] != null && ds.Tables[0].Rows[0]["TRANSLATOR"].ToString() != "")
                {
                    model.TRANSLATOR = ds.Tables[0].Rows[0]["TRANSLATOR"].ToString();
                }
                if (ds.Tables[0].Rows[0]["WORDS"] != null && ds.Tables[0].Rows[0]["WORDS"].ToString() != "")
                {
                    model.WORDS = int.Parse(ds.Tables[0].Rows[0]["WORDS"].ToString());
                }
                //try
                //{
                //    model.CoverImage = (byte[])ds.Tables[0].Rows[0]["COVERIMAGE"];
                //}
                //catch
                //{ }
                return model;
            }
        }

        /// <summary>
        /// 获取多个对象
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<BES.Entities.PLU> GetModelList(String Where)
        {
            String Sql = "SELECT * FROM T_PLU";
            if (!String.IsNullOrEmpty(Where) || Where.Trim() != "*")
            {
                Sql += " Where " + Where;
            }
            DataSet ds = DbHelperSQL.Query(Sql);
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                return new List<BES.Entities.PLU>();
            }
            else
            {
                List<BES.Entities.PLU> listPLU = new List<BES.Entities.PLU>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    BES.Entities.PLU model = new BES.Entities.PLU();
                    if (dr["AUTHOR"] != null && dr["AUTHOR"].ToString() != "")
                    {
                        model.AUTHOR = dr["AUTHOR"].ToString();
                    }
                    if (dr["BINDING"] != null && dr["BINDING"].ToString() != "")
                    {
                        model.BINDING = dr["BINDING"].ToString();
                    }
                    if (dr["BKSIZE"] != null && dr["BKSIZE"].ToString() != "")
                    {
                        model.BKSIZE = dr["BKSIZE"].ToString();
                    }
                    if (dr["CLSCODE"] != null && dr["CLSCODE"].ToString() != "")
                    {
                        model.CLSCODE = dr["CLSCODE"].ToString();
                    }
                    if (dr["CREATBY"] != null && dr["CREATBY"].ToString() != "")
                    {
                        model.CREATBY = dr["CREATBY"].ToString();
                    }
                    if (dr["CREDATE"] != null && dr["CREDATE"].ToString() != "")
                    {
                        model.CREDATE = Convert.ToDateTime(dr["CREDATE"].ToString());
                    }
                    if (dr["DPTCODE"] != null && dr["DPTCODE"].ToString() != "")
                    {
                        model.DPTCODE = dr["DPTCODE"].ToString();
                    }
                    if (dr["DuZheDingWei"] != null && dr["DuZheDingWei"].ToString() != "")
                    {
                        model.DuZheDingWei = dr["DuZheDingWei"].ToString();
                    }
                    if (dr["EDITION"] != null && dr["EDITION"].ToString() != "")
                    {
                        model.EDITION = int.Parse(dr["EDITION"].ToString());
                    }
                    if (dr["EXTCODE"] != null && dr["EXTCODE"].ToString() != "")
                    {
                        model.EXTCODE = dr["EXTCODE"].ToString();
                    }
                    if (dr["FRANCHISEE"] != null && dr["FRANCHISEE"].ToString() != "")
                    {
                        model.FRANCHISEE = dr["FRANCHISEE"].ToString();
                    }
                    if (dr["FULLCAT"] != null && dr["FULLCAT"].ToString() != "")
                    {
                        model.FULLCAT = dr["FULLCAT"].ToString();
                    }
                    if (dr["HIPRICE"] != null && dr["HIPRICE"].ToString() != "")
                    {
                        model.HIPRICE = Convert.ToDecimal(dr["HIPRICE"].ToString());
                    }
                    if (dr["ISABOOK"] != null && dr["ISABOOK"].ToString() != "")
                    {
                        model.ISABOOK = int.Parse(dr["ISABOOK"].ToString());
                    }
                    if (dr["ISBN"] != null && dr["ISBN"].ToString() != "")
                    {
                        model.ISBN = dr["ISBN"].ToString();
                    }
                    if (dr["ISISBN"] != null && dr["ISISBN"].ToString() != "")
                    {
                        model.ISISBN = int.Parse(dr["ISISBN"].ToString());
                    }
                    if (dr["ISUSED"] != null && dr["ISUSED"].ToString() != "")
                    {
                        if (Convert.ToBoolean(dr["ISUSED"].ToString()))
                        {
                            model.ISUSED = 1;
                        }
                        else
                        {
                            model.ISUSED = 0;
                        }
                    }
                    if (dr["JianJie"] != null && dr["JianJie"].ToString() != "")
                    {
                        model.JianJie = dr["JianJie"].ToString();
                    }
                    //if (dr["AUTHOR"] != null && dr["AUTHOR"].ToString() != "")
                    //{
                    //    model.ListPhotoFile = int.Parse(dr["AUTHOR"].ToString());
                    //}
                    if (dr["MaiDian"] != null && dr["MaiDian"].ToString() != "")
                    {
                        model.MaiDian = dr["MaiDian"].ToString();
                    }
                    if (dr["MODBY"] != null && dr["MODBY"].ToString() != "")
                    {
                        model.MODBY = dr["MODBY"].ToString();
                    }
                    if (dr["MODDATE"] != null && dr["MODDATE"].ToString() != "")
                    {
                        model.MODDATE = Convert.ToDateTime(dr["MODDATE"].ToString()).Date;
                    }
                    if (dr["NPRINT"] != null && dr["NPRINT"].ToString() != "")
                    {
                        model.NPRINT = int.Parse(dr["NPRINT"].ToString());
                    }
                    if (dr["PAGES"] != null && dr["PAGES"].ToString() != "")
                    {
                        model.PAGES = int.Parse(dr["PAGES"].ToString());
                    }
                    if (dr["PKPC"] != null && dr["PKPC"].ToString() != "")
                    {
                        model.PKPC = int.Parse(dr["PKPC"].ToString());
                    }
                    if (dr["PKQTY"] != null && dr["PKQTY"].ToString() != "")
                    {
                        model.PKQTY = int.Parse(dr["PKQTY"].ToString());
                    }
                    if (dr["PKSTYLE"] != null && dr["PKSTYLE"].ToString() != "")
                    {
                        model.PKSTYLE = dr["PKSTYLE"].ToString();
                    }
                    if (dr["PKWT"] != null && dr["PKWT"].ToString() != "")
                    {
                        model.PKWT = int.Parse(dr["PKWT"].ToString());
                    }

                    if (dr["PLUCODE"] != null && dr["PLUCODE"].ToString() != "")
                    {
                        model.PLUCODE = dr["PLUCODE"].ToString();
                    }
                    if (dr["PRICE"] != null && dr["PRICE"].ToString() != "")
                    {
                        model.PRICE = Convert.ToDecimal(dr["PRICE"].ToString());
                    }
                    if (dr["PUBDATE"] != null && dr["PUBDATE"].ToString() != "")
                    {
                        model.PUBDATE = Convert.ToDateTime(dr["PUBDATE"].ToString());
                    }
                    if (dr["PUBLISHER"] != null && dr["PUBLISHER"].ToString() != "")
                    {
                        model.PUBLISHER = dr["PUBLISHER"].ToString();
                    }
                    if (dr["PYSTYPE"] != null && dr["PYSTYPE"].ToString() != "")
                    {
                        model.PYSTYPE = dr["PYSTYPE"].ToString();
                    }
                    if (dr["RDISC"] != null && dr["RDISC"].ToString() != "")
                    {
                        model.RDISC = int.Parse(dr["RDISC"].ToString());
                    }
                    if (dr["SERIES"] != null && dr["SERIES"].ToString() != "")
                    {
                        model.SERIES = dr["SERIES"].ToString();
                    }
                    if (dr["ShangJiaJianYi"] != null && dr["ShangJiaJianYi"].ToString() != "")
                    {
                        model.ShangJiaJianYi = dr["ShangJiaJianYi"].ToString();
                    }
                    if (dr["SIJIAOHAO"] != null && dr["SIJIAOHAO"].ToString() != "")
                    {
                        model.SIJIAOHAO = dr["SIJIAOHAO"].ToString();
                    }
                    if (dr["TITLE"] != null && dr["TITLE"].ToString() != "")
                    {
                        model.TITLE = dr["TITLE"].ToString();
                    }
                    if (dr["TRANSLATOR"] != null && dr["TRANSLATOR"].ToString() != "")
                    {
                        model.TRANSLATOR = dr["TRANSLATOR"].ToString();
                    }
                    if (dr["WORDS"] != null && dr["WORDS"].ToString() != "")
                    {
                        model.WORDS = int.Parse(dr["WORDS"].ToString());
                    }
                    //try
                    //{
                    //    model.CoverImage = (byte[])ds.Tables[0].Rows[0]["COVERIMAGE"];
                    //}
                    //catch
                    //{ }
                    listPLU.Add(model);
                }
                return listPLU;
            }
        }

        /// <summary>
        /// 获取多个对象
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public DataSet GetModelDataSet(String Where)
        {
            String Sql = "SELECT * FROM T_PLU";
            if (!String.IsNullOrEmpty(Where) || Where.Trim() != "*")
            {
                Sql += " Where " + Where;
            }
            return DbHelperSQL.Query(Sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT AUTHOR,BINDING,BKSIZE,CLSCODE,CREATBY,CREDATE,DPTCODE,EDITION ,EXTCODE,FRANCHISEE,HIPRICE,ISABOOK,ISBN,ISISBN,ISUSED,MODBY,MODDATE,NPRINT,PAGES,PKPC,PKQTY,PKSTYLE,PKWT,PLUCODE,PRICE,PUBDATE,PYSTYPE,RDISC,SERIES,SIJIAOHAO,TITLE,TRANSLATOR,WORDS,DuZheDingWei,ShangJiaJianYi,MaiDian,JianJie FROM t_PLU");
            if (strWhere.Trim() != "" || strWhere.Trim() != "*")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询ISBN号相同的书
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public DataSet GetListByISBN(String ISBN)
        {
            String strSql = "SELECT PLUCODE,TITLE,PRICE,COMPANY.SHORTNAME,C1.SHORTNAME AS PUBLISHER FROM T_PLU LEFT JOIN COMPANY ON T_PLU.FRANCHISEE=COMPANY.CODE LEFT JOIN COMPANY C1 ON T_PLU.FRANCHISEE=C1.CODE WHERE ISBN='" + ISBN + "'";
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public DataSet GetImageList(String BookID)
        {
            String strSql = "SELECT FILEID,PHOTO,PHOTOFILENAME,ISCOVER,REMARKS FROM T_PHOTOFILE WHERE BOOKID='" + BookID + "'";
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="listPhotoFile"></param>
        /// <returns></returns>
        public bool AddImageList(List<BES.Entities.PhotoFile> listPhotoFile)
        {
            if (listPhotoFile.Count <= 0)
            {
                return false;
            }
            else
            {
                SqlCommand sc1 = new SqlCommand("DELETE FROM T_PHOTOFILE WHERE BOOKID=@BOOKID");
                sc1.Parameters.Add(new SqlParameter("@BOOKID", listPhotoFile[0].BookID));
                List<SqlCommand> lisSqlCommand = new List<SqlCommand>();
                lisSqlCommand.Add(sc1);
                foreach (BES.Entities.PhotoFile f in listPhotoFile)
                {
                    SqlCommand sc2 = new SqlCommand("INSERT INTO T_PHOTOFILE(FILEID,BOOKID,PHOTO,PHOTOFILENAME,REMARKS,ISCOVER)VALUES(@FILEID,@BOOKID,@PHOTO,@PHOTOFILENAME,@REMARKS,@ISCOVER)");
                    sc2.Parameters.Add(new SqlParameter("@FILEID", f.FileID));
                    sc2.Parameters.Add(new SqlParameter("@BOOKID", f.BookID));
                    sc2.Parameters.Add(new SqlParameter("@PHOTO", f.Photo));
                    sc2.Parameters.Add(new SqlParameter("@PHOTOFILENAME",f.PhotoFileName));
                    sc2.Parameters.Add(new SqlParameter("@REMARKS", f.Remarks));
                    sc2.Parameters.Add(new SqlParameter("@ISCOVER", f.IsCover));
                    lisSqlCommand.Add(sc2);
                }
                try
                {
                    DbHelperSQL.ExecuteSqlTran(lisSqlCommand);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 查询图书信息
        /// </summary>
        public DataSet SearchBook(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT PLUCODE,ISBN,TITLE,SERIES,AUTHOR,TRANSLATOR");
            strSql.Append(",DEPARTMENT.DPTNAME,CLASS.CLSNAME,PRICE,RDISC,PUBDATE");
            strSql.Append(",BINDING.DESCRIPT AS BINDINGNAME,SIZE.DESCRIPT AS SIZENAME,EDITION,NPRINT,PAGES,WORDS,COMPANY.SHORTNAME AS PUBLISHERNAME,C2.SHORTNAME AS FRANCHISEENAME");
            strSql.Append(",C3.SHORTNAME AS PYSTYPENAME");
            strSql.Append(",DUZHEDINGWEI,MAIDIAN,SHANGJIAJIANYI,JIANJIE");
            strSql.Append(" FROM T_PLU");
            strSql.Append(" LEFT JOIN BINDING ON T_PLU.BINDING=BINDING.BINDING");
            strSql.Append(" LEFT JOIN SIZE ON T_PLU.BKSIZE =SIZE.BKSIZE");
            strSql.Append(" LEFT JOIN CLASS ON T_PLU.CLSCODE=CLASS.CLSCODE");
            strSql.Append(" LEFT JOIN DEPARTMENT ON T_PLU.DPTCODE=DEPARTMENT.DPTCODE");
            strSql.Append(" LEFT JOIN COMPANY C3 ON T_PLU.PYSTYPE=C3.CODE");
            strSql.Append(" LEFT JOIN COMPANY ON T_PLU.PUBLISHER=COMPANY.CODE");
            strSql.Append(" LEFT JOIN COMPANY C2 ON T_PLU.PUBLISHER=C2.CODE");
            if (strWhere.Trim() != "" || strWhere.Trim() != "*")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ORDER BY ISBN ASC");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取封面图片
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public Byte[] GetCover(String BookID)
        {
            String SQL = "SELECT TOP 1 PHOTO FROM T_PHOTOFILE WHERE BOOKID='" + BookID + "' AND ISCOVER=1";
            DataSet ds = DbHelperSQL.Query(SQL);
            try
            {
                return (byte[])ds.Tables[0].Rows[0]["PHOTO"];
            }
            catch
            {
                return new Byte[0];
            }
        }
    }
}
