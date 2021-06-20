
create database QLThuVien
go
use QLThuVien
go
create table DOCGIA
(
	MaDocGia nchar(10),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh datetime,
	DiaChi nchar(100),
	PRIMARY KEY (MaDocGia),
)
create table SACH
(
	MaSach nchar(10),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nchar(10),
	PRIMARY KEY (MaSach),
)
create table PHIEUMUON
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayMuon datetime,
	NgayPhaiTra datetime,
	PRIMARY KEY (MaPhieu),
)
create table PHIEUTRA
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayTra datetime,
	PRIMARY KEY (MaPhieu),
)
create table ACCOUNT
(
	MaDocGia nchar(10) PRIMARY KEY,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	Quyen int,
)

alter table PHIEUMUON add
	constraint FK_PHIEUMUON_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUMUON_SACH foreign key (MaSach) references SACH (MaSach)

alter table PHIEUTRA add
	constraint FK_PHIEUTRA_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUTRA_SACH foreign key (MaSach) references SACH (MaSach)

ALTER TABLE dbo.DOCGIA ADD
	CONSTRAINT FK_DOCGIA_ACCOUNT FOREIGN KEY (MaDocGia) REFERENCES dbo.ACCOUNT(MaDocGia)

insert into ACCOUNT values ('1','p1', '1234', 1)
insert into ACCOUNT values ('2','p2', '1234', 1)
insert into ACCOUNT values ('3','p3', '1234', 1)
insert into ACCOUNT values ('4','p4', '1234', 1)
insert into ACCOUNT values ('999','admin','', 0)
----
insert into DOCGIA values ('1',N'Phạm Ngọc Hải','Nam',1999,N'Phú Yên')
insert into DOCGIA values ('2',N'Phạm Hải NGọc','Nam',1996,N'Trà Vinh')
insert into DOCGIA values ('3',N'Phạm Minh Hoang','Nam',2000,N'Bạc Liêu')
insert into DOCGIA values ('4',N'Nguyễn Thanh Hải',N'Nữ',1994,N'Sóc Trăng')

----
insert into SACH values ('1', N'Lập trình hướng đối tượng', N'Không biết', N'Lập trình', 'HCM', 1500, 3, N'Còn')
insert into SACH values ('2', N'Nhập môn lập trình', N'Không biết', N'Lập trình', 'HCM', 1500, 10, N'Còn')
insert into SACH values ('3', N'Kỹ Thuật Lập Trình', N'Không biết', N'Lập trình', 'HCM', 3000, 5, N'Còn')
insert into SACH values ('4', N'Thiết Kế Phần Mềm', N'Không biết', N'Lập trình', 'C#', 4000, 0, N'Hết')
insert into SACH values ('5', N'Thiết Kế Đồ Họa', N'Không biết', N'Thiết Kế', 'UTC2', 4000, 0, N'Hết')
insert into SACH values ('6', N'Xây Dựng', N'Không biết', N'Lập trình', 'HCM', 4000, 6, N'Còn')
insert into SACH values ('7', N'Nghìn lẻ một đêm', N'Không biết', N'Truyện ngắn', 'Kim Đồng', 4000, 7, N'Còn')
insert into SACH values ('8', N'Thánh hài', N'Không biết', N'Hài', 'Kim Đồng', 4000, 0, N'Hết')
---
insert into PHIEUMUON values ('1','1','1','5/5/2021', '7/6/2021')
insert into PHIEUMUON values ('2','2','1','7/5/2021', '7/6/2021')
insert into PHIEUMUON values ('3','2','2','7/5/2021', '7/6/2021')

---
insert into PHIEUTRA values ('1','1','2','7/6/2021')
insert into PHIEUTRA values ('2','2','1','7/6/2021')
insert into PHIEUTRA values ('3','2','2','7/6/2021')
go