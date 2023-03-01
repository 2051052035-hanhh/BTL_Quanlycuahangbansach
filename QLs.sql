CREATE DATABASE QLS
USE QLS
DROP DATABASE QLS
--TẠO BẢNG NHÂN VIÊN
CREATE TABLE NHANVIEN(
MANHANVIEN CHAR(10) NOT NULL PRIMARY KEY,
MATKHAU VARCHAR(20) NOT NULL,
HOTEN NVARCHAR(100) NOT NULL,
NGAYSINH DATE NOT NULL,
GIOITINH BIT NOT NULL ,
DIACHI NVARCHAR(100) NOT NULL,
SODIENTHOAI VARCHAR(20),
NGAYVAOLAM DATE NOT NULL,
CHUCVU NVARCHAR(20),
);

INSERT INTO NHANVIEN
VALUES 
('NV01','123456',N'Nguyễn Thị Nụ','10/11/2000',1,N'Đống Đa-Hà Nội','0973287666','11/9/2020',N'QUẢN LÝ'),
('NV02','123456',N'Trần Văn Sang','1/1/2000',0,N'Thanh Trì-Hà Nội','0972873536','11/11/2020',N'NHÂN VIÊN'),
('NV03','123456',N'Trần Tuấn Anh','1/20/2001',0,N'Hoàn Kiếm-Hà Nội','0273347611','11/1/2021',N'NHÂN VIÊN'),
('NV04','123456',N'Nguyễn Thế Anh','3/2/1999',0,N'Nam Từ Liêm- Hà Nội','0273287666','11/2/2021',N'NHÂN VIÊN'),
('NV05','123456',N'Lê Thị Thúy','1/2/2001',1,N'Cầu Giấy- Hà Nội','0973287999','11/12/2021',N'NHÂN VIÊN');

--TẠO BẢNG THELOAI
CREATE TABLE THELOAI
(
MATL CHAR(10) NOT NULL PRIMARY KEY,
TENTL NVARCHAR(50),
)
INSERT INTO THELOAI
VALUES 
('TL01',N'TRUYỆN NGẮN'),
('TL02',N'THƠ'),
('TL03',N'TRINH THÁM'),
('TL04',N'TRUYỆN TRANH'),
('TL05',N'SÁCH THIẾU NHI')

--TẠO BẢNG TACGIA
CREATE TABLE TACGIA
(
MATG CHAR(10) NOT NULL PRIMARY KEY,
TENTG NVARCHAR(50),
)
INSERT INTO TACGIA
VALUES 
('TG01',N'TÔ HOÀI'),
('TG02',N'NGUYỄN TÙNG'),
('TG03',N'ROBERT ASERTORIS'),
('TG04',N'HỒ CHÍ MINH'),
('TG05',N'ƠN TÙNG')

--TẠO BẢNG SACH
CREATE TABLE SACH
(
MASACH CHAR(10) NOT NULL PRIMARY KEY,
TENSACH NVARCHAR(50),
MATL CHAR(10),
MATG CHAR(10),
NXB NVARCHAR(50),
NAMXB INT,
GIA INT,
 FOREIGN KEY (MATL) REFERENCES THELOAI(MATL),
 FOREIGN KEY (MATG) REFERENCES TACGIA(MATG),
);
INSERT INTO SACH
VALUES
('S01',N'DẾ MÈN PHIÊU LƯU KÝ','TL01', 'TG01',N'KIM ĐỒNG',2020,50000),
('S02',N'BÚP SEN XANH','TL01', 'TG05',N'KIM ĐỒNG',2020,50000),
('S03',N'NHẬT KÝ TRONG TÙ','TL02', N'TG04',N'KIM ĐỒNG',2020,50000),
('S04',N'THƠ TÌNH','TL02', N'TG02',N'KIM ĐỒNG',2020,50000),
('S05',N'THƠ',N'TL02', N'TG02',N'KIM ĐỒNG',2020,50000);


--TẠO BẢNG KHACHHANG
CREATE TABLE KHACHHANG(
MAKHACH CHAR(10) NOT NULL PRIMARY KEY,
HOTEN NVARCHAR(100) NOT NULL,
DIENTHOAI VARCHAR(15),
);

INSERT INTO KHACHHANG
VALUES
('K01',N'Lê Đức Sơn','0987654699'),
('K02',N'Lê Đức Hòa','0987654677'),
('K03',N'Lê Đức Tú','0987654678'),
('K04',N'Đình Anh Tú','0987654666'),
('K05',N'Trần Anh Tân','0987654622');



--TẠO BẢNG THANHTOANHD
CREATE TABLE PHIEUHOADON(
SHD CHAR(10) NOT NULL PRIMARY KEY,
MANHANVIEN CHAR(10) NOT NULL,
MAKHACH CHAR(10) NOT NULL,
NGAYLAP DATE NOT NULL,
TONGTIEN INT,
CONSTRAINT FK_MANV_SHD FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN),
CONSTRAINT FK_MAK_SHD FOREIGN KEY (MAKHACH) REFERENCES KHACHHANG(MAKHACH),
);

