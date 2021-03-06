SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_db]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[sp_db]
as
select
            DATABASE_NAME   = db_name(s_mf.database_id)
             from
           sys.master_files s_mf
        where
            s_mf.state = 0 and -- ONLINE
            has_dbaccess(db_name(s_mf.database_id)) = 1
            and db_name(s_mf.database_id) NOT IN (''master'', ''tempdb'', ''model'', ''msdb'')
             and db_name(s_mf.database_id) not like ''ReportServer%''
        group by s_mf.database_id
        order by 1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_KATEGORI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_KATEGORI](
	[ID_KATEGORI] [int] IDENTITY(1,1) NOT NULL,
	[NAMA] [varchar](20) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_KATEGORI_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_KATEGORI_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_KATEGORI] PRIMARY KEY CLUSTERED 
(
	[ID_KATEGORI] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_KATEGORI', N'COLUMN',N'ID_KATEGORI'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI', @level2type=N'COLUMN',@level2name=N'ID_KATEGORI'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_KATEGORI', N'COLUMN',N'NAMA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_KATEGORI', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_KATEGORI'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_PEMBAYARAN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_PEMBAYARAN](
	[ID_PEMBAYARAN] [int] IDENTITY(1,1) NOT NULL,
	[VIA] [varchar](25) NULL,
	[LastEditDate] [datetime] NULL CONSTRAINT [DF_TBL_PEMBAYARAN_LastEditDate]  DEFAULT (getutcdate()),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_TBL_PEMBAYARAN_CreationDate]  DEFAULT (getutcdate()),
 CONSTRAINT [PK_TBL_PEMBAYARAN] PRIMARY KEY CLUSTERED 
(
	[ID_PEMBAYARAN] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PEMBAYARAN', N'COLUMN',N'ID_PEMBAYARAN'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PEMBAYARAN', N'COLUMN',N'VIA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'via' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN', @level2type=N'COLUMN',@level2name=N'VIA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PEMBAYARAN', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PEMBAYARAN'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_LOGIN]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', N'COLUMN',N'ID_USER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', N'COLUMN',N'NAMA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', N'COLUMN',N'USERNAME'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'username' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'USERNAME'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', N'COLUMN',N'PASSWORD'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'password' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'PASSWORD'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', N'COLUMN',N'AKSES'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'akses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN', @level2type=N'COLUMN',@level2name=N'AKSES'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_LOGIN', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_LOGIN'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_SUPPLIER]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_SUPPLIER', N'COLUMN',N'ID_SUPPLIER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'ID_SUPPLIER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_SUPPLIER', N'COLUMN',N'NAMA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_SUPPLIER', N'COLUMN',N'ALAMAT'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'alamat' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'ALAMAT'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_SUPPLIER', N'COLUMN',N'NO_TELP'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'no_telp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER', @level2type=N'COLUMN',@level2name=N'NO_TELP'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_SUPPLIER', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_SUPPLIER'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_PRODUK]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'ID_PRODUK'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_produk' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'ID_PRODUK'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'ID_KATEGORI'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_kategori' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'ID_KATEGORI'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'NAMA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nama' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'NAMA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'HARGA_BELI'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'harga_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'HARGA_BELI'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'HARGA_JUAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'harga_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'HARGA_JUAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', N'COLUMN',N'STOK'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'stok' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK', @level2type=N'COLUMN',@level2name=N'STOK'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_PRODUK', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_produk' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_PRODUK'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_JUAL]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'ID_TRANSAKSI_JUAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_transaksi_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_TRANSAKSI_JUAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'ID_USER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'NAMACUST'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'namacust' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'NAMACUST'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'ID_PEMBAYARAN'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'TANGGAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', N'COLUMN',N'STATUS'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_JUAL', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_head_jual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_JUAL'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_BELI]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'ID_TRANSAKSI_BELI'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_transaksi_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_TRANSAKSI_BELI'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'ID_USER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'ID_SUPPLIER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_supplier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_SUPPLIER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'ID_PEMBAYARAN'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_pembayaran' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'ID_PEMBAYARAN'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'TANGGAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', N'COLUMN',N'STATUS'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_HEAD_BELI', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_head_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_HEAD_BELI'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PEMBELIAN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN](
	[ID_RETUR_BELI] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH_RETUR] [int] NULL
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_master_]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_master_] on [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]
for insert
as
update b set b.stok = b.stok - i.jumlah_retur
from tbl_produk b join inserted i on b.id_produk = i.id_produk
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_r_beli]'))
EXEC dbo.sp_executesql @statement = N'CREATE trigger [dbo].[update_r_beli] on [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]
for insert
as

