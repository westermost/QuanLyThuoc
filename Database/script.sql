USE [QlThuocData]
GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_Select]
 @TenThuoc nvarchar(50)
as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]      
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
  WHERE [TenThuoc] = @TenThuoc
GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_Toa_CamCum]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_Toa_CamCum]

as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
	where [TenThuoc] = 'Panadol'
GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_Toa_DauBung]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_Toa_DauBung]

as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
	where [TenThuoc] = 'Celecoxib'



GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_Toa_NhucDau]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_Toa_NhucDau]

as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
	where [TenThuoc] = 'Glucosamin'



GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_Toa_TieuChay]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_Toa_TieuChay]

as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
	where [TenThuoc] = 'Naloxon'



GO
/****** Object:  StoredProcedure [dbo].[BanThuoc_UpdateSLThuoc]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BanThuoc_UpdateSLThuoc]
	 @MaThuoc nvarchar(10)
	,@SoLuong int

as


Update [dbo].[Thuoc]
	set [SoLuongThuoc] = [SoLuongThuoc] - @SoLuong
	where [MaThuoc] = @MaThuoc

GO
/****** Object:  StoredProcedure [dbo].[DangNhap_proc]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DangNhap_proc]
@username nvarchar(10),
@password nvarchar(10)
as
SELECT [username]
      ,[password]
  FROM [dbo].[DangNhap]
	WHERE @username = username
		and @password = password
GO
/****** Object:  StoredProcedure [dbo].[HoaDonBanLe_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonBanLe_Select]

as

SELECT [MaPhieuBan]
      ,[MaThuoc]
      ,[TenThuoc]
      ,[SoLuong]
      ,[DonGiaBan]
      ,[ThanhTien]
	  ,[NgayLapHoaDon]
  FROM [dbo].[HoaDonBanLe]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonBanLe_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HoaDonBanLe_Them]
			@MaPhieuBan nvarchar(10)
           ,@MaThuoc nvarchar(10)
           ,@TenThuoc nvarchar(50)
           ,@SoLuong int
           ,@DonGiaBan int
           ,@ThanhTien int
           ,@NgayLapHoaDon date
as

INSERT INTO [dbo].[HoaDonBanLe]
           ([MaPhieuBan]
           ,[MaThuoc]
           ,[TenThuoc]
           ,[SoLuong]
           ,[DonGiaBan]
           ,[ThanhTien]
           ,[NgayLapHoaDon])
     VALUES
           (@MaPhieuBan
           ,@MaThuoc
           ,@TenThuoc
           ,@SoLuong
           ,@DonGiaBan
           ,@ThanhTien
           ,@NgayLapHoaDon)
GO
/****** Object:  StoredProcedure [dbo].[HoaDonNhap_KiemTraID]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonNhap_KiemTraID]
	@SoPhieuNhap nvarchar(10)
as

SELECT [SoPhieuNhap]
      ,[MaNhaCC]
      ,[NgayNhap]
      ,[MaThuoc]
      ,[TenThuoc]
      ,[SoLuongNhap]
      ,[DonGia]
      ,[TongTien]
  FROM [dbo].[HoaDonNhap]
	where @SoPhieuNhap = [SoPhieuNhap]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonNhap_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonNhap_Select]

as

SELECT [SoPhieuNhap]
      ,[MaNhaCC]
	  ,[NgayNhap]
      ,[MaThuoc]
	  ,[TenThuoc]
      ,[SoLuongNhap]
      ,[DonGia]
      ,[TongTien]
  FROM [dbo].[HoaDonNhap]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonNhap_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonNhap_Them]
			@SoPhieuNhap nvarchar(10)
           ,@MaNhaCC nvarchar(10)
		   ,@NgayNhap date
           ,@MaThuoc nvarchar(10)
		   ,@TenThuoc nvarchar(50)
           ,@SoLuongNhap int
           ,@DonGia int
           ,@TongTien int
as

INSERT INTO [dbo].[HoaDonNhap]
           ([SoPhieuNhap]
           ,[MaNhaCC]
		   ,[NgayNhap]
           ,[MaThuoc]
		   ,[TenThuoc]
           ,[SoLuongNhap]
           ,[DonGia]
           ,[TongTien])
     VALUES
           (@SoPhieuNhap
           ,@MaNhaCC
		   ,@NgayNhap
           ,@MaThuoc
		   ,@TenThuoc
           ,@SoLuongNhap
           ,@DonGia
           ,@TongTien)
GO
/****** Object:  StoredProcedure [dbo].[HoaDonNhap_Update]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonNhap_Update]
			
           @MaNhaCC nvarchar(10)
		 
           ,@MaThuoc nvarchar(10)
		   ,@TenThuoc nvarchar(50)
           ,@SoLuongNhap int
           ,@DonGia int
          
as

UPDATE [dbo].[HoaDonNhap]
   SET 
      [MaNhaCC] = @MaNhaCC
      
      ,[MaThuoc] = @MaThuoc
      ,[TenThuoc] = @TenThuoc
      ,[SoLuongNhap] = @SoLuongNhap
      ,[DonGia] = @DonGia
      ,[TongTien] = (@DonGia * @SoLuongNhap)
 WHERE [MaThuoc] = @MaThuoc
GO
/****** Object:  StoredProcedure [dbo].[HoaDonXuat_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HoaDonXuat_Select]

as

SELECT [SoPhieuXuat]
      ,[MaThuoc]
      ,[TenThuoc]
      ,[MaKH]
      ,[SLMua]
      ,[DonGia]
      ,[ThanhTien]
	  ,[NgayLapHD]
  FROM [dbo].[HoaDonXuat]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonXuat_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HoaDonXuat_Them]
			@SoPhieuXuat nvarchar(10)
           ,@MaThuoc nvarchar(10)
           ,@TenThuoc nvarchar(50)
           ,@MaKH nvarchar(10)
           ,@SLMua int
           ,@DonGia int
           ,@ThanhTien int
           ,@NgayLapHD date
as

INSERT INTO [dbo].[HoaDonXuat]
           ([SoPhieuXuat]
           ,[MaThuoc]
           ,[TenThuoc]
           ,[MaKH]
           ,[SLMua]
           ,[DonGia]
           ,[ThanhTien]
           ,[NgayLapHD])
     VALUES
           (@SoPhieuXuat
           ,@MaThuoc
           ,@TenThuoc
           ,@MaKH
           ,@SLMua
           ,@DonGia
           ,@ThanhTien
           ,@NgayLapHD)
GO
/****** Object:  StoredProcedure [dbo].[KH_CapNhat]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_CapNhat]
			@MaKH nvarchar(10)
           ,@TenKH nvarchar(50)
           ,@NgaySinhKH date
           ,@DiaChiKH nvarchar(50)
           ,@SoDTKH nvarchar(11)
           ,@BenhAnKH nvarchar(500)
as

UPDATE [dbo].[KhachHang]
   SET [MaKH] = @MaKH
      ,[TenKH] = @TenKH
      ,[NgaySinhKH] = @NgaySinhKH
      ,[DiaChiKH] = @DiaChiKH
      ,[SoDTKH] = @SoDTKH
      ,[BenhAnKH] = @BenhAnKH
 WHERE [MaKH] = @MaKH

GO
/****** Object:  StoredProcedure [dbo].[KH_KiemTraID]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_KiemTraID]

	@MaKH nvarchar(10)
as
SELECT [MaKH]
      ,[TenKH]
      ,[NgaySinhKH]
      ,[DiaChiKH]
      ,[SoDTKH]
      ,[BenhAnKH]
  FROM [dbo].[KhachHang]
	WHERE @MaKH = [MaKH]



GO
/****** Object:  StoredProcedure [dbo].[KH_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_Select]
as
SELECT [MaKH]
      ,[TenKH]
      ,[NgaySinhKH]
      ,[DiaChiKH]
      ,[SoDTKH]
      ,[BenhAnKH]
  FROM [dbo].[KhachHang]
GO
/****** Object:  StoredProcedure [dbo].[KH_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_Them]
			@MaKH nvarchar(10)
           ,@TenKH nvarchar(50)
           ,@NgaySinhKH date
           ,@DiaChiKH nvarchar(50)
           ,@SoDTKH nvarchar(11)
           ,@BenhAnKH nvarchar(500)
as
INSERT INTO [dbo].[KhachHang]
           ([MaKH]
           ,[TenKH]
           ,[NgaySinhKH]
           ,[DiaChiKH]
           ,[SoDTKH]
           ,[BenhAnKH])
     VALUES
           (@MaKH
           ,@TenKH
           ,@NgaySinhKH
           ,@DiaChiKH
           ,@SoDTKH
           ,@BenhAnKH)

GO
/****** Object:  StoredProcedure [dbo].[KH_TimTheoMaKH]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_TimTheoMaKH]

	@MaKH nvarchar(50)
as

SELECT [MaKH]
      ,[TenKH]
      ,[NgaySinhKH]
      ,[DiaChiKH]
      ,[SoDTKH]
      ,[BenhAnKH]
  FROM [dbo].[KhachHang]
	where [MaKH] like @MaKH
GO
/****** Object:  StoredProcedure [dbo].[KH_TimTheoTen]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KH_TimTheoTen]

	@TenKH nvarchar(50)
as

SELECT [MaKH]
      ,[TenKH]
      ,[NgaySinhKH]
      ,[DiaChiKH]
      ,[SoDTKH]
      ,[BenhAnKH]
  FROM [dbo].[KhachHang]
	where [TenKH] like @TenKH
GO
/****** Object:  StoredProcedure [dbo].[KH_Xoa]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KH_Xoa]
@MaKH nvarchar(10)
as

DELETE FROM [dbo].[KhachHang]
      WHERE [MaKH] = @MaKH
GO
/****** Object:  StoredProcedure [dbo].[NhaCC_KiemTraID]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhaCC_KiemTraID]
	@MaNhaCC nvarchar(10)
as

SELECT [MaNhacCC]
      ,[TenNhaCC]
      ,[DiaChi]
      ,[SoDT]
  FROM [dbo].[NhacCC]
  where @MaNhaCC = [MaNhacCC]



GO
/****** Object:  StoredProcedure [dbo].[NhaCC_SelectCombox]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhaCC_SelectCombox]

as
SELECT [MaNhacCC]
      
  FROM [dbo].[NhacCC]
GO
/****** Object:  StoredProcedure [dbo].[NhaCC_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhaCC_Them]
			@MaNhacCC nvarchar(10)
           ,@TenNhaCC nvarchar(50)
           ,@DiaChi nvarchar(50)
           ,@SoDT nvarchar(11)
as

INSERT INTO [dbo].[NhacCC]
           ([MaNhacCC]
           ,[TenNhaCC]
           ,[DiaChi]
           ,[SoDT])
     VALUES
           (@MaNhacCC
           ,@TenNhaCC
           ,@DiaChi
           ,@SoDT)
GO
/****** Object:  StoredProcedure [dbo].[NhaCC_update]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhaCC_update]	
	@MaNhacCC nvarchar(10)
           ,@TenNhaCC nvarchar(50)
           ,@DiaChi nvarchar(50)
           ,@SoDT nvarchar(11)
		   as
UPDATE [dbo].[NhacCC]
   SET [MaNhacCC] = @MaNhacCC
      ,[TenNhaCC] = @TenNhaCC
      ,[DiaChi] = @DiaChi
      ,[SoDT] = @SoDT
 WHERE [MaNhacCC] = @MaNhacCC
GO
/****** Object:  StoredProcedure [dbo].[NhaCC_xoa]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhaCC_xoa]
@MaNhacCC nvarchar(10)
as

DELETE FROM [dbo].[NhacCC]
      WHERE [MaNhacCC] = @MaNhacCC
GO
/****** Object:  StoredProcedure [dbo].[Select_NhaCC]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_NhaCC]

as
SELECT [MaNhacCC]
      ,[TenNhaCC]
      ,[DiaChi]
      ,[SoDT]
  FROM [dbo].[NhacCC]

GO
/****** Object:  StoredProcedure [dbo].[Thuoc_KiemTraID]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Thuoc_KiemTraID]
	@MaThuoc nvarchar(10)
as
SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]	
	where @MaThuoc = [MaThuoc]



GO
/****** Object:  StoredProcedure [dbo].[Thuoc_Select]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Thuoc_Select]

as
SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
	  
  FROM [dbo].[Thuoc]
GO
/****** Object:  StoredProcedure [dbo].[Thuoc_Them]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Thuoc_Them]
			@MaThuoc nvarchar(10)
           ,@MaNhaCC nvarchar(10)
           ,@TenThuoc nvarchar(50)
			,@NamSX date
           ,@HSD date 
		   ,@SoLuongThuoc int
		   ,@DonGiaThuoc int
		   ,@DonViThuoc nvarchar(50)
as

INSERT INTO [dbo].[Thuoc]
           ([MaThuoc]
           ,[MaNhaCC]
           ,[TenThuoc]
           ,[NamSX]
           ,[HSD]
           ,[SoLuongThuoc]
           ,[DonGiaThuoc]
           ,[DonViThuoc])
     VALUES
           (@MaThuoc
           ,@MaNhaCC
           ,@TenThuoc
           ,@NamSX
           ,@HSD
           ,@SoLuongThuoc
           ,@DonGiaThuoc
           ,@DonViThuoc)




GO
/****** Object:  StoredProcedure [dbo].[Thuoc_TimKiem]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Thuoc_TimKiem]

	@TenThuoc nvarchar(50)
as

SELECT [MaThuoc]
      ,[MaNhaCC]
      ,[TenThuoc]
      ,[NamSX]
      ,[HSD]
      ,[SoLuongThuoc]
      ,[DonGiaThuoc]
      ,[DonViThuoc]
  FROM [dbo].[Thuoc]
	where [TenThuoc] like @TenThuoc

GO
/****** Object:  StoredProcedure [dbo].[Thuoc_Update]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Thuoc_Update]

		@MaThuoc nvarchar(10)
      ,@MaNhaCC nvarchar(10)
      ,@TenThuoc nvarchar(50)
      ,@NamSX date
      ,@HSD date
      ,@SoLuongThuoc int
      ,@DonGiaThuoc int
      ,@DonViThuoc nvarchar(50)
as

UPDATE [dbo].[Thuoc]
   SET [MaThuoc] = @MaThuoc
      ,[MaNhaCC] = @MaNhaCC
      ,[TenThuoc] = @TenThuoc
      ,[NamSX] = @NamSX
      ,[HSD] = @HSD
      ,[SoLuongThuoc] = @SoLuongThuoc
      ,[DonGiaThuoc] = @DonGiaThuoc
      ,[DonViThuoc] = @DonViThuoc
 WHERE [MaThuoc] = @MaThuoc
GO
/****** Object:  StoredProcedure [dbo].[TuSinhMa_MaThuoc]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TuSinhMa_MaThuoc]
as

Select TOP(1) Cast(Right(MaThuoc, 3) as int)+1 as SoMaHang
From Thuoc
Order by MaThuoc Desc

GO
/****** Object:  StoredProcedure [dbo].[xoa]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa]
@MaThuoc nvarchar(10)
as
DELETE FROM [dbo].[Thuoc]
      WHERE [MaThuoc] = @MaThuoc
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[username] [nvarchar](10) NOT NULL,
	[password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonBanLe]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanLe](
	[MaPhieuBan] [nvarchar](10) NOT NULL,
	[MaThuoc] [nvarchar](10) NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGiaBan] [int] NULL,
	[ThanhTien] [int] NULL,
	[NgayLapHoaDon] [date] NULL,
 CONSTRAINT [PK_DongPhieuBan] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[SoPhieuNhap] [nvarchar](10) NOT NULL,
	[MaNhaCC] [nvarchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaThuoc] [nvarchar](10) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[SoLuongNhap] [int] NULL,
	[DonGia] [int] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PhieuBan] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[SoPhieuXuat] [nvarchar](10) NOT NULL,
	[MaThuoc] [nvarchar](10) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[SLMua] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
	[NgayLapHD] [date] NULL,
 CONSTRAINT [PK_PhieuMua] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinhKH] [date] NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[SoDTKH] [nvarchar](11) NULL,
	[BenhAnKH] [nvarchar](500) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhacCC]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhacCC](
	[MaNhacCC] [nvarchar](10) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [nvarchar](11) NULL,
 CONSTRAINT [PK_NhacCC_1] PRIMARY KEY CLUSTERED 
(
	[MaNhacCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 4/25/2015 12:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [nvarchar](10) NOT NULL,
	[MaNhaCC] [nvarchar](10) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[NamSX] [date] NULL,
	[HSD] [date] NULL,
	[SoLuongThuoc] [int] NULL,
	[DonGiaThuoc] [int] NULL,
	[DonViThuoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhacCC] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhacCC] ([MaNhacCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhacCC]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMua_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_PhieuMua_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMua_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_PhieuMua_Thuoc]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_NhacCC] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhacCC] ([MaNhacCC])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_NhacCC]
GO
