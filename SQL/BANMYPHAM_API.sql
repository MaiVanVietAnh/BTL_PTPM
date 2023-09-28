create database BANMYPHAM_API

use BANMYPHAM_API

create table LoaiSanPham(
MaLoai int Identity(1,1) not null primary key,
TenLoai nvarchar(50) not null

);

create table SanPham(
MaSanPham int IDENTITY(1,1) NOT NULL primary key,
MaLoai int,
TenSanPham nvarchar(250) not null,
Anh varchar(1000),
SoLuong int,
Mota ntext,
NgayTao datetime,
FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham (MaLoai) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table KhachHang(
MaKhachHang int identity(1,1) not null primary key,
TenKhachHang nvarchar(200),
SoDienThoai varchar(20),
DiaChi nvarchar(500),
Email varchar(50),
);

create table NhanVien(
MaNhanVien int identity(1,1) primary key not null,
TenNhanVien nvarchar(100),
SoDienThoai varchar(20),
DiaChi nvarchar(100), 
Email varchar(50),
);

create table NhaCungCap(
MaNhaCungCap int identity(1,1) not null primary key,
TenNhaCungCap nvarchar(200),
DiaChi nvarchar(200),
SoDienThoai varchar(20),
);

create table Slide(
MaSlide int identity(1,1) not null primary key,
Anh varchar(500),
Link varchar(500),
);


create table UserGroup(
MaUserGroup int identity(1,1) not null primary key,
TenQuyen nvarchar(50),

);

create table LienHe(
MaLienHe int identity(1,1) not null primary key,
Hoten nvarchar(100),
Sdt nchar(20),
Email varchar(100),
Diachi nvarchar(200),
Tieude nvarchar(500),
Noidung nvarchar(1000),
);

create table HoaDonNhap(
MaHoaDonNhap int identity(1,1) not null primary key,
MaNhaCungCap int,
NgayNhap datetime, 
ThanhTien float,

FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap (MaNhaCungCap) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table ChiTietHoaDonNhap(
MaChiTietHoaDonNhap int identity(1,1) not null primary key,
MaHoaDonNhap int,
MaSanPham int,
DonGia float,
SoLuong int,
FOREIGN KEY (MaHoaDonNhap) REFERENCES HoaDonNhap (MaHoaDonNhap) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table HoaDonBan(
MaHoaDonBan int identity(1,1) not null primary key,
MaKhachHang int,
NgayBan datetime,
ThanhTien float,
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang) ON DELETE CASCADE ON UPDATE CASCADE,

);
create table ChiTietHoaDonBan(
MaChiTietHoaDonBan int identity(1,1) not null primary key,
MaHoaDonBan int,
MaSanPham int,
SoLuong int, 
GiaBan float,
FOREIGN KEY (MaHoaDonBan) REFERENCES HoaDonBan (MaHoaDonBan) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,

);

create table ChiTietAnhSanPham(
MaChiTietAnhSanPham int identity(1,1) not null primary key,
MaSanPham int,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table DonHang(
MaDonHang int identity(1,1) not null primary key,
MaKhachHang int,
NgayDat datetime,
TrangThai bit,
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang) ON DELETE CASCADE ON UPDATE CASCADE,

);

create table ChiTietDonHang(
MaChiTietDonHang int identity(1,1) not null primary key,
MaDonHang int,
MaSanPham int,
SoLuong int, 
GiaBan float,
FOREIGN KEY (MaDonHang) REFERENCES DonHang (MaDonHang) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
);



create table TaiKhoan(
MaTaiKhoan int identity(1,1) not null primary key,
TaiKhoan varchar(100),
MatKhau varchar(100),
MaKhachHang int,
TrangThai bit,
MaUserGroup int,
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaUserGroup) REFERENCES UserGroup (MaUserGroup) ON DELETE CASCADE ON UPDATE CASCADE,
);


create table ThongSoSanPham(
MaThongSoKyThuat int identity(1,1) not null primary key,
MaSanPham int, 
Anh varchar(500),
ThuongHieu varchar(500),
XuatXuThuongHieu varchar(500),
ThanhPhan varchar(500),
CongDung varchar(500),
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
);
drop table ThongSoSanPham


create table BinhLuan(
MaBinhLuan int identity(1,1) not null primary key,
MaKhachHang int,
MaSanPham int,
NoiDung ntext,
NgayGio datetime,
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,

);

create table GiaBan(
MaGiaSanPham int identity(1,1) not null primary key,
MaSanPham int,
NgayBatDau datetime,
NgayKetThuc datetime,
Gia float,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
);

create table Kho(
MaKho int identity(1,1) not null primary key,
TenKho nvarchar(500),
DiaChi nvarchar(500),
);

create table ChiTietKho(
MaChiTietKho int identity(1,1) not null primary key,
MaSanPham int,
MaKho int,
SoLuong int,
FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (MaKho) REFERENCES Kho (MaKho) ON DELETE CASCADE ON UPDATE CASCADE,

);











INSERT INTO LoaiSanPham (TenLoai)
VALUES
  (N'Chăm sóc da mặt'),
  (N'Trang điểm'),
  (N'Nước hoa'),
  (N'Chăm sóc tóc'),
  (N'Thực phẩm chức năng'),

INSERT INTO SanPham(MaLoai, TenSanPham, Anh, SoLuong, Mota, NgayTao)
VALUES
    (1, N'Tẩy trang', 's21.jpg', 50, N'Làm sạch lớp trang điểm', '2023-08-01 09:00:00'),
    (2, N'Son Thỏi', 'dau-goi-c.jpg', 50, N'Son Thỏi 3CE Vỏ Trong Suốt Unstained Red - Đỏ Phấn 3.5g', '2023-08-10 11:30:00'),
    (3, N'Carolina Herrera', 'nuochoa.jpg', 60, N'Nước Hoa Nữ Carolina Herrera Very Good Girl EDP 30ml', '2023-09-10 14:15:00'),
    (4, N'Dầu gội C', 'dau-goi-c.jpg', 50, N'Dầu gội cho tóc mềm mượt', '2023-09-10 15:30:00'),
    (5, N'Vitamin/ Khoáng chất', 'vitamin.jpg', 25, N'Bổ sug vitamin', '2023-09-23 16:45:00');

INSERT INTO KhachHang (TenKhachHang, SoDienThoai, DiaChi, Email)
VALUES
    (N'Nguyễn Văn A', '0123456789', N'123 Đường ABC, Quận XYZ', 'nguyenvana@example.com'),
    (N'Trần Thị B', '0987654321', N'456 Đường DEF, Quận UVW', 'tranthib@example.com'),
    (N'Lê Minh C', '0365987412', N'789 Đường GHI, Quận RST', 'leminhc@example.com'),
    (N'Phạm Đức D', '0754623987', N'101 Đường JKL, Quận MNO', 'phamducd@example.com'),
    (N'Huỳnh Ngọc E', '0923456710', N'222 Đường PQR, Quận LMN', 'huynhngoce@example.com');
INSERT INTO NhanVien (TenNhanVien, SoDienThoai, DiaChi, Email)
VALUES
    (N'Nguyễn Văn Nam', '0123456789', N'123 Đường XYZ, Quận ABC', 'namnguyen@example.com'),
    (N'Trần Thị Hương', '0987654321', N'456 Đường UVW, Quận DEF', 'huongtran@example.com'),
    (N'Lê Minh Tâm', '0365987412', N'789 Đường RST, Quận GHI', 'tamle@example.com'),
    (N'Phạm Đức Hùng', '0754623987', N'101 Đường MNO, Quận JKL', 'hungho@example.com'),
    (N'Huỳnh Ngọc Trâm', '0923456710', N'222 Đường LMN, Quận PQR', 'tramhuynh@example.com');
INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SoDienThoai)
VALUES
    (N'Công ty A', N'123 Đường XYZ, Quận ABC', '0123456789'),
    (N'Công ty B', N'456 Đường UVW, Quận DEF', '0987654321'),
    (N'Công ty C', N'789 Đường RST, Quận GHI', '0365987412'),
    (N'Công ty D', N'101 Đường MNO, Quận JKL', '0754623987'),
    (N'Công ty E', N'222 Đường LMN, Quận PQR', '0923456710');