declare @3 char(7)
select @3=ID_TRANSAKSI_BELI from TBL_RETUR_PEMBELIAN

update b set b.jumlah = b.jumlah - i.jumlah_retur
from tbl_detail_beli b join inserted i on b.id_produk = i.id_produk where ID_TRANSAKSI_BELI=@3
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_JUAL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_DETAIL_JUAL](
	[ID_TRANSAKSI_JUAL] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH] [int] NULL,
	[HARGA] [money] NULL,
	[STATUS] [varchar](7) NULL
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_jual]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_jual] on [dbo].[TBL_DETAIL_JUAL]
for insert
as
update b set b.stok = b.stok - i.jumlah
from tbl_produk b join inserted i on b.id_produk = i.id_produk
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_stat_detail_jual]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_stat_detail_jual] on [dbo].[TBL_DETAIL_JUAL]
for update
as
declare @1 int,@2 char(7), @3 char(7)
select @1=jumlah from inserted
select @2=id_produk from inserted
select @3=ID_TRANSAKSI_JUAL from inserted

--	delete tbl_detail_jual where id_produk=@2 and ID_TRANSAKSI_JUAL=@3 
	update tbl_detail_jual set [status]=''Offline'' where id_produk=@2 and ID_TRANSAKSI_JUAL=@3
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_stat_head_jual]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_stat_head_jual] on [dbo].[TBL_DETAIL_JUAL]
after update
as
declare @3 char(7), @4 int

select @3=ID_TRANSAKSI_JUAL from deleted
--select @1=id_produk from deleted
SELECT @4 = COUNT(*) FROM TBL_DETAIL_JUAL WHERE ID_TRANSAKSI_JUAL = @3 and [status]=''Online''

IF @4 <=0
BEGIN
	update tbl_head_jual set [status]=''Offline'' where ID_TRANSAKSI_JUAL=@3
END
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PENJUALAN]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PENJUALAN', N'COLUMN',N'ID_RETUR'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_retur' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'ID_RETUR'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PENJUALAN', N'COLUMN',N'ID_USER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PENJUALAN', N'COLUMN',N'TANGGAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PENJUALAN', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Retur_Penjualan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PENJUALAN'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PENJUALAN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN](
	[ID_RETUR] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH_RETUR] [int] NULL
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_master]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_master] on [dbo].[TBL_DETAIL_RETUR_PENJUALAN]
for insert
as
update b set b.stok = b.stok + i.jumlah_retur
from tbl_produk b join inserted i on b.id_produk = i.id_produk
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_r_jual]'))
EXEC dbo.sp_executesql @statement = N'CREATE trigger [dbo].[update_r_jual] on [dbo].[TBL_DETAIL_RETUR_PENJUALAN]
for insert
as

declare @3 char(7)
select @3=ID_TRANSAKSI_JUAL from TBL_RETUR_PENJUALAN

