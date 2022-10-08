USE [master]
GO
    IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QLKTX')
  BEGIN
    CREATE DATABASE [QLKTX]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKTX', FILENAME = N'D:\New folder\Database\QLKTX.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKTX_log', FILENAME = N'D:\New folder\Database\QLKTX_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
    END
   GO
ALTER DATABASE [QLKTX] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKTX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKTX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKTX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKTX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKTX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKTX] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKTX] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLKTX] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLKTX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKTX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKTX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKTX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKTX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKTX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKTX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKTX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKTX] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKTX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKTX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKTX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKTX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKTX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKTX] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKTX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKTX] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKTX] SET  MULTI_USER 
GO
ALTER DATABASE [QLKTX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKTX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKTX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKTX] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLKTX]
GO

SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'sinhvien'
            AND type = 'U'
        )
begin
create table sinhvien
(
	masv char(12) constraint pk_sv primary key,
	hoten nvarchar(40) constraint nn_htsv not null,
	ngaysinh smalldatetime constraint nn_nssv not null,
	gioitinh varchar(3) constraint ch_gtsv check (gioitinh in ('nam','nu')),
	cmnd char(9) constraint nn_cmndsv not null,
	sdt varchar(20),
	)
end
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'phong'
            AND type = 'U'
        )
begin
create table phong
(
	sophong char(4) constraint pk_phong primary key,
	sluongsv int constraint ch_phong check ( sluongsv <= 8 ),
	tinhtrangphong varchar(50)
)
end
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'hopdong'
            AND type = 'U'
        )
begin
create table hopdong
(
	mahopdong char(10) constraint pk_hd primary key,
	masv char(12) constraint fk_hdsv foreign key references sinhvien(masv),
	sophong char(4) constraint fk_hdph foreign key references phong(sophong),
	ngaylap smalldatetime,
	ngaybatdau smalldatetime,
	ngayketthuc smalldatetime
)
	alter table hopdong add constraint ch_ngayhd check (ngaybatdau < ngayketthuc)
	alter table hopdong add constraint ch_laphd check (ngaylap < ngaybatdau)
end
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'hoadondiennuoc'
            AND type = 'U'
        )
begin
create table hoadondiennuoc
(
	mahd char(10) constraint pk_hodon primary key,
	sophong char(4) constraint fk_hoadonph foreign key references phong(sophong), 
	ngaylap smalldatetime,
	tongtien money,
)
end
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'phiktx'
            AND type = 'U'
        )
begin
create table phiktx
(
	mabienlai varchar(20) constraint pk_phiktx primary key,
	masv char(12) constraint fk_phisv foreign key references sinhvien(masv),
	sophong char(4) constraint fk_phiph foreign key references phong(sophong),
	namhoc smallint,
	ngaythu smalldatetime,
	sotien money 
)
end
IF NOT EXISTS (
        SELECT 1
        FROM sys.tables
        WHERE name = 'taikhoan'
            AND type = 'U'
        )
begin
create table taikhoan
(
	email nvarchar(40) constraint pk_email primary key,
	pass char(12)constraint nn_pass not null,
	quyen char(10) default 'user',
	masv char(12) null constraint fk_TKSV foreign key references sinhvien(masv)
)
end
insert into sinhvien values('2080600032',N'Võ Nguyên Khoa',20/09/1998,N'nam','241670421','0927996813')
insert into sinhvien values('2080600033',N'Nguyễn Hà An Khang',20/09/1998,N'nam','241670422','0927996815')
insert into sinhvien values('2080600034',N'Giang Khải Minh',20/09/1998,N'nam','241670423','0927996816')
insert into sinhvien values('2080600035',N'Nguyễn Hải Long',20/09/1998,N'nam','241670424','0927996817')





insert into taikhoan values('vonguyenkhoa1998@gmail.com','123456',default,'2080600032')
insert into taikhoan values('vonguyenkhoa1988@gmail.com','123457','admin','2080600033')



go
create proc USP_LOGIN
@email nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from taikhoan where email = @email and pass = @passWord
end 
go

go
create proc USP_REGISTER
@email nvarchar(100), @passWord nvarchar(100), @maSV nvarchar(100)
as
begin
	insert into taikhoan values(@email , @passWord, default , @maSV)
end 
go



