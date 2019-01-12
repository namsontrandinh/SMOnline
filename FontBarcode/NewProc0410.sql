IF OBJECT_ID('ChiTietPhieuBan_Add_WithoutMaKho') IS NOT NULL
	DROP PROCEDURE ChiTietPhieuBan_Add_WithoutMaKho
IF OBJECT_ID('ChiTietPhieuBan_Add') IS NOT NULL
	DROP PROCEDURE ChiTietPhieuBan_Add
IF OBJECT_ID('HangHoa_GetByMaVach') IS NOT NULL
	DROP PROCEDURE HangHoa_GetByMaVach
IF OBJECT_ID('HangHoa_GetByMaHang') IS NOT NULL
	DROP PROCEDURE HangHoa_GetByMaHang
IF OBJECT_ID('ChiTietPhieuMua_Add') IS NOT NULL
	DROP PROCEDURE ChiTietPhieuMua_Add
IF OBJECT_ID('HangHoa_InMaVach') IS NOT NULL
	DROP PROCEDURE HangHoa_InMaVach
IF OBJECT_ID('HangHoa_GetHangHoa') IS NOT NULL
	DROP PROCEDURE HangHoa_GetHangHoa
IF OBJECT_ID('PhieuHangHoa_SumDay') IS NOT NULL
	DROP PROCEDURE PhieuHangHoa_SumDay
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	16/08/2018
* Edit	date	:	10/06/2018
* Decription	:	Tính tổng tiền bán theo ngày
* Script name	:	PhieuHangHoa_SumDay
************************************************************/
CREATE PROCEDURE [dbo].[PhieuHangHoa_SumDay]
	@FromTime INT,
	@ToTime INT
AS
BEGIN
	SELECT MaPhieu,TongTien from tblPhieuBanHang
	WHERE NgayBan between @FromTime and @ToTime
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	10/06/2018
* Edit	date	:	
* Decription	:	lấy danh sách hàng hóa
* Script name	:	[HangHoa_GetHangHoa] 
************************************************************/
CREATE PROCEDURE [dbo].HangHoa_GetHangHoa
AS
BEGIN
	SELECT tblHangHoa.MaHang,MaVach,TenHang,DonViTinh,(GiaBan*PhanTram/100) [GiaBan], NhomHangHoa,NhaCungCap,tblBanTheoDVT.MaDVT,tblNhomHangHoa.MaNhomHangHoa
	FROM tblHangHoa,tblDonViTinh,tblBanTheoDVT,tblNhomHangHoa,tblNhaCungCap
	WHERE tblBanTheoDVT.MaDVT=tblDonViTinh.MaDVT
	AND tblBanTheoDVT.MaHang=tblHangHoa.MaHang 
	AND tblHangHoa.MaNhomHangHoa=tblNhomHangHoa.MaNhomHangHoa
	and tblNhaCungCap.MaNCC=tblHangHoa.MaNCC
	
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	10/06/2018
* Edit	date	:	
* Decription	:	chọn hàng in mã vạch
* Script name	:	[HangHoa_InMaVach] '0123456789'
************************************************************/
CREATE PROCEDURE [dbo].[HangHoa_InMaVach]
	@MaHang varchar(100)
AS
BEGIN
	SELECT tblHangHoa.MaHang,TenHang,(GiaBan*PhanTram/100) [Giaban]
	FROM tblHangHoa,tblDonViTinh,tblBanTheoDVT
	WHERE tblHangHoa.MaHang=@MaHang
	AND tblBanTheoDVT.MaDVT=tblDonViTinh.MaDVT
	AND tblBanTheoDVT.MaHang=tblHangHoa.MaHang 
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	11/08/2018
* Edit	date	:	27/8/2018
* Decription	:	chọn hàng hóa theo mã hàng hóa
* Script name	:	HangHoa_GetByMaHang
************************************************************/
create PROCEDURE [dbo].[HangHoa_GetByMaHang]
	@MaHang varchar(100)
AS
BEGIN
	SELECT tblHangHoa.MaHang,TenHang,DonViTinh,(GiaBan*PhanTram/100) [Giaban],tblBanTheoDVT.MaDVT
	FROM tblHangHoa,tblDonViTinh,tblBanTheoDVT
	WHERE tblHangHoa.MaHang=@MaHang
	AND tblBanTheoDVT.MaDVT=tblDonViTinh.MaDVT
	AND tblBanTheoDVT.MaHang=tblHangHoa.MaHang 
END
go
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	11/08/2018
* Edit	date	:	15/8/2018
* Decription	:	chọn hàng hóa theo mã vạch
* Script name	:	HangHoa_GetByMaVach
************************************************************/
create PROCEDURE [dbo].[HangHoa_GetByMaVach]
	@MaVach varchar(100)
AS
BEGIN
	SELECT tblHangHoa.MaHang,TenHang,DonViTinh,(GiaBan*PhanTram/100) [Giaban],tblBanTheoDVT.MaDVT
	FROM tblHangHoa,tblDonViTinh,tblBanTheoDVT
	WHERE MaVach= @MaVach
	AND tblBanTheoDVT.MaDVT=tblDonViTinh.MaDVT
	AND tblBanTheoDVT.MaHang=tblHangHoa.MaHang 
