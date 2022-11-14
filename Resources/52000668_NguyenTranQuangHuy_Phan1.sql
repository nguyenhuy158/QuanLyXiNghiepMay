
SET DATEFORMAT dmy;

--Create table
CREATE DATABASE QuanLyVatTuCuaXiNghiepMay;
GO
USE QuanLyVatTuCuaXiNghiepMay;
	
CREATE TABLE NguyenLieu(
	maNguyenLieu		nvarchar(15),
	tenNguyenLieu		nvarchar(50),
	ghiChu				nvarchar(50),
	CONSTRAINT PK_NguyenLieu 
		PRIMARY KEY(maNguyenLieu)
)

CREATE TABLE SanPham(
	maSanPham		nvarchar(15),
	tenSanPham		nvarchar(50),
	ghiChu			nvarchar(50),
	CONSTRAINT PK_SanPham
		PRIMARY KEY(maSanPham)
)

CREATE TABLE DinhMuc(
	maNguyenLieu		nvarchar(15),
	maSanPham			nvarchar(15),
	donViTinh			nvarchar(15),
	soLuong				int,
	CONSTRAINT PK_DinhMuc 
		PRIMARY KEY(maNguyenLieu, maSanPham),
	CONSTRAINT FK_DinhMuc_maNguyenLieu
		FOREIGN KEY(maNguyenLieu) REFERENCES NguyenLieu(maNguyenLieu),
	CONSTRAINT FK_DinhMuc_maSanPham
		FOREIGN KEY(maSanPham) REFERENCES SanPham(maSanPham)
)

CREATE TABLE CongDoan(
	maSanPham			nvarchar(15),
	sttCongDoan			int,
	yeuCauKyThuat		nvarchar(15),
	dinhMucTienLuong	int,
	ghiChu				nvarchar(50),
	CONSTRAINT PK_CongDoan 
		PRIMARY KEY(maSanPham, sttCongDoan),
	CONSTRAINT FK_CongDoan_maSanPham
		FOREIGN KEY(maSanPham) REFERENCES SanPham(maSanPham)
)

CREATE TABLE PhanXuong(
	maPhanXuong			nvarchar(15),
	tenPhanXuong		nvarchar(15),
	diaChi				nvarchar(15),
	soDienThoai			nvarchar(15),
	CONSTRAINT PK_PhanXuong 
		PRIMARY KEY(maPhanXuong)
)

CREATE TABLE PhieuNhanNguyenLieu(
	soPhieuNhan			nvarchar(15),
	ngayLapPhieu		datetime,
	tenNguoiNhan		nvarchar(50),
	CONSTRAINT PK_PhieuNhanNguyenLieu 
		PRIMARY KEY(soPhieuNhan)
)

CREATE TABLE ChiTietPhieuNhan(
	soPhieuNhan			nvarchar(15),
	maNguyenLieu		nvarchar(15),
	soLuong				int,
	CONSTRAINT PK_ChiTietPhieuNhan 
		PRIMARY KEY(soPhieuNhan, maNguyenLieu),
	CONSTRAINT FK_ChiTietPhieuNhan_soPhieuNhan
		FOREIGN KEY(soPhieuNhan) REFERENCES PhieuNhanNguyenLieu(soPhieuNhan),
	CONSTRAINT FK_ChiTietPhieuNhan_maNguyenLieu
		FOREIGN KEY(maNguyenLieu) REFERENCES NguyenLieu(maNguyenLieu)
)

CREATE TABLE PhieuPhanCong(
	soPhieuPhanCong			nvarchar(15),
	maPhanXuong				nvarchar(15),
	ngayLapPhieu			datetime,
	CONSTRAINT PK_PhieuPhanCong 
		PRIMARY KEY(soPhieuPhanCong),
	CONSTRAINT FK_PhieuPhanCong_maPhanXuong
		FOREIGN KEY(maPhanXuong) REFERENCES PhanXuong(maPhanXuong)
)

