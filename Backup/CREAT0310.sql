USE [CacheDB]
GO
/****** Object:  Table [dbo].[t_User]    Script Date: 03/10/2013 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_User](
	[userid] [int] NOT NULL,
	[usertype] [int] NULL,
	[username] [varchar](50) NULL,
	[userpassword] [varchar](50) NULL,
	[companycode] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_PLU]    Script Date: 03/10/2013 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_PLU](
	[ISBN] [varchar](20) NULL,
	[TITLE] [varchar](160) NOT NULL,
	[AUTHOR] [varchar](80) NULL,
	[TRANSLATOR] [varchar](80) NULL,
	[SERIES] [varchar](160) NULL,
	[PRICE] [decimal](19, 2) NULL,
	[EDITION] [smallint] NULL,
	[NPRINT] [smallint] NULL,
	[CLSCODE] [varchar](20) NOT NULL,
	[CATEGORY] [varchar](8) NULL,
	[PUBLISHER] [varchar](10) NULL,
	[PUBDATE] [datetime] NULL,
	[PAGES] [smallint] NULL,
	[WORDS] [int] NULL,
	[BINDING] [varchar](6) NULL,
	[CREDATE] [datetime] NULL,
	[CREATBY] [varchar](6) NULL,
	[SIJIAOHAO] [varchar](50) NULL,
	[ISISBN] [smallint] NULL,
	[PLUCODE] [varchar](50) NOT NULL,
	[ISABOOK] [smallint] NOT NULL,
	[EXTCODE] [varchar](8) NULL,
	[BKSIZE] [varchar](6) NULL,
	[FULLCAT] [varchar](12) NULL,
	[PYSTYPE] [smallint] NOT NULL,
	[MODDATE] [datetime] NULL,
	[MODBY] [varchar](6) NULL,
	[JP] [varchar](160) NULL,
	[HIPRICE] [decimal](19, 2) NULL,
	[AVPRICE] [decimal](19, 2) NULL,
	[LSPRICE] [decimal](19, 2) NULL,
	[LDATE] [datetime] NULL,
	[DPTCODE] [varchar](6) NULL,
	[PKSTYLE] [varchar](2) NULL,
	[PKPC] [real] NULL,
	[PKQTY] [smallint] NULL,
	[PKWT] [real] NULL,
	[WSDISC] [real] NULL,
	[RDISC] [real] NULL,
	[PRICEA] [decimal](18, 2) NULL,
	[PRICEB] [decimal](18, 2) NULL,
	[PRICEC] [decimal](18, 2) NULL,
	[PRICED] [decimal](18, 2) NULL,
	[TYPE] [smallint] NULL,
	[FRANCHISEE] [varchar](10) NULL,
	[PRICE1] [decimal](19, 2) NULL,
	[PRICE2] [decimal](19, 2) NULL,
	[PRICE3] [decimal](19, 0) NULL,
	[ISBN10] [varchar](20) NULL,
	[BKTYPE] [smallint] NULL,
	[MINQTY] [int] NULL,
	[CATEGORY1] [varchar](8) NULL,
	[SEM] [smallint] NULL,
	[LC1001] [nvarchar](10) NULL,
	[LC2001] [nvarchar](10) NULL,
	[exceptional] [bit] NOT NULL,
	[Special] [bit] NOT NULL,
	[MODBYspe] [varchar](6) NULL,
	[MODDATEspe] [datetime] NULL,
	[ISUSED] [bit] NULL,
	[DuZheDingWei] [varchar](50) NULL,
	[MaiDian] [varchar](50) NULL,
	[ShangJiaJianYi] [varchar](50) NULL,
	[JianJie] [varchar](500) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_PhotoFile]    Script Date: 03/10/2013 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_PhotoFile](
	[FileID] [varchar](50) NOT NULL,
	[BookID] [varchar](50) NULL,
	[Photo] [image] NULL,
	[PhotoFileName] [varchar](50) NULL,
	[Remarks] [varchar](200) NULL,
	[IsCover] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Dict]    Script Date: 03/10/2013 21:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Dict](
	[TypeID] [int] NULL,
	[TypeName] [varchar](50) NULL,
	[TypeValue] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