update b set b.jumlah = b.jumlah - i.jumlah_retur
from tbl_detail_jual b join inserted i on b.id_produk = i.id_produk where ID_TRANSAKSI_JUAL=@3
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PEMBELIAN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_RETUR_PEMBELIAN](
	[ID_RETUR_BELI] [char](7) NOT NULL,
	[ID_USER] [char](7) NULL,
	[ID_TRANSAKSI_BELI] [char](7) NULL,
	[TANGGAL] [datetime] NULL,
 CONSTRAINT [PK_TBL_RETUR_PEMBELIAN] PRIMARY KEY CLUSTERED 
(
	[ID_RETUR_BELI] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PEMBELIAN', N'COLUMN',N'ID_RETUR_BELI'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_retur_beli' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'ID_RETUR_BELI'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PEMBELIAN', N'COLUMN',N'ID_USER'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'ID_USER'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PEMBELIAN', N'COLUMN',N'TANGGAL'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tanggal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN', @level2type=N'COLUMN',@level2name=N'TANGGAL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'TBL_RETUR_PEMBELIAN', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tbl_Retur_Pembelian' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBL_RETUR_PEMBELIAN'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_BELI]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_DETAIL_BELI](
	[ID_TRANSAKSI_BELI] [char](7) NULL,
	[ID_PRODUK] [char](7) NULL,
	[JUMLAH] [int] NULL,
	[HARGA] [money] NULL,
	[STATUS] [varchar](7) NULL
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_beli]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_beli] on [dbo].[TBL_DETAIL_BELI]
for insert
as
update b set b.stok = b.stok + i.jumlah
from tbl_produk b join inserted i on b.id_produk = i.id_produk
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_stat_detail_beli]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_stat_detail_beli] on [dbo].[TBL_DETAIL_BELI]
for update
as
declare @1 int,@2 char(7),@3 char(7)
select @1=jumlah from inserted
select @2=id_produk from inserted
select @3=ID_TRANSAKSI_BELI from inserted

update tbl_detail_beli set status=''Offline'' where id_produk=@2 and ID_TRANSAKSI_BELI=@3
' 
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[update_stat_head_beli]'))
EXEC dbo.sp_executesql @statement = N'create trigger [dbo].[update_stat_head_beli] on [dbo].[TBL_DETAIL_BELI]
after update
as
declare @3 char(7), @4 int

select @3=ID_TRANSAKSI_BELI from deleted
--select @1=id_produk from deleted
SELECT @4 = COUNT(*) FROM TBL_DETAIL_BELI WHERE ID_TRANSAKSI_BELI = @3 and [status]=''Online''

IF @4 <=0
BEGIN
	update tbl_head_beli set [status]=''Offline'' where ID_TRANSAKSI_BELI=@3
END
' 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_LOG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_LOG](
	[ID_LOG] [int] NOT NULL,
	[ID_USER] [char](7) NULL,
	[TGL_MASUK] [datetime] NULL,
	[TGL_KELUAR] [datetime] NULL,
	[AKSI] [varchar](35) NULL,
 CONSTRAINT [PK_TBL_LOG] PRIMARY KEY CLUSTERED 
(
	[ID_LOG] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_rpt_jual]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_rpt_jual]
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
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_produk_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_get_produk_beli]
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_PRODUK.NAMA AS Produk,dbo.TBL_KATEGORI.NAMA AS Kategori,dbo.TBL_PRODUK.stok AS Stok ,dbo.TBL_PRODUK.harga_beli AS Harga FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_produk]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_get_produk]
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_PRODUK.NAMA AS Produk,dbo.TBL_KATEGORI.NAMA AS Kategori,dbo.TBL_PRODUK.stok AS Stok ,dbo.TBL_PRODUK.harga_beli AS HargaB,dbo.TBL_PRODUK.harga_jual AS HargaJ FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_retur_Detail_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_retur_Detail_beli]
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
WHERE      (dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI = @1) and (dbo.TBL_DETAIL_BELI.STATUS = ''Online'') and (dbo.TBL_DETAIL_BELI.JUMLAH > 0)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_retur_Detail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_retur_Detail]
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
WHERE     (dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = @1 and tbl_detail_jual.status=''Online'' and tbl_detail_jual.jumlah>0)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_detail_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_view_detail_beli]
(@1 char(7)
)
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS Produk, dbo.TBL_PRODUK.harga_beli AS Harga FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI where id_produk=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_product]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[proc_view_product]
as 
SELECT     dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS [Nama Produk], 
                      dbo.TBL_PRODUK.HARGA_BELI AS [Harga Beli], dbo.TBL_PRODUK.HARGA_JUAL AS [Harga Jual], dbo.TBL_PRODUK.STOK AS Stok, dbo.TBL_PRODUK.CreationDate, 
                      dbo.TBL_PRODUK.LastEditDate
