USE [master]
GO
/****** Object:  Database [CHUNGKHOANHN]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE DATABASE [CHUNGKHOANHN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CHUNGKHOANHN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVER\MSSQL\DATA\CHUNGKHOANHN.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CHUNGKHOANHN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVER\MSSQL\DATA\CHUNGKHOANHN_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CHUNGKHOANHN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CHUNGKHOANHN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CHUNGKHOANHN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ARITHABORT OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CHUNGKHOANHN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CHUNGKHOANHN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CHUNGKHOANHN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CHUNGKHOANHN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET RECOVERY FULL 
GO
ALTER DATABASE [CHUNGKHOANHN] SET  MULTI_USER 
GO
ALTER DATABASE [CHUNGKHOANHN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CHUNGKHOANHN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CHUNGKHOANHN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CHUNGKHOANHN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CHUNGKHOANHN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CHUNGKHOANHN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CHUNGKHOANHN', N'ON'
GO
ALTER DATABASE [CHUNGKHOANHN] SET QUERY_STORE = OFF
GO
USE [CHUNGKHOANHN]
GO
/****** Object:  User [Thien]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE USER [Thien] FOR LOGIN [NDT01] WITH DEFAULT_SCHEMA=[Thien]
GO
/****** Object:  User [HTKN]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_FBBD0E6210F44C999DAE88208FCB40AE]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_FBBD0E6210F44C999DAE88208FCB40AE]
GO
/****** Object:  DatabaseRole [MSmerge_F9625F17474843FC878257083AA3ACA2]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_F9625F17474843FC878257083AA3ACA2]
GO
/****** Object:  DatabaseRole [MSmerge_F1075CB9E3C2405592864ED0BDE1DC9C]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_F1075CB9E3C2405592864ED0BDE1DC9C]
GO
/****** Object:  DatabaseRole [MSmerge_9FBB8E521EB546A59B25550844FFA12B]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_9FBB8E521EB546A59B25550844FFA12B]
GO
/****** Object:  DatabaseRole [MSmerge_916D41BCFFAE47FD931B5E01DBC9DF69]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_916D41BCFFAE47FD931B5E01DBC9DF69]
GO
/****** Object:  DatabaseRole [MSmerge_1A4D36B5FC2F448EB741132D3D01EF4D]    Script Date: 4/24/2022 10:43:33 AM ******/
CREATE ROLE [MSmerge_1A4D36B5FC2F448EB741132D3D01EF4D]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_FBBD0E6210F44C999DAE88208FCB40AE]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_F9625F17474843FC878257083AA3ACA2]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_F1075CB9E3C2405592864ED0BDE1DC9C]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_9FBB8E521EB546A59B25550844FFA12B]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_916D41BCFFAE47FD931B5E01DBC9DF69]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_1A4D36B5FC2F448EB741132D3D01EF4D]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Schema [Thien]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE SCHEMA [Thien]
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server
GO
/****** Object:  Table [dbo].[BangPhi]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangPhi](
	[MaBP] [varchar](5) NOT NULL,
	[TenPhi] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_BangPhi] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBangPhi]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBangPhi](
	[MaBP] [varchar](5) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Ngayapdung] [date] NOT NULL,
	[GiaTriMoi] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ThayDoiPhi] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC,
	[Ngayapdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietQuyDinh]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietQuyDinh](
	[MaQD] [varchar](15) NOT NULL,
	[Ngayapdung] [date] NOT NULL,
	[GiaTri] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiTietQuyDinh_1] PRIMARY KEY CLUSTERED 
(
	[MaQD] ASC,
	[Ngayapdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongTyChungKhoan]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTyChungKhoan](
	[MaCTCK] [varchar](3) NOT NULL,
	[TenCTCK] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](80) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CongTyChungKhoan] PRIMARY KEY CLUSTERED 
(
	[MaCTCK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoPhieu]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoPhieu](
	[MaCP] [varchar](6) NOT NULL,
	[TenCT] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](80) NULL,
	[Email] [varchar](50) NULL,
	[SDT] [varchar](15) NULL,
	[Fax] [varchar](10) NULL,
	[Website] [varchar](80) NULL,
	[SoLuongCP] [int] NULL,
	[MaSGD] [varchar](5) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CoPhieu] PRIMARY KEY CLUSTERED 
(
	[MaCP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaCoPhieu]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaCoPhieu](
	[MaCP] [varchar](6) NOT NULL,
	[Ngay] [date] NOT NULL,
	[GiaSan] [float] NULL,
	[GiaThamChieu] [float] NULL,
	[GiaDongCua] [float] NULL,
	[GiaTran] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GiaCoPhieu] PRIMARY KEY CLUSTERED 
(
	[MaCP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LenhDat]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LenhDat](
	[IDLD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[LoaiGD] [nvarchar](15) NULL,
	[SoLuongDat] [int] NULL,
	[GiaDat] [float] NULL,
	[NgayGio] [datetime] NULL,
	[MaTKNH] [varchar](10) NOT NULL,
	[MaLL] [varchar](5) NOT NULL,
	[MaCP] [varchar](6) NOT NULL,
	[MaTT] [varchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LenhDat] PRIMARY KEY CLUSTERED 
(
	[IDLD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LenhKhop]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LenhKhop](
	[IDLK] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SoLuongKhop] [int] NULL,
	[GiaKhop] [float] NULL,
	[TgKhop] [datetime] NULL,
	[PhiGiaoDich] [float] NULL,
	[IDLD] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LenhKhop] PRIMARY KEY CLUSTERED 
(
	[IDLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiLenh]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiLenh](
	[MaLL] [varchar](5) NOT NULL,
	[LoaiLenh] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LoaiLenh] PRIMARY KEY CLUSTERED 
(
	[MaLL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganHang]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganHang](
	[MaNH] [varchar](10) NOT NULL,
	[TenNH] [nvarchar](250) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NganHang] PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaDauTu]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaDauTu](
	[MaNDT] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](10) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](80) NULL,
	[Email] [varchar](50) NULL,
	[SDT] [varchar](15) NULL,
	[CMND/Passport] [varchar](15) NULL,
	[NgayCap] [date] NULL,
	[QuocGia] [nvarchar](20) NULL,
	[MKGiaoDich] [varchar](10) NULL,
	[MKDatLenh] [varchar](10) NULL,
	[MaCTCK] [varchar](3) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhaDauTu] PRIMARY KEY CLUSTERED 
(
	[MaNDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](10) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](80) NULL,
	[SDT] [varchar](15) NULL,
	[DaNghiViec] [bit] NULL,
	[MaCTCK] [varchar](3) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVienSGD]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienSGD](
	[MaNVSGD] [varchar](10) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](10) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](80) NULL,
	[SDT] [varchar](15) NULL,
	[DaNghiViec] [bit] NULL,
	[MaSGD] [varchar](5) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVienSGD] PRIMARY KEY CLUSTERED 
(
	[MaNVSGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[MaQD] [varchar](15) NOT NULL,
	[TenQuyDinh] [nvarchar](50) NULL,
	[MaNVSGD] [varchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_QuyDinh] PRIMARY KEY CLUSTERED 
(
	[MaQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanGiaoDich]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanGiaoDich](
	[MaSGD] [varchar](5) NOT NULL,
	[TenSGD] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_SanGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaSGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoHuu]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoHuu](
	[MaNDT] [varchar](10) NOT NULL,
	[MaCP] [varchar](6) NOT NULL,
	[SoLuong] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_SoHuu] PRIMARY KEY CLUSTERED 
(
	[MaNDT] ASC,
	[MaCP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanNganHang]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanNganHang](
	[MaTKNH] [varchar](10) NOT NULL,
	[Sodu] [float] NULL,
	[MaNH] [varchar](10) NOT NULL,
	[MaNDT] [varchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TaiKhoanNganHang] PRIMARY KEY CLUSTERED 
(
	[MaTKNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTT] [varchar](10) NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangPhi] ([MaBP], [TenPhi], [rowguid]) VALUES (N'BP01', N'Phí TY1', N'fc4b9f5e-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[BangPhi] ([MaBP], [TenPhi], [rowguid]) VALUES (N'BP02', N'PHÍTY2', N'595c5b93-8453-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[ChiTietBangPhi] ([MaBP], [MaNV], [Ngayapdung], [GiaTriMoi], [rowguid]) VALUES (N'BP01', N'NV01', CAST(N'2021-12-04' AS Date), 0.3, N'c51cb0a9-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[ChiTietBangPhi] ([MaBP], [MaNV], [Ngayapdung], [GiaTriMoi], [rowguid]) VALUES (N'BP02', N'NV01', CAST(N'2021-12-05' AS Date), 0.4, N'5a5c5b93-8453-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[ChiTietQuyDinh] ([MaQD], [Ngayapdung], [GiaTri], [rowguid]) VALUES (N'BienDoGia', CAST(N'2021-12-05' AS Date), 0.03, N'616181af-6d55-ec11-8761-2047474b0878')
INSERT [dbo].[ChiTietQuyDinh] ([MaQD], [Ngayapdung], [GiaTri], [rowguid]) VALUES (N'BienDoGia', CAST(N'2021-12-06' AS Date), 0.05, N'ce3132e5-6d55-ec11-8761-2047474b0878')
INSERT [dbo].[ChiTietQuyDinh] ([MaQD], [Ngayapdung], [GiaTri], [rowguid]) VALUES (N'BuocGiaDatLenh', CAST(N'2021-12-07' AS Date), 0.1, N'94146503-6e55-ec11-8761-2047474b0878')
INSERT [dbo].[ChiTietQuyDinh] ([MaQD], [Ngayapdung], [GiaTri], [rowguid]) VALUES (N'LoLenhToiThieu', CAST(N'2121-12-07' AS Date), 100, N'af667217-6e55-ec11-8761-2047474b0878')
GO
INSERT [dbo].[CongTyChungKhoan] ([MaCTCK], [TenCTCK], [DiaChi], [rowguid]) VALUES (N'CT1', N'Công Ty Chứng Khoán 1', N'Hà Nội', N'd5a5c793-fc50-ec11-875f-b0c090485d08')
INSERT [dbo].[CongTyChungKhoan] ([MaCTCK], [TenCTCK], [DiaChi], [rowguid]) VALUES (N'CT2', N'Công Ty Chứng Khoán 2', N'HCM', N'd294f5a0-fc50-ec11-875f-b0c090485d08')
GO
INSERT [dbo].[CoPhieu] ([MaCP], [TenCT], [DiaChi], [Email], [SDT], [Fax], [Website], [SoLuongCP], [MaSGD], [rowguid]) VALUES (N'CP01', N'Cổ Phiếu 01', N'Bình Phước', N'thiendu2507@gmail.com', N'0987654321', N'123456', N'facebook.com', 1000, N'HNX', N'4f08ab03-cb51-ec11-8760-b0c090485d08')
INSERT [dbo].[CoPhieu] ([MaCP], [TenCT], [DiaChi], [Email], [SDT], [Fax], [Website], [SoLuongCP], [MaSGD], [rowguid]) VALUES (N'CP02', N'Cổ Phiếu 02', N'Nha Trang', N'TNT@gmail.com', N'0909090909', N'23456', N'google.com', 15000, N'HNX', N'c9242068-7853-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[GiaCoPhieu] ([MaCP], [Ngay], [GiaSan], [GiaThamChieu], [GiaDongCua], [GiaTran], [rowguid]) VALUES (N'CP01', CAST(N'2021-12-10' AS Date), 24.3, 26.9, 25, 29.5, N'3358f743-7953-ec11-8760-b0c090485d08')
INSERT [dbo].[GiaCoPhieu] ([MaCP], [Ngay], [GiaSan], [GiaThamChieu], [GiaDongCua], [GiaTran], [rowguid]) VALUES (N'CP02', CAST(N'2021-12-10' AS Date), 23.3, 25.8, 25, 28, N'51773769-7953-ec11-8760-b0c090485d08')
GO
SET IDENTITY_INSERT [dbo].[LenhDat] ON 

INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (1, N'M', 0, 25, CAST(N'2021-12-05T15:18:37.733' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'566edbf1-a355-ec11-8761-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2, N'B', 0, 25, CAST(N'2021-12-05T17:36:07.777' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'6b4a3c27-b755-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (4, N'M', 0, 27, CAST(N'2021-12-10T08:09:41.570' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KH', N'c166f9d9-5559-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (5, N'B', 100, 26, CAST(N'2021-12-10T08:17:45.657' AS DateTime), N'TKNH04', N'LO', N'CP01', N'CK', N'48e882fa-5659-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (6, N'B', 50, 25, CAST(N'2021-12-10T13:16:28.367' AS DateTime), N'TKNH05', N'LO', N'CP01', N'K1P', N'308d47b5-8059-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (7, N'M', 50, 24.5, CAST(N'2021-12-10T13:18:52.537' AS DateTime), N'TKNH04', N'LO', N'CP01', N'CK', N'd80b360b-8159-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2002, N'M', 0, 25, CAST(N'2021-12-05T16:14:54.683' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'abcfacce-ab55-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2003, N'M', 0, 25, CAST(N'2021-12-05T16:18:34.253' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'9fba8c51-ac55-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2004, N'M', 0, 26, CAST(N'2021-12-05T16:21:55.137' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'eec948c9-ac55-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2010, N'B', 0, 25, CAST(N'2021-12-06T13:59:05.117' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'9a5591ff-6156-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2012, N'M', 0, 26, CAST(N'2021-12-05T15:01:28.923' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'48130db7-6a56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2013, N'B', 0, 25, CAST(N'2021-12-06T15:16:31.367' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'13e9f2d0-6c56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2017, N'M', 0, 25, CAST(N'2021-12-06T16:13:02.850' AS DateTime), N'TKNH04', N'LO', N'CP01', N'KK', N'2b3169b6-7456-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2018, N'M', 100, 25, CAST(N'2021-12-06T16:21:13.673' AS DateTime), N'TKNH04', N'LO', N'CP02', N'KK', N'2f1efcda-7556-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2019, N'B', 2, 26, CAST(N'2021-12-06T16:25:12.750' AS DateTime), N'TKNH01', N'LO', N'CP01', N'KK', N'c30a7c69-7656-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2020, N'B', 0, 24, CAST(N'2021-12-09T17:10:27.223' AS DateTime), N'TKNH01', N'LO', N'CP02', N'KH', N'3393ad3a-d858-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2021, N'B', 80, 24, CAST(N'2021-12-07T06:10:48.653' AS DateTime), N'TKNH01', N'LO', N'CP02', N'K1P', N'ee237347-d858-ec11-8762-2047474b0878')
INSERT [dbo].[LenhDat] ([IDLD], [LoaiGD], [SoLuongDat], [GiaDat], [NgayGio], [MaTKNH], [MaLL], [MaCP], [MaTT], [rowguid]) VALUES (2022, N'M', 130, 25, CAST(N'2021-12-07T06:10:48.653' AS DateTime), N'TKNH02', N'LO', N'CP01', N'K1P', N'74050bc9-f558-ec11-8762-2047474b0878')
SET IDENTITY_INSERT [dbo].[LenhDat] OFF
GO
SET IDENTITY_INSERT [dbo].[LenhKhop] ON 

INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (1, 123, 26, CAST(N'2021-12-05T17:36:07.727' AS DateTime), 1279.2, 2004, N'6a4a3c27-b755-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2, 100, 25, CAST(N'2021-12-05T17:37:54.780' AS DateTime), 1000, 1, N'bb010b67-b755-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (3, 100, 25, CAST(N'2021-12-05T17:37:54.780' AS DateTime), 2000, 2002, N'bc010b67-b755-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (4, 100, 27, CAST(N'2021-12-10T08:16:42.063' AS DateTime), 1080, 4, N'f1789bd4-5659-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (5, 50, 25, CAST(N'2021-12-10T13:19:09.050' AS DateTime), 500, 6, N'2a170e15-8159-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2002, 77, 25, CAST(N'2021-12-05T21:48:51.720' AS DateTime), 770, 2, N'3748ae75-da55-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2003, 54, 25, CAST(N'2021-12-06T14:02:24.393' AS DateTime), NULL, 2010, N'1bbc5876-6256-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2004, 100, 25, CAST(N'2021-12-06T14:57:38.927' AS DateTime), 1000, 2003, N'c798f62d-6a56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2005, 50, 26, CAST(N'2021-12-06T15:23:02.810' AS DateTime), 520, 2012, N'f1a044ba-6d56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2006, 25, 25, CAST(N'2021-12-06T16:13:02.817' AS DateTime), 250, 2013, N'2a3169b6-7456-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2007, 25, 25, CAST(N'2021-12-06T16:26:57.270' AS DateTime), 250, 2017, N'f968c8a7-7656-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2008, 15, 26, CAST(N'2021-12-06T16:35:58.000' AS DateTime), 156, 2019, N'4cc915ea-7756-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2009, 5, 26, CAST(N'2021-12-06T16:42:10.530' AS DateTime), 52, 2019, N'b05121c8-7856-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2010, 2, 26, CAST(N'2021-12-06T17:03:47.230' AS DateTime), 20.8, 2019, N'fb2606cd-7b56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2011, 1, 26, CAST(N'2021-12-06T17:19:44.943' AS DateTime), 10.4, 2019, N'473fdd07-7e56-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2012, 100, 24, CAST(N'2021-12-09T20:34:21.910' AS DateTime), 960, 2020, N'11321eb7-f458-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2013, 20, 24, CAST(N'2021-12-09T20:34:21.953' AS DateTime), 192, 2021, N'12321eb7-f458-ec11-8762-2047474b0878')
INSERT [dbo].[LenhKhop] ([IDLK], [SoLuongKhop], [GiaKhop], [TgKhop], [PhiGiaoDich], [IDLD], [rowguid]) VALUES (2014, 120, 25, CAST(N'2021-12-09T21:01:33.320' AS DateTime), 1200, 2022, N'ca888383-f858-ec11-8762-2047474b0878')
SET IDENTITY_INSERT [dbo].[LenhKhop] OFF
GO
INSERT [dbo].[LoaiLenh] ([MaLL], [LoaiLenh], [rowguid]) VALUES (N'LO', N'Lệnh Giới Hạn', N'0c7618e0-7953-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[NganHang] ([MaNH], [TenNH], [rowguid]) VALUES (N'ACB', N'Ngân Hàng Á Châu', N'5a6c9f4b-8a53-ec11-8760-b0c090485d08')
INSERT [dbo].[NganHang] ([MaNH], [TenNH], [rowguid]) VALUES (N'ARB', N'ARIBANK', N'0cf602c3-4053-ec11-8760-b0c090485d08')
INSERT [dbo].[NganHang] ([MaNH], [TenNH], [rowguid]) VALUES (N'SCB', N'Sacomebank', N'c29784ef-e751-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [Phai], [NgaySinh], [NoiSinh], [DiaChi], [Email], [SDT], [CMND/Passport], [NgayCap], [QuocGia], [MKGiaoDich], [MKDatLenh], [MaCTCK], [rowguid]) VALUES (N'NDT01', N'Lý', N'Thien', 1, CAST(N'2021-11-11' AS Date), N'BP', N'BP', N'DU@gmail.com', N'0987654321', N'285707450', CAST(N'2021-11-07' AS Date), N'VietNam', N'123', NULL, N'CT1', N'07ec6e95-e751-ec11-8760-b0c090485d08')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [Phai], [NgaySinh], [NoiSinh], [DiaChi], [Email], [SDT], [CMND/Passport], [NgayCap], [QuocGia], [MKGiaoDich], [MKDatLenh], [MaCTCK], [rowguid]) VALUES (N'NDT02', N'Trần', N'Duy', 1, CAST(N'2021-11-11' AS Date), N'HN', N'HN', N'Duy@gmail.com', N'0123456789', N'123456788', CAST(N'2021-11-02' AS Date), N'VietNam', N'123', N'123', N'CT1', N'323660b7-e751-ec11-8760-b0c090485d08')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [Phai], [NgaySinh], [NoiSinh], [DiaChi], [Email], [SDT], [CMND/Passport], [NgayCap], [QuocGia], [MKGiaoDich], [MKDatLenh], [MaCTCK], [rowguid]) VALUES (N'NDT03', N'Nguyễn', N'Ha', 1, CAST(N'1999-01-01' AS Date), N'Ca Mau', N'Ca Mau', N'ha.n@gmail.com', N'987608767', N'285777345', CAST(N'2014-02-02' AS Date), N'Viet Nam', N'123', N'123', N'CT2', N'612e31e4-6359-ec11-8762-2047474b0878')
GO
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaCTCK], [rowguid]) VALUES (N'NV01', N'Lý Thiên', N'Du', 1, CAST(N'1998-01-01' AS Date), N'Bình Phước', N'0987654321', 0, N'CT1', N'5a8eeccc-fc50-ec11-875f-b0c090485d08')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaCTCK], [rowguid]) VALUES (N'NV02', N'Văn', N'Tèo', 1, CAST(N'2000-02-02' AS Date), N'HCM', N'0999999999', 0, N'CT2', N'80d0afdf-fc50-ec11-875f-b0c090485d08')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaCTCK], [rowguid]) VALUES (N'NV03', N'Văn Tý', N'Tý', 1, CAST(N'1999-01-01' AS Date), N'HN', N'0909090909', 0, N'CT1', N'ab600fb0-c151-ec11-8760-b0c090485d08')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaCTCK], [rowguid]) VALUES (N'NV05', N'Phạm', N'Thái', 1, CAST(N'2021-12-21' AS Date), N'Phú Thọ', N'0000000000', 1, N'CT1', N'07e32952-7753-ec11-8760-b0c090485d08')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaCTCK], [rowguid]) VALUES (N'NV06', N'Phan', N'Ha', 1, CAST(N'1998-07-07' AS Date), N'Nghệ An', N'0154685356', 0, N'CT1', N'1e4cae3d-3b58-ec11-8762-2047474b0878')
GO
INSERT [dbo].[NhanVienSGD] ([MaNVSGD], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SDT], [DaNghiViec], [MaSGD], [rowguid]) VALUES (N'SGD01', N'Trần', N'Vinh', 1, CAST(N'2000-01-01' AS Date), N'Nha Trang', N'0000000000', 0, N'HNX', N'a320af52-c951-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[QuyDinh] ([MaQD], [TenQuyDinh], [MaNVSGD], [rowguid]) VALUES (N'BienDoGia', N'Bien Do Gia', N'SGD01', N'9a7a714b-6d55-ec11-8761-2047474b0878')
INSERT [dbo].[QuyDinh] ([MaQD], [TenQuyDinh], [MaNVSGD], [rowguid]) VALUES (N'BuocGiaDatLenh', N'Buoc Gia Dat Lenh', N'SGD01', N'cd78645b-6d55-ec11-8761-2047474b0878')
INSERT [dbo].[QuyDinh] ([MaQD], [TenQuyDinh], [MaNVSGD], [rowguid]) VALUES (N'LoLenhToiThieu', N'Lo Lenh Toi Thieu', N'SGD01', N'704e6572-6d55-ec11-8761-2047474b0878')
GO
INSERT [dbo].[SanGiaoDich] ([MaSGD], [TenSGD], [rowguid]) VALUES (N'HNX', N'Hà Nội', N'043f433b-c951-ec11-8760-b0c090485d08')
GO
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT01', N'CP01', 100, N'a39715bf-1c54-ec11-8760-b0c090485d08')
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT01', N'CP02', 300, N'c9b0c5d9-1c54-ec11-8760-b0c090485d08')
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT02', N'CP01', 1023, N'30dded1e-ba55-ec11-8762-2047474b0878')
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT02', N'CP02', 120, N'18e83856-7756-ec11-8762-2047474b0878')
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT03', N'CP01', 400, N'09a8d13d-6459-ec11-8762-2047474b0878')
INSERT [dbo].[SoHuu] ([MaNDT], [MaCP], [SoLuong], [rowguid]) VALUES (N'NDT03', N'CP02', 250, N'a22d2e47-6459-ec11-8762-2047474b0878')
GO
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH01', 92845.2, N'SCB', N'NDT01', N'7f69186a-ea51-ec11-8760-b0c090485d08')
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH02', 499995000, N'ARB', N'NDT01', N'248684e1-4053-ec11-8760-b0c090485d08')
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH03', 199996150, N'ACB', N'NDT01', N'c53c7d59-8a53-ec11-8760-b0c090485d08')
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH04', 999994913.6, N'ACB', N'NDT02', N'b88d260b-ba55-ec11-8762-2047474b0878')
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH05', 10002750, N'ACB', N'NDT03', N'b591d535-6459-ec11-8762-2047474b0878')
INSERT [dbo].[TaiKhoanNganHang] ([MaTKNH], [Sodu], [MaNH], [MaNDT], [rowguid]) VALUES (N'TKNH06', 20000000, N'ARB', N'NDT03', N'94098b54-6459-ec11-8762-2047474b0878')
GO
INSERT [dbo].[TrangThai] ([MaTT], [TrangThai], [rowguid]) VALUES (N'CK', N'CHỜ KHỚP', N'24bd0b6b-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[TrangThai] ([MaTT], [TrangThai], [rowguid]) VALUES (N'DH', N'ĐÃ HỦY', N'02204786-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[TrangThai] ([MaTT], [TrangThai], [rowguid]) VALUES (N'K1P', N'KHỚP 1 PHẦN', N'625d9871-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[TrangThai] ([MaTT], [TrangThai], [rowguid]) VALUES (N'KH', N'KHỚP HẾT', N'b2f2d495-4753-ec11-8760-b0c090485d08')
INSERT [dbo].[TrangThai] ([MaTT], [TrangThai], [rowguid]) VALUES (N'KK', N'CHƯA KHỚP', N'01204786-4753-ec11-8760-b0c090485d08')
GO
/****** Object:  Index [MSmerge_index_581577110]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_581577110] ON [dbo].[BangPhi]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_613577224]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_613577224] ON [dbo].[ChiTietBangPhi]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_645577338]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_645577338] ON [dbo].[ChiTietQuyDinh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_677577452]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_677577452] ON [dbo].[CongTyChungKhoan]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_709577566]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_709577566] ON [dbo].[CoPhieu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_741577680]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_741577680] ON [dbo].[GiaCoPhieu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1925581898]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1925581898] ON [dbo].[LenhDat]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_773577794]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_773577794] ON [dbo].[LenhKhop]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_805577908]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_805577908] ON [dbo].[LoaiLenh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_837578022]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_837578022] ON [dbo].[NganHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_869578136]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_869578136] ON [dbo].[NhaDauTu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_901578250]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_901578250] ON [dbo].[NhanVien]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_933578364]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_933578364] ON [dbo].[NhanVienSGD]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_965578478]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_965578478] ON [dbo].[QuyDinh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_997578592]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_997578592] ON [dbo].[SanGiaoDich]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1029578706]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1029578706] ON [dbo].[SoHuu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1061578820]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1061578820] ON [dbo].[TaiKhoanNganHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1093578934]    Script Date: 4/24/2022 10:43:34 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1093578934] ON [dbo].[TrangThai]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BangPhi] ADD  CONSTRAINT [MSmerge_df_rowguid_4193600CEE294734BB7AF55C91150F6A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ChiTietBangPhi] ADD  CONSTRAINT [MSmerge_df_rowguid_912958FB3DC84E44A58CF8CE6B00CA9A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ChiTietQuyDinh] ADD  CONSTRAINT [MSmerge_df_rowguid_A178AF47061D4493BC8E7A58B5FC6321]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CongTyChungKhoan] ADD  CONSTRAINT [MSmerge_df_rowguid_AE642C0B24254125B82383CF291B9470]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CoPhieu] ADD  CONSTRAINT [MSmerge_df_rowguid_90EE045E5A694D629ED690B63411CB4A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GiaCoPhieu] ADD  CONSTRAINT [MSmerge_df_rowguid_CAEC2423C12F454181BABF5187F59F6E]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LenhDat] ADD  CONSTRAINT [MSmerge_df_rowguid_D9D72EA932C64B9F86D8B9D9BF655183]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LenhKhop] ADD  CONSTRAINT [MSmerge_df_rowguid_B1EB14D028B84D428BE1A2D61180D1B6]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LoaiLenh] ADD  CONSTRAINT [MSmerge_df_rowguid_D875B19180494AD4A4E29943D1CB7845]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NganHang] ADD  CONSTRAINT [MSmerge_df_rowguid_DB2B8314AF1B4014BFE8C753D829EF6C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhaDauTu] ADD  CONSTRAINT [MSmerge_df_rowguid_7E1F25D436444FA4BE1706528E00A8DD]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_EE7FB0F9FEFE42E1B88ACBEE699CE441]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVienSGD] ADD  CONSTRAINT [MSmerge_df_rowguid_4EEDE81437874F3E9FD3E2C577EF359B]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [MSmerge_df_rowguid_A1302D62B29C4EE182FB13EB2E95DB80]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SanGiaoDich] ADD  CONSTRAINT [MSmerge_df_rowguid_7B72E04FE9294D05855B9967936C2CF5]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SoHuu] ADD  CONSTRAINT [MSmerge_df_rowguid_2F72DB43BCDF43AC9D45465AC378D503]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] ADD  CONSTRAINT [MSmerge_df_rowguid_837360F354DB49E69A6DFF9B8877EED9]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[TrangThai] ADD  CONSTRAINT [MSmerge_df_rowguid_5BFAAEE8B6614D6E8F60AD7EC5F57D08]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ChiTietBangPhi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBangPhi_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChiTietBangPhi] CHECK CONSTRAINT [FK_ChiTietBangPhi_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietBangPhi]  WITH CHECK ADD  CONSTRAINT [FK_ThayDoiPhi_BangPhi] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BangPhi] ([MaBP])
GO
ALTER TABLE [dbo].[ChiTietBangPhi] CHECK CONSTRAINT [FK_ThayDoiPhi_BangPhi]
GO
ALTER TABLE [dbo].[ChiTietQuyDinh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietQuyDinh_QuyDinh] FOREIGN KEY([MaQD])
REFERENCES [dbo].[QuyDinh] ([MaQD])
GO
ALTER TABLE [dbo].[ChiTietQuyDinh] CHECK CONSTRAINT [FK_ChiTietQuyDinh_QuyDinh]
GO
ALTER TABLE [dbo].[CoPhieu]  WITH CHECK ADD  CONSTRAINT [FK_CoPhieu_SanGiaoDich] FOREIGN KEY([MaSGD])
REFERENCES [dbo].[SanGiaoDich] ([MaSGD])
GO
ALTER TABLE [dbo].[CoPhieu] CHECK CONSTRAINT [FK_CoPhieu_SanGiaoDich]
GO
ALTER TABLE [dbo].[GiaCoPhieu]  WITH CHECK ADD  CONSTRAINT [FK_GiaCoPhieu_CoPhieu1] FOREIGN KEY([MaCP])
REFERENCES [dbo].[CoPhieu] ([MaCP])
GO
ALTER TABLE [dbo].[GiaCoPhieu] CHECK CONSTRAINT [FK_GiaCoPhieu_CoPhieu1]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [FK_LenhDat_GiaCoPhieu] FOREIGN KEY([MaCP])
REFERENCES [dbo].[GiaCoPhieu] ([MaCP])
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [FK_LenhDat_GiaCoPhieu]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [FK_LenhDat_LoaiLenh] FOREIGN KEY([MaLL])
REFERENCES [dbo].[LoaiLenh] ([MaLL])
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [FK_LenhDat_LoaiLenh]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [FK_LenhDat_TaiKhoanNganHang] FOREIGN KEY([MaTKNH])
REFERENCES [dbo].[TaiKhoanNganHang] ([MaTKNH])
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [FK_LenhDat_TaiKhoanNganHang]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [FK_LenhDat_TaiKhoanNganHang1] FOREIGN KEY([MaTKNH])
REFERENCES [dbo].[TaiKhoanNganHang] ([MaTKNH])
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [FK_LenhDat_TaiKhoanNganHang1]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [FK_LenhDat_TrangThai] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrangThai] ([MaTT])
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [FK_LenhDat_TrangThai]
GO
ALTER TABLE [dbo].[LenhKhop]  WITH CHECK ADD  CONSTRAINT [FK_LenhKhop_LenhDat] FOREIGN KEY([IDLD])
REFERENCES [dbo].[LenhDat] ([IDLD])
GO
ALTER TABLE [dbo].[LenhKhop] CHECK CONSTRAINT [FK_LenhKhop_LenhDat]
GO
ALTER TABLE [dbo].[NhaDauTu]  WITH CHECK ADD  CONSTRAINT [FK_NhaDauTu_CongTyChungKhoan] FOREIGN KEY([MaCTCK])
REFERENCES [dbo].[CongTyChungKhoan] ([MaCTCK])
GO
ALTER TABLE [dbo].[NhaDauTu] CHECK CONSTRAINT [FK_NhaDauTu_CongTyChungKhoan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_CongTyChungKhoan] FOREIGN KEY([MaCTCK])
REFERENCES [dbo].[CongTyChungKhoan] ([MaCTCK])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_CongTyChungKhoan]
GO
ALTER TABLE [dbo].[NhanVienSGD]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienSGD_SanGiaoDich] FOREIGN KEY([MaSGD])
REFERENCES [dbo].[SanGiaoDich] ([MaSGD])
GO
ALTER TABLE [dbo].[NhanVienSGD] CHECK CONSTRAINT [FK_NhanVienSGD_SanGiaoDich]
GO
ALTER TABLE [dbo].[QuyDinh]  WITH CHECK ADD  CONSTRAINT [FK_QuyDinh_NhanVienSGD] FOREIGN KEY([MaNVSGD])
REFERENCES [dbo].[NhanVienSGD] ([MaNVSGD])
GO
ALTER TABLE [dbo].[QuyDinh] CHECK CONSTRAINT [FK_QuyDinh_NhanVienSGD]
GO
ALTER TABLE [dbo].[SoHuu]  WITH CHECK ADD  CONSTRAINT [FK_SoHuu_GiaCoPhieu] FOREIGN KEY([MaCP])
REFERENCES [dbo].[GiaCoPhieu] ([MaCP])
GO
ALTER TABLE [dbo].[SoHuu] CHECK CONSTRAINT [FK_SoHuu_GiaCoPhieu]
GO
ALTER TABLE [dbo].[SoHuu]  WITH CHECK ADD  CONSTRAINT [FK_SoHuu_NhaDauTu] FOREIGN KEY([MaNDT])
REFERENCES [dbo].[NhaDauTu] ([MaNDT])
GO
ALTER TABLE [dbo].[SoHuu] CHECK CONSTRAINT [FK_SoHuu_NhaDauTu]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNganHang_NganHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NganHang] ([MaNH])
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] CHECK CONSTRAINT [FK_TaiKhoanNganHang_NganHang]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNganHang_NhaDauTu] FOREIGN KEY([MaNDT])
REFERENCES [dbo].[NhaDauTu] ([MaNDT])
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] CHECK CONSTRAINT [FK_TaiKhoanNganHang_NhaDauTu]
GO
ALTER TABLE [dbo].[LenhDat]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_06A6A3EC_2EC8_48A4_8315_1B4BFFCC244D] CHECK NOT FOR REPLICATION (([IDLD]>(1) AND [IDLD]<=(1001) OR [IDLD]>(1001) AND [IDLD]<=(2001)))
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [repl_identity_range_06A6A3EC_2EC8_48A4_8315_1B4BFFCC244D]
GO
ALTER TABLE [dbo].[LenhKhop]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_B18D0028_5DFA_45FD_BB35_114444DB074A] CHECK NOT FOR REPLICATION (([IDLK]>=(1) AND [IDLK]<=(1001) OR [IDLK]>(1001) AND [IDLK]<=(2001)))
GO
ALTER TABLE [dbo].[LenhKhop] CHECK CONSTRAINT [repl_identity_range_B18D0028_5DFA_45FD_BB35_114444DB074A]
GO
/****** Object:  StoredProcedure [dbo].[CursorLoaiGD]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CursorLoaiGD]
  @OutCrsr CURSOR VARYING OUTPUT, 
  @macp NVARCHAR( 10), @Ngay NVARCHAR( 50),  @LoaiGD CHAR 
AS
SET DATEFORMAT DMY 
IF (@LoaiGD='M')
	SET @OutCrsr = CURSOR FOR 
	SELECT IDLD, NgayGio, SoLuongDat, GiaDat, MaTKNH from LenhDat
	WHERE MACP = @macp
	AND DAY(NgayGio)=DAY(@Ngay)AND MONTH(NgayGio)= MONTH(@Ngay) AND YEAR(NgayGio)=YEAR(@Ngay)  
    AND LOAIGD=@LoaiGD AND SoLuongDat >0  
    ORDER BY GiaDat DESC, NgayGio 
ELSE
	SET @OutCrsr = CURSOR FOR
	SELECT IDLD, NgayGio, SoLuongDat, GiaDat, MaTKNH from LenhDat
	WHERE MACP = @macp
	AND DAY(NgayGio)=DAY(@Ngay)AND MONTH(NgayGio)= MONTH(@Ngay) AND YEAR(NgayGio)=YEAR(@Ngay)  
    AND LOAIGD=@LoaiGD AND SoLuongDat >0  
    ORDER BY GiaDat ASC, NgayGio
OPEN @OutCrsr
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP_NDT]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
SELECT USERNAME = @TENUSER, 
	HOTEN = (SELECT Ho+ ' '+ Ten FROM NhaDauTu  WHERE MaNDT = @TENUSER ),
	TENNHOM= NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_NV]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP_NV]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
	SELECT USERNAME = @TENUSER, 
	HOTEN = (SELECT Ho+ ' '+ Ten FROM NhanVien  WHERE MaNV = @TENUSER ),
	TENNHOM= NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP_NVSGD]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP_NVSGD]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
	HOTEN = (SELECT Ho+ ' '+ Ten FROM NhanVienSGD  WHERE MaNVSGD = @TENUSER ),
	TENNHOM= NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_KHOPLENH_LO]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KHOPLENH_LO]

 @MACP NVARCHAR( 10),  @MATKNH NVARCHAR( 10), @LOAIGD CHAR, 
 @SOLUONGMB INT, @GIADATMB FLOAT 
AS
DECLARE @NGAYQD NVARCHAR(50), @NGAY NVARCHAR(50), @PHANTRAMPHI Float,  @MANDTCT NVARCHAR(10), @MACTCKDL NVARCHAR(10)


SET DATEFORMAT DMY
SET @NGAY = GETDATE()


SET @MANDTCT =(SELECT  MaNDT FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH)

SELECT @MACTCKDL = MaCTCK FROM  NhaDauTu WHERE  MaNDT = @MANDTCT



 IF(@MACTCKDL = 'CT1')
	BEGIN 
	SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1')NV WHERE CTBP.MaNV = NV.MaNV)
	SELECT @PHANTRAMPHI =  GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
	END
 ELSE
	BEGIN 
	SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2')NV WHERE CTBP.MaNV = NV.MaNV)
	SELECT @PHANTRAMPHI = GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
	END
DECLARE @CrsrVar CURSOR ,@IDLD INT, @NGAYDAT NVARCHAR( 50), @SOLUONG INT, @GIADAT FLOAT,  
		@SOLUONGKHOP INT, @GIAKHOP FLOAT, @TONGSLK INT, @DUKHOP BIT,@PHIGD Float, 
		@TKNH NVARCHAR(10), @MANDT NVARCHAR(10), @SOLUONGDAT INT, @MANDTDL NVARCHAR(10)

	SET  @TONGSLK = 0
	SET @DUKHOP  =0;
	
	IF (@LOAIGD = 'B')
		EXEC CursorLoaiGD @CrsrVar OUTPUT, @MACP, @NGAY, 'M'
	ELSE 
		EXEC CursorLoaiGD  @CrsrVar OUTPUT, @MACP, @NGAY, 'B'
  
FETCH NEXT FROM @CrsrVar  INTO @IDLD,  @NGAYDAT, @SOLUONG, @GIADAT, @TKNH
WHILE (@@FETCH_STATUS <> -1 AND @SOLUONGMB >0)
	BEGIN
		IF  (@LOAIGD = 'B' )
			BEGIN
				IF  (@GIADATMB <= @GIADAT)
					BEGIN
						
						 IF @SOLUONGMB >= @SOLUONG
							BEGIN
								SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH 
								SELECT @MANDTDL = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH
								SELECT @SOLUONGDAT = SoLuongDat FROM LenhDat WHERE  IDLD = @IDLD
								SET @SOLUONGKHOP = @SOLUONG                     
								SET @GIAKHOP = @GIADAT                     
								SET @soluongMB = @soluongMB - @soluong            
								UPDATE dbo.LenhDat  
									SET SoLuongDat = 0, MaTT = N'KH'
									WHERE CURRENT OF @CrsrVar
								UPDATE SoHuu 
									SET SoLuong = SoLuong - @SOLUONGDAT
									WHERE MaNDT = @MANDT AND MaCP = @MACP
								UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHANTRAMPHI * (@SOLUONG * @GIADAT) ))
									WHERE TaiKhoanNganHang.MaTKNH = @MATKNH
								SET @DUKHOP = 1
							END						

						ELSE
							BEGIN
								SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH
								SELECT @MANDTDL = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH
								SET @SOLUONGKHOP = @SOLUONGMB                     
								SET @GIAKHOP = @GIADAT                          
		
								UPDATE dbo.LenhDat  
									SET SoLuongDat = SoLuongDat - @SOLUONGMB, MaTT = N'K1P'	
									WHERE CURRENT OF @CrsrVar
								UPDATE SoHuu 
									SET SoLuong = SoLuong - @SOLUONGDAT
									WHERE MaNDT = @MANDT AND MaCP = @MACP
									DECLARE @MANDTKL NVARCHAR(10), @MACTCKKL NVARCHAR(10) , @PHICT FLOAT
									--Kiểm tra xem lm của ndt thuộc cty nào.
									SET @MANDTKL =(SELECT  MaNDT FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH)
									SELECT @MACTCKKL = MaCTCK FROM  NhaDauTu WHERE  MaNDT = @MANDTDL
									 IF(@MACTCKKL = 'CT1')
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT =  GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHICT * (@SOLUONG * @GIADAT) ))
										WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END
									 ELSE
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT = GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHICT * (@SOLUONG * @GIADAT) ))
										WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END

								UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHANTRAMPHI * (@SOLUONG * @GIADAT) ))
									WHERE TaiKhoanNganHang.MaTKNH = @MATKNH
								SET @SOLUONGMB = 0
								SET @DUKHOP = 1;
							END
								SET @TONGSLK = @TONGSLK + @SOLUONGKHOP
								SET @PHIGD = @TONGSLK * @PHANTRAMPHI * @GIADAT

						INSERT INTO dbo.LenhKhop( SoLuongKhop, GiaKhop,TgKhop,PhiGiaoDich, IDLD)
						VALUES (@SOLUONGKHOP, @GIAKHOP,GETDATE(),@PHIGD, @IDLD);
				
					END
			END
			

	
		IF (@LOAIGD ='M' )
			BEGIN
				
				IF  (@GIADATMB >= @GIADAT)
					BEGIN
						
						IF @SOLUONGMB < @SOLUONG
							BEGIN
								SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH
								SELECT @MANDTDL = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH
								SET @SOLUONGKHOP = @SOLUONGMB											 
								SET @GIAKHOP = @GIADAT													
								UPDATE dbo.LenhDat  
									SET SoLuongDat = SoLuongDat - @SOLUONGMB, MaTT = N'K1P'
									WHERE CURRENT OF @CrsrVar
								UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu - ((@SOLUONGMB * @GIADAT) + (@PHANTRAMPHI * (@SOLUONGMB * @GIADAT) ))
									WHERE TaiKhoanNganHang.MaTKNH = @MATKNH

								DECLARE @MANDTKL1 NVARCHAR(10), @MACTCKKL1 NVARCHAR(10) , @PHICT1 FLOAT
								-- Vơi lệnh mua bán của ndt thì xem ndt đó thuộc công ty nào
								SET @MANDTKL1 =(SELECT  MaNDT FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH)
									SELECT @MACTCKKL1 = MaCTCK FROM  NhaDauTu WHERE  MaNDT = @MANDTDL
									 IF(@MACTCKKL1 = 'CT1')
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT1 =  GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHICT1 * (@SOLUONG * @GIADAT) ))
										WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END
									 ELSE
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT1 = GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu + ((@SOLUONG * @GIADAT) - (@PHICT1 * (@SOLUONG * @GIADAT) ))
										WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END



								UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu + (@SOLUONGMB * @GIADAT )
									WHERE TaiKhoanNganHang.MaTKNH = @TKNH
								UPDATE SoHuu 
									SET SoLuong = SoLuong + @SOLUONGMB
									WHERE MaNDT = @MANDTDL AND MaCP = @MACP
								SET @SOLUONGMB = 0
								SET @DUKHOP = 1
							END
						
						ELSE
							BEGIN
								SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH
								SELECT @MANDTDL = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH

								SET @SOLUONGKHOP = @SOLUONG
								SET @GIAKHOP = @GIADAT
								SET @SOLUONGMB = @SOLUONGMB - @SOLUONG
       
								UPDATE dbo.LenhDat  
									SET SoLuongDat = 0, MaTT = N'KH'
									WHERE CURRENT OF @CrsrVar

									DECLARE @MANDTKL2 NVARCHAR(10), @MACTCKKL2 NVARCHAR(10) , @PHICT2 FLOAT
								-- Vơi lệnh mua bán của ndt thì xem ndt đó thuộc công ty nào
								SET @MANDTKL2 =(SELECT  MaNDT FROM TaiKhoanNganHang WHERE MaTKNH = @TKNH)
									SELECT @MACTCKKL1 = MaCTCK FROM  NhaDauTu WHERE  MaNDT = @MANDTDL
									 IF(@MACTCKKL2 = 'CT1')
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT1 =  GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT1') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu - ((@SOLUONG * @GIADAT) + (@PHICT2 * (@SOLUONG * @GIADAT)))
									WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END
									 ELSE
										BEGIN 
										SET @NGAYQD = (SELECT MAX(Ngayapdung) FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2')NV WHERE CTBP.MaNV = NV.MaNV)
										SELECT @PHICT2 = GiaTriMoi FROM ChiTietBangPhi CTBP, (SELECT MaNV FROM NhanVien WHERE MaCTCK = 'CT2') NV WHERE CTBP.MaNV = NV.MaNV AND CTBP.Ngayapdung = @NGAYQD
										UPDATE DBO.TaiKhoanNganHang
									SET Sodu = Sodu - ((@SOLUONG * @GIADAT) + (@PHICT2 * (@SOLUONG * @GIADAT)))
									WHERE TaiKhoanNganHang.MaTKNH = @TKNH
										END

								UPDATE SoHuu 
									SET SoLuong = SoLuong + @SOLUONG
									WHERE MaNDT = @MANDTDL AND MaCP = @MACP
								END

								SET @DUKHOP = 1
								
								SET @TONGSLK = @TONGSLK + @SOLUONGKHOP
								SET @PHIGD = @SOLUONGKHOP * @PHANTRAMPHI * @GIADAT

						INSERT INTO dbo.LenhKhop( SoLuongKhop, GiaKhop,TgKhop,PhiGiaoDich, IDLD)
						VALUES (@SOLUONGKHOP, @GIAKHOP,GETDATE(),@PHIGD,@IDLD);
						
					END
			END
			
		
		FETCH NEXT FROM @CrsrVar INTO  @IDLD, @NGAYDAT , @SOLUONG , @GIADAT, @TKNH
	END
IF (@SOLUONGMB > 0)
	BEGIN
		IF (@DUKHOP=1)
			BEGIN
				BEGIN
					INSERT INTO dbo.LenhDat
					(
						MaCP,
						NgayGio,
						loaiGD,
						GiaDat,
						SoLuongDat,
						MaLL,
						MaTT,
						MaTKNH
					)
					VALUES
					(   @MACP,        
						GETDATE(), 
						@LOAIGD,  
						@GIADATMB,
						@SOLUONGMB,
						N'LO',       
						N'K1P',         
						@MATKNH        
						)
				END
				IF(@LOAIGD = 'M')
				BEGIN
					UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu - ((@SOLUONGMB * @GIADATMB) + (@PHANTRAMPHI * (@SOLUONGMB * @GIADATMB) ))
										WHERE TaiKhoanNganHang.MaTKNH = @MATKNH
				END
				ELSE
				BEGIN
					SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH
									UPDATE SoHuu 
										SET SoLuong = SoLuong - @SOLUONGMB
										WHERE MaNDT = @MANDT AND MaCP = @MACP
				END
			END
		ELSE
			BEGIN
				BEGIN
				INSERT INTO dbo.LenhDat
				(
					MaCP,
					NgayGio,
					loaiGD,
					GiaDat,
					SoLuongDat,
					MaLL,
					MaTT,
					MaTKNH
				)
				VALUES
				(   @MACP,        
					GETDATE(), 
					@LOAIGD,  
					@GIADATMB,
					@SOLUONGMB,
					N'LO',       
					N'CK',         
					@MATKNH        
					)
					END
					
				IF(@LOAIGD = 'M')
				BEGIN
					UPDATE DBO.TaiKhoanNganHang
										SET Sodu = Sodu - ((@SOLUONGMB * @GIADATMB) + (@PHANTRAMPHI * (@SOLUONGMB * @GIADATMB) ))
										WHERE TaiKhoanNganHang.MaTKNH = @MATKNH
				END
				ELSE
				BEGIN
					SELECT @MANDT = (MaNDT) FROM TaiKhoanNganHang WHERE MaTKNH = @MATKNH
									UPDATE SoHuu 
										SET SoLuong = SoLuong - @SOLUONGMB
										WHERE MaNDT = @MANDT AND MaCP = @MACP
				END
			END

		
	END
					

	SELECT @TONGSLK
	RETURN @TONGSLK
	
    CLOSE @CrsrVar
    DEALLOCATE @CrsrVar



GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_GIA]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_GIA]
@MACP VARCHAR(10)
AS
DECLARE @NGAY DATE
--SET @MACP = 'CP01'
SET @NGAY = GETDATE()

SELECT GiaThamChieu, GiaSan, GiaTran
FROM GiaCoPhieu
WHERE MaCP = @MACP AND Ngay = @NGAY
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_HOTEN_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_HOTEN_NDT]
 
@MANDT VARCHAR(10)
AS




SELECT  (HO+' '+TEN)HOTEN 
FROM NhaDauTu
WHERE MaNDT = @MANDT
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MACP_CUA_1NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_MACP_CUA_1NDT]
 @MANDT NVARCHAR(10)
--SET @MANDT = 'NDT02'
AS
SELECT MaCP, SoLuong
FROM SoHuu
WHERE MaNDT = @MANDT
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_SODUCP_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_SODUCP_NDT]
--DECLARE 
@MANDT VARCHAR(10)
AS
DECLARE @NGAYGD DATE, @NGAY DATE
SELECT @NGAYGD = MAX(Ngay) FROM GiaCoPhieu
SET @NGAY = GETDATE() - 1

SELECT  SH.MaCP, 
		TONGSOCOPHIEU = (CASE WHEN CPKD.SOLUONGDAT IS NULL THEN SH.SoLuong ELSE (SH.SoLuong + CPKD.SOLUONGDAT)END),
		SODUKHADUNG = (SoLuong),
		GIATRICOPHIEU = (GCP.GiaThamChieu * 1000), 
		TONGIGATRI =  (CASE WHEN CPKD.SOLUONGDAT IS NULL THEN (SH.SoLuong * GCP.GiaThamChieu * 1000) 
										   ELSE ((SH.SoLuong + CPKD.SOLUONGDAT) * GCP.GiaThamChieu * 1000) END)
FROM ((SELECT MaCP, SoLuong FROM SoHuu SH WHERE SH.MaNDT = @MANDT) SH
	LEFT JOIN
	(SELECT MaCP, GiaThamChieu FROM GiaCoPhieu GCP WHERE GCP.Ngay = @NGAYGD) GCP
	ON SH.MaCP = GCP.MaCP) 
	LEFT JOIN
	 (SELECT SOLUONGDAT=(SUM(LD.SoLuongDat)), LD.MaCP
	 FROM
		(SELECT MaTKNH FROM TaiKhoanNganHang TKNH WHERE TKNH.MaNDT = @MANDT) TKNH
		INNER JOIN
		(SELECT  SoLuongDat, GiaDat, MaTKNH, MaCP FROM LenhDat LD WHERE (LD.MaTT = 'CK' OR LD.MaTT = 'K1P' )AND LD.LoaiGD = 'B' AND NgayGio > @NGAY ) LD
		ON TKNH.MaTKNH = LD.MaTKNH
		GROUP BY LD.MaCP) CPKD
ON SH.MaCP = CPKD.MaCP 
		
		
	

GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT]
--DECLARE 
@MANDT VARCHAR(10)
AS
DECLARE @NGAYAPDUNG DATE, @SODU INT, @SODUCHOTHANHTOAN INT, @PHIGD INT, @NGAY DATE
SELECT @NGAYAPDUNG = MAX(Ngayapdung)FROM ChiTietBangPhi
SET @NGAY = GETDATE() -1

--SET @MANDT = 'NDT01'
--AS

	SELECT DISTINCT  
	TKNH.MaTKNH, SODU =(case when (SUM(LD.GIATRILENH)) IS NULL  THEN (SUM(DISTINCT Sodu)) ELSE  (SUM(DISTINCT Sodu) + SUM(LD.GIATRILENH) + SUM(LD.GIATRILENH * CTBP.GiaTriMoi)) END)
			, SODUCHOTHANHTOAN = (CASE WHEN (SUM(LD.GIATRILENH)) IS NULL THEN 0 ELSE (SUM(LD.GIATRILENH)) END), 
						PHIGIAODICH =(CASE WHEN (SUM(LD.GIATRILENH)) IS NULL THEN 0 ELSE (SUM(LD.GIATRILENH * CTBP.GiaTriMoi)) END), 
						SOTIENKHADUNGCONLAI = (SUM(DISTINCT Sodu))
		FROM 
			(SELECT SoDu, MaTKNH FROM TaiKhoanNganHang TKNH WHERE TKNH.MaNDT = @MANDT ) TKNH
			LEFT JOIN
			(SELECT (LD.SoLuongDat * LD.GiaDat)GIATRILENH, MaTKNH, MaTT FROM LenhDat LD WHERE LD.LoaiGD = 'M' AND (LD.MaTT = 'CK' OR LD.MaTT = 'K1P') AND NgayGio > @NGAY ) LD 
			ON TKNH.MaTKNH = LD.MaTKNH
			,
			(SELECT GiaTriMoi FROM ChiTietBangPhi CTBP WHERE CTBP.Ngayapdung = @NGAYAPDUNG) CTBP
			GROUP BY TKNH.MaTKNH
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_SODUTIEN_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_LAY_SODUTIEN_NDT]
--DECLARE 
@MANDT VARCHAR(10)
AS
DECLARE @NGAYAPDUNG DATE, @SODU INT, @SODUCHOTHANHTOAN INT, @PHIGD INT, @NGAY DATE
SELECT @NGAYAPDUNG = MAX(Ngayapdung)FROM ChiTietBangPhi
SET @NGAY = GETDATE() - 1


--SET @MANDT = 'NDT01'
--AS
SELECT @SODU = CTT.SODU,@SODUCHOTHANHTOAN = CTT.SODUCHOTHANHTOAN,@PHIGD = CTT.PHIGD
FROM(
	SELECT  (SUM (DISTINCT CT.Sodu))SODU, 
			(SUM( DISTINCT CT.GIATRILENH))SODUCHOTHANHTOAN,
			(SUM(CT.PHIGIAODICH))PHIGD
	FROM
		(SELECT  Sodu, LD.GIATRILENH, PHIGIAODICH = (LD.GIATRILENH * CTBP.GiaTriMoi) 
		FROM 
			(SELECT SoDu, MaTKNH FROM TaiKhoanNganHang TKNH WHERE TKNH.MaNDT = @MANDT ) TKNH
			LEFT JOIN
			(SELECT GIATRILENH = (LD.SoLuongDat * LD.GiaDat), 
					MaTKNH, 
					MaTT FROM LenhDat LD WHERE LD.LoaiGD = 'M' AND (LD.MaTT = 'CK' OR LD.MaTT = 'K1P') AND NgayGio > @NGAY) LD 
			ON TKNH.MaTKNH = LD.MaTKNH
			,
			(SELECT GiaTriMoi FROM ChiTietBangPhi CTBP WHERE CTBP.Ngayapdung = @NGAYAPDUNG) CTBP
			GROUP BY CTBP.GiaTriMoi, TKNH.Sodu, LD.GIATRILENH) CT) CTT



SELECT SODU = (CASE WHEN @PHIGD IS NULL THEN @SODU ELSE(@SODU + @PHIGD + @SODUCHOTHANHTOAN) END),
		SOTIENCHOTHANHTOAN = (CASE WHEN @SODUCHOTHANHTOAN IS NULL THEN 0 ELSE @SODUCHOTHANHTOAN END),
		PHIGIAODICH = (CASE WHEN @PHIGD IS NULL THEN 0 ELSE  @PHIGD END), 
		SODUCHOTHANHTOAN = @SODU
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_TKNH_NDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_TKNH_NDT]
 @MANDT NVARCHAR(10)
--SET @MANDT = 'NDT02'
AS
SELECT MaTKNH
FROM TaiKhoanNganHang
WHERE MaNDT = @MANDT
GO
/****** Object:  StoredProcedure [dbo].[SP_LietkeCoPhieuNDT]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LietkeCoPhieuNDT]
	-- Add the parameters for the stored procedure here
	@MaNDT varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SoHuu.MaCP, SoHuu.SoLuong, GiaCoPhieu.GiaThamChieu, SoHuu.SoLuong*GiaCoPhieu.GiaThamChieu AS TRIGIA 
	FROM SoHuu 
	INNER JOIN GiaCoPhieu
	ON SoHuu.MaCP= GiaCoPhieu.MaCP
	Where SoHuu.MaNDT = @MaNDT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LietkeLenhKhop]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LietkeLenhKhop]
	-- Add the parameters for the stored procedure here
	@tungay DATETIME, @denngay DATETIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT LenhKhop.TgKhop ,LenhKhop.SoLuongKhop,LenhKhop.GiaKhop ,LenhDat.MaCP, LenhDat.LoaiGD ,LenhDat.MaLL 
	FROM LenhKhop
	INNER JOIN LenhDat
	ON LenhKhop.IDLD = LenhDat.IDLD
	WHERE LenhKhop.TgKhop >= @tungay AND LenhKhop.TgKhop <= @denngay
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 4/24/2022 10:43:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[sp_TaoTaiKhoan]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'CHUNGKHOANHN'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'CongTY' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
	IF @ROLE= 'SoGD' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'NhaDauTu'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
USE [master]
GO
ALTER DATABASE [CHUNGKHOANHN] SET  READ_WRITE 
GO
