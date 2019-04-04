create database QLVeMayBay
go
use QLVeMayBay
go

create table HangHangKhong(
	MaHang varchar(4) primary key not null,
	TenHang nvarchar(50) not null
)
go

insert into HangHangKhong values ('H001','VietJet Air')
insert into HangHangKhong values ('H002','VietNam AirLine')
insert into HangHangKhong values ('H003','Bamboo Airways')
insert into HangHangKhong values ('H004','Jetstar')
go

create table SoDoGhe(
	MaSoDo varchar(4) primary key not null,
	SLDayGhe int ,
	SLGheMoiDay int ,
)
go

insert into SoDoGhe values ('SD01',5,4)
insert into SoDoGhe values ('SD02',5,4)
insert into SoDoGhe values ('SD03',5,4)
insert into SoDoGhe values ('SD04',5,4)
insert into SoDoGhe values ('SD05',5,4)
go

create table MayBay(
	MaMayBay varchar(4) primary key not null,
	MaHang varchar(4) foreign key references HangHangKhong(MaHang),
	MaSoDo varchar(4) foreign key references SoDoGhe(MaSoDo),
	TenMayBay nvarchar(50) not null,
)
go

insert into MayBay values ('MB01','H001','SD01',N'Máy bay 1')
insert into MayBay values ('MB02','H002','SD01',N'Máy bay 2')
insert into MayBay values ('MB03','H003','SD01',N'Máy bay 3')
insert into MayBay values ('MB04','H004','SD01',N'Máy bay 4')
insert into MayBay values ('MB05','H001','SD01',N'Máy bay 5')
insert into MayBay values ('MB06','H002','SD01',N'Máy bay 6')
go

create table Ghe(
	MaSoDo varchar(4) foreign key references SoDoGhe(MaSoDo),
	MaGhe varchar(4) primary key not null,
	TinhTrangGhe nvarchar(20), 
)
go

insert into Ghe values ('SD01','A001',N'Đã đặt')
insert into Ghe values ('SD01','A002',N'Chưa đặt')
insert into Ghe values ('SD01','A003',N'Chưa đặt')
insert into Ghe values ('SD01','A004',N'Chưa đặt')
insert into Ghe values ('SD01','B001',N'Chưa đặt')
insert into Ghe values ('SD01','B002',N'Chưa đặt')
insert into Ghe values ('SD01','B003',N'Chưa đặt')
insert into Ghe values ('SD01','B004',N'Chưa đặt')
insert into Ghe values ('SD01','C001',N'Đã đặt')
insert into Ghe values ('SD01','C002',N'Chưa đặt')
insert into Ghe values ('SD01','C003',N'Chưa đặt')
insert into Ghe values ('SD01','C004',N'Chưa đặt')
insert into Ghe values ('SD01','D001',N'Chưa đặt')
insert into Ghe values ('SD01','D002',N'Chưa đặt')
insert into Ghe values ('SD01','D003',N'Chưa đặt')
insert into Ghe values ('SD01','D004',N'Chưa đặt')
insert into Ghe values ('SD01','E001',N'Chưa đặt')
insert into Ghe values ('SD01','E002',N'Chưa đặt')
insert into Ghe values ('SD01','E003',N'Chưa đặt')
insert into Ghe values ('SD01','E004',N'Chưa đặt')