FROM         dbo.TBL_KATEGORI INNER JOIN
                      dbo.TBL_PRODUK ON dbo.TBL_KATEGORI.ID_KATEGORI = dbo.TBL_PRODUK.ID_KATEGORI
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_kategori]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_get_kategori]

as
SELECT     ID_KATEGORI AS [ID Kategori], NAMA AS [Nama Kategori], CreationDate AS Pembuatan
FROM         dbo.TBL_KATEGORI
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_kategori]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[proc_save_kategori]
(
@1 varchar(20)
)
as
insert into tbl_kategori(nama) values(@1)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_kategori]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[proc_view_kategori]
as
SELECT     ID_KATEGORI AS [ID Kategori], NAMA AS [Nama Kategori],  CreationDate AS [Data Pembuatan]
FROM         dbo.TBL_KATEGORI
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_delete_kategori]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[proc_delete_kategori]
(
@1 int
)
as
delete from tbl_kategori where id_kategori=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_detail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_detail]
(@1 char(7)
)
as
SELECT dbo.TBL_PRODUK.ID_PRODUK AS [ID Produk], dbo.TBL_KATEGORI.NAMA AS Kategori, dbo.TBL_PRODUK.NAMA AS Produk FROM dbo.TBL_PRODUK INNER JOIN dbo.TBL_KATEGORI ON dbo.TBL_PRODUK.ID_KATEGORI = dbo.TBL_KATEGORI.ID_KATEGORI where id_produk=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_pembayaran]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_save_pembayaran](
@1 varchar(25))
as 
insert into tbl_pembayaran(via)values(@1)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_pembayaran]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_view_pembayaran]
as 
SELECT     ID_PEMBAYARAN AS [ID Pembayaran], VIA AS [Nama Pembayaran VIA], CreationDate AS [Tanggal Pembuatan]
FROM         dbo.TBL_PEMBAYARAN
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_delete_pembayaran]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_delete_pembayaran](
@1 int)
as 
delete from tbl_pembayaran where id_pembayaran=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_pembayaran]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_get_pembayaran]

as
SELECt ID_PEMBAYARAN AS ID, VIA AS [Via Bank] FROM dbo.TBL_PEMBAYARAN
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_retur_data_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_retur_data_beli]
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
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_retur_data]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_retur_data]
(@1 char(7)
)
as
SELECT     dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS [ID Transaksi], dbo.TBL_LOGIN.NAMA AS [Nama User], dbo.TBL_HEAD_JUAL.NAMACUST AS [Nama Pelanggan], 
                      dbo.TBL_HEAD_JUAL.TANGGAL AS Tanggal, dbo.TBL_PEMBAYARAN.VIA AS Pembayaran
FROM         dbo.TBL_HEAD_JUAL INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_JUAL.ID_USER = dbo.TBL_LOGIN.ID_USER INNER JOIN
                      dbo.TBL_PEMBAYARAN ON dbo.TBL_HEAD_JUAL.ID_PEMBAYARAN = dbo.TBL_PEMBAYARAN.ID_PEMBAYARAN
WHERE     (dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL = @1)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_retur_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_save_retur_beli]
(
@1 char(7),
@2 char(7),
@3 char(7),
@4 datetime
)
as
insert into tbl_retur_pembelian values(@1,@2,@3,@4)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_head]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_get_head]
as
SELECT dbo.TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL AS ID, dbo.TBL_HEAD_JUAL.NAMACUST AS [Nama Pelanggan], dbo.TBL_HEAD_JUAL.TANGGAL AS Tanggal, dbo.TBL_LOGIN.NAMA AS [User],dbo.TBL_HEAD_JUAL.status AS Status  FROM dbo.TBL_HEAD_JUAL INNER JOIN dbo.TBL_LOGIN ON dbo.TBL_HEAD_JUAL.ID_USER = dbo.TBL_LOGIN.ID_USER where status=''Online''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_head_jual]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_save_head_jual]
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
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_retur_jual]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_save_retur_jual](
@1 char(7),
@2 char(7),
@3 char(7),
@4 datetime)
as
insert into tbl_retur_penjualan (id_retur,id_user,id_transaksi_jual,tanggal)values(@1,@2,@3,@4)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_head_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_save_head_beli]
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
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_head_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_get_head_beli]
as
SELECT     dbo.TBL_HEAD_BELI.ID_TRANSAKSI_BELI AS ID, dbo.TBL_SUPPLIER.NAMA AS [Nama Pemasok], dbo.TBL_HEAD_BELI.TANGGAL AS Tanggal, 
                      dbo.TBL_LOGIN.NAMA AS [User]