END
go
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	16/08/2018
* Edit	date	:	19/08/2018
* Decription	:	thêm chi tiết phiếu bán không tính tồn kho
* Script name	:	ChiTietPhieuBan_Add_WithoutMaKho
************************************************************/
CREATE PROCEDURE ChiTietPhieuBan_Add_WithoutMaKho
	@data dtChiTietPhieuBan READONLY
AS
BEGIN
	DECLARE @MaPhieu	VARCHAR(50)
	DECLARE @MaHang	VARCHAR(100)
	DECLARE @SoLuong INT
	DECLARE @MaDVT	INT
	DECLARE @GiaBan	FLOAT
	DECLARE @TrangThai	BIT
	DECLARE CUR CURSOR
	FOR SELECT * FROM @data	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai
	WHILE @@FETCH_STATUS=0
	BEGIN 
		INSERT INTO tblChiTietPhieuBan
		(MaPhieu,MaHang,SoLuong,MaDVT,GiaBan,TrangThai)
		VALUES
		(@MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai)
	
		FETCH NEXT FROM CUR INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai
	END
	
	CLOSE CUR
	DEALLOCATE CUR
END
go
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	16/08/2018
* Edit	date	:	19/08/2018
* Decription	:	thêm chi tiết phiếu m
* Script name	:	ChiTietPhieuBan_Add
************************************************************/
create PROCEDURE [dbo].[ChiTietPhieuBan_Add]
	@data dtChiTietPhieuBan READONLY,
	@MaKho INT
AS
BEGIN
	DECLARE @MaPhieu	VARCHAR(50)
	DECLARE @MaHang	VARCHAR(100)
	DECLARE @SoLuong INT
	DECLARE @MaDVT	INT
	DECLARE @GiaBan	FLOAT
	DECLARE @TrangThai	BIT
	DECLARE @SoLuongTrongKho INT
	DECLARE CUR CURSOR
	FOR SELECT * FROM @data	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai
	WHILE @@FETCH_STATUS=0
	BEGIN 
		INSERT INTO tblChiTietPhieuBan
		(MaPhieu,MaHang,SoLuong,MaDVT,GiaBan,TrangThai)
		VALUES
		(@MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai)
		SET @SoLuongTrongKho=(SELECT SoLuong FROM dbo.tblKhoHang WHERE MaKho=@MaKho AND MaHang=@MaHang)
		UPDATE dbo.tblKhoHang
		SET SoLuong=@SoLuongTrongKho-@SoLuong
		WHERE MaKho=@MaKho AND MaHang=@MaHang
		FETCH NEXT FROM CUR INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai
	END
	
	CLOSE CUR
	DEALLOCATE CUR
END
go
/************************************************************
--* Author		: 	Tran Phuong Thao
--* Company		:	Phan Mem Ban Hang.
--* Create date	: 	11/08/2018
--* Edit	date	:	19/08/2018
--* Decription	:	Thêm mới chi tiêt phiếu mua
--* Script name	:	ChiTietPhieuMua_Add
--************************************************************/
CREATE PROCEDURE [dbo].[ChiTietPhieuMua_Add]
	@data dtChiTietPhieuMua READONLY,
	@MaKho INT
AS
BEGIN
	DECLARE @MaPhieu VARCHAR(50)
	DECLARE @MaHang VARCHAR(100)
	DECLARE @SoLuong TINYINT
	DECLARE @MaDVT INT
	DECLARE @GiaNhap INT
	DECLARE @GiaBan FLOAT
	DECLARE @TrangThai BIT
	DECLARE @SoLuongTrongKho INT
	DECLARE cur CURSOR
	FOR SELECT * FROM @data
	OPEN cur	
	FETCH NEXT FROM cur INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaNhap,@GiaBan,@TrangThai
	WHILE @@FETCH_STATUS=0
	BEGIN
		INSERT INTO tblChiTietPhieuMua
		(MaPhieu,MaHang,SoLuong,MaDVT,GiaNhap,TrangThai)
		VALUES
		(@MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaNhap,@TrangThai)
		IF NOT EXISTS (SELECT SoLuong FROM dbo.tblKhoHang WHERE MaHang=@MaHang AND MaKho=@MaKho)
		BEGIN
			INSERT INTO dbo.tblKhoHang
			        ( MaKho, MaHang, SoLuong )
			VALUES  ( @MaKho, @MaHang, @SoLuong)
		END
		ELSE
		BEGIN
		SET @SoLuongTrongKho=(SELECT SoLuong FROM dbo.tblKhoHang WHERE MaHang=@MaHang AND MaKho=@MaKho)
			UPDATE dbo.tblKhoHang	
			SET SoLuong=@SoLuongTrongKho+@SoLuong
			WHERE	MaKho=@MaKho AND MaHang=@MaHang  
		END
		FETCH NEXT FROM cur INTO @MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaNhap,@GiaBan,@TrangThai
	END

	CLOSE cur
	DEALLOCATE cur
END
GO