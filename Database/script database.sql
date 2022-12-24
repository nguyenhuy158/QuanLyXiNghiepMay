USE [master]
GO
/****** Object:  Database [QuanLyVatTuCuaXiNghiepMay]    Script Date: 12/24/2022 8:10:02 AM ******/
CREATE DATABASE [QuanLyVatTuCuaXiNghiepMay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyVatTuCuaXiNghiepMay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyVatTuCuaXiNghiepMay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyVatTuCuaXiNghiepMay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyVatTuCuaXiNghiepMay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyVatTuCuaXiNghiepMay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET QUERY_STORE = OFF
GO
USE [QuanLyVatTuCuaXiNghiepMay]
GO
/****** Object:  UserDefinedFunction [dbo].[Int2Nvarchar]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Int2Nvarchar] 
(
	-- Add the parameters for the function here
	@number int
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar nvarchar(50) = right('000' + cast(@number as varchar(3)), 3)

	-- Return the result of the function
	RETURN @ResultVar

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaCongDoan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaCongDoan]
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 CongDoan.soCongDoan 
							from CongDoan
							where CongDoan.soCongDoan like 'CD' + @temp + '%'
							order by soCongDoan desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'CD' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaNguyenLieu]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaNguyenLieu]  
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 NguyenLieu.ma 
							from NguyenLieu
							where NguyenLieu.ma like 'NL' + @temp + '%'
							order by ma desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'NL' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhanXuong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaPhanXuong]
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 PhanXuong.ma 
							from PhanXuong
							where PhanXuong.ma like 'PX' + @temp + '%'
							order by ma desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'PX' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhieuNhan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaPhieuNhan]
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 PhieuNhan.so
							from PhieuNhan
							where PhieuNhan.so like 'PN' + @temp + '%'
							order by so desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'PN' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhieuPhanCong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaPhieuPhanCong]
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 PhieuPhanCong.so
							from PhieuPhanCong
							where PhieuPhanCong.so like 'PC' + @temp + '%'
							order by so desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'PC' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[TaoMaSanPham]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[TaoMaSanPham] 
(
	-- Add the parameters for the function here
	
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50) = ''

	-- Add the T-SQL statements to compute the return value here
	DECLARE @year nvarchar(50) =  cast(Year(GETDATE()) as nvarchar(50))
	DECLARE @month nvarchar(50) =  cast(month(GETDATE()) as nvarchar(50))
	DECLARE @day nvarchar(50) =  cast(day(GETDATE()) as nvarchar(50))
	DECLARE @number int


	DECLARE @temp nvarchar(50) = @year + @month + @day
	DECLARE @currentID nvarchar(50) = (Select Top 1 SanPham.ma 
							from SanPham
							where SanPham.ma like 'SP' + @temp + '%'
							order by ma desc)

	if (@currentID is null)
	begin
		set @number = 1
	END
	else 
	begin
		set @number = cast(RIGHT(@currentId, 3) as int) + 1
	end

	set @Result = 'SP' + @year + @month + @day + dbo.Int2NvarChar(@number)
	-- Return the result of the function
	RETURN @Result

END
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhan](
	[soPhieuNhan] [nvarchar](50) NOT NULL,
	[maNguyenLieu] [nvarchar](50) NOT NULL,
	[soLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhan] PRIMARY KEY CLUSTERED 
(
	[soPhieuNhan] ASC,
	[maNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuPhanCong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuPhanCong](
	[soPhieuPhanCong] [nvarchar](50) NOT NULL,
	[maSanPham] [nvarchar](50) NOT NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuPhanCong] PRIMARY KEY CLUSTERED 
(
	[soPhieuPhanCong] ASC,
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongDoan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongDoan](
	[maSanPham] [nvarchar](50) NOT NULL,
	[soCongDoan] [nvarchar](50) NOT NULL,
	[yeuCauKyThuat] [nvarchar](50) NULL,
	[mucTienLuong] [int] NULL,
	[ghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CongDoan] PRIMARY KEY CLUSTERED 
(
	[maSanPham] ASC,
	[soCongDoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DinhMuc]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DinhMuc](
	[maNguyenLieu] [nvarchar](50) NOT NULL,
	[maSanPham] [nvarchar](50) NOT NULL,
	[donViTinh] [nvarchar](50) NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_DinhMuc] PRIMARY KEY CLUSTERED 
(
	[maNguyenLieu] ASC,
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[ma] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanXuong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanXuong](
	[ma] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanXuong] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhan](
	[so] [nvarchar](50) NOT NULL,
	[tenNguoiNhan] [nvarchar](50) NOT NULL,
	[ngayTao] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhanNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[so] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuPhanCong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuPhanCong](
	[so] [nvarchar](50) NOT NULL,
	[maPhanXuong] [nvarchar](50) NOT NULL,
	[ngayTao] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuPhanCong_1] PRIMARY KEY CLUSTERED 
(
	[so] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ma] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101001', N'NL20221010001', 2)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221010001', 4)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221010002', 45)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221110001', 788)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221110002', 8)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221114001', 90)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101002', N'NL20221114002', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221101003', N'NL20221114002', 1233)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221113003', N'NL20221114002', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221115001', N'NL20221010001', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221115001', N'NL20221010002', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221115001', N'NL20221110001', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221115001', N'NL20221110002', 123)
GO
INSERT [dbo].[ChiTietPhieuNhan] ([soPhieuNhan], [maNguyenLieu], [soLuong]) VALUES (N'PN20221115001', N'NL20221114001', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221114001', N'SP20221110002', 1)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221114001', N'SP20221113002', 32)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221114001', N'SP20221113003', 12)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221114002', N'SP20221110002', 222)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221114003', N'SP20221114003', 2)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115001', N'SP20221110002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115001', N'SP20221113002', 3444)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115001', N'SP20221113003', 3)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115001', N'SP20221114001', 3)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115002', N'SP20221110002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115003', N'SP20221113002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115003', N'SP20221113003', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115003', N'SP20221114001', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115003', N'SP20221114002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115003', N'SP20221114003', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115004', N'SP20221114003', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221110002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221113002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221113003', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221114001', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221114002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115011', N'SP20221114003', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221110002', 111)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221113002', 112)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221113003', 113)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221114001', 114)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221114002', 123)
GO
INSERT [dbo].[ChiTietPhieuPhanCong] ([soPhieuPhanCong], [maSanPham], [soLuong]) VALUES (N'PC20221115015', N'SP20221114003', 1233)
GO
INSERT [dbo].[CongDoan] ([maSanPham], [soCongDoan], [yeuCauKyThuat], [mucTienLuong], [ghiChu]) VALUES (N'SP20221110002', N'CD20221114001', N'biết may', 12, N'không có')
GO
INSERT [dbo].[CongDoan] ([maSanPham], [soCongDoan], [yeuCauKyThuat], [mucTienLuong], [ghiChu]) VALUES (N'SP20221110002', N'CD20221114002', N'đan', 100, N'không có')
GO
INSERT [dbo].[CongDoan] ([maSanPham], [soCongDoan], [yeuCauKyThuat], [mucTienLuong], [ghiChu]) VALUES (N'SP20221110002', N'CD20221217001', N'không', 1000000000, N'không')
GO
INSERT [dbo].[CongDoan] ([maSanPham], [soCongDoan], [yeuCauKyThuat], [mucTienLuong], [ghiChu]) VALUES (N'SP20221110002', N'CD20221217002', N'không', 1000, N'không')
GO
INSERT [dbo].[DinhMuc] ([maNguyenLieu], [maSanPham], [donViTinh], [soLuong]) VALUES (N'NL20221010001', N'SP20221110002', N'Thùng', 123)
GO
INSERT [dbo].[DinhMuc] ([maNguyenLieu], [maSanPham], [donViTinh], [soLuong]) VALUES (N'NL20221010001', N'SP20221113002', N'Túi', 2312312)
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'1', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'2', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'3', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'4', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'5', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'6', N'1', N'1')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221010001', N'Vải bông', N'')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221010002', N'Thun lạnh', N'')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221110001', N'Vải Loại 2', N'Không có')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221110002', N'Vải loại 3', N'')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221114001', N'Vải Loại 1', N'')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL20221114002', N'Thuốc nhuộm', N'Không có')
GO
INSERT [dbo].[NguyenLieu] ([ma], [ten], [ghiChu]) VALUES (N'NL241220220001', N'ten nguyen lieu test 1', N'khong co')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221111001', N'Chợ bến thành', N'TP.HCM', N'0123546789')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221114001', N'Tái chế', N'TP.HCM', N'0123546789')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221114002', N'Chuyên may áo', N'Ninh Thuận', N'0123737788')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221114003', N'Hàng VIP', N'TP.HCM', N'0123546789')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221114004', N'Chợ lớn', N'Bà Rịa', N'0123546789')
GO
INSERT [dbo].[PhanXuong] ([ma], [ten], [diaChi], [sdt]) VALUES (N'PX20221114005', N'Hàng đồng giá', N'TP.HCM', N'0123546789')
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221101001', N'Huy', CAST(N'2022-02-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221101002', N'Trần Huy', CAST(N'2022-02-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221101003', N'Huy Nguyễn', CAST(N'2022-10-20T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221101004', N'Lan', CAST(N'2022-10-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221113001', N'Hoàng Đức', CAST(N'2022-11-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221113002', N'Võ Đức', CAST(N'2022-02-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221113003', N'Nguyễn Huy', CAST(N'2022-02-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221114001', N'Điệp', CAST(N'2022-02-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221114002', N'Quốc Anh', CAST(N'2022-10-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221114003', N'Gia Bảo', CAST(N'2019-11-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221114004', N'Báo', CAST(N'2020-11-14T21:22:20.910' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221115001', N'Quá Báo', CAST(N'2022-11-15T15:33:25.353' AS DateTime))
GO
INSERT [dbo].[PhieuNhan] ([so], [tenNguoiNhan], [ngayTao]) VALUES (N'PN20221115002', N'Github', CAST(N'2022-11-15T15:34:15.767' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221114001', N'PX20221114001', CAST(N'2022-08-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221114002', N'PX20221111001', CAST(N'2022-11-11T22:45:23.973' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221114003', N'PX20221114004', CAST(N'2019-11-14T22:50:34.863' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115001', N'PX20221111001', CAST(N'2022-11-15T14:37:01.947' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115002', N'PX20221114005', CAST(N'2022-11-15T14:38:12.123' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115003', N'PX20221114005', CAST(N'2022-11-15T14:38:18.707' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115004', N'PX20221114005', CAST(N'2022-11-15T14:38:19.503' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115005', N'PX20221114002', CAST(N'2022-11-15T14:38:20.860' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115007', N'PX20221114001', CAST(N'2022-11-15T14:38:25.240' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115008', N'PX20221111001', CAST(N'2022-11-15T17:39:56.557' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115009', N'PX20221111001', CAST(N'2022-11-15T17:40:18.923' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115010', N'PX20221111001', CAST(N'2022-11-15T17:40:20.877' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115011', N'PX20221111001', CAST(N'2022-11-15T17:40:21.457' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115012', N'PX20221111001', CAST(N'2022-11-15T17:40:21.973' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115013', N'PX20221111001', CAST(N'2022-11-15T17:40:22.467' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115014', N'PX20221114002', CAST(N'2022-11-14T17:43:59.103' AS DateTime))
GO
INSERT [dbo].[PhieuPhanCong] ([so], [maPhanXuong], [ngayTao]) VALUES (N'PC20221115015', N'PX20221114002', CAST(N'2022-08-14T17:44:22.087' AS DateTime))
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221110002', N'Áo Thun Lạnh', N'')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221113002', N'Áo Thun', N'')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221113003', N'Áo Khoác', N'')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221114001', N'Áo Jean', N'Tay ngắn')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221114002', N'Quần Joke', N'Size L')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221114003', N'Áo Jean', N'Tay dài')
GO
INSERT [dbo].[SanPham] ([ma], [ten], [ghiChu]) VALUES (N'SP20221217001', N'Nón len', N'cho mùa đông')
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhan_maNguyenLieu] FOREIGN KEY([maNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuNhan_maNguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhan_soPhieuNhan] FOREIGN KEY([soPhieuNhan])
REFERENCES [dbo].[PhieuNhan] ([so])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhan] CHECK CONSTRAINT [FK_ChiTietPhieuNhan_soPhieuNhan]
GO
ALTER TABLE [dbo].[ChiTietPhieuPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuPhanCong_maSanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([ma])
GO
ALTER TABLE [dbo].[ChiTietPhieuPhanCong] CHECK CONSTRAINT [FK_ChiTietPhieuPhanCong_maSanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuPhanCong_soPhieuPhanCong] FOREIGN KEY([soPhieuPhanCong])
REFERENCES [dbo].[PhieuPhanCong] ([so])
GO
ALTER TABLE [dbo].[ChiTietPhieuPhanCong] CHECK CONSTRAINT [FK_ChiTietPhieuPhanCong_soPhieuPhanCong]
GO
ALTER TABLE [dbo].[CongDoan]  WITH CHECK ADD  CONSTRAINT [FK_CongDoan_maSanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([ma])
GO
ALTER TABLE [dbo].[CongDoan] CHECK CONSTRAINT [FK_CongDoan_maSanPham]
GO
ALTER TABLE [dbo].[DinhMuc]  WITH CHECK ADD  CONSTRAINT [FK_DinhMuc_maNguyenLieu] FOREIGN KEY([maNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ma])
GO
ALTER TABLE [dbo].[DinhMuc] CHECK CONSTRAINT [FK_DinhMuc_maNguyenLieu]
GO
ALTER TABLE [dbo].[DinhMuc]  WITH CHECK ADD  CONSTRAINT [FK_DinhMuc_maSanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([ma])
GO
ALTER TABLE [dbo].[DinhMuc] CHECK CONSTRAINT [FK_DinhMuc_maSanPham]
GO
ALTER TABLE [dbo].[PhieuPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuPhanCong_maPhanXuong] FOREIGN KEY([maPhanXuong])
REFERENCES [dbo].[PhanXuong] ([ma])
GO
ALTER TABLE [dbo].[PhieuPhanCong] CHECK CONSTRAINT [FK_PhieuPhanCong_maPhanXuong]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoPhanXuongKyNhan]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCaoPhanXuongKyNhan]
	-- Add the parameters for the stored procedure here
	@Ngay DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	phanxuong.ma, PhanXuong.diaChi, PhanXuong.ten,
	sum(ChiTietPhieuPhanCong.soLuong) as soLuong
	from PhanXuong
	join PhieuPhanCong 
	on PhanXuong.ma = PhieuPhanCong.maPhanXuong
	join ChiTietPhieuPhanCong
	on ChiTietPhieuPhanCong.soPhieuPhanCong = PhieuPhanCong.so
	where Datediff(dd, @Ngay, PhieuPhanCong.ngayTao) = 0
	group by phanxuong.ma, PhanXuong.diaChi, PhanXuong.ten

END
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoPhieuPhanCongTheoNgay]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCaoPhieuPhanCongTheoNgay]
	@Ngay DateTime
AS
BEGIN
	SELECT 
		PhieuPhanCong.so, PhieuPhanCong.maPhanXuong, 
		PhanXuong.ten, PhanXuong.diaChi, 
		SanPham.ma, SanPham.ten,
		ChiTietPhieuPhanCong.soLuong
	FROM PhieuPhanCong 
		join ChiTietPhieuPhanCong 
		on PhieuPhanCong.so = ChiTietPhieuPhanCong.soPhieuPhanCong
		join PhanXuong 
		on PhieuPhanCong.maPhanXuong = PhanXuong.ma
		join SanPham 
		on ChiTietPhieuPhanCong.maSanPham = SanPham.ma
	WHERE DateDiff(dd, @Ngay, PhieuPhanCong.ngayTao) = 0
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSanPhamSanXuatCuaTungPhanXuong]    Script Date: 12/24/2022 8:10:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ThongKeSanPhamSanXuatCuaTungPhanXuong]
	-- Add the parameters for the stored procedure here
	@maPhanXuong nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
		SanPham.ma,
		SanPham.ten,
		SUM(ChiTietPhieuPhanCong.soLuong) as soLuong
	from PhanXuong
	join PhieuPhanCong
		on PhieuPhanCong.maPhanXuong = PhanXuong.ma
	join ChiTietPhieuPhanCong
		on PhieuPhanCong.so = ChiTietPhieuPhanCong.soPhieuPhanCong
	join SanPham 
		on SanPham.ma = ChiTietPhieuPhanCong.maSanPham
	where PhanXuong.ma = @maPhanXuong
	group by
		SanPham.ma, SanPham.ten
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyVatTuCuaXiNghiepMay] SET  READ_WRITE 
GO