FROM         dbo.TBL_HEAD_BELI INNER JOIN
                      dbo.TBL_LOGIN ON dbo.TBL_HEAD_BELI.ID_USER = dbo.TBL_LOGIN.ID_USER INNER JOIN
                      dbo.TBL_SUPPLIER ON dbo.TBL_HEAD_BELI.ID_SUPPLIER = dbo.TBL_SUPPLIER.ID_SUPPLIER where dbo.TBL_HEAD_BELI.status=''Online''
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_detail_jual]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_save_detail_jual]
(
@1 char(7),
@2 char(7),
@3 int,
@4 money,
@5 varchar(7)
)
as
insert into tbl_detail_jual values (@1,@2,@3,@4,@5)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insert_detail_retur_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_insert_detail_retur_beli]
(
@1 char(7),
@2 char(7),
@3 int
)
as 
insert into tbl_detail_retur_pembelian values(@1,@2,@3)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insert_detail_retur]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_insert_detail_retur]
(
@1 char(7),
@2 char(7),
@3 int
)
as 
insert into tbl_detail_retur_penjualan values(@1,@2,@3)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_detail_beli]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_save_detail_beli]
(
@1 char(7),
@2 char(7),
@3 int,
@4 money,
@5 varchar(7)
)
as
insert into TBL_DETAIL_BELI values (@1,@2,@3,@4,@5)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_product]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[proc_save_product]
(
@1 char(7),
@2 int,
@3 varchar(35),
@4 money,
@5 money,
@6 int)
as 
insert into tbl_produk(id_produk,id_kategori,nama,harga_beli,harga_jual,stok) values (@1,@2,@3,@4,@5,@6)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_update_product]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[proc_update_product]
(
@1 char(7),
@2 int,
@3 varchar(35),
@4 money,
@5 money,
@6 int)
as 
update tbl_produk set id_kategori=@2,nama=@3,harga_beli=@4,harga_jual=@5,stok=@6 where id_produk=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_chek_stok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_chek_stok]
(@1 char(7))
as
select nama,stok from tbl_produk WHERE id_produk=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_auto_produk]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_auto_produk]
as 
 select count(*) from tbl_produk
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_delete_product]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_delete_product]
(@1 char (7))
as
delete from tbl_produk where id_produk=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_proses_Login]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_proses_Login]

@3 varchar(25),
@4 varchar(25)

as
select * from tbl_login where username=@3 and password=HASHBYTES(''MD5'', @4)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_auto_user]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_auto_user]
as
 select count(*) from tbl_login
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_user]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_save_user]
(@1 char (7),
@2 varchar (35),
@3 varchar(25),
@4 varchar(25),
@5 varchar(10))
as
insert into tbl_login (id_user,nama,username,password,akses)values (@1,@2,@3,HashBytes(''MD5'',@4 ),@5)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_update_user]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_update_user]
(@1 char (7),
@2 varchar (35),
@3 varchar(25),
@4 varchar(25),
@5 varchar(10))
as