CREATE TABLE ChiTietPhieuPhanCong(
	soPhieuPhanCong			nvarchar(15),
	maSanPham				nvarchar(15),
	soLuong					int,
	CONSTRAINT PK_ChiTietPhieuPhanCong 
		PRIMARY KEY(soPhieuPhanCong, maSanPham),
	CONSTRAINT FK_ChiTietPhieuPhanCong_soPhieuPhanCong
		FOREIGN KEY(soPhieuPhanCong) REFERENCES PhieuPhanCong(soPhieuPhanCong),
	CONSTRAINT FK_ChiTietPhieuPhanCong_maSanPham
		FOREIGN KEY(maSanPham) REFERENCES SanPham(maSanPham)
)

--INSERT DATA 

INSERT INTO NguyenLieu
VALUES 
('1', 'vai loai 1', ''),
('2', 'vai loai 2', ''),
('3', 'vai loai 3', ''),
('4', 'vai loai 4', ''),
('5', 'vai loai 5', '')


INSERT INTO SanPham
VALUES 
('1', 'ao 1', ''),
('2', 'ao 2', ''),
('3', 'ao 3', ''),
('4', 'ao 4', ''),
('5', 'ao 5', '')

INSERT INTO DinhMuc
VALUES 
('1', '1', 'cai', 100),
('2', '2', 'cai', 100),
('3', '3', 'cai', 100),
('4', '4', 'cai', 100),
('5', '5', 'cai', 100),
('1', '2', 'cai', 100)

INSERT INTO CongDoan
VALUES 
('1', '1', 'biet may', 10000, ''),
('2', '1', 'biet may', 10000, ''),
('1', '2', 'biet may', 10000, ''),
('2', '2', 'biet may', 10000, ''),
('1', '3', 'biet may', 10000, '')

INSERT INTO PhanXuong
VALUES 
('1', 'tai che', 'TP.HCM', '0123546789'),
('2', 'hang vip', 'TP.HCM', '0123546789'),
('3', 'cho lon', 'TP.HCM', '0123546789'),
('4', 'chuong reo', 'TP.HCM', '0123546789'),
('5', 'cho ben thanh', 'TP.HCM', '0123546789')

INSERT INTO PhieuNhanNguyenLieu
VALUES 
('1', '22/02/2022', 'Duc map'),
('2', '22/02/2022', 'Duc map'),
('3', '22/02/2022', 'Duc map'),
('4', '22/02/2022', 'Duc map'),
('5', '22/02/2022', 'Duc map')

INSERT INTO ChiTietPhieuNhan
VALUES 
('1', '1', 100),
('2', '2', 100),
('3', '3', 100),
('4', '4', 100),
('5', '5', 100)	

INSERT INTO PhieuPhanCong
VALUES 
('1', '1', '22/02/2022'),
('2', '2', '22/02/2022'),
('3', '3', '22/02/2022'),
('4', '4', '22/02/2022'),
('5', '5', '22/02/2022')

INSERT INTO ChiTietPhieuPhanCong
VALUES 
('1', '1', 100),
('2', '2', 100),
('3', '3', 100),
('4', '4', 100),
('5', '5', 100)


----1b them du lieu cho cac bang theo thu tu
----san bong 
----	> dich vu 
----		> gia tien thue san 
----				> thue san 
----						> chi tiet thue san

--INSERT INTO SanBong
--VALUES 
--('SB_001', 'Sân bóng 1', 'sân 5'),
--('SB_002', 'Sân bóng 2', 'sân 11'),
--('SB_003', 'Sân bóng 3', 'sân 11'),
--('SB_004', 'Sân bóng 4', 'sân 7'),
--('SB_005', 'Sân bóng 5', 'sân 11'),
--('SB_006', 'Sân bóng 6', 'sân 7')

--INSERT INTO DichVu
--VALUES 
--('DV_001', 'Dịch Vụ Thuê áo đá banh',		'43', '20000'),
--('DV_002', 'Dịch Vụ Mua áo đá banh',		'10', '179000'),
--('DV_003', 'Dịch Vụ Giữ xe',				'51', '10000'),
--('DV_004', 'Dịch Vụ Y tế',					'12', '267000'),
--('DV_005', 'Dịch Vụ Thuê giày thi đấu',		'51', '50000'),
--('DV_006', 'Dịch Vụ Cung cấp nước',			'97', '19000'),
--('DV_007', 'Dịch Vụ Ăn uống tại căng tin',	'74', '65000'),
--('DV_008', 'Dịch Vụ Tổ chức sự kiện',		'19', '1500000')

