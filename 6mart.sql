USE [master]
GO
/****** Object:  Database [Erp102Ev]    Script Date: 6.03.2022 22:38:00 ******/
CREATE DATABASE [Erp102Ev]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Erp102Ev', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Erp102Ev.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Erp102Ev_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Erp102Ev_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Erp102Ev] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Erp102Ev].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Erp102Ev] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Erp102Ev] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Erp102Ev] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Erp102Ev] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Erp102Ev] SET ARITHABORT OFF 
GO
ALTER DATABASE [Erp102Ev] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Erp102Ev] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Erp102Ev] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Erp102Ev] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Erp102Ev] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Erp102Ev] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Erp102Ev] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Erp102Ev] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Erp102Ev] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Erp102Ev] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Erp102Ev] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Erp102Ev] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Erp102Ev] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Erp102Ev] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Erp102Ev] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Erp102Ev] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Erp102Ev] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Erp102Ev] SET RECOVERY FULL 
GO
ALTER DATABASE [Erp102Ev] SET  MULTI_USER 
GO
ALTER DATABASE [Erp102Ev] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Erp102Ev] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Erp102Ev] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Erp102Ev] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Erp102Ev] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Erp102Ev] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Erp102Ev', N'ON'
GO
ALTER DATABASE [Erp102Ev] SET QUERY_STORE = OFF
GO
USE [Erp102Ev]
GO
/****** Object:  Table [dbo].[Sehirler]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehirler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[code] [char](2) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDepartmanlar]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartmanlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanKodu] [char](1) NULL,
	[Adi] [nvarchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDoktorlar]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDoktorlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Unvan] [nvarchar](10) NULL,
	[Adi] [nvarchar](70) NULL,
	[Hastane1Id] [int] NULL,
	[Hastane2Id] [int] NULL,
	[Hastane3Id] [int] NULL,
	[Muayenehane] [nvarchar](100) NULL,
	[Tel1] [nvarchar](20) NULL,
	[Tel2] [nvarchar](20) NULL,
	[Gsm] [nvarchar](20) NULL,
	[Email] [nvarchar](70) NULL,
	[DTarih] [datetime] NULL,
	[SehirId] [int] NULL,
	[VergiDairesi] [nvarchar](50) NULL,
	[VergiNo] [nvarchar](11) NULL,
 CONSTRAINT [PK_tblDoktorlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFirmaDetaylar]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFirmaDetaylar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GirisId] [int] NULL,
	[GirisAdi] [char](1) NULL,
	[YetkiliAdi] [nvarchar](50) NULL,
	[DepartmanId] [int] NULL,
	[Tel] [nvarchar](20) NULL,
	[Gsm] [nvarchar](20) NULL,
	[Email] [nchar](50) NULL,
 CONSTRAINT [PK_FirmaDetaylar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFirmalar]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFirmalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](100) NULL,
	[Adres] [nvarchar](350) NULL,
	[SehirId] [int] NULL,
	[FirmaTip] [nvarchar](50) NULL,
	[VergiDairesi] [nvarchar](50) NULL,
	[VergiNo] [nvarchar](11) NULL,
	[Tel] [nvarchar](20) NULL,
	[Email] [nvarchar](70) NULL,
 CONSTRAINT [PK_tblFirmalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHastaneDetaylar]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHastaneDetaylar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GirisId] [int] NULL,
	[GirisAdi] [char](1) NULL,
	[YetkiliAdi] [nvarchar](50) NULL,
	[DepartmanId] [int] NULL,
	[Tel] [nvarchar](20) NULL,
	[Gsm] [nvarchar](20) NULL,
	[Email] [nchar](50) NULL,
 CONSTRAINT [PK_tblHastaneDetaylar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHastaneler]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHastaneler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](250) NULL,
	[TipID] [int] NULL,
	[Adres] [nvarchar](max) NULL,
	[SehirId] [int] NULL,
	[Tel] [nvarchar](20) NULL,
	[CariAdi] [nvarchar](250) NULL,
	[VergiDairesi] [nvarchar](100) NULL,
	[VergiNo] [nvarchar](11) NULL,
 CONSTRAINT [PK__tblHasta__3214EC071F72CB85] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHastanetip]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHastanetip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipAdi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersoneller]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersoneller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Unvan] [nvarchar](30) NULL,
	[Adi] [nvarchar](100) NULL,
	[DepartmanId] [int] NULL,
	[Tel] [nvarchar](20) NULL,
	[Gsm] [nvarchar](20) NULL,
	[Email] [nvarchar](70) NULL,
	[Adres] [nvarchar](300) NULL,
	[SehirId] [int] NULL,
	[IsBaslangicTarih] [datetime] NULL,
	[IsBitisTarih] [datetime] NULL,
 CONSTRAINT [PK_tblPersoneller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStokDurum]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStokDurum](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Barkod] [nvarchar](100) NULL,
	[UrunKodu] [nvarchar](100) NULL,
	[LotSeriNo] [nvarchar](50) NULL,
	[StokAdet] [int] NULL,
	[RafAdet] [int] NULL,
	[KonsinyeAdet] [int] NULL,
	[SubeAdet] [int] NULL,
	[UrunHareketAdet] [int] NULL,
	[SutKodu] [nvarchar](50) NULL,
	[BransNo] [nvarchar](250) NULL,
	[Uts] [bit] NULL,
	[UTarih] [date] NULL,
	[SKTarih] [date] NULL,
 CONSTRAINT [PK_tblStokDurum] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunGirisAlt]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunGirisAlt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GirisId] [int] NULL,
	[Barkod] [nvarchar](100) NULL,
	[UrunKodu] [nvarchar](100) NULL,
	[LotSeriNo] [nvarchar](50) NULL,
	[GirisAdet] [int] NULL,
	[GirisTarih] [date] NULL,
	[BransNo] [nvarchar](50) NULL,
	[UtsDurum] [bit] NULL,
	[UTarih] [date] NULL,
	[SKTarih] [date] NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblUrunGirisAlt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunGirisUst]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunGirisUst](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GirisId] [int] NULL,
	[CariTip] [nvarchar](10) NULL,
	[CariAdi] [nvarchar](100) NULL,
	[CariId] [int] NULL,
	[GirisTuru] [nvarchar](20) NULL,
	[FaturaNo] [nvarchar](30) NULL,
	[Aciklama] [nvarchar](350) NULL,
	[GirisTarih] [date] NULL,
	[isDeleted] [bit] NULL,
	[CreatedDate] [date] NULL,
	[CreatedUser] [int] NULL,
	[UpdateDate] [date] NULL,
	[UpdateUser] [int] NULL,
 CONSTRAINT [PK_tblUrunGirisUst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunKayitAlt]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunKayitAlt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Uid] [int] NULL,
	[UIKodu] [nvarchar](50) NULL,
	[GMDMKodu] [nvarchar](50) NULL,
	[UNSPCKodu] [nvarchar](50) NULL,
	[SB] [bit] NULL,
	[KullanimDisi] [bit] NULL,
	[BirimFiyat] [decimal](18, 4) NULL,
	[ParaBirimi] [nvarchar](10) NULL,
	[MinFiyat] [decimal](18, 4) NULL,
	[Ubb] [nvarchar](50) NULL,
	[Sut] [nvarchar](50) NULL,
	[SutFiyat] [decimal](18, 4) NULL,
	[SutAciklama] [nvarchar](250) NULL,
	[Aciklama] [nvarchar](250) NULL,
	[Sinif] [nvarchar](70) NULL,
	[BransAdi] [nvarchar](max) NULL,
	[UTS] [bit] NULL,
 CONSTRAINT [PK_tblUrunKayitAlt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunKayitUst]    Script Date: 6.03.2022 22:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunKayitUst](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Uid] [int] NULL,
	[FirmaId] [int] NULL,
	[UrunKodu] [nvarchar](70) NULL,
	[AciklamaTr] [nvarchar](250) NULL,
	[AciklamaEng] [nvarchar](250) NULL,
	[GirisTarih] [date] NULL,
	[Resim] [image] NULL,
	[KullanimSuresi] [int] NULL,
 CONSTRAINT [PK_tblUrunKayitUst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sehirler] ON 
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (1, N'01', N'Adana')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (2, N'02', N'Adıyaman')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (3, N'03', N'Afyon')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (4, N'04', N'Ağrı')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (5, N'05', N'Amasya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (6, N'06', N'Ankara')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (7, N'07', N'Antalya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (8, N'08', N'Artvin')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (9, N'09', N'Aydın')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (10, N'10', N'Balıkesir')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (11, N'11', N'Bilecik')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (12, N'12', N'Bingöl')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (13, N'13', N'Bitlis')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (14, N'14', N'Bolu')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (15, N'15', N'Burdur')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (16, N'16', N'Bursa')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (17, N'17', N'Çanakkale')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (18, N'18', N'Çankırı')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (19, N'19', N'Çorum')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (20, N'20', N'Denizli')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (21, N'21', N'Diyarbakır')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (22, N'22', N'Edirne')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (23, N'23', N'Elazığ')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (24, N'24', N'Erzincan')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (25, N'25', N'Erzurum')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (26, N'26', N'Eskişehir')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (27, N'27', N'Gaziantep')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (28, N'28', N'Giresun')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (29, N'29', N'Gümüşhane')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (30, N'30', N'Hakkari')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (31, N'31', N'Hatay')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (32, N'32', N'Isparta')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (33, N'33', N'Mersin')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (34, N'34', N'İstanbul')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (35, N'35', N'İzmir')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (36, N'36', N'Kars')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (37, N'37', N'Kastamonu')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (38, N'38', N'Kayseri')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (39, N'39', N'Kırklareli')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (40, N'40', N'Kırşehir')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (41, N'41', N'Kocaeli')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (42, N'42', N'Konya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (43, N'43', N'Kütahya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (44, N'44', N'Malatya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (45, N'45', N'Manisa')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (46, N'46', N'K.Maraş')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (47, N'47', N'Mardin')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (48, N'48', N'Muğla')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (49, N'49', N'Muş')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (50, N'50', N'Nevşehir')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (51, N'51', N'Niğde')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (52, N'52', N'Ordu')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (53, N'53', N'Rize')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (54, N'54', N'Sakarya')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (55, N'55', N'Samsun')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (56, N'56', N'Siirt')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (57, N'57', N'Sinop')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (58, N'58', N'Sivas')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (59, N'59', N'Tekirdağ')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (60, N'60', N'Tokat')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (61, N'61', N'Trabzon')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (62, N'62', N'Tunceli')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (63, N'63', N'Şanlıurfa')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (64, N'64', N'Uşak')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (65, N'65', N'Van')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (66, N'66', N'Yozgat')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (67, N'67', N'Zonguldak')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (68, N'68', N'Aksaray')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (69, N'69', N'Bayburt')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (70, N'70', N'Karaman')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (71, N'71', N'Kırıkkale')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (72, N'72', N'Batman')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (73, N'73', N'Şırnak')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (74, N'74', N'Bartın')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (75, N'75', N'Ardahan')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (76, N'76', N'Iğdır')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (77, N'77', N'Yalova')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (78, N'78', N'Karabük')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (79, N'79', N'Kilis')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (80, N'80', N'Osmaniye')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (81, N'81', N'Düzce')
GO
INSERT [dbo].[Sehirler] ([Id], [code], [name]) VALUES (82, N'84', N'Sehir Secin')
GO
SET IDENTITY_INSERT [dbo].[Sehirler] OFF
GO
SET IDENTITY_INSERT [dbo].[tblDepartmanlar] ON 
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (1, N'H', N'Ameliyathane')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (2, N'H', N'Satin Alma')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (3, N'H', N'Muhasebe')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (4, N'H', N'Poliklinik')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (5, N'H', N'Servis')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (6, N'H', N'Acil')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (7, N'H', N'Yogun Bakim')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (8, N'F', N'Satin Alma')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (9, N'F', N'Muhasebe')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (10, N'F', N'Evrak')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (11, N'F', N'Depo')
GO
INSERT [dbo].[tblDepartmanlar] ([Id], [DepartmanKodu], [Adi]) VALUES (12, N'F', N'Lojistik')
GO
SET IDENTITY_INSERT [dbo].[tblDepartmanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblDoktorlar] ON 
GO
INSERT [dbo].[tblDoktorlar] ([Id], [Unvan], [Adi], [Hastane1Id], [Hastane2Id], [Hastane3Id], [Muayenehane], [Tel1], [Tel2], [Gsm], [Email], [DTarih], [SehirId], [VergiDairesi], [VergiNo]) VALUES (1, N'ProfDr', N'Ahmet Mahmudovt', 3, 2, 3, N'mahmudov malikanesi', N'(567) 945-6465', N'(789) 496-5466', N'(456) 465-4566', N'mahmudav@gmail.com', CAST(N'1991-12-01T19:10:42.000' AS DateTime), 3, N'MVO', N'53434534533')
GO
INSERT [dbo].[tblDoktorlar] ([Id], [Unvan], [Adi], [Hastane1Id], [Hastane2Id], [Hastane3Id], [Muayenehane], [Tel1], [Tel2], [Gsm], [Email], [DTarih], [SehirId], [VergiDairesi], [VergiNo]) VALUES (2, N'ProfDr', N'Salam Makarna', 2, 3, 1, N'mahmudov malikanesi', N'(654) 656-4646', N'(123) 123-1321', N'(556) 545-6564', N'salam@gmail.com', CAST(N'1992-02-01T19:10:42.000' AS DateTime), 5, N'MVO', N'53434534533')
GO
INSERT [dbo].[tblDoktorlar] ([Id], [Unvan], [Adi], [Hastane1Id], [Hastane2Id], [Hastane3Id], [Muayenehane], [Tel1], [Tel2], [Gsm], [Email], [DTarih], [SehirId], [VergiDairesi], [VergiNo]) VALUES (3, N'YrdDocDr', N'Mehmet Morinovt', 1, 3, 2, N'sdfdsfsdfdsdfs', N'(124) 122-1412', N'(363) 464-3634', N'(645) 645-6456', N'mmmm', CAST(N'2022-02-19T19:18:50.000' AS DateTime), NULL, N'asd', N'12312312312')
GO
SET IDENTITY_INSERT [dbo].[tblDoktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblFirmaDetaylar] ON 
GO
INSERT [dbo].[tblFirmaDetaylar] ([Id], [GirisId], [GirisAdi], [YetkiliAdi], [DepartmanId], [Tel], [Gsm], [Email]) VALUES (1, 5, NULL, N'Ahmet', 9, N'(123) 123-1231', N'(124) 124-1241', N'ahmet                                             ')
GO
SET IDENTITY_INSERT [dbo].[tblFirmaDetaylar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblFirmalar] ON 
GO
INSERT [dbo].[tblFirmalar] ([Id], [Adi], [Adres], [SehirId], [FirmaTip], [VergiDairesi], [VergiNo], [Tel], [Email]) VALUES (1, N'Aselsan', N'Ankara55', 54, N'Distiributor', N'AVD', N'12312312312', N'(123) 123-123', N'aselsan@gmail.com')
GO
INSERT [dbo].[tblFirmalar] ([Id], [Adi], [Adres], [SehirId], [FirmaTip], [VergiDairesi], [VergiNo], [Tel], [Email]) VALUES (5, N'Wissen', N'besktast', 54, N'AnaSatici', N'bvd', N'12312312312', N'(231) 231-2312', N'wssn')
GO
SET IDENTITY_INSERT [dbo].[tblFirmalar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHastaneDetaylar] ON 
GO
INSERT [dbo].[tblHastaneDetaylar] ([Id], [GirisId], [GirisAdi], [YetkiliAdi], [DepartmanId], [Tel], [Gsm], [Email]) VALUES (1, 1, NULL, N'fgdfdgddf', 1, N'(123) 121-2312', N'(123) 123-1232', N'asdasdsadas                                       ')
GO
SET IDENTITY_INSERT [dbo].[tblHastaneDetaylar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHastaneler] ON 
GO
INSERT [dbo].[tblHastaneler] ([Id], [Adi], [TipID], [Adres], [SehirId], [Tel], [CariAdi], [VergiDairesi], [VergiNo]) VALUES (1, N'Mahmudiye', 2, N'asddsasdat', 34, N'(453) 453-4535', N'Mahmud', N'CNO', N'64654646546')
GO
INSERT [dbo].[tblHastaneler] ([Id], [Adi], [TipID], [Adres], [SehirId], [Tel], [CariAdi], [VergiDairesi], [VergiNo]) VALUES (2, N'Dizdariye', 2, N'buyuktrt', 32, N'(123) 123-1254', N'Dizdariye Saglik Hizmet Ltd Sti', N'Buyukcekmece VD', N'47634331456')
GO
INSERT [dbo].[tblHastaneler] ([Id], [Adi], [TipID], [Adres], [SehirId], [Tel], [CariAdi], [VergiDairesi], [VergiNo]) VALUES (3, N'Carsamba', 1, N'asfasffasfasfast', 2, N'(654) 564-5644', N'Carsamba', N'sasadas', N'46363443534')
GO
SET IDENTITY_INSERT [dbo].[tblHastaneler] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHastanetip] ON 
GO
INSERT [dbo].[tblHastanetip] ([Id], [TipAdi]) VALUES (1, N'Devlet')
GO
INSERT [dbo].[tblHastanetip] ([Id], [TipAdi]) VALUES (2, N'Ozel')
GO
INSERT [dbo].[tblHastanetip] ([Id], [TipAdi]) VALUES (3, N'Vakif')
GO
SET IDENTITY_INSERT [dbo].[tblHastanetip] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPersoneller] ON 
GO
INSERT [dbo].[tblPersoneller] ([Id], [Unvan], [Adi], [DepartmanId], [Tel], [Gsm], [Email], [Adres], [SehirId], [IsBaslangicTarih], [IsBitisTarih]) VALUES (1, N'Hasta Bakici', N'Trikov Milikov', 2, N'(123) 123-2131', N'(112) 412-4214', N'sdfsdfdsfds', N'Tarlabasi+-', 2, CAST(N'2022-02-01T21:52:22.000' AS DateTime), CAST(N'2052-02-20T21:52:22.000' AS DateTime))
GO
INSERT [dbo].[tblPersoneller] ([Id], [Unvan], [Adi], [DepartmanId], [Tel], [Gsm], [Email], [Adres], [SehirId], [IsBaslangicTarih], [IsBitisTarih]) VALUES (3, N'Hemsire', N'Baba Dede', 6, N'(121) 231-2312', N'(123) 123-1231', N'dfgdfgdf', N'Babaeski', 6, CAST(N'2022-01-31T22:02:51.000' AS DateTime), CAST(N'2029-01-01T22:02:51.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblPersoneller] OFF
GO
SET IDENTITY_INSERT [dbo].[tblStokDurum] ON 
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (1, N'AR-1001/1234', N'AR-1001', N'1234', 100, 100, 0, 0, 0, N'123', N'123', 1, CAST(N'2020-12-11' AS Date), CAST(N'2022-12-11' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (2, N'TT-1005/1234', N'TT-1005', N'1234', 750, 750, 0, 0, 0, N'', N' ', 1, CAST(N'1999-02-01' AS Date), CAST(N'2002-02-01' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (3, N'TT-1005/4056', N'TT-1005', N'4056', 380, 380, 0, 0, 0, N'', N'', 0, CAST(N'2021-03-05' AS Date), CAST(N'2024-03-05' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (4, N'TR-1005/1234', N'TR-1005', N'1234', 500, 500, 0, 0, 0, N'', N'', 1, CAST(N'1999-02-01' AS Date), CAST(N'2002-06-01' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (5, N'TT-1005/123', N'TT-1005', N'123', 700, 700, 0, 0, 0, N'', N'', 0, CAST(N'1998-02-01' AS Date), CAST(N'2001-02-01' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (8, N'TT-1005/144', N'TT-1005', N'144', 100, 100, 0, 0, 0, N'', N'', 0, CAST(N'1999-02-01' AS Date), CAST(N'2002-02-01' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (9, N'TT-1005/444', N'TT-1005', N'444', 1295, 1295, 0, 0, 0, N'', N'', 0, CAST(N'1999-05-01' AS Date), CAST(N'2002-05-01' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (10, N'TT-1005/555', N'TT-1005', N'555', 400, 400, 0, 0, 0, N'', N'', 0, CAST(N'2005-05-03' AS Date), CAST(N'2008-05-03' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (11, N'TT-1005/666', N'TT-1005', N'666', 300, 300, 0, 0, 0, N'', N'', 0, CAST(N'2007-08-03' AS Date), CAST(N'2010-08-03' AS Date))
GO
INSERT [dbo].[tblStokDurum] ([Id], [Barkod], [UrunKodu], [LotSeriNo], [StokAdet], [RafAdet], [KonsinyeAdet], [SubeAdet], [UrunHareketAdet], [SutKodu], [BransNo], [Uts], [UTarih], [SKTarih]) VALUES (12, N'TT-1005/999', N'TT-1005', N'999', 800, 800, 0, 0, 0, N'', N'', 0, CAST(N'2005-08-01' AS Date), CAST(N'2008-08-01' AS Date))
GO
SET IDENTITY_INSERT [dbo].[tblStokDurum] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUrunGirisAlt] ON 
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (1, 1, N'TT-1005/1234', N'TT-1005', N'1234', 100, CAST(N'2022-03-02' AS Date), N'', 1, CAST(N'1999-02-01' AS Date), CAST(N'2002-02-01' AS Date), N'asdasd')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (2, 2, N'TT-1005/1234', N'TT-1005', N'1234', 50, CAST(N'2022-03-02' AS Date), N'', 1, CAST(N'2005-03-04' AS Date), CAST(N'2008-03-04' AS Date), N'asdsaasd')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (3, 3, N'TT-1005/4056', N'TT-1005', N'4056', 380, CAST(N'2022-03-02' AS Date), N'', 0, CAST(N'2021-03-05' AS Date), CAST(N'2024-03-05' AS Date), N'aa')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (4, 4, N'TT-1005/1234', N'TT-1005', N'1234', 300, CAST(N'2022-03-02' AS Date), N'', 1, CAST(N'1999-02-01' AS Date), CAST(N'2002-02-01' AS Date), N'bee')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (5, 5, N'TR-1005/1234', N'TR-1005', N'1234', 500, CAST(N'2022-03-04' AS Date), N'', 1, CAST(N'1999-02-01' AS Date), CAST(N'2002-06-01' AS Date), N'sa')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (7, 4, N'TT-1005/123', N'TT-1005', N'123', 700, CAST(N'2022-03-02' AS Date), N'', 0, CAST(N'1998-02-01' AS Date), CAST(N'2001-02-01' AS Date), N'fff')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (11, 4, N'TT-1005/444', N'TT-1005', N'444', 300, CAST(N'2022-03-02' AS Date), N'', 0, CAST(N'1999-05-01' AS Date), CAST(N'2002-05-01' AS Date), N'asa')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (12, 5, N'TT-1005/444', N'TT-1005', N'444', 995, CAST(N'2022-03-04' AS Date), N'', 0, CAST(N'1999-05-04' AS Date), CAST(N'2002-05-04' AS Date), N'fff')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (13, 5, N'TT-1005/555', N'TT-1005', N'555', 400, CAST(N'2022-03-04' AS Date), N'', 0, CAST(N'2005-05-03' AS Date), CAST(N'2008-05-03' AS Date), N'ttt')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (14, 5, N'TT-1005/666', N'TT-1005', N'666', 300, CAST(N'2022-03-04' AS Date), N'', 0, CAST(N'2007-08-03' AS Date), CAST(N'2010-08-03' AS Date), N'qwe')
GO
INSERT [dbo].[tblUrunGirisAlt] ([Id], [GirisId], [Barkod], [UrunKodu], [LotSeriNo], [GirisAdet], [GirisTarih], [BransNo], [UtsDurum], [UTarih], [SKTarih], [Aciklama]) VALUES (15, 4, N'TT-1005/999', N'TT-1005', N'999', 800, CAST(N'2022-03-02' AS Date), N'', 0, CAST(N'2005-08-01' AS Date), CAST(N'2008-08-01' AS Date), N'fqe')
GO
SET IDENTITY_INSERT [dbo].[tblUrunGirisAlt] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUrunGirisUst] ON 
GO
INSERT [dbo].[tblUrunGirisUst] ([Id], [GirisId], [CariTip], [CariAdi], [CariId], [GirisTuru], [FaturaNo], [Aciklama], [GirisTarih], [isDeleted], [CreatedDate], [CreatedUser], [UpdateDate], [UpdateUser]) VALUES (1, 1, N'Doktor', N'Ahmet Mahmudovt', 1, N'Normal Giris', N'123', N'asddsa', CAST(N'2022-03-02' AS Date), 0, CAST(N'2022-03-02' AS Date), -1, CAST(N'2022-03-02' AS Date), -1)
GO
INSERT [dbo].[tblUrunGirisUst] ([Id], [GirisId], [CariTip], [CariAdi], [CariId], [GirisTuru], [FaturaNo], [Aciklama], [GirisTarih], [isDeleted], [CreatedDate], [CreatedUser], [UpdateDate], [UpdateUser]) VALUES (2, 2, N'Doktor', N'Salam Makarna', 2, N'Muhtelif Giris', N'1234', N'yeni mallar', CAST(N'2022-03-02' AS Date), 0, CAST(N'2022-03-02' AS Date), -1, CAST(N'2022-03-02' AS Date), -1)
GO
INSERT [dbo].[tblUrunGirisUst] ([Id], [GirisId], [CariTip], [CariAdi], [CariId], [GirisTuru], [FaturaNo], [Aciklama], [GirisTarih], [isDeleted], [CreatedDate], [CreatedUser], [UpdateDate], [UpdateUser]) VALUES (3, 3, N'Firma', N'Wissen', 5, N'Normal Giris', N'987', N'sa aga', CAST(N'2022-03-02' AS Date), 0, CAST(N'2022-03-02' AS Date), -1, CAST(N'2022-03-02' AS Date), -1)
GO
INSERT [dbo].[tblUrunGirisUst] ([Id], [GirisId], [CariTip], [CariAdi], [CariId], [GirisTuru], [FaturaNo], [Aciklama], [GirisTarih], [isDeleted], [CreatedDate], [CreatedUser], [UpdateDate], [UpdateUser]) VALUES (4, 4, N'Hastane', N'Dizdariye', 2, N'Normal Giris', N'445', N'asdasdasd', CAST(N'2022-03-02' AS Date), 0, CAST(N'2022-03-02' AS Date), -1, CAST(N'2022-03-02' AS Date), -1)
GO
INSERT [dbo].[tblUrunGirisUst] ([Id], [GirisId], [CariTip], [CariAdi], [CariId], [GirisTuru], [FaturaNo], [Aciklama], [GirisTarih], [isDeleted], [CreatedDate], [CreatedUser], [UpdateDate], [UpdateUser]) VALUES (5, 5, N'Hastane', N'Dizdariye', 2, N'Muhtelif Giris', N'1234', N'Maraba', CAST(N'2022-03-04' AS Date), 0, CAST(N'2022-03-04' AS Date), -1, CAST(N'2022-03-04' AS Date), -1)
GO
SET IDENTITY_INSERT [dbo].[tblUrunGirisUst] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUrunKayitAlt] ON 
GO
INSERT [dbo].[tblUrunKayitAlt] ([Id], [Uid], [UIKodu], [GMDMKodu], [UNSPCKodu], [SB], [KullanimDisi], [BirimFiyat], [ParaBirimi], [MinFiyat], [Ubb], [Sut], [SutFiyat], [SutAciklama], [Aciklama], [Sinif], [BransAdi], [UTS]) VALUES (28, 5, N'TT-1005', N'123', N'412', 1, 0, CAST(25.0000 AS Decimal(18, 4)), N'USD', CAST(21.0000 AS Decimal(18, 4)), N'412', N'445', CAST(11.0000 AS Decimal(18, 4)), N'bbbeee', N'bro', N'ii', N'', 1)
GO
INSERT [dbo].[tblUrunKayitAlt] ([Id], [Uid], [UIKodu], [GMDMKodu], [UNSPCKodu], [SB], [KullanimDisi], [BirimFiyat], [ParaBirimi], [MinFiyat], [Ubb], [Sut], [SutFiyat], [SutAciklama], [Aciklama], [Sinif], [BransAdi], [UTS]) VALUES (29, 6, N'TR-1005', N'A245C', N'BT49E', 1, 0, CAST(45.0000 AS Decimal(18, 4)), N'EUR', CAST(32.0000 AS Decimal(18, 4)), N'TCKE4F', N'PR4EG', CAST(3525.0000 AS Decimal(18, 4)), N'cok pahali', N'degisim istasyonu', N'iii', N'', 1)
GO
INSERT [dbo].[tblUrunKayitAlt] ([Id], [Uid], [UIKodu], [GMDMKodu], [UNSPCKodu], [SB], [KullanimDisi], [BirimFiyat], [ParaBirimi], [MinFiyat], [Ubb], [Sut], [SutFiyat], [SutAciklama], [Aciklama], [Sinif], [BransAdi], [UTS]) VALUES (30, 6, N'TR-1005', N'BL34F', N'HEF24T', 0, 0, CAST(45.0000 AS Decimal(18, 4)), N'EUR', CAST(32.0000 AS Decimal(18, 4)), N'LT45C', N'TB2749', CAST(3325.0000 AS Decimal(18, 4)), N'ucuz  bu usta', N'degisim istasyonu', N'iii', N'', 1)
GO
INSERT [dbo].[tblUrunKayitAlt] ([Id], [Uid], [UIKodu], [GMDMKodu], [UNSPCKodu], [SB], [KullanimDisi], [BirimFiyat], [ParaBirimi], [MinFiyat], [Ubb], [Sut], [SutFiyat], [SutAciklama], [Aciklama], [Sinif], [BransAdi], [UTS]) VALUES (31, 5, N'TT-1005', N'123', N'415', 1, 0, CAST(25.0000 AS Decimal(18, 4)), N'USD', CAST(21.0000 AS Decimal(18, 4)), N'444', N'111', CAST(11.0000 AS Decimal(18, 4)), N'asdas', N'bro', N'ii', N'', 1)
GO
SET IDENTITY_INSERT [dbo].[tblUrunKayitAlt] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUrunKayitUst] ON 
GO
INSERT [dbo].[tblUrunKayitUst] ([Id], [Uid], [FirmaId], [UrunKodu], [AciklamaTr], [AciklamaEng], [GirisTarih], [Resim], [KullanimSuresi]) VALUES (9, 5, 1, N'TT-1005', N'bro', N'hey', CAST(N'2022-02-27' AS Date), NULL, 36)
GO
INSERT [dbo].[tblUrunKayitUst] ([Id], [Uid], [FirmaId], [UrunKodu], [AciklamaTr], [AciklamaEng], [GirisTarih], [Resim], [KullanimSuresi]) VALUES (10, 6, 1, N'TR-1005', N'degisim istasyonu', N'interchange station', CAST(N'2022-03-04' AS Date), NULL, 40)
GO
SET IDENTITY_INSERT [dbo].[tblUrunKayitUst] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblStokDurum_Barkod]    Script Date: 6.03.2022 22:38:00 ******/
CREATE NONCLUSTERED INDEX [IX_tblStokDurum_Barkod] ON [dbo].[tblStokDurum]
(
	[Barkod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblStokDurum_UrunKodu]    Script Date: 6.03.2022 22:38:00 ******/
CREATE NONCLUSTERED INDEX [IX_tblStokDurum_UrunKodu] ON [dbo].[tblStokDurum]
(
	[UrunKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDoktorlar]  WITH CHECK ADD  CONSTRAINT [FK_tblDoktorlar_Sehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([Id])
GO
ALTER TABLE [dbo].[tblDoktorlar] CHECK CONSTRAINT [FK_tblDoktorlar_Sehirler]
GO
ALTER TABLE [dbo].[tblDoktorlar]  WITH CHECK ADD  CONSTRAINT [FK_tblDoktorlar_tblHastaneler] FOREIGN KEY([Hastane1Id])
REFERENCES [dbo].[tblHastaneler] ([Id])
GO
ALTER TABLE [dbo].[tblDoktorlar] CHECK CONSTRAINT [FK_tblDoktorlar_tblHastaneler]
GO
ALTER TABLE [dbo].[tblDoktorlar]  WITH CHECK ADD  CONSTRAINT [FK_tblDoktorlar_tblHastaneler1] FOREIGN KEY([Hastane2Id])
REFERENCES [dbo].[tblHastaneler] ([Id])
GO
ALTER TABLE [dbo].[tblDoktorlar] CHECK CONSTRAINT [FK_tblDoktorlar_tblHastaneler1]
GO
ALTER TABLE [dbo].[tblDoktorlar]  WITH CHECK ADD  CONSTRAINT [FK_tblDoktorlar_tblHastaneler2] FOREIGN KEY([Hastane3Id])
REFERENCES [dbo].[tblHastaneler] ([Id])
GO
ALTER TABLE [dbo].[tblDoktorlar] CHECK CONSTRAINT [FK_tblDoktorlar_tblHastaneler2]
GO
ALTER TABLE [dbo].[tblFirmaDetaylar]  WITH CHECK ADD  CONSTRAINT [FK_FirmaDetaylar_tblDepartmanlar] FOREIGN KEY([DepartmanId])
REFERENCES [dbo].[tblDepartmanlar] ([Id])
GO
ALTER TABLE [dbo].[tblFirmaDetaylar] CHECK CONSTRAINT [FK_FirmaDetaylar_tblDepartmanlar]
GO
ALTER TABLE [dbo].[tblFirmaDetaylar]  WITH CHECK ADD  CONSTRAINT [FK_FirmaDetaylar_tblFirmalar1] FOREIGN KEY([GirisId])
REFERENCES [dbo].[tblFirmalar] ([Id])
GO
ALTER TABLE [dbo].[tblFirmaDetaylar] CHECK CONSTRAINT [FK_FirmaDetaylar_tblFirmalar1]
GO
ALTER TABLE [dbo].[tblFirmalar]  WITH CHECK ADD  CONSTRAINT [FK_tblFirmalar_Sehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([Id])
GO
ALTER TABLE [dbo].[tblFirmalar] CHECK CONSTRAINT [FK_tblFirmalar_Sehirler]
GO
ALTER TABLE [dbo].[tblHastaneDetaylar]  WITH CHECK ADD  CONSTRAINT [FK_tblHastaneDetaylar_tblDepartmanlar] FOREIGN KEY([DepartmanId])
REFERENCES [dbo].[tblDepartmanlar] ([Id])
GO
ALTER TABLE [dbo].[tblHastaneDetaylar] CHECK CONSTRAINT [FK_tblHastaneDetaylar_tblDepartmanlar]
GO
ALTER TABLE [dbo].[tblHastaneDetaylar]  WITH CHECK ADD  CONSTRAINT [FK_tblHastaneDetaylar_tblHastaneler] FOREIGN KEY([GirisId])
REFERENCES [dbo].[tblHastaneler] ([Id])
GO
ALTER TABLE [dbo].[tblHastaneDetaylar] CHECK CONSTRAINT [FK_tblHastaneDetaylar_tblHastaneler]
GO
ALTER TABLE [dbo].[tblHastaneler]  WITH CHECK ADD  CONSTRAINT [FK_tblHastaneler_Sehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([Id])
GO
ALTER TABLE [dbo].[tblHastaneler] CHECK CONSTRAINT [FK_tblHastaneler_Sehirler]
GO
ALTER TABLE [dbo].[tblHastaneler]  WITH CHECK ADD  CONSTRAINT [FK_tblHastaneler_tblHastanetip] FOREIGN KEY([TipID])
REFERENCES [dbo].[tblHastanetip] ([Id])
GO
ALTER TABLE [dbo].[tblHastaneler] CHECK CONSTRAINT [FK_tblHastaneler_tblHastanetip]
GO
ALTER TABLE [dbo].[tblPersoneller]  WITH CHECK ADD  CONSTRAINT [FK_tblPersoneller_Sehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([Id])
GO
ALTER TABLE [dbo].[tblPersoneller] CHECK CONSTRAINT [FK_tblPersoneller_Sehirler]
GO
ALTER TABLE [dbo].[tblPersoneller]  WITH CHECK ADD  CONSTRAINT [FK_tblPersoneller_tblDepartmanlar] FOREIGN KEY([DepartmanId])
REFERENCES [dbo].[tblDepartmanlar] ([Id])
GO
ALTER TABLE [dbo].[tblPersoneller] CHECK CONSTRAINT [FK_tblPersoneller_tblDepartmanlar]
GO
ALTER TABLE [dbo].[tblUrunKayitUst]  WITH CHECK ADD  CONSTRAINT [FK_tblUrunKayitUst_tblFirmalar] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[tblFirmalar] ([Id])
GO
ALTER TABLE [dbo].[tblUrunKayitUst] CHECK CONSTRAINT [FK_tblUrunKayitUst_tblFirmalar]
GO
USE [master]
GO
ALTER DATABASE [Erp102Ev] SET  READ_WRITE 
GO