update tbl_login set nama=@2, username=@3,password=HashBytes(''MD5'',@4 ),akses=@5 where id_user=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_user]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_view_user]
as
SELECT     ID_USER AS [ID Pengguna], NAMA AS Nama, USERNAME AS Username, PASSWORD AS Password, AKSES AS Akses, CreationDate
FROM         dbo.TBL_LOGIN
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Delete_user]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_Delete_user]
(@1 char (7))
as
delete from tbl_login where id_user=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_delete_pemasok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_delete_pemasok]
(@1 char(7))
as 
delete from tbl_supplier where id_supplier=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_auto_pemasok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_auto_pemasok]
as 
 select count(*) from tbl_supplier
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_save_pemasok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_save_pemasok]
(
@1 char(7),
@2 varchar(35),
@3 varchar (200),
@4 varchar (13)
)
as
insert into tbl_supplier (id_supplier,nama,alamat,no_telp)values(@1,@2,@3,@4)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_update_pemasok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE proc [dbo].[proc_update_pemasok]
(
@1 char(7),
@2 varchar(35),
@3 varchar (200),
@4 varchar (13)
)
as
update tbl_supplier set nama=@2,alamat=@3,no_telp=@4 where id_supplier=@1
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_view_pemasok]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_view_pemasok]
as
SELECT     ID_SUPPLIER AS [ID Pemasok], NAMA AS [Nama Pemasok], ALAMAT AS Alamat, NO_TELP AS [No Telp], LastEditDate AS Pembaharuan, 
                      CreationDate AS Pembuatan