--insert into Ghe values ('SD02','A001',N'Chưa đặt')
--insert into Ghe values ('SD02','A002',N'Chưa đặt')
--insert into Ghe values ('SD02','A003',N'Chưa đặt')
--insert into Ghe values ('SD02','A004',N'Chưa đặt')
--insert into Ghe values ('SD02','B001',N'Chưa đặt')
--insert into Ghe values ('SD02','B002',N'Chưa đặt')
--insert into Ghe values ('SD02','B003',N'Chưa đặt')
--insert into Ghe values ('SD02','B004',N'Chưa đặt')
--insert into Ghe values ('SD02','C001',N'Chưa đặt')
--insert into Ghe values ('SD02','C002',N'Chưa đặt')
--insert into Ghe values ('SD02','C003',N'Chưa đặt')
--insert into Ghe values ('SD02','C004',N'Chưa đặt')
--insert into Ghe values ('SD02','D001',N'Chưa đặt')
--insert into Ghe values ('SD02','D002',N'Chưa đặt')
--insert into Ghe values ('SD02','D003',N'Chưa đặt')
--insert into Ghe values ('SD02','D004',N'Chưa đặt')
--insert into Ghe values ('SD02','E001',N'Chưa đặt')
--insert into Ghe values ('SD02','E002',N'Chưa đặt')
--insert into Ghe values ('SD02','E003',N'Chưa đặt')
--insert into Ghe values ('SD02','E004',N'Chưa đặt')

--insert into Ghe values ('SD03','A001',N'Chưa đặt')
--insert into Ghe values ('SD03','A002',N'Chưa đặt')
--insert into Ghe values ('SD03','A003',N'Chưa đặt')
--insert into Ghe values ('SD03','A004',N'Chưa đặt')
--insert into Ghe values ('SD03','B001',N'Chưa đặt')
--insert into Ghe values ('SD03','B002',N'Chưa đặt')
--insert into Ghe values ('SD03','B003',N'Chưa đặt')
--insert into Ghe values ('SD03','B004',N'Chưa đặt')
--insert into Ghe values ('SD03','C001',N'Chưa đặt')
--insert into Ghe values ('SD03','C002',N'Chưa đặt')
--insert into Ghe values ('SD03','C003',N'Chưa đặt')
--insert into Ghe values ('SD03','C004',N'Chưa đặt')
--insert into Ghe values ('SD03','D001',N'Chưa đặt')
--insert into Ghe values ('SD03','D002',N'Chưa đặt')
--insert into Ghe values ('SD03','D003',N'Chưa đặt')
--insert into Ghe values ('SD03','D004',N'Chưa đặt')
--insert into Ghe values ('SD03','E001',N'Chưa đặt')
--insert into Ghe values ('SD03','E002',N'Chưa đặt')
--insert into Ghe values ('SD03','E003',N'Chưa đặt')
--insert into Ghe values ('SD03','E004',N'Chưa đặt')

--insert into Ghe values ('SD04','A001',N'Chưa đặt')
--insert into Ghe values ('SD04','A002',N'Chưa đặt')
--insert into Ghe values ('SD04','A003',N'Chưa đặt')
--insert into Ghe values ('SD04','A004',N'Chưa đặt')
--insert into Ghe values ('SD04','B001',N'Chưa đặt')
--insert into Ghe values ('SD04','B002',N'Chưa đặt')
--insert into Ghe values ('SD04','B003',N'Chưa đặt')
--insert into Ghe values ('SD04','B004',N'Chưa đặt')
--insert into Ghe values ('SD04','C001',N'Chưa đặt')
--insert into Ghe values ('SD04','C002',N'Chưa đặt')
--insert into Ghe values ('SD04','C003',N'Chưa đặt')
--insert into Ghe values ('SD04','C004',N'Chưa đặt')
--insert into Ghe values ('SD04','D001',N'Chưa đặt')
--insert into Ghe values ('SD04','D002',N'Chưa đặt')
--insert into Ghe values ('SD04','D003',N'Chưa đặt')
--insert into Ghe values ('SD04','D004',N'Chưa đặt')
--insert into Ghe values ('SD04','E001',N'Chưa đặt')
--insert into Ghe values ('SD04','E002',N'Chưa đặt')
--insert into Ghe values ('SD04','E003',N'Chưa đặt')
--insert into Ghe values ('SD04','E004',N'Chưa đặt')

