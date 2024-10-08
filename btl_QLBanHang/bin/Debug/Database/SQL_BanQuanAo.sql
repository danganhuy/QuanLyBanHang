USE [BTL_BanQuanAo]
GO
/****** Object:  Table [dbo].[tblChiTietHDB]    Script Date: 11/19/2022 2:14:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDB](
	[MaHDB] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[SLBan] [int] NULL,
	[MaKM] [nvarchar](50) NULL,
	[ThanhTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonBan]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonBan](
	[MaHDB] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[NgayBan] [date] NULL,
 CONSTRAINT [PK_tblHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[TienBanNam]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TienBanNam] ( @Nam int) 
returns table 
as
 return (
		select
isnull(sum(case month(NgayBan) when 1 then (ThanhTien) end),0) as Thang1,
isnull(sum(case month(NgayBan) when 2 then (ThanhTien) end),0) as Thang2,
isnull(sum(case month(NgayBan) when 3 then (ThanhTien) end),0) as Thang3,
isnull(sum(case month(NgayBan) when 4 then (ThanhTien) end),0) as Thang4,
isnull(sum(case month(NgayBan) when 5 then (ThanhTien) end),0) as Thang5,
isnull(sum(case month(NgayBan) when 6 then (ThanhTien) end),0) as Thang6,
isnull(sum(case month(NgayBan) when 7 then (ThanhTien) end),0) as Thang7,
isnull(sum(case month(NgayBan) when 8 then (ThanhTien) end),0) as Thang8,
isnull(sum(case month(NgayBan) when 9 then (ThanhTien) end),0) as Thang9,
isnull(sum(case month(NgayBan) when 10 then (ThanhTien) end),0) as Thang10,
isnull(sum(case month(NgayBan) when 11 then (ThanhTien) end),0) as Thang11,
isnull(sum(case month(NgayBan) when 12 then (ThanhTien) end),0) as Thang12
from tblChiTietHDB ct join tblHoaDonBan hd on ct.MaHDB=hd.MaHDB 
where year(NgayBan)=@Nam) 
GO
/****** Object:  Table [dbo].[tblChiTietHDN]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDN](
	[MaHDN] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SLNhap] [int] NOT NULL,
	[ThanhTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHDN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[TienNhapNam]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TienNhapNam] ( @Nam int) 
returns table 
as
 return (
		select
isnull(sum(case month(NgayNhap) when 1 then (ThanhTien) end),0) as Thang1,
isnull(sum(case month(NgayNhap) when 2 then (ThanhTien) end),0) as Thang2,
isnull(sum(case month(NgayNhap) when 3 then (ThanhTien) end),0) as Thang3,
isnull(sum(case month(NgayNhap) when 4 then (ThanhTien) end),0) as Thang4,
isnull(sum(case month(NgayNhap) when 5 then (ThanhTien) end),0) as Thang5,
isnull(sum(case month(NgayNhap) when 6 then (ThanhTien) end),0) as Thang6,
isnull(sum(case month(NgayNhap) when 7 then (ThanhTien) end),0) as Thang7,
isnull(sum(case month(NgayNhap) when 8 then (ThanhTien) end),0) as Thang8,
isnull(sum(case month(NgayNhap) when 9 then (ThanhTien) end),0) as Thang9,
isnull(sum(case month(NgayNhap) when 10 then (ThanhTien) end),0) as Thang10,
isnull(sum(case month(NgayNhap) when 11 then (ThanhTien) end),0) as Thang11,
isnull(sum(case month(NgayNhap) when 12 then (ThanhTien) end),0) as Thang12
from tblChiTietHDN ct join tblHoaDonNhap hd on ct.MaHDN=hd.MaHDN 
where year(NgayNhap)=@Nam) 
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaChatLieu] [nvarchar](50) NULL,
	[MaMauSac] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MaKM] [nvarchar](50) NULL,
	[DonGiaNhap] [money] NULL,
	[DonGiaBan] [money] NULL,
	[Anh] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[SPBan]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  function [dbo].[SPBan]  (@Nam int,  @TenSP nvarchar(50))
returns table 
as
 return(
select TenSP,sum(ThanhTien) as DTBan
from tblChiTietHDB join tblHoaDonBan on tblChiTietHDB.MaHDB=tblHoaDonBan.MaHDB join tblSanPham on tblSanPham.MaSP=tblChiTietHDB.MaSP
where year(NgayBan)=@Nam and tblSanPham.TenSP=@TenSP 
group by TenSP)
GO
/****** Object:  UserDefinedFunction [dbo].[SPNhap]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  function [dbo].[SPNhap]  (@Nam int,  @TenSP nvarchar(50))
returns table 
as
 return(
select TenSP,sum(ThanhTien) as DTNhap
from tblChiTietHDN join tblHoaDonNhap on tblChiTietHDN.MaHDN=tblHoaDonNhap.MaHDN join tblSanPham on tblSanPham.MaSP=tblChiTietHDN.MaSP
where year(NgayNhap)=@Nam and tblSanPham.TenSP=@TenSP
group by TenSP)
GO
/****** Object:  UserDefinedFunction [dbo].[SPBanBDTron]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  function [dbo].[SPBanBDTron]  (@Nam int)
returns table 
as
 return(
select TenSP,sum(ThanhTien) as DTBan
from tblChiTietHDB join tblHoaDonBan on tblChiTietHDB.MaHDB=tblHoaDonBan.MaHDB join tblSanPham on tblSanPham.MaSP=tblChiTietHDB.MaSP
where year(NgayBan)=@Nam
group by TenSP)
GO
/****** Object:  UserDefinedFunction [dbo].[SPNhapBDTron]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  function [dbo].[SPNhapBDTron]  (@Nam int)
returns table 
as
 return(
select TenSP,sum(ThanhTien) as DTNhap
from tblChiTietHDN join tblHoaDonNhap on tblChiTietHDN.MaHDN=tblHoaDonNhap.MaHDN join tblSanPham on tblSanPham.MaSP=tblChiTietHDN.MaSP
where year(NgayNhap)=@Nam
group by TenSP)
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChatLieu] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietNV]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietNV](
	[MaNV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NULL,
	[LuongCB] [money] NULL,
	[HeSo] [float] NULL,
	[Thuong] [money] NULL,
 CONSTRAINT [PK_tblChiTietNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Anh] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhuyenMai]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhuyenMai](
	[MaKM] [nvarchar](50) NOT NULL,
	[GiamGia] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMauSac]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMauSac](
	[MaMauSac] [nvarchar](50) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblMauSac] PRIMARY KEY CLUSTERED 
(
	[MaMauSac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNV]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNV](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[Anh] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_tblNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSize]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSize](
	[MaSize] [nvarchar](50) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSize] PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[MaNV] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Email] [nchar](100) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl01', N'Bò')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl02', N'Vải')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl03', N'Nhung')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'cl04', N'Cotton')
GO
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb01', N'sp03', 1, N'km02', 160000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb01', N'sp04', 5, N'km03', 210000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb02', N'sp01', 1, N'km00', 100000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb02', N'sp02', 3, N'km01', 270000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb04', N'sp02', 4, N'km01', 360000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb04', N'sp03', 5, N'km02', 800000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb05', N'sp04', 10, N'km03', 210000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb05', N'sp01', 10, N'km00', 100000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb03', N'sp03', 4, N'km02', 640000.0000)
INSERT [dbo].[tblChiTietHDB] ([MaHDB], [MaSP], [SLBan], [MaKM], [ThanhTien]) VALUES (N'hnb03', N'sp04', 3, N'km03', 210000.0000)
GO
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd01', N'sp01', 2, 100000.0000)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd01', N'sp02', 3, 2250000.0000)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd02', N'sp03', 5, 500000.0000)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd02', N'sp04', 5, 300000.0000)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd03', N'sp04', 5, 300000.0000)
INSERT [dbo].[tblChiTietHDN] ([MaHDN], [MaSP], [SLNhap], [ThanhTien]) VALUES (N'hnd03', N'sp03', 5, 500000.0000)
GO
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv01', N'Nhân Viên', 1000000.0000, 1.5, 500000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv02', N'Nhân Viên', 1000000.0000, 1.5, 500000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv03', N'Nhân Viên', 1000000.0000, 1.5, 500000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv04', N'Nhân Viên', 1000000.0000, 1.5, 500000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv05', N'Nhân Viên', 1000000.0000, 1.5, 500000.0000)
INSERT [dbo].[tblChiTietNV] ([MaNV], [ChucVu], [LuongCB], [HeSo], [Thuong]) VALUES (N'nv06', N'Quản Lý', 2000000.0000, 2, 1000000.0000)
GO
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'hnb01', N'nv04', N'kh04', CAST(N'2020-11-17' AS Date))
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'hnb02', N'nv05', N'kh02', CAST(N'2021-09-01' AS Date))
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'hnb03', N'nv01', N'kh03', CAST(N'2019-11-25' AS Date))
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'hnb04', N'nv03', N'kh05', CAST(N'2022-11-17' AS Date))
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaNV], [MaKH], [NgayBan]) VALUES (N'hnb05', N'nv05', N'kh04', CAST(N'2022-11-17' AS Date))
GO
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hnd01', N'nv01', CAST(N'2021-10-01' AS Date), N'ncc01')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hnd02', N'nv02', CAST(N'2020-11-17' AS Date), N'ncc02')
INSERT [dbo].[tblHoaDonNhap] ([MaHDN], [MaNV], [NgayNhap], [MaNCC]) VALUES (N'hnd03', N'nv03', CAST(N'2022-11-17' AS Date), N'ncc03')
GO
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh01', N'Đặng Thành Nam', N'Hà Tĩnh', N'0377482722', CAST(N'2022-11-18' AS Date), N'', N'Nam       ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh02', N'Trịnh Hải Dương', N'Thanh Hóa', N'0998778964', CAST(N'2000-10-19' AS Date), N'kh02.jpg', N'Nam       ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh03', N'Hoàng Anh Tú', N'Nghệ An', N'0998472634', CAST(N'2001-02-19' AS Date), N'kh03.jpg', N'Nam       ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh04', N'Phạm Linh Anh', N'Hồ Chí Minh', N'0936475892', CAST(N'1999-06-18' AS Date), N'kh04.jpg', N'Nữ        ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [Anh], [GioiTinh]) VALUES (N'kh05', N'Đoàn Văn Nam', N'Nam Định', N'0377407258', CAST(N'2012-11-17' AS Date), N'kh01.jpg', N'Nam       ')
GO
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km00', N'0', N'Mặc Định')
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km01', N'10', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km02', N'20', NULL)
INSERT [dbo].[tblKhuyenMai] ([MaKM], [GiamGia], [GhiChu]) VALUES (N'km03', N'30', NULL)
GO
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'mms01', N'Xanh')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'mms02', N'Đỏ')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'mms03', N'Vàng')
INSERT [dbo].[tblMauSac] ([MaMauSac], [TenMau]) VALUES (N'mms04', N'Trắng')
GO
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc01', N'Việt Nam')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc02', N'Trung Quốc')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc03', N'Hàn Quốc')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNCC]) VALUES (N'ncc04', N'Mỹ')
GO
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv01', N'Đoàn Quốc Huy', N'Nam Định', N'0377497293', N'nv01.jpg', N'Nam', CAST(N'2002-01-13' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv02', N'Nguyễn Hà Phương', N'Hà Nội', N'0793672938', N'nv02.jpg', N'Nữ', CAST(N'2002-11-07' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv03', N'Đặng Văn Huy', N'Hà Nội', N'0348272937', N'nv03.jpg', N'Nam', CAST(N'2002-10-08' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv04', N'Phạm Văn Dương', N'Thái Bình', N'0391272937', N'nv04.jpg', N'Nam', CAST(N'2002-08-08' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv05', N'Nguyễn Hồng Nhung', N'Ninh Bình', N'0359662937', N'nv05.jpg', N'Nữ', CAST(N'2002-05-08' AS Date))
INSERT [dbo].[tblNV] ([MaNV], [TenNV], [DiaChi], [SoDienThoai], [Anh], [GioiTinh], [NgaySinh]) VALUES (N'nv06', N'Quản Trị Viên', N'Tp.HCM', N'03482722493', N'macdinh.png', N'Nam', CAST(N'2002-06-08' AS Date))
GO
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [MaMauSac], [MaSize], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp01', N'Áo Bò', N'cl01', N'mms01', N's01', 1, N'km00', 50000.0000, 100000.0000, N'quanbo.jpg', N'', N'ncc01')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [MaMauSac], [MaSize], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp02', N'Áo Vest', N'cl02', N'mms02', N's02', 16, N'km01', 750000.0000, 100000.0000, N'aovest.jpg', N'', N'ncc02')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [MaMauSac], [MaSize], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp03', N'Quần Bò', N'cl03', N'mms03', N's03', 30, N'km02', 100000.0000, 200000.0000, N'quanbo.jpg', N'', N'ncc03')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaChatLieu], [MaMauSac], [MaSize], [SoLuong], [MaKM], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu], [MaNCC]) VALUES (N'sp04', N'Quần Vải', N'cl04', N'mms02', N's04', 32, N'km03', 150000.0000, 300000.0000, N'aovest.jpg', N'', N'ncc04')
GO
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's01', N'S')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's02', N'M')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's03', N'L')
INSERT [dbo].[tblSize] ([MaSize], [TenSize]) VALUES (N's04', N'XL')
GO
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv01', N'huydq', N'123', N'huydoan1301@gmail.com                                                                               ')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv02', N'phuonghn', N'123', N'huydoan1301@gmail.com                                                                               ')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv03', N'huydv', N'123', N'huydoan1301@gmail.com                                                                               ')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv04', N'duongvp', N'123', N'huysieunhan2k7@gmail.com                                                                            ')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv05', N'nhunghn', N'123', N'hsnhsn2k7@gmail.com                                                                                 ')
INSERT [dbo].[tblUser] ([MaNV], [Username], [Password], [Email]) VALUES (N'nv06', N'abc', N'123', N'hsnhsn@gmail.com                                                                                    ')
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[tblHoaDonBan] ([MaHDB])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblKhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblKhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblKhuyenMai]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietNV]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNV_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblChiTietNV] CHECK CONSTRAINT [FK_tblChiTietNV_tblNV]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblNV]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNV]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblChatLieu] FOREIGN KEY([MaChatLieu])
REFERENCES [dbo].[tblChatLieu] ([MaChatLieu])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblChatLieu]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblKhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[tblKhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblKhuyenMai]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNV] ([MaNV])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblNV]
GO
/****** Object:  StoredProcedure [dbo].[DTSP]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DTSP]  @Nam int,  @TenSP nvarchar(50),@nhap money output, @ban money output
as
begin
select @ban=sum(ThanhTien)
from tblChiTietHDB join tblHoaDonBan on tblChiTietHDB.MaHDB=tblHoaDonBan.MaHDB join tblSanPham on tblSanPham.MaSP=tblChiTietHDB.MaSP
where tblChiTietHDB.MaSP=N'sp02' and year(NgayBan)=2021 and tblSanPham.TenSP=@TenSP
select  @nhap=sum(ThanhTien)
from tblChiTietHDN join tblHoaDonNhap on tblChiTietHDN.MaHDN=tblHoaDonNhap.MaHDN join tblSanPham on tblSanPham.MaSP=tblChiTietHDN.MaSP
where tblChiTietHDN.MaSP=N'sp02' and year(NgayNhap)=2021 and tblSanPham.TenSP=@TenSP
end
GO
/****** Object:  StoredProcedure [dbo].[sp_doanhthu]    Script Date: 11/19/2022 2:14:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_doanhthu] @Nam int
as
    declare @EndMonth int = 12
    declare @Loop int = 1
    declare @TienNhap float = 0
    declare @TienBan float = 0
    declare @Result float = 0

    DECLARE @DoanhThuTable TABLE (
        Thang int,
        TienNhap float,
        TienBan float,
        ChenhLech float
    );
 
    WHILE @Loop <= @EndMonth 
    BEGIN
        set @TienBan = (
            select case
                   when sum(DonGiaBan * SLBan) is not null then sum(DonGiaBan * SLBan)
                   else 0
                   end
            from tblHoaDonBan join tblChiTietHDB on tblHoaDonBan.MaHDB = tblChiTietHDB.MaHDB join tblSanPham on tblChiTietHDB.MaSP = tblSanPham.MaSP
            where year(NgayBan) = @Nam and month(NgayBan) = @Loop 
        )

        set @TienNhap = (
            select case
                   when sum(DonGiaNhap * SLNhap) is not null then sum(DonGiaNhap * SLNhap)
                   else 0
                   end
             from tblHoaDonNhap join tblChiTietHDN on tblHoaDonNhap.MaHDN = tblChiTietHDN.MaHDN join tblSanPham on tblChiTietHDN.MaSP = tblSanPham.MaSP
            where year(NgayNhap) = @Nam and month(NgayNhap) = @Loop 
        )

        set @Result = @TienBan - @TienNhap

        INSERT INTO @DoanhThuTable
        VALUES (@Loop, @TienNhap, @TienBan, @Result)

        set @Loop = @Loop + 1
    END
GO
