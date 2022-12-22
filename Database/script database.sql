USE [master]
GO
/****** Object:  Database [QuanLyVatTuCuaXiNghiepMay]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Int2Nvarchar]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaCongDoan]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaNguyenLieu]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhanXuong]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhieuNhan]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaPhieuPhanCong]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TaoMaSanPham]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuNhan]    Script Date: 12/23/2022 12:19:32 AM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuPhanCong]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[CongDoan]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[DinhMuc]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[PhanXuong]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[PhieuNhan]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[PhieuPhanCong]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[BaoCaoPhanXuongKyNhan]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[BaoCaoPhieuPhanCongTheoNgay]    Script Date: 12/23/2022 12:19:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[ThongKeSanPhamSanXuatCuaTungPhanXuong]    Script Date: 12/23/2022 12:19:33 AM ******/
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
