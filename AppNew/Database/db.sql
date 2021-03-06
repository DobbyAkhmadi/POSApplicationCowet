USE [db_app]
GO
/****** Object:  Table [dbo].[TBL_LOGIN]    Script Date: 06/17/2015 10:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_LOGIN](
	[ID_USER] [char](7) NOT NULL,
	[NAMA] [varchar](35) NULL,
	[USERNAME] [varchar](25) NULL,
	[PASSWORD] [varchar](25) NULL,
	[AKSES] [varchar](10) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_LOGIN_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_LOGIN_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_LOGIN] PRIMARY KEY NONCLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'username' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'USERNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'password' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'PASSWORD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'akses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'AKSES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN'
GO
/****** Object:  Table [dbo].[TBL_SUPPLIER]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_SUPPLIER](
	[ID_SUPPLIER] [char](7) NOT NULL,
	[NAMA] [varchar](35) NULL,
	[ALAMAT] [varchar](200) NULL,
	[NO_TELP] [varchar](12) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_SUPPLIER_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_SUPPLIER_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_SUPPLIER] PRIMARY KEY CLUSTERED 
(
	[ID_SUPPLIER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'ID_SUPPLIER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'alamat' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'ALAMAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'no_telp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'NO_TELP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER'
GO
/****** Object:  StoredProcedure [dbo].[sp_db]    Script Date: 06/17/2015 10:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_db]
as
select
            DATABASE_NAME   = db_name(s_mf.database_id)
             from
           sys.master_files s_mf
        where
            s_mf.state = 0 and -- ONLINE
            has_dbaccess(db_name(s_mf.database_id)) = 1
            and db_name(s_mf.database_id) NOT IN ('master', 'tempdb', 'model', 'msdb')
             and db_name(s_mf.database_id) not like 'ReportServer%'
        group by s_mf.database_id
        order by 1
GO
/****** Object:  Table [dbo].[TBL_KATEGORI]    Script Date: 06/17/2015 10:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_KATEGORI](
	[ID_KATEGORI] [int] IDENTITY(1,1) NOT NULL,
	[NAMA] [varchar](20) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_KATEGORI_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_KATEGORI_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_KATEGORI] PRIMARY KEY CLUSTERED 
(
	[ID_KATEGORI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI', @level2type=N'COLUMN',@level2name=N'ID_KATEGORI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI'
GO
/****** Object:  Table [dbo].[TBL_PEMBAYARAN]    Script Date: 06/17/2015 10:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_PEMBAYARAN](
	[ID_PEMBAYARAN] [int] IDENTITY(1,1) NOT NULL,
	[VIA] [varchar](25) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_PEMBAYARAN_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_PEMBAYARAN_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_PEMBAYARAN] PRIMARY KEY CLUSTERED 
(
	[ID_PEMBAYARAN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'via' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN', @level2type=N'COLUMN',@level2name=N'VIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN'
GO
/****** Object:  Table [dbo].[TBL_RETUR_PEMBELIAN]    Script Date: 06/17/2015 10:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_RETUR_PEMBELIAN](
	[ID_RETUR_BELI] [char](7) NOT NULL,
	[ID_USER] [char](7) NULL,
	[ID_TRANSAKSI_BELI] [char](7) NULL,
	[TANGGAL] [datetime] NULL,
 CONSTRAINT [PK_TBL_RETUR_PEMBELIAN] PRIMARY KEY CLUSTERED 
(
	[ID_RETUR_BELI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_retur_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'ID_RETUR_BELI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Retur_Pembelian' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN'
GO
/****** Object:  Table [dbo].[TBL_LOG]    Script Date: 06/17/2015 10:55:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_LOG](
	[ID_LOG] [int] NOT NULL,
	[ID_USER] [char](7) NULL,
	[TGL_MASUK] [datetime] NULL,
	[TGL_KELUAR] [datetime] NULL,
	[AKSI] [varchar](35) NULL,
 CONSTRAINT [PK_TBL_LOG] PRIMARY KEY CLUSTERED 
(
	[ID_LOG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_HEAD_JUAL]    Script Date: 06/17/2015 10:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_HEAD_JUAL](
	[ID_TRANSAKSI_JUAL] [char](7) NOT NULL,
	[ID_USER] [char](7) NULL,
	[NAMACUST] [varchar](25) NULL,
	[ID_PEMBAYARAN] [int] NULL,
	[TANGGAL] [datetime] NULL CONSTRAINT [DF_TBL_HEAD_JUAL_TANGGAL]  DEFAULT (getutcdate()),
	[TYPE] [varchar](12) NULL,
	[KREDIT] [int] NULL,
	[DISKON] [int] NULL,
	[STATUS] [varchar](8) NULL,
	[GRANDTOTAL] [money] NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_HEAD_JUAL_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_HEAD_JUAL_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_HEAD_JUAL] PRIMARY KEY CLUSTERED 
(
	[ID_TRANSAKSI_JUAL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_transaksi_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_TRANSAKSI_JUAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'namacust' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'NAMACUST'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_head_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL'
GO
/****** Object:  Table [dbo].[TBL_RETUR_PENJUALAN]    Script Date: 06/17/2015 10:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_RETUR_PENJUALAN](
	[ID_RETUR] [char](7) NOT NULL,
	[ID_USER] [char](7) NULL,
	[ID_TRANSAKSI_JUAL] [char](7) NULL,
	[TANGGAL] [datetime] NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_RETUR_PENJUALAN_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_RETUR_PENJUALAN_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_RETUR_PENJUALAN] PRIMARY KEY CLUSTERED 
(
	[ID_RETUR] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_retur' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'ID_RETUR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Retur_Penjualan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN'
GO
/****** Object:  Table [dbo].[TBL_HEAD_BELI]    Script Date: 06/17/2015 10:55:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_HEAD_BELI](
	[ID_TRANSAKSI_BELI] [char](7) NOT NULL,
	[ID_USER] [char](7) NULL,
	[ID_SUPPLIER] [char](7) NULL,
	[ID_PEMBAYARAN] [int] NULL,
	[TANGGAL] [datetime] NULL,
	[TYPEE] [varchar](12) NULL,
	[KREDIT] [int] NULL,
	[DISKON] [int] NULL,
	[STATUS] [varchar](8) NULL,
	[GRANDTOTAL] [money] NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_HEAD_BELI_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_HEAD_BELI_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_HEAD_BELI] PRIMARY KEY NONCLUSTERED 
(
	[ID_TRANSAKSI_BELI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_transaksi_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_TRANSAKSI_BELI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_SUPPLIER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_head_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI'
GO
/****** Object:  Table [dbo].[TBL_DETAIL_JUAL]    Script Date: 06/17/2015 10:54:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DETAIL_JUAL](
	[ID_TRANSAKSI_JUAL] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH] [int] NULL,
	[HARGA] [money] NULL,
	[STATUS] [varchar](7) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]    Script Date: 06/17/2015 10:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN](
	[ID_RETUR_BELI] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH_RETUR] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_DETAIL_RETUR_PENJUALAN]    Script Date: 06/17/2015 10:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN](
	[ID_RETUR] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH_RETUR] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_DETAIL_BELI]    Script Date: 06/17/2015 10:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DETAIL_BELI](
	[ID_TRANSAKSI_BELI] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH] [int] NULL,
	[HARGA] [money] NULL,
	[STATUS] [varchar](7) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_PRODUK]    Script Date: 06/17/2015 10:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_PRODUK](
	[ID_PRODUK] [char](7) NOT NULL,
	[ID_KATEGORI] [int] NULL,
	[NAMA] [varchar](35) NULL,
	[HARGA_BELI] [money] NULL,
	[HARGA_JUAL] [money] NULL,
	[STOK] [int] NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_PRODUK_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_PRODUK_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_PRODUK] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_produk' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'ID_PRODUK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'ID_KATEGORI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'harga_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'HARGA_BELI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'harga_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'HARGA_JUAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'stok' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'STOK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_produk' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK'
GO
/****** Object:  StoredProcedure [dbo].[proc_auto_user]    Script Date: 06/17/2015 10:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_auto_user]
as
 select count(*) from tbl_login
GO
/****** Object:  StoredProcedure [dbo].[proc_save_user]    Script Date: 06/17/2015 10:54:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_save_user]
(@1 char (7),
@2 varchar (35),
@3 varchar(25),
@4 varchar(25),
@5 varchar(10))
as
insert into tbl_login (id_user,nama,username,password,akses)values (@1,@2,@3,HashBytes('MD5',@4 ),@5)
GO
/****** Object:  StoredProcedure [dbo].[proc_view_retur_data_beli]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_retur_data_beli]
(@1 char(7)
)
as
SELECT     dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI AS ID, dbo.TBL_HEAD_BELI.TANGGAL AS Tanggal, dbo.TBL_SUPPLIER.NAMA AS [Nama Pemasok], 
                      dbo.TBL_SUPPLIER.ALAMAT AS Alamat, dbo.TBL_SUPPLIER.NO_TELP AS [No Telp], dbo.TBL_PEMBAYARAN.VIA, dbo.TBL_LOGIN.NAMA AS [User]
FROM         dbo.TBL_HEAD_BELI INNER JOIN
                      dbo.TBL_PEMBAYARAN ON dbo.TBL_HEAD_BELI.ID_PEMBAYARAN = dbo.TBL_PEMBAYARAN.ID_PEMBAYARAN INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_BELI.ID_USER = dbo.TBL_LOGIN.ID_USER INNER JOIN
                      dbo.TBL_SUPPLIER ON dbo.TBL_HEAD_BELI.ID_SUPPLIER = dbo.TBL_SUPPLIER.ID_SUPPLIER
WHERE     (dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI = @1 )
GO
/****** Object:  StoredProcedure [dbo].[proc_view_retur_data]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_retur_data]
(@1 char(7)
)
as
SELECT     dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS [ID Transaksi], dbo.TBL_LOGIN.NAMA AS [Nama User], dbo.TBL_HEAD_JUAL.NAMACUST AS [Nama Pelanggan], 
                      dbo.TBL_HEAD_JUAL.TANGGAL AS Tanggal, dbo.TBL_PEMBAYARAN.VIA AS Pembayaran
FROM         dbo.TBL_HEAD_JUAL INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_JUAL.ID_USER = dbo.TBL_LOGIN.ID_USER INNER JOIN
                      dbo.TBL_PEMBAYARAN ON dbo.TBL_HEAD_JUAL.ID_PEMBAYARAN = dbo.TBL_PEMBAYARAN.ID_PEMBAYARAN
WHERE     (dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = @1)
GO
/****** Object:  StoredProcedure [dbo].[proc_update_user]    Script Date: 06/17/2015 10:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_update_user]
(@1 char (7),
@2 varchar (35),
@3 varchar(25),
@4 varchar(25),
@5 varchar(10))
as

update tbl_login set nama=@2, username=@3,password=HashBytes('MD5',@4 ),akses=@5 where id_user=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_view_user]    Script Date: 06/17/2015 10:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_user]
as
SELECT     ID_USER AS [ID Pengguna], NAMA AS Nama, USERNAME AS Username, PASSWORD AS Password, AKSES AS Akses, CreationDate
FROM         dbo.TBL_LOGIN
GO
/****** Object:  StoredProcedure [dbo].[proc_Delete_user]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_Delete_user]
(@1 char (7))
as
delete from tbl_login where id_user=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_get_head]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_get_head]
as
SELECT dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS ID, dbo.TBL_HEAD_JUAL.NAMACUST AS [Nama Pelanggan], dbo.TBL_HEAD_JUAL.TANGGAL AS Tanggal, dbo.TBL_LOGIN.NAMA AS [User],dbo.TBL_HEAD_JUAL.status AS Status  FROM dbo.TBL_HEAD_JUAL INNER JOIN dbo.TBL_LOGIN ON dbo.TBL_HEAD_JUAL.ID_USER = dbo.TBL_LOGIN.ID_USER where status='Online'
GO
/****** Object:  StoredProcedure [dbo].[proc_get_head_beli]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_get_head_beli]
as
SELECT     dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI AS ID, dbo.TBL_SUPPLIER.NAMA AS [Nama Pemasok], dbo.TBL_HEAD_BELI.TANGGAL AS Tanggal, 
                      dbo.TBL_LOGIN.NAMA AS [User]
FROM         dbo.TBL_HEAD_BELI INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_BELI.ID_USER = dbo.TBL_LOGIN.ID_USER INNER JOIN
                      dbo.TBL_SUPPLIER ON dbo.TBL_HEAD_BELI.ID_SUPPLIER = dbo.TBL_SUPPLIER.ID_SUPPLIER where dbo.TBL_HEAD_BELI.status='Online'
GO
/****** Object:  StoredProcedure [dbo].[proc_proses_Login]    Script Date: 06/17/2015 10:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_proses_Login]

@3 varchar(25),
@4 varchar(25)

as
select * from tbl_login where username=@3 and password=HASHBYTES('MD5', @4)
GO
/****** Object:  StoredProcedure [dbo].[proc_rpt_jual]    Script Date: 06/17/2015 10:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_rpt_jual]
(
@1 char(7)
)
as 
SELECT     dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS [ID Transaksi], dbo.TBL_HEAD_JUAL.TANGGAL AS Tanggal, dbo.TBL_HEAD_JUAL.NAMACUST AS Pelanggan, 
                      dbo.TBL_PEMBAYARAN.VIA AS Via, dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_PRODUK.NAMA AS [Nama Produk], 
                      dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_DETAIL_JUAL.JUMLAH AS Jumlah, dbo.TBL_DETAIL_JUAL.HARGA AS Harga, dbo.TBL_LOGIN.NAMA AS [User]
FROM         dbo.TBL_HEAD_JUAL INNER JOIN
                      dbo.TBL_DETAIL_JUAL ON dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = dbo.TBL_DETAIL_JUAL.ID_TRANSAKSI_JUAL INNER JOIN
                      dbo.TBL_PEMBAYARAN ON dbo.TBL_HEAD_JUAL.ID_PEMBAYARAN = dbo.TBL_PEMBAYARAN.ID_PEMBAYARAN INNER JOIN
                      dbo.TBL_PRODUK ON dbo.TBL_DETAIL_JUAL.ID_PRODUK = dbo.TBL_PRODUK.ID_PRODUK INNER JOIN
                      dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_JUAL.ID_USER = dbo.TBL_LOGIN.ID_USER
WHERE     (dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = @1)
GO
/****** Object:  StoredProcedure [dbo].[proc_get_produk_beli]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_get_produk_beli]
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_PRODUK.NAMA AS Produk,dbo.TBL_KATEGORI.NAMA AS Kategori,dbo.TBL_PRODUK.stok AS Stok ,dbo.TBL_PRODUK.harga_beli AS Harga FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[proc_get_produk]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_get_produk]
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_PRODUK.NAMA AS Produk,dbo.TBL_KATEGORI.NAMA AS Kategori,dbo.TBL_PRODUK.stok AS Stok ,dbo.TBL_PRODUK.harga_beli AS HargaB,dbo.TBL_PRODUK.harga_jual AS HargaJ FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[proc_view_retur_Detail_beli]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_retur_Detail_beli]
(@1 char(7)
)
as
SELECT     dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI AS [ID Transaksi], dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, 
                      dbo.TBL_PRODUK.NAMA AS [Nama Produk], dbo.TBL_DETAIL_BELI.HARGA AS Harga, dbo.TBL_DETAIL_BELI.JUMLAH AS Jumlah, 
                      dbo.TBL_DETAIL_BELI.STATUS AS Status
FROM         dbo.TBL_PRODUK INNER JOIN
                      dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI INNER JOIN
                      dbo.TBL_DETAIL_BELI ON dbo.TBL_PRODUK.ID_PRODUK = dbo.TBL_DETAIL_BELI.ID_PRODUK INNER JOIN
                      dbo.TBL_HEAD_BELI ON dbo.TBL_DETAIL_BELI.ID_TRANSAKSI_BELI = dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI
WHERE      (dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI = @1) and (dbo.TBL_DETAIL_BELI.STATUS = 'Online') and (dbo.TBL_DETAIL_BELI.JUMLAH > 0)
GO
/****** Object:  StoredProcedure [dbo].[proc_view_retur_Detail]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_retur_Detail]
(@1 char(7)
)
as
SELECT     dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS [ID Transaksi], dbo.TBL_DETAIL_JUAL.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, 
                      dbo.TBL_PRODUK.NAMA AS [Nama Produk], dbo.TBL_DETAIL_JUAL.HARGA AS Harga, dbo.TBL_DETAIL_JUAL.JUMLAH AS Jumlah, 
                      dbo.TBL_DETAIL_JUAL.STATUS AS Status
FROM         dbo.TBL_DETAIL_JUAL INNER JOIN
                      dbo.TBL_HEAD_JUAL ON dbo.TBL_DETAIL_JUAL.ID_TRANSAKSI_JUAL = dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL INNER JOIN
                      dbo.TBL_PRODUK ON dbo.TBL_DETAIL_JUAL.ID_PRODUK = dbo.TBL_PRODUK.ID_PRODUK INNER JOIN
                      dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI
WHERE     (dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = @1 and tbl_detail_jual.status='Online' and tbl_detail_jual.jumlah>0)
GO
/****** Object:  StoredProcedure [dbo].[proc_view_product]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_view_product]
as 
SELECT     dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS [Nama Produk], 
                      dbo.TBL_PRODUK.HARGA_BELI AS [Harga Beli], dbo.TBL_PRODUK.HARGA_JUAL AS [Harga Jual], dbo.TBL_PRODUK.STOK AS Stok, dbo.TBL_PRODUK.CreationDate, 
                      dbo.TBL_PRODUK.LastEditDate
FROM         dbo.TBL_KATEGORI INNER JOIN
                      dbo.TBL_PRODUK ON dbo.TBL_KATEGORI.ID_KATEGORI = dbo.TBL_PRODUK.ID_KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[proc_save_product]    Script Date: 06/17/2015 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_save_product]
(
@1 char(7),
@2 int,
@3 varchar(35),
@4 money,
@5 money,
@6 int)
as 
insert into tbl_produk(id_produk,id_kategori,nama,harga_beli,harga_jual,stok) values (@1,@2,@3,@4,@5,@6)
GO
/****** Object:  StoredProcedure [dbo].[proc_update_product]    Script Date: 06/17/2015 10:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_update_product]
(
@1 char(7),
@2 int,
@3 varchar(35),
@4 money,
@5 money,
@6 int)
as 
update tbl_produk set id_kategori=@2,nama=@3,harga_beli=@4,harga_jual=@5,stok=@6 where id_produk=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_view_detail]    Script Date: 06/17/2015 10:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_view_detail]
(@1 char(7)
)
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS Produk FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI where id_produk=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_view_detail_beli]    Script Date: 06/17/2015 10:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_view_detail_beli]
(@1 char(7)
)
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS Produk, dbo.TBL_PRODUK.harga_beli AS Harga FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI where id_produk=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_chek_stok]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_chek_stok]
(@1 char(7))
as
select nama,stok from tbl_produk WHERE id_produk=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_auto_produk]    Script Date: 06/17/2015 10:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_auto_produk]
as 
 select count(*) from tbl_produk
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_product]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_delete_product]
(@1 char (7))
as
delete from tbl_produk where id_produk=@1
GO
/****** Object:  Trigger [update_master]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_master] on [dbo].[TBL_DETAIL_RETUR_PENJUALAN]
for insert
as
update b set b.stok = b.stok + i.jumlah_retur
from tbl_produk b join inserted i on b.id_produk = i.id_produk
GO
/****** Object:  Trigger [update_master_]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_master_] on [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]
for insert
as
update b set b.stok = b.stok - i.jumlah_retur
from tbl_produk b join inserted i on b.id_produk = i.id_produk
GO
/****** Object:  Trigger [update_beli]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_beli] on [dbo].[TBL_DETAIL_BELI]
for insert
as
update b set b.stok = b.stok + i.jumlah
from tbl_produk b join inserted i on b.id_produk = i.id_produk
GO
/****** Object:  Trigger [update_jual]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_jual] on [dbo].[TBL_DETAIL_JUAL]
for insert
as
update b set b.stok = b.stok - i.jumlah
from tbl_produk b join inserted i on b.id_produk = i.id_produk
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_pemasok]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_delete_pemasok]
(@1 char(7))
as 
delete from tbl_supplier where id_supplier=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_auto_pemasok]    Script Date: 06/17/2015 10:54:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_auto_pemasok]
as 
 select count(*) from tbl_supplier
GO
/****** Object:  StoredProcedure [dbo].[proc_save_pemasok]    Script Date: 06/17/2015 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_save_pemasok]
(
@1 char(7),
@2 varchar(35),
@3 varchar (200),
@4 varchar (13)
)
as
insert into tbl_supplier (id_supplier,nama,alamat,no_telp)values(@1,@2,@3,@4)
GO
/****** Object:  StoredProcedure [dbo].[proc_update_pemasok]    Script Date: 06/17/2015 10:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_update_pemasok]
(
@1 char(7),
@2 varchar(35),
@3 varchar (200),
@4 varchar (13)
)
as
update tbl_supplier set nama=@2,alamat=@3,no_telp=@4 where id_supplier=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_view_pemasok]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_view_pemasok]
as
SELECT     ID_SUPPLIER AS [ID Pemasok], NAMA AS [Nama Pemasok], ALAMAT AS Alamat, NO_TELP AS [No Telp], LastEditDate AS Pembaharuan, 
                      CreationDate AS Pembuatan
FROM         dbo.TBL_SUPPLIER
GO
/****** Object:  StoredProcedure [dbo].[proc_get_supplier]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_get_supplier]
as
SELECT     ID_SUPPLIER AS [ID Supplier], NAMA AS Nama, ALAMAT AS Alamat, NO_TELP AS [No Telp]
FROM         dbo.TBL_SUPPLIER
GO
/****** Object:  StoredProcedure [dbo].[proc_get_kategori]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_get_kategori]

as
SELECT     ID_KATEGORI AS [ID Kategori], NAMA AS [Nama Kategori], CreationDate AS Pembuatan
FROM         dbo.TBL_KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[proc_save_kategori]    Script Date: 06/17/2015 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_save_kategori]
(
@1 varchar(20)
)
as
insert into tbl_kategori(nama) values(@1)
GO
/****** Object:  StoredProcedure [dbo].[proc_view_kategori]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_view_kategori]
as
SELECT     ID_KATEGORI AS [ID Kategori], NAMA AS [Nama Kategori],  CreationDate AS [Data Pembuatan]
FROM         dbo.TBL_KATEGORI
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_kategori]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_delete_kategori]
(
@1 int
)
as
delete from tbl_kategori where id_kategori=@1
GO
/****** Object:  Trigger [update_r_beli]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[update_r_beli] on [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]
for insert
as

declare @3 char(7)
select @3=ID_TRANSAKSI_BELI from TBL_RETUR_PEMBELIAN

update b set b.jumlah = b.jumlah - i.jumlah_retur
from tbl_detail_beli b join inserted i on b.id_produk = i.id_produk where ID_TRANSAKSI_BELI=@3
GO
/****** Object:  StoredProcedure [dbo].[proc_save_retur_beli]    Script Date: 06/17/2015 10:54:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_save_retur_beli]
(
@1 char(7),
@2 char(7),
@3 char(7),
@4 datetime
)
as
insert into tbl_retur_pembelian values(@1,@2,@3,@4)
GO
/****** Object:  StoredProcedure [dbo].[proc_save_pembayaran]    Script Date: 06/17/2015 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_save_pembayaran](
@1 varchar(25))
as 
insert into tbl_pembayaran(via)values(@1)
GO
/****** Object:  StoredProcedure [dbo].[proc_view_pembayaran]    Script Date: 06/17/2015 10:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_view_pembayaran]
as 
SELECT     ID_PEMBAYARAN AS [ID Pembayaran], VIA AS [Nama Pembayaran VIA], CreationDate AS [Tanggal Pembuatan]
FROM         dbo.TBL_PEMBAYARAN
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_pembayaran]    Script Date: 06/17/2015 10:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_delete_pembayaran](
@1 int)
as 
delete from tbl_pembayaran where id_pembayaran=@1
GO
/****** Object:  StoredProcedure [dbo].[proc_get_pembayaran]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_get_pembayaran]

as
SELECt ID_PEMBAYARAN AS ID, VIA AS [Via Bank] FROM dbo.TBL_PEMBAYARAN
GO
/****** Object:  StoredProcedure [dbo].[proc_save_detail_beli]    Script Date: 06/17/2015 10:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_save_detail_beli]
(
@1 char(7),
@2 char(7),
@3 int,
@4 money,
@5 varchar(7)
)
as
insert into TBL_DETAIL_BELI values (@1,@2,@3,@4,@5)
GO
/****** Object:  Trigger [update_stat_detail_beli]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_stat_detail_beli] on [dbo].[TBL_DETAIL_BELI]
for update
as
declare @1 int,@2 char(7),@3 char(7)
select @1=jumlah from inserted
select @2=id_produk from inserted
select @3=ID_TRANSAKSI_BELI from inserted

update tbl_detail_beli set status='Offline' where id_produk=@2 and ID_TRANSAKSI_BELI=@3
GO
/****** Object:  Trigger [update_stat_head_beli]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_stat_head_beli] on [dbo].[TBL_DETAIL_BELI]
after update
as
declare @3 char(7), @4 int

select @3=ID_TRANSAKSI_BELI from deleted
--select @1=id_produk from deleted
SELECT @4 = COUNT(*) FROM TBL_DETAIL_BELI WHERE ID_TRANSAKSI_BELI = @3 and [status]='Online'

IF @4 <=0
BEGIN
	update tbl_head_beli set [status]='Offline' where ID_TRANSAKSI_BELI=@3
END
GO
/****** Object:  Trigger [update_stat_head_jual]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_stat_head_jual] on [dbo].[TBL_DETAIL_JUAL]
after update
as
declare @3 char(7), @4 int

select @3=ID_TRANSAKSI_JUAL from deleted
--select @1=id_produk from deleted
SELECT @4 = COUNT(*) FROM TBL_DETAIL_JUAL WHERE ID_TRANSAKSI_JUAL = @3 and [status]='Online'

IF @4 <=0
BEGIN
	update tbl_head_jual set [status]='Offline' where ID_TRANSAKSI_JUAL=@3
END
GO
/****** Object:  Trigger [update_stat_detail_jual]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[update_stat_detail_jual] on [dbo].[TBL_DETAIL_JUAL]
for update
as
declare @1 int,@2 char(7), @3 char(7)
select @1=jumlah from inserted
select @2=id_produk from inserted
select @3=ID_TRANSAKSI_JUAL from inserted

--	delete tbl_detail_jual where id_produk=@2 and ID_TRANSAKSI_JUAL=@3 
	update tbl_detail_jual set [status]='Offline' where id_produk=@2 and ID_TRANSAKSI_JUAL=@3
GO
/****** Object:  Trigger [update_r_jual]    Script Date: 06/17/2015 10:55:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[update_r_jual] on [dbo].[TBL_DETAIL_RETUR_PENJUALAN]
for insert
as

declare @3 char(7)
select @3=ID_TRANSAKSI_JUAL from TBL_RETUR_PENJUALAN

update b set b.jumlah = b.jumlah - i.jumlah_retur
from tbl_detail_jual b join inserted i on b.id_produk = i.id_produk where ID_TRANSAKSI_JUAL=@3
GO
/****** Object:  StoredProcedure [dbo].[proc_save_detail_jual]    Script Date: 06/17/2015 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_save_detail_jual]
(
@1 char(7),
@2 char(7),
@3 int,
@4 money,
@5 varchar(7)
)
as
insert into tbl_detail_jual values (@1,@2,@3,@4,@5)
GO
/****** Object:  StoredProcedure [dbo].[proc_insert_detail_retur_beli]    Script Date: 06/17/2015 10:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insert_detail_retur_beli]
(
@1 char(7),
@2 char(7),
@3 int
)
as 
insert into tbl_detail_retur_pembelian values(@1,@2,@3)
GO
/****** Object:  StoredProcedure [dbo].[proc_insert_detail_retur]    Script Date: 06/17/2015 10:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_insert_detail_retur]
(
@1 char(7),
@2 char(7),
@3 int
)
as 
insert into tbl_detail_retur_penjualan values(@1,@2,@3)
GO
/****** Object:  StoredProcedure [dbo].[proc_save_head_jual]    Script Date: 06/17/2015 10:54:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_save_head_jual]
(
@1 char(7),
@2 char(7),
@3 varchar(25),
@4 int,
@5 datetime,
@6 varchar(12),
@7 int,
@8 int,
@9 varchar(8),
@10 money)
as
insert into TBL_HEAD_JUAL(ID_TRANSAKSI_JUAL,
ID_USER,
NAMACUST,
ID_PEMBAYARAN,
TANGGAL,
TYPE,
KREDIT,
DISKON,
STATUS,
GRANDTOTAL) values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)
GO
/****** Object:  StoredProcedure [dbo].[proc_save_retur_jual]    Script Date: 06/17/2015 10:54:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_save_retur_jual](
@1 char(7),
@2 char(7),
@3 char(7),
@4 datetime)
as
insert into tbl_retur_penjualan (id_retur,id_user,id_transaksi_jual,tanggal)values(@1,@2,@3,@4)
GO
/****** Object:  StoredProcedure [dbo].[proc_save_head_beli]    Script Date: 06/17/2015 10:54:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_save_head_beli]
(
@1 char(7),
@2 char(7),
@3 varchar(25),
@4 int,
@5 datetime,
@6 varchar(12),
@7 int,
@8 int,
@9 varchar(8),
@10 money)
as
insert into TBL_HEAD_BELI(id_transaksi_beli,id_user,id_supplier,id_pembayaran,tanggal,TYPEE,kredit,diskon,[status],GRANDTOTAL) values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)
GO
/****** Object:  ForeignKey [fk_headb_to_detailb]    Script Date: 06/17/2015 10:54:54 ******/
ALTER TABLE [dbo].[TBL_DETAIL_BELI]  WITH NOCHECK ADD  CONSTRAINT [fk_headb_to_detailb] FOREIGN KEY([ID_TRANSAKSI_BELI])
REFERENCES [dbo].[TBL_HEAD_BELI] ([ID_TRANSAKSI_BELI])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_BELI] CHECK CONSTRAINT [fk_headb_to_detailb]
GO
/****** Object:  ForeignKey [FK_TBL_DETA_DETAIL_BE_TBL_PROD]    Script Date: 06/17/2015 10:54:54 ******/
ALTER TABLE [dbo].[TBL_DETAIL_BELI]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETA_DETAIL_BE_TBL_PROD] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_BELI] CHECK CONSTRAINT [FK_TBL_DETA_DETAIL_BE_TBL_PROD]
GO
/****** Object:  ForeignKey [fk_head_to_detail]    Script Date: 06/17/2015 10:54:55 ******/
ALTER TABLE [dbo].[TBL_DETAIL_JUAL]  WITH NOCHECK ADD  CONSTRAINT [fk_head_to_detail] FOREIGN KEY([ID_TRANSAKSI_JUAL])
REFERENCES [dbo].[TBL_HEAD_JUAL] ([ID_TRANSAKSI_JUAL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_JUAL] CHECK CONSTRAINT [fk_head_to_detail]
GO
/****** Object:  ForeignKey [FK_TBL_DETA_DETAIL_PR_TBL_PROD]    Script Date: 06/17/2015 10:54:55 ******/
ALTER TABLE [dbo].[TBL_DETAIL_JUAL]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETA_DETAIL_PR_TBL_PROD] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_JUAL] CHECK CONSTRAINT [FK_TBL_DETA_DETAIL_PR_TBL_PROD]
GO
/****** Object:  ForeignKey [FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK]    Script Date: 06/17/2015 10:54:56 ******/
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN] CHECK CONSTRAINT [FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK]
GO
/****** Object:  ForeignKey [fk_tbl_headb_to_detailb]    Script Date: 06/17/2015 10:54:56 ******/
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [fk_tbl_headb_to_detailb] FOREIGN KEY([ID_RETUR_BELI])
REFERENCES [dbo].[TBL_RETUR_PEMBELIAN] ([ID_RETUR_BELI])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_tbl_headb_to_detailb]
GO
/****** Object:  ForeignKey [fk_returj_to_detail_returj]    Script Date: 06/17/2015 10:54:57 ******/
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN]  WITH NOCHECK ADD  CONSTRAINT [fk_returj_to_detail_returj] FOREIGN KEY([ID_RETUR])
REFERENCES [dbo].[TBL_RETUR_PENJUALAN] ([ID_RETUR])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_returj_to_detail_returj]
GO
/****** Object:  ForeignKey [FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK]    Script Date: 06/17/2015 10:54:57 ******/
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN] CHECK CONSTRAINT [FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK]
GO
/****** Object:  ForeignKey [fk_headb_to_pmbyran]    Script Date: 06/17/2015 10:55:00 ******/
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH CHECK ADD  CONSTRAINT [fk_headb_to_pmbyran] FOREIGN KEY([ID_PEMBAYARAN])
REFERENCES [dbo].[TBL_PEMBAYARAN] ([ID_PEMBAYARAN])
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_pmbyran]
GO
/****** Object:  ForeignKey [fk_headb_to_supp]    Script Date: 06/17/2015 10:55:00 ******/
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH CHECK ADD  CONSTRAINT [fk_headb_to_supp] FOREIGN KEY([ID_SUPPLIER])
REFERENCES [dbo].[TBL_SUPPLIER] ([ID_SUPPLIER])
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_supp]
GO
/****** Object:  ForeignKey [fk_headb_to_user]    Script Date: 06/17/2015 10:55:00 ******/
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH NOCHECK ADD  CONSTRAINT [fk_headb_to_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_user]
GO
/****** Object:  ForeignKey [fk_head_to_fk_log]    Script Date: 06/17/2015 10:55:03 ******/
ALTER TABLE [dbo].[TBL_HEAD_JUAL]  WITH CHECK ADD  CONSTRAINT [fk_head_to_fk_log] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_HEAD_JUAL] CHECK CONSTRAINT [fk_head_to_fk_log]
GO
/****** Object:  ForeignKey [fk_head_to_fk_pembyrn]    Script Date: 06/17/2015 10:55:03 ******/
ALTER TABLE [dbo].[TBL_HEAD_JUAL]  WITH NOCHECK ADD  CONSTRAINT [fk_head_to_fk_pembyrn] FOREIGN KEY([ID_PEMBAYARAN])
REFERENCES [dbo].[TBL_PEMBAYARAN] ([ID_PEMBAYARAN])
GO
ALTER TABLE [dbo].[TBL_HEAD_JUAL] NOCHECK CONSTRAINT [fk_head_to_fk_pembyrn]
GO
/****** Object:  ForeignKey [FK_TBL_LOG_REFERENCE_TBL_LOGI]    Script Date: 06/17/2015 10:55:05 ******/
ALTER TABLE [dbo].[TBL_LOG]  WITH CHECK ADD  CONSTRAINT [FK_TBL_LOG_REFERENCE_TBL_LOGI] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_LOG] CHECK CONSTRAINT [FK_TBL_LOG_REFERENCE_TBL_LOGI]
GO
/****** Object:  ForeignKey [FK_TBL_PROD_REFERENCE_TBL_KATE]    Script Date: 06/17/2015 10:55:10 ******/
ALTER TABLE [dbo].[TBL_PRODUK]  WITH CHECK ADD  CONSTRAINT [FK_TBL_PROD_REFERENCE_TBL_KATE] FOREIGN KEY([ID_KATEGORI])
REFERENCES [dbo].[TBL_KATEGORI] ([ID_KATEGORI])
GO
ALTER TABLE [dbo].[TBL_PRODUK] CHECK CONSTRAINT [FK_TBL_PROD_REFERENCE_TBL_KATE]
GO
/****** Object:  ForeignKey [fk_retur_user]    Script Date: 06/17/2015 10:55:12 ******/
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [fk_retur_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_retur_user]
GO
/****** Object:  ForeignKey [fk_returb_to_headb]    Script Date: 06/17/2015 10:55:12 ******/
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN]  WITH CHECK ADD  CONSTRAINT [fk_returb_to_headb] FOREIGN KEY([ID_TRANSAKSI_BELI])
REFERENCES [dbo].[TBL_HEAD_BELI] ([ID_TRANSAKSI_BELI])
GO
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_returb_to_headb]
GO
/****** Object:  ForeignKey [fk_returjual_to_headjual]    Script Date: 06/17/2015 10:55:13 ******/
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN]  WITH CHECK ADD  CONSTRAINT [fk_returjual_to_headjual] FOREIGN KEY([ID_TRANSAKSI_JUAL])
REFERENCES [dbo].[TBL_HEAD_JUAL] ([ID_TRANSAKSI_JUAL])
GO
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_returjual_to_headjual]
GO
/****** Object:  ForeignKey [fk_tblretur_log]    Script Date: 06/17/2015 10:55:13 ******/
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN]  WITH CHECK ADD  CONSTRAINT [fk_tblretur_log] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_tblretur_log]
GO