--insert into Ghe values ('SD05','A001',N'Chưa đặt')
--insert into Ghe values ('SD05','A002',N'Chưa đặt')
--insert into Ghe values ('SD05','A003',N'Chưa đặt')
--insert into Ghe values ('SD05','A004',N'Chưa đặt')
--insert into Ghe values ('SD05','B001',N'Chưa đặt')
--insert into Ghe values ('SD05','B002',N'Chưa đặt')
--insert into Ghe values ('SD05','B003',N'Chưa đặt')
--insert into Ghe values ('SD05','B004',N'Chưa đặt')
--insert into Ghe values ('SD05','C001',N'Chưa đặt')
--insert into Ghe values ('SD05','C002',N'Chưa đặt')
--insert into Ghe values ('SD05','C003',N'Chưa đặt')
--insert into Ghe values ('SD05','C004',N'Chưa đặt')
--insert into Ghe values ('SD05','D001',N'Chưa đặt')
--insert into Ghe values ('SD05','D002',N'Chưa đặt')
--insert into Ghe values ('SD05','D003',N'Chưa đặt')
--insert into Ghe values ('SD05','D004',N'Chưa đặt')
--insert into Ghe values ('SD05','E001',N'Chưa đặt')
--insert into Ghe values ('SD05','E002',N'Chưa đặt')
--insert into Ghe values ('SD05','E003',N'Chưa đặt')
--insert into Ghe values ('SD05','E004',N'Chưa đặt')
go
create table TuyenBay(
	MaTuyenBay varchar(4) primary key not null,
	SanBayDi nvarchar(20) ,
	SanBayDen nvarchar(20),
)
go

insert into TuyenBay values ('TB01',N'Tân Sơn Nhất',N'Nội Bài')
insert into TuyenBay values ('TB02',N'Tân Sơn Nhất',N'Quảng Nam')
insert into TuyenBay values ('TB03',N'Tân Sơn Nhất',N'Quảng Bình')
insert into TuyenBay values ('TB04',N'Tân Sơn Nhất',N'Phú Yên')

insert into TuyenBay values ('TB05',N'Nội Bài',N'Tân Sơn Nhất')
insert into TuyenBay values ('TB06',N'Nội Bài',N'Quảng Nam')
insert into TuyenBay values ('TB07',N'Nội Bài',N'Quảng Bình')
insert into TuyenBay values ('TB08',N'Nội Bài',N'Phú Yên')

insert into TuyenBay values ('TB09',N'Quảng Nam',N'Tân Sơn Nhất')
insert into TuyenBay values ('TB10',N'Quảng Nam',N'Quảng Bình')
insert into TuyenBay values ('TB11',N'Quảng Nam',N'Nội Bài')
insert into TuyenBay values ('TB12',N'Quảng Nam',N'Phú Yên')

insert into TuyenBay values ('TB13',N'Quảng Bình ',N'Tân Sơn Nhất')
insert into TuyenBay values ('TB14',N'Quảng Bình ',N'Quảng Nam')
insert into TuyenBay values ('TB15',N'Quảng Bình ',N'Nội Bài')
insert into TuyenBay values ('TB16',N'Quảng Bình ',N'Phú Yên')

insert into TuyenBay values ('TB17',N'Phú Yên',N'Quảng Nam')
insert into TuyenBay values ('TB18',N'Phú Yên',N'Quảng Bình')
insert into TuyenBay values ('TB19',N'Phú Yên',N'Nội Bài')
insert into TuyenBay values ('TB20',N'Phú Yên',N'Tân Sơn Nhất')
go

create table ChuyenBay(
	MaChuyenBay varchar(4) primary key not null,
	MaTuyenBay varchar(4) foreign key references TuyenBay(MaTuyenBay),
	MaMayBay varchar(4) foreign key references MayBay(MaMayBay),
	NgayKhoiHanh date ,
	NgayDen date,
	GioDi time,
	GioDen time,
	TongTien int ,
	check(NgayKhoiHanh <= NgayDen)
)
go

insert into ChuyenBay values ('CB01','TB01','MB01','2018-11-11','2018-11-11','07:30','08:30',1000000)
insert into ChuyenBay values ('CB02','TB02','MB02','2018-11-11','2018-11-11','07:00','08:00',1500000)
insert into ChuyenBay values ('CB03','TB03','MB03','2018-11-11','2018-11-11','09:30','10:00',3000000)
insert into ChuyenBay values ('CB04','TB04','MB04','2018-11-11','2018-11-11','09:00','09:30',2100000)

