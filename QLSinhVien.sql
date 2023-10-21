create database QLSinhvien
go
use QLSinhvien
go

--/// Sinh vien
create table Sinhvien
(
	Malop nvarchar(50),
	Masinhvien int primary key not null,
	Tensinhvien nvarchar(50),
	Ngaysinh datetime,
	Gioitinh nvarchar(50),
	Quequan nvarchar(50),
	Email nvarchar(50),
	Sodienthoai nvarchar(50),
	Picture image,
)
go
create proc sp_AllSinhvien
as
select * from Sinhvien
go
create proc sp_AddSinhvien
@Malop nvarchar(50),
@Masinhvien int,
@Tensinhvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	insert into Sinhvien values(@Malop,@Masinhvien,@Tensinhvien,@Ngaysinh,@Gioitinh,@Quequan,@Email,@Sodienthoai,@Picture)
end
go
create proc sp_SearchSinhvien
(@Masinhvien nvarchar(50),@Tensinhvien nvarchar(50))
as
begin
	select * from Sinhvien where Masinhvien like '%'+@Masinhvien+'%' or Tensinhvien like '%'+@Tensinhvien+'%'
end
go
create proc sp_SearchSvFromMalop
(@Malop nvarchar(50))
as
begin
	select * from Sinhvien where Malop = @Malop
end
go
create proc sp_ReportSvFromMalop
(@Malop nvarchar(50))
as
begin
	select sv.Malop,lp.Tenlop,lp.Course,sv.Masinhvien,sv.Tensinhvien,sv.Ngaysinh,sv.Gioitinh,sv.Quequan,sv.Email,sv.Sodienthoai from Sinhvien sv join Lop lp on sv.Malop=lp.Malop
	where sv.Malop = @Malop
end
go

create proc sp_UpdateSinhvien
@Malop nvarchar(50),
@Masinhvien int,
@Tensinhvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	Update  Sinhvien set Malop=@Malop,Tensinhvien=@Tensinhvien,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Quequan=@Quequan,Email=@Email,Sodienthoai=@Sodienthoai,Picture=@Picture
	where Masinhvien=@Masinhvien
end
go

create proc sp_DeleteSinhvien
@Masinhvien int
as
begin
	Delete Diem where Masinhvien=@Masinhvien
	Delete Sinhvien Where Masinhvien=@Masinhvien
end
go

--///////// Hoc phan
create table Hocphan
(
	Mahocphan nvarchar(50) ,
	Tenhocphan nvarchar(50) not null primary key,
	Sotinchi int,
	Kyhoc int
)
go
create proc sp_AllHocphan
as
select * From Hocphan
go
create proc sp_AddHocphan
(@Mahocphan nvarchar(50),
@Tenhocphan nvarchar(50),
@Sotinchi int,
@Kyhoc int)
as
begin
	insert into Hocphan Values(@Mahocphan,@Tenhocphan,@Sotinchi,@Kyhoc)
end
go
create proc sp_UpdateHocphan
(@Mahocphan nvarchar(50),
@Tenhocphan nvarchar(50),
@Sotinchi int,
@Kyhoc int)
as
begin
	Update Hocphan set Tenhocphan=@Tenhocphan,Sotinchi=@Sotinchi,Kyhoc=@Kyhoc
	where Mahocphan=@Mahocphan
end
go
create proc sp_DeleteHocphan
@Mahocphan nvarchar(50)
as
begin
	Delete Hocphan where Mahocphan=@Mahocphan
end

go

--/////// Lop
create table Lop
(
	Malop nvarchar(50) not null primary key,
	Tenlop nvarchar(50),
	Course nvarchar(20)
)
go
create proc sp_AllLop
as
begin
	select * from Lop
end
go
create proc sp_AddLop
(
@Malop nvarchar(50),
@Tenlop nvarchar(50),
@Course nvarchar(50)
)
as
begin
	insert into Lop Values(@Malop,@Tenlop,@Course)
end
go
create proc sp_ComboxMalop
as
select Malop from Lop
go

go
create proc sp_UpdateLop
@Malop nvarchar(50),
@Tenlop nvarchar(50),
@Course nvarchar(50)
as
begin
	Update Lop set Tenlop=@Tenlop,Course=@Course where Malop=@Malop
end
go

create proc sp_SearchLop
@Malop nvarchar(50)
as
begin
	select * from Lop where Malop=@Malop
end
go
--'///// Diem
create table Diem
(
	Masinhvien int not null foreign key references Sinhvien(Masinhvien),
	Tenhocphan nvarchar(50) not null foreign key references Hocphan(Tenhocphan),
	Diemchuyencan decimal(3,1),
	Diemgiuaky decimal(3,1),
	Diemcuoiky decimal(3,1),
	Thangdiem10 decimal(3,1),
	Thangdiem4 decimal(3,1),
	Thangdiemchu nvarchar(10)
)
go
create proc sp_Alldiem
as
select * from Diem
go
create proc sp_AddDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50),
@Diemchuyencan decimal(3,1),
@Diemgiuaky decimal(3,1),
@Diemcuoiky decimal(3,1),
@Thangdiem10 decimal(3,1),
@Thangdiem4 decimal(3,1),
@Thangdiemchu nvarchar(10))
as
begin
	if(not exists(Select * from Diem where Masinhvien=@Masinhvien And Tenhocphan=@Tenhocphan))
		Insert into Diem Values(@Masinhvien,@Tenhocphan,@Diemchuyencan,@Diemgiuaky,@Diemcuoiky,@Thangdiem10,@Thangdiem4,@Thangdiemchu)
	else
		print N'Lỗi thêm'
