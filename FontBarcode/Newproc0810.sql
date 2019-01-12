IF OBJECT_ID('PhieuBanHang_GetMaPhieu') IS NOT NULL
	DROP PROCEDURE PhieuBanHang_GetMaPhieu
IF OBJECT_ID('KhachHang_Add') IS NOT NULL
	DROP PROCEDURE KhachHang_Add
IF OBJECT_ID('NhaCungCap_Add') IS NOT NULL
	DROP PROCEDURE NhaCungCap_Add
IF OBJECT_ID('NhanVien_GetMaNhanVien') IS NOT NULL
	DROP PROCEDURE NhanVien_GetMaNhanVien
GO

/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	08/10/2018
* Edit	date	:	
* Decription	:	lấy mã nhân viên
* Script name	:	NhanVien_GetMaNhanVien
************************************************************/
CREATE PROCEDURE NhanVien_GetMaNhanVien
AS
BEGIN
	DECLARE @MA INT
	DECLARE @MaNhanVien varchar(30)
	SET @MaNhanVien=(SELECT TOP 1 MaNhanVien FROM tblNhanVien ORDER BY CONVERT(INT,SUBSTRING(MaNhanVien,2,3)) desc)
	IF @MaNhanVien IS NULL
		SET @MA=1
	ELSE
		SET @MA=CONVERT(INT,SUBSTRING(@MaNhanVien,2,3)+1)
	SET @MaNhanVien= 'NV'+RIGHT('000'+CONVERT(VARCHAR,@MA),3)
	SELECT @MaNhanVien
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	27/08/2018
* Edit	date	:	08/10/2018
* Decription	:	LƯU THÔNG TIN NHÀ CUNG CẤP
* Script name	:	NhaCungCap_Add
************************************************************/
CREATE PROCEDURE [dbo].[NhaCungCap_Add]
	@NhaCungCap	nvarchar(200)	,
	@DiaChi	nvarchar(200)	,
	@SoDienThoai	varchar(50)	,
	@Email	varchar(200)	,
	@ThongTinThem	nvarchar(300)	,
	@NgayHopTac	date	,
	@CreateID	varchar(10)	,
	@CreateDate	int	,
	@NguoiLienHe nvarchar(150)
AS
BEGIN
	INSERT INTO tblNhaCungCap
	(NhaCungCap,DiaChi,SoDienThoai,Email,ThongTinThem,NgayHopTac,CreateID,CreateDate,NguoiLienHe)
	VALUES
	(@NhaCungCap,@DiaChi,@SoDienThoai,@Email,@ThongTinThem,@NgayHopTac,@CreateID,@CreateDate,@NguoiLienHe)
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	22/08/2018
* Edit	date	:	08/10/2018
* Decription	:	Thêm khách hàng
* Script name	:	KhachHang_Add
************************************************************/
CREATE PROCEDURE [dbo].[KhachHang_Add]
	@MaKhachHang varchar(50),
	@TenKhachHang	nvarchar(200),
	@DiaChi	nvarchar(300),
	@SDT	varchar(50),
	@ThongTinThem	nvarchar(200),
	@CreateID	INT,
	@CreateDate	INT,
	@CMT varchar(50),
	@NgaySinh INT
AS
BEGIN
	
	INSERT INTO dbo.tblKhachHang
	(MaKhachHang, TenKhachHang ,DiaChi ,SoDienThoai ,ThongTinThem ,CreateID ,CreateDate,CMT,NgaySinh)
	VALUES  
	(@MaKhachHang, @TenKhachHang,@DiaChi,@SDT,@ThongTinThem,@CreateID,@CreateDate,@CMT,@NgaySinh)
END
GO
/************************************************************
* Author		: 	Tran Phuong Thao
* Company		:	Phan Mem Ban Hang.
* Create date	: 	08/10/2018
* Edit	date	:	
* Decription	:	Lấy mã phiếu
* Script name	:	PhieuBanHang_GetMaPhieu '081018'
************************************************************/
CREATE PROCEDURE PhieuBanHang_GetMaPhieu
	@date varchar(30)
AS
BEGIN
	DECLARE @maphieu varchar(30)
	DECLARE @soPhieu int
	SET @maphieu=(SELECT TOP 1 MaPhieu FROM tblPhieuBanHang
	WHERE SUBSTRING(MaPhieu,1,8)='BH'+@date
	ORDER BY NgayBan DESC)
	IF	@maphieu is null
		set @soPhieu=1
	ELSE 
		SET @soPhieu=CONVERT(INT,RIGHT(@maphieu,3))+1
	SET @maphieu='BH'+@date+RIGHT('000'+CONVERT(VARCHAR,@soPhieu),3)
	SELECT @maphieu
END