insert into ChuyenBay values ('CB05','TB05','MB05','2018-11-12','2018-11-12','07:30','08:30',1700000)
insert into ChuyenBay values ('CB06','TB06','MB06','2018-11-12','2018-11-12','08:00','08:30',2500000)
insert into ChuyenBay values ('CB07','TB07','MB02','2018-11-12','2018-11-12','09:30','10:30',3000000)
insert into ChuyenBay values ('CB08','TB08','MB02','2018-11-12','2018-11-12','07:00','08:30',2800000)

insert into ChuyenBay values ('CB09','TB09','MB03','2018-11-13','2018-11-13','07:00','08:30',2800000)
insert into ChuyenBay values ('CB10','TB10','MB04','2018-11-13','2018-11-13','07:00','07:30',2800000)
insert into ChuyenBay values ('CB11','TB11','MB05','2018-11-13','2018-11-13','08:30','09:00',2800000)
insert into ChuyenBay values ('CB12','TB12','MB06','2018-11-13','2018-11-13','15:00','16:00',1500000)

insert into ChuyenBay values ('CB13','TB13','MB01','2018-11-14','2018-11-14','07:30','08:30',1000000)
insert into ChuyenBay values ('CB14','TB14','MB02','2018-11-14','2018-11-14','07:00','08:30',1500000)
insert into ChuyenBay values ('CB15','TB15','MB03','2018-11-14','2018-11-14','15:30','16:00',3000000)
insert into ChuyenBay values ('CB16','TB16','MB04','2018-11-14','2018-11-14','15:00','16:00',2100000)

insert into ChuyenBay values ('CB17','TB17','MB05','2018-11-15','2018-11-15','07:30','08:30',1700000)
insert into ChuyenBay values ('CB18','TB18','MB06','2018-11-15','2018-11-15','07:00','08:00',2500000)
insert into ChuyenBay values ('CB19','TB19','MB01','2018-11-15','2018-11-15','15:00','16:00',3000000)
insert into ChuyenBay values ('CB20','TB20','MB02','2018-11-15','2018-11-15','16:00','16:30',2800000)
go

create table KhachHang(
	CMND int primary key not null,
	TenKH nvarchar(50) not null,
	GioiTinh nvarchar(4) check(GioiTinh in (N'Nam',N'Nữ',N'Khác')) not null,
	DiaChi nvarchar(100) not null,
	Email varchar(50) ,
	SDT varchar(11),
)
go

insert into KhachHang values(206144301,N'Nguyễn Huy Đức','Nam',N'Quảng Nam','huyduc@email.com','0123456789')
insert into KhachHang values(206144302,N'Nguyễn Đức Huy','Nam',N'Đà Nẵng','duchuy@email.com','0123456789')

go
create table NhanVien(
	MaNV int identity(100,1) primary key not null,
	TenNV nvarchar(50) not null,
	GioiTinh nvarchar(4) check ( GioiTinh in ( N'Nam',N'Nữ',N'Khác')) not null,
	DiaChi nvarchar(100) not null,
	Email varchar(50) ,
	SDT varchar(11),
	MatKhau varchar(20)
)
 go
insert into NhanVien values(N'Lê Văn Anh',N'Nam',N'Đà Nẵng','vananh@email.com','0123411789','123')
insert into NhanVien values(N'Trần Công Bảo','Nam',N'Đà Nẵng','congbao@email.com','0127411729','123')
insert into NhanVien values(N'Nguyễn Thị Thảo',N'Nữ',N'Quảng Nam','thao@email.com','0125411728','123')
go

create table VeChuyenBay(
	MaVe int identity(1000,1) primary key not null,
	CMND int foreign key references KhachHang(CMND),
	MaChuyenBay varchar(4) foreign key references ChuyenBay(MaChuyenBay),
	NgayDat date , 
	ThoiGianBay time null,
	ChoNgoiSo char(4) null,
	TongTien int null,
)
go