--Thủ tục--
--Loại san pham
create procedure lsp_getall
as
	begin
		select * from LoaiSanPham
	end;
go
lsp_getall

create procedure [dbo].[lsp_get-by-id](@MaLoai int)
as
	begin
		select *
		from LoaiSanPham
		Where MaLoai = @MaLoai
	end;
go


create procedure lsp_create(@TenLoai nvarchar(50))
as 
	begin
		INSERT INTO LoaiSanPham(TenLoai)
                VALUES (@TenLoai);
        SELECT '';
	end;
go 

create procedure lsp_update(
@MaLoai int,
@TenLoai nvarchar(50)
)
as
	begin
		Update  LoaiSanPham 
	  set  
	  TenLoai = IIf(@TenLoai is Null, TenLoai, @TenLoai)
	  Where MaLoai = @MaLoai
      
	  SELECT '';
    END;
go

create procedure lsp_delete(@MaLoai int)
as
	begin
		delete from LoaiSanPham
		where MaLoai = @MaLoai
	end;
go

--sản phẩm

ALTER PROCEDURE sanpham_create 
	
(@MaLoai int,
@TenSanPham nvarchar(250),
@Anh varchar(1000),
@SoLuong int,
@Mota ntext,
@MaSanPham int,
@KichCoManHinh varchar(500),
@DoPhanGiai varchar (500),
@LoaiManHinh varchar (500),
@HeDieuHanh varchar(500),
@ChatLieuChanDe   varchar(500),
@ChatLieuVienTiVi varchar(500)
)
as 
	begin
		Insert into SanPham(MaLoai, TenSanPham, Anh, SoLuong, MoTa, NgayTao )
		values (@MaLoai, @TenSanPham, @Anh, @SoLuong, @Mota, GETDATE());

		insert into ThongSoKyThuat(MaSanPham,KichCoManHinh,DoPhanGiai,LoaiManHinh,HeDieuHanh,ChatLieuChanDe, ChatLieuVienTiVi)
		values(IDENT_CURRENT('SanPham'), @KichCoManHinh, @DoPhanGiai,@LoaiManHinh,@HeDieuHanh,@ChatLieuChanDe,@ChatLieuVienTiVi);
	end;