--INSERT INTO GiaTienThueSan
--VALUES 
--('GTTS_001', '05:00:00', '07:00:00', '200000'),
--('GTTS_002', '07:00:00', '11:00:00', '300000'),
--('GTTS_003', '11:00:00', '15:00:00', '250000'),
--('GTTS_004', '15:00:00', '18:00:00', '450000'),
--('GTTS_005', '18:00:00', '20:00:00', '600000'),
--('GTTS_006', '20:00:00', '22:00:00', '450000')

--INSERT INTO ThueSan
--VALUES 
--('01062022001', '0555506477', 'SB_003', '01-06-2022', '05:00', '07:00', '200000'),
--('02062022001', '0555582335', 'SB_001', '02-06-2022', '05:00', '07:00', '200000'),
--('02062022002', '0355595981', 'SB_004', '02-06-2022', '05:00', '07:00', '200000'),
--('03062022001', '0555588520', 'SB_005', '03-06-2022', '05:00', '07:00', '200000'),
--('03062022002', '0355566326', 'SB_002', '03-06-2022', '05:00', '07:00', '200000'),
--('03062022003', '0755599004', 'SB_003', '03-06-2022', '05:00', '07:00', '200000')

--INSERT INTO ChiTietThueSan
--VALUES 
--('01062022001', 'DV_003',	'5',	'10000'),
--('02062022001', 'DV_003',	'6',	'10000'),
--('02062022002', 'DV_003',	'7',	'10000'),
--('03062022001', 'DV_003',	'11',	'10000'),
--('03062022002', 'DV_003',	'30',	'10000'),
--('03062022003', 'DV_003',	'8',	'10000'),
--('02062022001', 'DV_004',	'11',	'267000'),
--('03062022002', 'DV_008',	'30',	'1500000'),
--('01062022001', 'DV_006',	'8',	'19000')

----2a tao ma tu dong cho bang thue san
--GO
--CREATE OR ALTER FUNCTION function_generationPrefixCode_ThueSan(@ngayThueSan date)
--RETURNS nvarchar(15)
--AS
--BEGIN
--	DECLARE @prefix as nvarchar(8) = 
--		CASE
--		WHEN LEN(CONVERT(nvarchar, DAY(@ngayThueSan))) = 1 
--			THEN '0' +  CONVERT(nvarchar, DAY(@ngayThueSan))
--		ELSE CONVERT(nvarchar, DAY(@ngayThueSan)) 
--		END
--	SET @prefix = 
--			@prefix 
--			+ 
--			CASE
--			WHEN LEN(CONVERT(nvarchar, MONTH(@ngayThueSan))) = 1 
--				THEN '0' +  CONVERT(nvarchar, MONTH(@ngayThueSan))
--			ELSE CONVERT(nvarchar, MONTH(@ngayThueSan)) 
--			END
--	SET @prefix = @prefix + CONVERT(nvarchar, YEAR(@ngayThueSan))

--	RETURN @prefix;
--END

--GO
--CREATE OR ALTER FUNCTION function_getMaxFromDate_ThueSan(@ngayThueSan date)
--RETURNS int
--AS
--BEGIN
--	DECLARE @code as int = 	(
--			SELECT MAX(CONVERT(int, RIGHT(maThueSan, 3))) 
--			AS 'orderMaThueSan' 
--			FROM ThueSan 
--			WHERE ngayThueSan = @ngayThueSan
--			)

--	RETURN CASE WHEN @code IS NULL THEN 0 ELSE @code END
--END

----DROP FUNCTION dbo.function_getMaxFromDate_ThueSan

