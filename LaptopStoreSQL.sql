create database [QL_Laptop]

create table Account(
	Username  nvarchar(50) primary key ,
	Userpass nvarchar(50) not null,
)
go
insert into Account( Username, Userpass ) Values('admin' , '123')
insert into Account( Username, Userpass ) Values('thinh' , '123')
go
create table ManufactureInfo
(
	[MftID] nvarchar(10) not null,
	[MftName] nvarchar(20) null,
	CONSTRAINT PK_ManufactureInfo PRIMARY KEY ([MftID])
)
go
create table ProductInfo
(
	[ProductID] nvarchar(50) not null,
	[MftID] nvarchar(10) not null,
	[ProductName] nvarchar(50) null,
	[ProductPrice] money null,
	[ProductDescription] nvarchar(max) null,
	[ProductPicture] image null,
	CONSTRAINT PK_Person PRIMARY KEY ([ProductID]),
	CONSTRAINT FK_ProductInfo_MftInfo foreign key (MftID) REFERENCES ManufactureInfo([MftID])
)
go

create table NhanVien(
	MaNV  nvarchar(50) primary key ,
	TenNV nvarchar(50) not null,
	GioiTinh nvarchar(50) not null,
	DienThoai nvarchar(50) not null,	
)
go
create table KhachHang(
	MaKH nvarchar(50) primary key ,
	Username nvarchar(50) not null FOREIGN KEY REFERENCES Account(Username),
	TenKH nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	DienThoai nvarchar(50) not null,	
)
go
create table HoaDonBan(
	MaHD  nvarchar(50) primary key ,
	MaNV nvarchar(50) not null FOREIGN KEY REFERENCES NhanVien(MaNV),
	NgayBan datetime not null ,
	MaKH nvarchar(50) not null FOREIGN KEY REFERENCES KhachHang(MaKH),
	TongTien money not null ,
)
go
create table ChiTietHD(
	MaHD nvarchar(50) FOREIGN KEY REFERENCES HoaDonBan(MaHD) ,
	MaSP nvarchar(50) FOREIGN KEY REFERENCES ProductInfo(ProductID),
	PRIMARY KEY (MaHD, MaSP),
	SoLuong int not null,
	TongTien money not null
)
go

insert into HoaDonBan(MaHD,MaNV,NgayBan,MaKH,TongTien)
values('MHD0'+,'NV001',GETDATE(),'MKH0',100000)
go
insert into ChiTietHD(MaHD,MaSP,SoLuong,TongTien)
values('MHD0','MSP001',3,100000)
insert into ChiTietHD(MaHD,MaSP,SoLuong,TongTien)
values('MHD0','MSP002',5,60000)

insert into ManufactureInfo(MftID, MftName)
values('MFT001','Asus')
insert into ManufactureInfo(MftID, MftName)
values('MFT002','Gigabyte')
insert into ManufactureInfo(MftID, MftName)
values('MFT003','Acer')
insert into ManufactureInfo(MftID, MftName)
values('MFT004','Dell')
insert into ManufactureInfo(MftID, MftName)
values('MFT005','HP')
insert into ManufactureInfo(MftID, MftName)
values('MFT006','Apple')
insert into ManufactureInfo(MftID, MftName)
values('MFT007','Lenovo')
go
insert into NhanVien(MaNV, TenNV, GioiTinh, DienThoai)
values('NV001',N'Dương Minh Hiếu', 'Nữ', '09123123')
insert into NhanVien(MaNV, TenNV, GioiTinh, DienThoai)
values('NV002',N'Đào Quang Cường', 'Nam', '09536345')
insert into NhanVien(MaNV, TenNV, GioiTinh, DienThoai)
values('NV003',N'Nguyễn Đức Thịnh', 'Nam', '09164664')
insert into NhanVien(MaNV, TenNV, GioiTinh, DienThoai)
values('ONLINE',N'ONLINE', 'ONLINE', '0')