go

ALTER PROCEDURE sanpham_update 
	
(@MaSanPham int,
@MaLoai int,
@TenSanPham nvarchar(250),
@Anh varchar(1000),
@SoLuong int,
@Mota ntext

)
as 
	begin
		Update  SanPham 
	  set  
	  MaLoai = IIf(@MaLoai is Null, MaLoai, @MaLoai),
	  TenSanPham = @TenSanPham,
	  Anh = IIf(@Anh is Null, Anh, @Anh),
	  SoLuong = IIf(@SoLuong is Null, SoLuong, @SoLuong),
	  Mota = IIF(@Mota is null, Mota, @Mota),
	  NgayTao = GETDATE()
	  Where MaSanPham = @MaSanPham
      
	  SELECT '';
    END;
go


CREATE PROCEDURE sanpham_delete
(@MaSanPham int)
as
	begin
		Delete from SanPham
		where MaSanPham = @MaSanPham
	end;
go


-- sản phẩm mới về
alter PROCEDURE sanpham_moinhat
(@Soluong int)
AS
BEGIN
    SELECT TOP(@Soluong) sp.MaSanPham ,sp.TenSanPham, g.Gia, tskt.KichCoManHinh, tskt.DoPhanGiai 
    FROM SanPham as sp inner join GiaBan as g on sp.MaSanPham = g.MaSanPham inner join ThongSoKyThuat as tskt on sp.MaSanPham = tskt.MaSanPham 
    ORDER BY NgayTao desc
END	
sanpham_moinhat @Soluong = '8'



--sản phẩm bán chạy
alter procedure sanpham_banchay
(@soluong int)
as
	begin
		select top (@soluong) sp.MaSanPham, sp.TenSanPham, sp.Anh, sum(cthdb.SoLuong) as SoLuongDaBan , g.Gia,tskt.KichCoManHinh, tskt.DoPhanGiai 
		from SanPham as sp inner join ChiTietHoaDonBan as cthdb on sp.MaSanPham = cthdb.MaSanPham  inner join GiaBan as g on sp.MaSanPham = g.MaSanPham inner join ThongSoKyThuat as tskt on sp.MaSanPham = tskt.MaSanPham 
		group by sp.MaSanPham, sp.TenSanPham, sp.Anh, g.Gia,tskt.KichCoManHinh, tskt.DoPhanGiai 
		order by SoLuongDaBan desc
	end;
go
sanpham_banchay 3

--sản phẩm nhiều người mua
alter procedure sanpham_oder
(@Sl int)
as 
	begin
		select top (@Sl) sp.MaSanPham, sp.TenSanPham, g.Gia, 
		SUM(dh.Soluong) as SoLuongDatHang ,tskt.KichCoManHinh, tskt.DoPhanGiai
		from SanPham as sp inner join ChiTietDonHang as dh on sp.MaSanPham = dh.MaSanPham inner join GiaBan as g on sp.MaSanPham = g.MaSanPham inner join ThongSoKyThuat as tskt on sp.MaSanPham = tskt.MaSanPham 
		group by sp.MaSanPham, sp.TenSanPham,g.gia,tskt.KichCoManHinh, tskt.DoPhanGiai
		order by sum(dh.Soluong) desc 
	end;
go
sanpham_oder 8

--All Slider
create procedure slide_getall
as
	begin
		select * from Slide
	end
go



-- lấy sản phẩm theo mã san pham
alter procedure sanpham_get_by_id
(@MaSanPham int)
as
begin
	Select * 
		from SanPham 
		where MaSanPham =@MaSanPham
end;
go
sanpham_get_by_id 2