--GO
--CREATE OR ALTER FUNCTION function_generationCode_ThueSan(@ngayThueSan date)
--RETURNS nvarchar(15)
--AS
--BEGIN
--	DECLARE @prefix as nvarchar(8) = dbo.function_generationPrefixCode_ThueSan(@ngayThueSan);
--	DECLARE @temp as int = dbo.function_getMaxFromDate_ThueSan(@ngayThueSan) + 1;
--	DECLARE @code as nvarchar(8) = 
--		CASE 
--		WHEN @temp < 10
--		THEN '00' + CONVERT(nvarchar, @temp)
--		WHEN @temp < 100
--		THEN '0' + CONVERT(nvarchar, @temp)
--		ELSE '' + CONVERT(nvarchar, @temp)
--		END
--	RETURN @prefix + @code;
--END

----select dbo.function_generationCode_ThueSan('03-06-2022')

----2b tao ma tu dong cho bang thue san
--GO
--CREATE OR ALTER FUNCTION function_getMoneyFromGioVaoGioRa_ThueSan(@gioVao time, @gioRa time)
--RETURNS int
--AS
--BEGIN
--	DECLARE @money as int = (
--		SELECT soTien 
--		FROM GiaTienThueSan 
--		WHERE DATEDIFF(HOUR, @gioVao, tuGio) <= 0 
--			AND DATEDIFF(HOUR, @gioRa, denGio) >= 0
--							)
--	RETURN @money;
--END

----select dbo.function_getMoneyFromGioVaoGioRa_ThueSan('05:00:0', '07:00:00')


----3a
--GO
--CREATE OR ALTER PROCEDURE procedure_themDuLieu_GiaTienThueSan 
--		@ma as nvarchar(15), @tuGio as time, @denGio as time, @soTien as int
--AS
--BEGIN
--	IF (@ma IN (SELECT maGiaTien FROM GiaTienThueSan))
--	BEGIN
--		PRINT N'Mã giá tiền đã tồn tại rồi. Vui lòng thử với mã giá tiền mới.';
--		RETURN;
--	END
--	IF (@tuGio > @denGio)
--	BEGIN
--		PRINT N'Giờ bắt đầu phải nhỏ hơn giờ kết thúc. Vui lòng thử lại.';
--		RETURN;
--	END

--	INSERT INTO GiaTienThueSan
--	VALUES 
--	(@ma, @tuGio, @denGio, @soTien)
--	PRINT N'Thêm dữ liệu thành công.';
--END

--EXECUTE procedure_themDuLieu_GiaTienThueSan 'GTTS_007', '22:00:00', '23:00:00', '18000'

----3b
--GO
--CREATE OR ALTER PROCEDURE procedure_them10000DichVuThueAo_DichVu 
--AS
--BEGIN
--	UPDATE DichVu
--	SET
--		donGia = donGia + 10000
--	WHERE tenDichVu LIKE '%thuê áo%'
--END

--EXECUTE procedure_them10000DichVuThueAo_DichVu 

----4
----tổng tiền = tiền thuê sân + tiền sử dụng dịch vụ của lần thuê sân đó
--GO
--CREATE OR ALTER TRIGGER trigger_ChiTietThueSan
--ON ChiTietThueSan
--FOR INSERT, DELETE, UPDATE
--AS
--BEGIN

--	UPDATE ThueSan
--	SET tongTien = tongTien 
--		- (SELECT sum(donGia * soLuong) 
--				FROM ChiTietThueSan 
--				WHERE ChiTietThueSan.maThueSan = (SELECT deleted.maThueSan from deleted))
--	WHERE ThueSan.maThueSan = (SELECT deleted.maThueSan from deleted)

--	UPDATE ThueSan
--	SET tongTien = dbo.function_getMoneyFromGioVaoGioRa_ThueSan(gioBatDau, gioKetThuc) 
--		+ (SELECT sum(donGia * soLuong) 
--				FROM ChiTietThueSan 
--				WHERE ChiTietThueSan.maThueSan = (SELECT inserted.maThueSan from inserted))
--	WHERE ThueSan.maThueSan = (SELECT inserted.maThueSan from inserted)

--END