INSERT INTO PHIEUHOADON
VALUES
('SHD01','NV01','K01','2/2/2023',900000),
('SHD02','NV01','K02','2/3/2023',900000),
('SHD03','NV02','K03','2/4/2023',900000),
('SHD04','NV03','K03','2/5/2023',900000),
('SHD05','NV01','K01','2/6/2023',900000);

CREATE TABLE CHITIETHOADON
(
SHD CHAR(10) NOT NULL,
MASACH CHAR(10) NOT NULL,
SOLUONG INT,
PRIMARY KEY(MASACH, SHD),
FOREIGN KEY (SHD) REFERENCES PHIEUHOADON(SHD),
FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
);
INSERT INTO CHITIETHOADON
VALUES
('SHD01','S01',10),
('SHD01','S02',8),
('SHD02','S02',18),
('SHD03','S02',18),
('SHD04','S02',18),
('SHD05','S02',18);






-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--Tạo thủ tục đăng nhập cho nhân viên sp_check_login

DROP PROC IF EXISTS sp_check_login
GO
CREATE PROC sp_check_login (@manv CHAR(10), @pass VARCHAR(20)) AS
BEGIN
SELECT MANHANVIEN, HOTEN FROM NHANVIEN WHERE MANHANVIEN = @manv AND MATKHAU = @pass
END
GO
---xóa nhân viên
DROP PROC IF EXISTS sp_ins_NV
GO
CREATE PROC sp_ins_NV @option INT, @MSNV CHAR(10), @HOTENNV NVARCHAR(100), @MatKhau CHAR(20), @NGAYSINHNV DATE, @GIOITINHNV BIT, @DIACHINV NVARCHAR(100),@CHUCVU NVARCHAR(20), @DIENTHOAINV VARCHAR(20), @NGAYVAOLAM DATE
AS
BEGIN
    IF(@option = 1)
    BEGIN
        INSERT INTO NHANVIEN VALUES(@MSNV, @MatKhau, @HOTENNV, @NGAYSINHNV, @GIOITINHNV, @DIACHINV, @DIENTHOAINV, @NGAYVAOLAM, @CHUCVU)
    END
    ELSE IF(@option = 2)
    BEGIN
        UPDATE NHANVIEN SET MANHANVIEN = @MSNV, MATKHAU = @MatKhau, HOTEN = @HOTENNV, NGAYSINH = @NGAYSINHNV, GIOITINH = @GIOITINHNV, DIACHI = @DIACHINV, SODIENTHOAI = @DIENTHOAINV, NGAYVAOLAM = @NGAYVAOLAM, CHUCVU = @CHUCVU WHERE MANHANVIEN = @MSNV
    END
    ELSE
    BEGIN
        DELETE NHANVIEN WHERE MANHANVIEN = @MSNV
    END
END
GO
----Tạo thủ tục xóa nhan vien
DROP PROC IF EXISTS sp_del_NhanVien
GO
CREATE PROCEDURE sp_del_NhanVien @MSNV CHAR (10)		
AS
	BEGIN
        DELETE NHANVIEN WHERE MANHANVIEN = @MSNV
    END

GO
----Tạo thủ tục xóa sách
DROP PROC IF EXISTS sp_del_sach
GO
CREATE PROCEDURE sp_del_sach @MASACH CHAR (10)		
AS
	BEGIN
        DELETE SACH WHERE MASACH = @MASACH
    END

GO

----Tạo thủ tục xóa khách hàng
DROP PROC IF EXISTS sp_del_khach
GO
CREATE PROCEDURE sp_del_khach @MAKHACH CHAR (10)		
AS
	BEGIN
        DELETE KHACHHANG WHERE MAKHACH = @MAKHACH
    END

GO

----Tạo thủ tục sửa hoặc chèn sách
DROP PROC IF EXISTS sp_ins_sach
GO
CREATE procedure sp_ins_sach
	@option 		char(1),
	@MASACH		char(10),
	@TENSACH		nvarchar(50),
	@MATL			char(10),
	@MATG CHAR(10),
	@NXB NVARCHAR(50),
	@NAMXB INT,
	@GIA		money
	as
	begin
	if (@option=1)
		insert into SACH(MASACH,TENSACH,MATL, MATG,NXB, NAMXB, GIA) values (@MASACH,@TENSACH,@MATL,@MATG,@NXB,@NAMXB, @GIA)
	else if (@option=2)
		Update SACH 	set TENSACH = @TENSACH, MATL=@MATL, MATG=@MATG, NXB=@NXB , NAMXB=@NAMXB, GIA=@GIA  WHERE MASACH=@MASACH
	END