insert into VeChuyenBay values(206144301,'CB01','2018-11-11','01:00:00','A001',1000000)
insert into VeChuyenBay values(206144302,'CB02','2018-11-11','01:00:00','C001',1500000)
go

create table NhatKyThanhToan(
	MaNhatKy int identity(1000,1) primary key not null,
	MaNV int foreign key references NhanVien(MaNV) ,
	MaVe int foreign key references VeChuyenBay(MaVe),
	TongTien int ,
	TrangThai nvarchar(50),
	NgayThanhToan datetime,
)
go

insert into NhatKyThanhToan values(100,1000,1000000,N'Đã thanh toán',getdate())
insert into NhatKyThanhToan values(101,1001,1500000,N'Đã thanh toán',getdate())
go

--create trigger NhatKy on VeChuyenBay for update
--as
--begin
--	declare @MaVe int , @TongTien decimal(18,0) , @ChoNgoiSo char(4)
--	select @MaVe = MaVe from inserted
--	select @TongTien = TongTien from inserted
--	if @TongTien != 0
--	begin
--		insert into NhatKyThanhToan(MaVe,TongTien,TrangThai,NgayThanhToan) values(@MaVe,@TongTien,N'Đã thanh toán',getdate())
--	end
--	select @ChoNgoiSo = ChoNgoiSo from inserted
--	if @ChoNgoiSo = N'Chưa đặt'
--	begin
--		Update Ghe set TinhTrangGhe = N'Đã đặt' where MaGhe = @ChoNgoiSo
--	end
--end
--go

create trigger updateGhe on VeChuyenBay for update
as
begin
	declare @MaVe int , @ChoNgoiSo char(4) , @TinhTrangGhe nvarchar(20) , @ChoNgoiCu char(4)
	select @MaVe = MaVe from inserted
	select @ChoNgoiSo = ChoNgoiSo from inserted
	select @TinhTrangGhe = TinhTrangGhe from Ghe where MaGhe = @ChoNgoiSo
	if @TinhTrangGhe = N'Chưa đặt'
	begin
		Update Ghe set TinhTrangGhe = N'Đã đặt' where MaGhe = @ChoNgoiSo
	end

	select @ChoNgoiCu = ChoNgoiSo from deleted
		Update Ghe set TinhTrangGhe = N'Chưa đặt' where MaGhe = @ChoNgoiCu
end
go

create trigger capNhatGhe on VeChuyenBay for delete
as
begin
	declare @MaVe int , @ChoNgoiSo char(4) , @TinhTrangGhe nvarchar(20) , @ChoNgoiCu char(4)
	select @MaVe = MaVe from deleted
	select @ChoNgoiSo = ChoNgoiSo from deleted
	select @TinhTrangGhe = TinhTrangGhe from Ghe where MaGhe = @ChoNgoiSo
	Update Ghe set TinhTrangGhe = N'Chưa đặt' where MaGhe = @ChoNgoiSo
end
go

--create trigger LayThoiGianBay on VeChuyenBay for insert
--as
--begin
--	declare @MaVe int ,@MaChuyenBay varchar(4),@ThoiGianBay time , @GioDi time , @GioDen time
--	select @MaVe = MaVe from inserted
--	select @MaChuyenBay = MaChuyenBay from inserted 
--	select @GioDi = GioDi, @GioDen = GioDen from ChuyenBay where MaChuyenBay = @MaChuyenBay
--	select @ThoiGianBay = ThoiGianBay from inserted

--	declare @time datetime = cast(@ThoiGianBay as datetime)
--	declare @tgdi datetime = cast(@GioDi as datetime)
--	declare @tgden datetime = cast(@GioDen as datetime)
--	if @ThoiGianBay = null
--	begin
--		set @time = @tgden-@tgdi
--		set @ThoiGianBay = cast(@time as time)
--		update VeChuyenBay set ThoiGianBay = @ThoiGianBay where MaVe = @MaVe
--	end
--end