FROM         dbo.TBL_SUPPLIER
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_supplier]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create proc [dbo].[proc_get_supplier]
as
SELECT     ID_SUPPLIER AS [ID Supplier], NAMA AS Nama, ALAMAT AS Alamat, NO_TELP AS [No Telp]
FROM         dbo.TBL_SUPPLIER
' 
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_PROD_REFERENCE_TBL_KATE]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_PRODUK]'))
ALTER TABLE [dbo].[TBL_PRODUK]  WITH CHECK ADD  CONSTRAINT [FK_TBL_PROD_REFERENCE_TBL_KATE] FOREIGN KEY([ID_KATEGORI])
REFERENCES [dbo].[TBL_KATEGORI] ([ID_KATEGORI])
GO
ALTER TABLE [dbo].[TBL_PRODUK] CHECK CONSTRAINT [FK_TBL_PROD_REFERENCE_TBL_KATE]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_head_to_fk_log]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_JUAL]'))
ALTER TABLE [dbo].[TBL_HEAD_JUAL]  WITH CHECK ADD  CONSTRAINT [fk_head_to_fk_log] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_HEAD_JUAL] CHECK CONSTRAINT [fk_head_to_fk_log]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_head_to_fk_pembyrn]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_JUAL]'))
ALTER TABLE [dbo].[TBL_HEAD_JUAL]  WITH NOCHECK ADD  CONSTRAINT [fk_head_to_fk_pembyrn] FOREIGN KEY([ID_PEMBAYARAN])
REFERENCES [dbo].[TBL_PEMBAYARAN] ([ID_PEMBAYARAN])
GO
ALTER TABLE [dbo].[TBL_HEAD_JUAL] NOCHECK CONSTRAINT [fk_head_to_fk_pembyrn]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_headb_to_pmbyran]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_BELI]'))
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH CHECK ADD  CONSTRAINT [fk_headb_to_pmbyran] FOREIGN KEY([ID_PEMBAYARAN])
REFERENCES [dbo].[TBL_PEMBAYARAN] ([ID_PEMBAYARAN])
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_pmbyran]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_headb_to_supp]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_BELI]'))
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH CHECK ADD  CONSTRAINT [fk_headb_to_supp] FOREIGN KEY([ID_SUPPLIER])
REFERENCES [dbo].[TBL_SUPPLIER] ([ID_SUPPLIER])
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_supp]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_headb_to_user]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_HEAD_BELI]'))
ALTER TABLE [dbo].[TBL_HEAD_BELI]  WITH NOCHECK ADD  CONSTRAINT [fk_headb_to_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[TBL_HEAD_BELI] CHECK CONSTRAINT [fk_headb_to_user]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PEMBELIAN]'))
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN] CHECK CONSTRAINT [FK_TBL_DETAIL_RETUR_PEMBELIAN_TBL_PRODUK]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_tbl_headb_to_detailb]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PEMBELIAN]'))
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [fk_tbl_headb_to_detailb] FOREIGN KEY([ID_RETUR_BELI])
REFERENCES [dbo].[TBL_RETUR_PEMBELIAN] ([ID_RETUR_BELI])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_tbl_headb_to_detailb]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_head_to_detail]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_JUAL]'))
ALTER TABLE [dbo].[TBL_DETAIL_JUAL]  WITH NOCHECK ADD  CONSTRAINT [fk_head_to_detail] FOREIGN KEY([ID_TRANSAKSI_JUAL])
REFERENCES [dbo].[TBL_HEAD_JUAL] ([ID_TRANSAKSI_JUAL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_JUAL] CHECK CONSTRAINT [fk_head_to_detail]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_DETA_DETAIL_PR_TBL_PROD]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_JUAL]'))
ALTER TABLE [dbo].[TBL_DETAIL_JUAL]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETA_DETAIL_PR_TBL_PROD] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_JUAL] CHECK CONSTRAINT [FK_TBL_DETA_DETAIL_PR_TBL_PROD]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_returjual_to_headjual]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PENJUALAN]'))
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN]  WITH CHECK ADD  CONSTRAINT [fk_returjual_to_headjual] FOREIGN KEY([ID_TRANSAKSI_JUAL])
REFERENCES [dbo].[TBL_HEAD_JUAL] ([ID_TRANSAKSI_JUAL])
GO
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_returjual_to_headjual]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_tblretur_log]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PENJUALAN]'))
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN]  WITH CHECK ADD  CONSTRAINT [fk_tblretur_log] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_tblretur_log]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_returj_to_detail_returj]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PENJUALAN]'))
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN]  WITH NOCHECK ADD  CONSTRAINT [fk_returj_to_detail_returj] FOREIGN KEY([ID_RETUR])
REFERENCES [dbo].[TBL_RETUR_PENJUALAN] ([ID_RETUR])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN] CHECK CONSTRAINT [fk_returj_to_detail_returj]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_RETUR_PENJUALAN]'))
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_RETUR_PENJUALAN] CHECK CONSTRAINT [FK_TBL_DETAIL_RETUR_PENJUALAN_TBL_PRODUK]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_retur_user]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PEMBELIAN]'))
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN]  WITH NOCHECK ADD  CONSTRAINT [fk_retur_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_retur_user]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_returb_to_headb]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_RETUR_PEMBELIAN]'))
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN]  WITH CHECK ADD  CONSTRAINT [fk_returb_to_headb] FOREIGN KEY([ID_TRANSAKSI_BELI])
REFERENCES [dbo].[TBL_HEAD_BELI] ([ID_TRANSAKSI_BELI])
GO
ALTER TABLE [dbo].[TBL_RETUR_PEMBELIAN] CHECK CONSTRAINT [fk_returb_to_headb]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_headb_to_detailb]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_BELI]'))
ALTER TABLE [dbo].[TBL_DETAIL_BELI]  WITH NOCHECK ADD  CONSTRAINT [fk_headb_to_detailb] FOREIGN KEY([ID_TRANSAKSI_BELI])
REFERENCES [dbo].[TBL_HEAD_BELI] ([ID_TRANSAKSI_BELI])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAIL_BELI] CHECK CONSTRAINT [fk_headb_to_detailb]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_DETA_DETAIL_BE_TBL_PROD]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_DETAIL_BELI]'))
ALTER TABLE [dbo].[TBL_DETAIL_BELI]  WITH NOCHECK ADD  CONSTRAINT [FK_TBL_DETA_DETAIL_BE_TBL_PROD] FOREIGN KEY([ID_PRODUK])
REFERENCES [dbo].[TBL_PRODUK] ([ID_PRODUK])
GO
ALTER TABLE [dbo].[TBL_DETAIL_BELI] CHECK CONSTRAINT [FK_TBL_DETA_DETAIL_BE_TBL_PROD]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_LOG_REFERENCE_TBL_LOGI]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_LOG]'))
ALTER TABLE [dbo].[TBL_LOG]  WITH CHECK ADD  CONSTRAINT [FK_TBL_LOG_REFERENCE_TBL_LOGI] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[TBL_LOGIN] ([ID_USER])
GO
ALTER TABLE [dbo].[TBL_LOG] CHECK CONSTRAINT [FK_TBL_LOG_REFERENCE_TBL_LOGI]