GO
--thủ tục sửa hoặc thêm khách 
DROP PROC IF EXISTS sp_ins_khach
GO
CREATE procedure sp_ins_khach
	@option 		char(1),
	@MAKHACH	char(10),
	@HOTEN		nvarchar(50),
	@SDT CHAR(11)

	as
	begin
	if (@option=1)
		insert into KHACHHANG(MAKHACH,HOTEN,DIENTHOAI) values (@MAKHACH,@HOTEN,@SDT)
	else if (@option=2)
		Update KHACHHANG	set HOTEN = @HOTEN, DIENTHOAI=@SDT WHERE MAKHACH=@MAKHACH
	END
GO
--sp_list_NV: thủ tục in ra màn hình thông tin bảng NHANVIEN
DROP PROC IF EXISTS sp_list_NV
GO
CREATE PROC sp_list_NV
AS
BEGIN 
    SELECT * FROM NHANVIEN
END
GO
EXEC sp_list_NV
--sp_list_NV: thủ tục in ra màn hình thông tin bảng sách
DROP PROC IF EXISTS sp_list_sach
GO
CREATE PROC sp_list_sach
AS
BEGIN 
    SELECT * FROM SACH
END
GO
EXEC sp_list_NV
--thủ tục in ra dang sách khách hàng
DROP PROC IF EXISTS sp_list_KH
GO
CREATE PROC sp_list_KH
AS
BEGIN 
    SELECT * FROM KHACHHANG
END
GO
EXEC sp_list_KH
--thủ tục sửa hoặc thêm thể loại
DROP PROC IF EXISTS sp_ins_theloai
GO
CREATE procedure sp_ins_theloai
	@option 		char(1),
	@MATHELOAI	char(10),
	@TENTHELOAI		nvarchar(50)


	as
	begin
	if (@option=1)
		insert into THELOAI(MATL,TENTL) values (@MATHELOAI,@TENTHELOAI)
	else if (@option=2)
		Update THELOAI	set TENTL = @TENTHELOAI WHERE MATL=@MATHELOAI
	END
GO
--thủ tục in ra dang sách thể loại
DROP PROC IF EXISTS sp_list_theloai
GO
CREATE PROC sp_list_theloai
AS
BEGIN 
    SELECT * FROM THELOAI
END
GO
EXEC sp_list_theloai
----Tạo thủ tục xóa thể loại
DROP PROC IF EXISTS sp_del_theloai
GO
CREATE PROCEDURE sp_del_theloai @MATHELOAI CHAR (10)		
AS
	BEGIN
        DELETE THELOAI WHERE MATL = @MATHELOAI
    END

GO


--thủ tục sửa hoặc thêm thể loại
DROP PROC IF EXISTS sp_ins_tacgia
GO
CREATE procedure sp_ins_tacgia
	@option 		char(1),
	@MATG	char(10),
	@TENTG		nvarchar(50)


	as
	begin
	if (@option=1)
		insert into TACGIA(MATG,TENTG) values (@MATG,@TENTG)
	else if (@option=2)
		Update TACGIA	set TENTG = @TENTG WHERE MATG=@MATG
	END
GO
--thủ tục in ra dang sách thể loại
DROP PROC IF EXISTS sp_list_tacgia
GO
CREATE PROC sp_list_tacgia
AS
BEGIN 
    SELECT * FROM TACGIA
END
GO

----Tạo thủ tục xóa tác giả
DROP PROC IF EXISTS sp_del_tacgia
GO
CREATE PROCEDURE sp_del_tacgia @MATG CHAR (10)		
AS
	BEGIN
        DELETE TACGIA WHERE MATG = @MATG
    END

GO


--thủ tục sửa hoặc thêm thể loại
DROP PROC IF EXISTS sp_ins_tacgia
GO
CREATE procedure sp_ins_tacgia
	@option 		char(1),
	@MATG	char(10),
	@TENTG		nvarchar(50)


	as
	begin
	if (@option=1)
		insert into TACGIA(MATG,TENTG) values (@MATG,@TENTG)
	else if (@option=2)
		Update TACGIA	set TENTG = @TENTG WHERE MATG=@MATG
	END
GO
--thủ tục in ra dang sách hóa đơn
DROP PROC IF EXISTS sp_list_hoadon
GO
CREATE PROC sp_list_hoadon
AS
BEGIN 
    SELECT * FROM PHIEUHOADON
END
GO

--thủ tục sửa hoặc thêm hóa đơn
DROP PROC IF EXISTS sp_ins_hoadon
GO
CREATE procedure sp_ins_hoadon
	@option 		char(1),
	@SHD	char(10),
	@MAK		nvarchar(50),
	@MANV CHAR(10),
	@NGAYLAP DATE,
	@TONGTIEN MONEY



	as
	begin
	if (@option=1)
		insert into PHIEUHOADON(SHD,MANHANVIEN, MAKHACH, NGAYLAP,TONGTIEN) values (@SHD,@MANV, @MAK, @NGAYLAP, @TONGTIEN)
	else if (@option=2)
		Update PHIEUHOADON	set MAKHACH = @MAK, TONGTIEN = @TONGTIEN WHERE SHD = @SHD 
	END
GO