end
go
create proc sp_UpdateDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50),
@Diemchuyencan decimal(3,1),
@Diemgiuaky decimal(3,1),
@Diemcuoiky decimal(3,1),
@Thangdiem10 decimal(3,1),
@Thangdiem4 decimal(3,1),
@Thangdiemchu nvarchar(10))
as
begin
	Update Diem set Diemchuyencan=@Diemchuyencan,Diemgiuaky=@Diemgiuaky,Diemcuoiky=@Diemcuoiky,Thangdiem10=@Thangdiem10,Thangdiem4=@Thangdiem4,Thangdiemchu=@Thangdiemchu
	Where Masinhvien = @Masinhvien and Tenhocphan=@Tenhocphan
end
go
create proc sp_DeleteDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50))
as
begin
	Delete Diem Where Masinhvien = @Masinhvien and Tenhocphan=@Tenhocphan
end
go
create proc sp_SearchDiem
(@Masinhvien nvarchar(50))
as
begin
	select * from Diem where Masinhvien like '%'+@Masinhvien+'%'
end
go
create proc sp_ReportDiemFromSV
(@Masinhvien nvarchar(50))
as
begin
	select sv.Masinhvien,sv.Tensinhvien,hp.Mahocphan,hp.Tenhocphan,hp.Sotinchi,d.Thangdiem10,d.Thangdiem4,d.Thangdiemchu 
	from Sinhvien sv join Diem d on sv.Masinhvien=d.Masinhvien join Hocphan hp on hp.Tenhocphan=d.Tenhocphan 
	where d.Masinhvien = @Masinhvien
end
go

---//////////Giảng viên
create table Giangvien
(
	Tenhocphan nvarchar(50) not null foreign key references Hocphan(Tenhocphan),
	Magiangvien int primary key not null,
	Tengiangvien nvarchar(50),
	Ngaysinh datetime,
	Gioitinh nvarchar(50),
	Quequan nvarchar(50),
	Email nvarchar(50),
	Sodienthoai nvarchar(50),
	Picture image,
)
go
create proc sp_AddGiangvien
@Tenhocphan nvarchar(50),
@Magiangvien int,
@Tengiangvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	insert into Giangvien values(@Tenhocphan,@Magiangvien,@Tengiangvien,@Ngaysinh,@Gioitinh,@Quequan,@Email,@Sodienthoai,@Picture)
end
go
create proc sp_SearchGiangvien
(@Magiangvien nvarchar(50),@Tengiangvien nvarchar(50))
as
begin
	select * from Giangvien where Magiangvien like '%'+@Magiangvien+'%' or Tengiangvien like '%'+@Tengiangvien+'%'
end
go
go
create proc sp_AllGiangvien
as
select * from Giangvien
go
create proc sp_UpdateGiangvien
@Tenhocphan nvarchar(50),
@Magiangvien int,
@Tengiangvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	Update  Giangvien set Tenhocphan=@Tenhocphan,Tengiangvien=@Tengiangvien,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Quequan=@Quequan,Email=@Email,Sodienthoai=@Sodienthoai,Picture=@Picture
	where Magiangvien=@Magiangvien
end
go
create proc sp_DeleteGiangvien
@Magiangvien int
as
begin
	Delete  Giangvien where Magiangvien=@Magiangvien
end
go

---- ppppp
create proc sp_SumTinchi
@Masinhvien int
as
select sum(hp.Sotinchi) from Hocphan hp 
join Diem d on hp.Tenhocphan=d.Tenhocphan 
join Sinhvien sv on d.Masinhvien = sv.Masinhvien
where d.Masinhvien = @Masinhvien and d.Thangdiemchu != 'F'
go


create proc sp_AVG
@Masinhvien int
as
select Cast(avg(Thangdiem10) as decimal(4,2)) from Diem
where Masinhvien = @Masinhvien
go

create proc sp_Bangdiemcanhan
@Masinhvien int
as
select hp.Mahocphan,hp.Tenhocphan,hp.Kyhoc,hp.Sotinchi,d.Diemchuyencan,d.Diemgiuaky,d.Diemcuoiky,d.Thangdiem10,d.Thangdiem4,d.Thangdiemchu 
from Diem d join Hocphan hp on d.Tenhocphan=hp.Tenhocphan
where d.Masinhvien = @Masinhvien
go

create proc sp_Hocphanchuatichluy
@Masinhvien int
as
begin
	select * from Hocphan
	where Tenhocphan not in (Select Tenhocphan From Diem Where Masinhvien=@Masinhvien)
end

go
Create table Accounts
(
Username nvarchar(50),
Password nvarchar(50)
)
insert into Accounts
values ('Tam','123')
-- report bang diem lop + monhoc
create proc sp_BangdiemLopVaHocphan
(
@Malop nvarchar(50),
@Tenhocphan nvarchar(50)
)
as
begin
	Select l.Malop, l.Tenlop, hp.Tenhocphan, sv.Masinhvien, sv.Tensinhvien, sv.Ngaysinh, d.Diemchuyencan, d.Diemgiuaky, d.Diemcuoiky, d.Thangdiem10, d.Thangdiem4, d.Thangdiemchu 
	from Sinhvien sv join Diem d 
	on sv.Masinhvien = d.Masinhvien join Hocphan hp 
	on hp.Tenhocphan = d.Tenhocphan join Lop l
	on l.Malop = sv.Malop
	where l.Malop = @Malop and d.Tenhocphan = @Tenhocphan
end