-- lấy sản phẩm theo loại san pham
alter procedure sanpham_theoloai
(@MaLoai int)
as
	begin
		Select sp.MaSanPham .TenSanPham, sp.Anh,sp.Mota, ts.KichCoManHinh, ts.DoPhanGiai,ts.LoaiManHinh,ts.HeDieuHanh,ts.ChatLieuChanDe,ts.ChatLieuVienTiVi,g.Gia
		from SanPham as sp inner join ThongSoKyThuat as ts 
		on sp.MaSanPham = ts.MaSanPham inner join GiaBan as g 
		on sp.MaSanPham=g.MaSanPham
		where MaLoai = @MaLoai
	end;
go
sanpham_theoloai 4

-- lấy ra tất cả san pham
create procedure sanpham_getAll
as
	begin
		select * from SanPham
	end;
go
 sanpham_getAll

 -- tim kiem san pham 
create procedure sanpham_search
(@page_index  INT  = 1, 
@page_size   INT   = 10,
@TenSanPham Nvarchar(250)   = null,
@MaSanPham int  = null,
@TenLoai Nvarchar(250) = null,
@option varchar(50)  = null,
@FromPrice float =  null,
@ToPrice float = null
)
as
	begin
		DECLARE @RecordCount BIGINT;
        IF(@page_size <> 0) --nếu page_size != 0
            BEGIN
                SET NOCOUNT ON;
                        SELECT(ROW_NUMBER() OVER( --ROW_NUMBER()nghĩa là gán một con số tăng tuần tự cho mỗi bản ghi theo thứ tự của Tendanhmuc, bắt đầu từ 1. 
                              ORDER BY 
							  CASE 
							       WHEN  @option = 'TEN' THEN sp.TenSanPham
							  END ASC)) AS RowNumber, 
								sp.MaSanPham,
							   sp.MaLoai,
							   sp.TenSanPham,
							   sp.Anh,
							   sp.SoLuong,
							   sp.Mota
                        INTO #Results1
                        FROM SanPham AS sp left join GiaBan as gb on sp.MaSanPham = gb.MaSanPham
						inner join LoaiSanPham as lsp on lsp.MaLoai = sp.MaLoai

					    WHERE  (@TenSanPham is null Or sp.TenSanPham like N'%'+@TenSanPham+'%') and						
						(@MaSanPham is null or sp.MaSanPham = @MaSanPham) and
						(@TenLoai is null or lsp.TenLoai like N'%'+@TenLoai+'%') and
						(@FromPrice is null or @ToPrice is null  Or (gb.Gia >= @FromPrice and gb.Gia <= @ToPrice));



                        SELECT @RecordCount = COUNT(*)
                        FROM #Results1;

                        SELECT *, 
                               @RecordCount AS RecordCount
                        FROM #Results1
                        WHERE ROWNUMBER BETWEEN(@page_index - 1) * @page_size + 1 AND(((@page_index - 1) * @page_size + 1) + @page_size) - 1
                              OR @page_index = -1;
                        DROP TABLE #Results1; 
						
            END;
		ELSE
            BEGIN
                SET NOCOUNT ON;
                        SELECT(ROW_NUMBER() OVER( --ROW_NUMBER()nghĩa là gán một con số tăng tuần tự cho mỗi bản ghi theo thứ tự của Tendanhmuc, bắt đầu từ 1. 
                              ORDER BY 
							  CASE 
							       WHEN  @option = 'TEN' THEN sp.TenSanPham
							  END ASC)) AS RowNumber, 
								sp.MaSanPham,
							   sp.MaLoai,
							   sp.TenSanPham,
							   sp.Anh,
							   sp.SoLuong,
							   sp.Mota
                        INTO #Results2
                        FROM SanPham AS sp left join GiaBan as gb on sp.MaSanPham = gb.MaSanPham
						inner join LoaiSanPham as lsp on lsp.MaLoai = sp.MaLoai

					    WHERE  (@TenSanPham is null Or sp.TenSanPham like N'%'+@TenSanPham+'%') and						
						(@MaSanPham is null or sp.MaSanPham = @MaSanPham) and
						(@TenLoai is null or lsp.TenLoai like N'%'+@TenLoai+'%') and
						(@FromPrice is null or @ToPrice is null  Or (gb.Gia >= @FromPrice and gb.Gia <= @ToPrice));
                     
                        SELECT @RecordCount = COUNT(*)
                        FROM #Results2;
                        SELECT *, 
                               @RecordCount AS RecordCount
                        FROM #Results2;
                        DROP TABLE #Results2;
        END;
    END;
GO

sanpham_search @page_index = 1, @page_size = 10,@FromPrice = 9000000, @ToPrice = 15000000
sanpham_search @page_index = 1, @page_size = 10,@TenLoai='s'
sanpham_search @page_index = 1, @page_size = 10,@TenSanPham='tivi sony '
