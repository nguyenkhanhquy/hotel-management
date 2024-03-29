USE [master]
GO

IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'QuanLyKhachSan')
    DROP DATABASE QuanLyKhachSan;
GO

CREATE DATABASE [QuanLyKhachSan]
GO

USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[ChiTietHopDong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHopDong](
	[MaHopDong] [nvarchar](10) NOT NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[NgayVao] [date] NOT NULL,
	[SoNgayThue] [int] NOT NULL,
	[SoLuongPhongThue] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
	[TinhTrangThanhToan] [bit] NOT NULL,
 CONSTRAINT [PK__ChiTietH__36DD43426915497B] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaHopDong] [nvarchar](10) NULL,
	[TongTien] [int] NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
 CONSTRAINT [PK__HoaDon__835ED13BBEED770D] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](30) NOT NULL,
	[CCCD] [nvarchar](12) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[MaThanhPho] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [nvarchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](30) NOT NULL,
	[GiaPhong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](30) NOT NULL,
	[CCCD] [nvarchar](12) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[MaLoaiPhong] [nvarchar](10) NULL,
	[SoPhong] [nvarchar](3) NOT NULL,
	[SoLuongNguoi] [int] NOT NULL,
	[PhongTrong] [bit] NOT NULL,
	[MaHopDong] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhPho]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[MaThanhPho] [nvarchar](10) NOT NULL,
	[TenThanhPho] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHopDong] ([MaHopDong], [MaNhanVien], [MaKhachHang], [NgayVao], [SoNgayThue], [SoLuongPhongThue], [TongTien], [TinhTrangThanhToan]) VALUES (N'HD001', N'NV001', N'KH001', CAST(N'2023-06-06' AS Date), 2, 1, 1100000, 1)
INSERT [dbo].[ChiTietHopDong] ([MaHopDong], [MaNhanVien], [MaKhachHang], [NgayVao], [SoNgayThue], [SoLuongPhongThue], [TongTien], [TinhTrangThanhToan]) VALUES (N'HD002', N'NV002', N'KH002', CAST(N'2023-06-06' AS Date), 1, 1, 350000, 0)
INSERT [dbo].[ChiTietHopDong] ([MaHopDong], [MaNhanVien], [MaKhachHang], [NgayVao], [SoNgayThue], [SoLuongPhongThue], [TongTien], [TinhTrangThanhToan]) VALUES (N'HD003', N'NV003', N'KH003', CAST(N'2023-06-06' AS Date), 1, 2, 900000, 1)
INSERT [dbo].[ChiTietHopDong] ([MaHopDong], [MaNhanVien], [MaKhachHang], [NgayVao], [SoNgayThue], [SoLuongPhongThue], [TongTien], [TinhTrangThanhToan]) VALUES (N'HD004', N'NV004', N'KH004', CAST(N'2023-06-06' AS Date), 3, 1, 1050000, 0)
INSERT [dbo].[ChiTietHopDong] ([MaHopDong], [MaNhanVien], [MaKhachHang], [NgayVao], [SoNgayThue], [SoLuongPhongThue], [TongTien], [TinhTrangThanhToan]) VALUES (N'HD005', N'NV005', N'KH005', CAST(N'2023-06-06' AS Date), 1, 1, 550000, 0)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaHopDong], [TongTien], [NgayThanhToan]) VALUES (N'H001', N'HD001', 1100000, CAST(N'2023-06-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaHopDong], [TongTien], [NgayThanhToan]) VALUES (N'H002', N'HD003', 900000, CAST(N'2023-06-06' AS Date))
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH001', N'Nguyễn Lương Huy', N'089751235489', CAST(N'2003-08-12' AS Date), N'Nam', N'0963790308', N'TP01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH002', N'Trần Trọng Khang', N'093512687951', CAST(N'2003-04-13' AS Date), N'Nam', N'0912727714', N'TP02')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH003', N'Phạm Ngọc Đăng Khoa', N'079203011307', CAST(N'2003-07-11' AS Date), N'Nam', N'0377264088', N'TP01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH004', N'Đỗ Anh Khoa', N'077203001348', CAST(N'2003-08-25' AS Date), N'Nam', N'0797528596', N'TP01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH005', N'Trần Thị Ánh Hồng', N'078515589658', CAST(N'2002-09-08' AS Date), N'Nữ', N'0988512578', N'TP07')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH006', N'Nguyễn Thị Tuyết', N'089784612648', CAST(N'2000-09-08' AS Date), N'Nữ', N'0987123657', N'TP05')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH007', N'Võ Chí Khương', N'054203007640', CAST(N'2003-01-07' AS Date), N'Nam', N'0768495049', N'TP04')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH008', N'Đinh Trung Nguyên', N'079203015206', CAST(N'2003-03-08' AS Date), N'Nam', N'0866049283', N'TP01')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH009', N'Mai Thị Ngọc', N'098412364875', CAST(N'2003-08-07' AS Date), N'Nữ', N'0974125487', N'TP03')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CCCD], [NgaySinh], [GioiTinh], [SDT], [MaThanhPho]) VALUES (N'KH010', N'Trịnh Phương Anh', N'087512697845', CAST(N'2001-08-07' AS Date), N'Nữ', N'0987451254', N'TP10')
GO
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [GiaPhong]) VALUES (N'LP01', N'VIP', 550000)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [GiaPhong]) VALUES (N'LP02', N'Thường', 350000)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV001', N'Nguyễn Đoàn Tiến Anh', N'724241928822', CAST(N'2003-02-23' AS Date), N'Nam', N'0333714071')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV002', N'Phan Lê Thành Công', N'091203002715', CAST(N'2003-09-16' AS Date), N'Nam', N'0945052542')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV003', N'Trần Thị An', N'098751268895', CAST(N'2000-08-09' AS Date), N'Nữ', N'0958788512')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV004', N'Võ Thế Dân', N'080203013191', CAST(N'2003-04-13' AS Date), N'Nam', N'0858591303')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV005', N'Phan Thị Tú Trinh', N'096547826587', CAST(N'2003-01-13' AS Date), N'Nữ', N'0985632148')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV006', N'Huỳnh Nam Duy', N'089203023180', CAST(N'2003-01-16' AS Date), N'Nam', N'0834643661')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV007', N'Nguyễn Hồng Thông Điệp', N'080203003735', CAST(N'2003-12-02' AS Date), N'Nam', N'0392963132')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV008', N'Nguyễn Thị Quỳnh Anh', N'098745235487', CAST(N'2001-02-06' AS Date), N'Nữ', N'0965487523')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV009', N'Vũ Thị Yến', N'087569521598', CAST(N'2002-03-06' AS Date), N'Nữ', N'0987452136')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [CCCD], [NgaySinh], [GioiTinh], [SDT]) VALUES (N'NV010', N'Hồ Văn Huỳnh Hợp', N'083218474559', CAST(N'2003-11-08' AS Date), N'Nam', N'0982499757')
GO
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P01', N'LP01', N'101', 4, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P02', N'LP02', N'201', 2, 0, N'HD002')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P03', N'LP01', N'102', 4, 0, N'HD005')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P04', N'LP02', N'203', 2, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P05', N'LP02', N'204', 2, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P06', N'LP01', N'103', 2, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P07', N'LP02', N'205', 2, 0, N'HD004')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P08', N'LP01', N'104', 3, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P09', N'LP01', N'105', 2, 1, NULL)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [SoPhong], [SoLuongNguoi], [PhongTrong], [MaHopDong]) VALUES (N'P10', N'LP02', N'206', 2, 1, NULL)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau]) VALUES (N'user', N'123456')
GO
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP01', N'Hồ Chí Minh')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP02', N'Nha Trang')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP03', N'Bến Tre')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP04', N'Thanh Hóa')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP05', N'Hà Nội')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP06', N'Bình Định')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP07', N'Đồng Nai')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP08', N'Long An')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP09', N'Trà Vinh')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (N'TP10', N'Cà Mau')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__A955A0AA57A91B09]    Script Date: 6/6/2023 1:41:17 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__CA1930A500CFFA20]    Script Date: 6/6/2023 1:41:17 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__A955A0AA9EACE50C]    Script Date: 6/6/2023 1:41:17 AM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__CA1930A5615FA250]    Script Date: 6/6/2023 1:41:17 AM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Phong__7C736CA16A89734A]    Script Date: 6/6/2023 1:41:17 AM ******/
ALTER TABLE [dbo].[Phong] ADD UNIQUE NONCLUSTERED 
(
	[SoPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHo__MaKha__571DF1D5] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK__ChiTietHo__MaKha__571DF1D5]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHo__MaNha__5629CD9C] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK__ChiTietHo__MaNha__5629CD9C]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__MaHopDon__5EBF139D] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[ChiTietHopDong] ([MaHopDong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__MaHopDon__5EBF139D]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaThanhPho])
REFERENCES [dbo].[ThanhPho] ([MaThanhPho])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK__Phong__MaHopDong__5BE2A6F2] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[ChiTietHopDong] ([MaHopDong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK__Phong__MaHopDong__5BE2A6F2]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatChiTietHopDong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatChiTietHopDong]
	@MaHopDong nvarchar(10),
	@SoNgayThue int
AS
BEGIN
	UPDATE ChiTietHopDong 
	SET
	SoNgayThue=@SoNgayThue
	WHERE MaHopDong=@MaHopDong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatKhachHang]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCapNhatKhachHang] 
@MaKhachHang nvarchar(10),
@TenKhachHang nvarchar(30),
@CCCD nvarchar(12),
@NgaySinh date,
@GioiTinh nvarchar(3),
@DienThoai nvarchar(10),
@MaThanhPho nvarchar(10)
AS
BEGIN
	UPDATE KhachHang 
	SET
	TenKhachHang=@TenKhachHang, 
	CCCD=@CCCD, 
	NgaySinh=@NgaySinh, 
	GioiTinh=@GioiTinh, 
	SDT=@DienThoai
	WHERE MaKhachHang=@MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatLoaiPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatLoaiPhong] 
@MaLoaiPhong nvarchar(10),
@TenLoaiPhong nvarchar(30),
@GiaPhong int
AS
BEGIN
	UPDATE LoaiPhong 
	SET
	TenLoaiPhong=@TenLoaiPhong, 
	GiaPhong=@GiaPhong
	WHERE MaLoaiPhong=@MaLoaiPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatMaHopDong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatMaHopDong]
	@MaPhong nvarchar(10),
	@MaHopDong nvarchar(10)
AS
BEGIN
	UPDATE Phong 
	SET
	PhongTrong = '0',
	MaHopDong = @MaHopDong
    WHERE MaPhong = @MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatNhanVien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCapNhatNhanVien] 
@MaNhanVien nvarchar(10),
@TenNhanVien nvarchar(30),
@CCCD nvarchar(12),
@NgaySinh date,
@GioiTinh nvarchar(3),
@DienThoai nvarchar(10)
AS
BEGIN
	UPDATE NhanVien 
	SET
	TenNhanVien=@TenNhanVien, 
	CCCD=@CCCD, 
	NgaySinh=@NgaySinh, 
	GioiTinh=@GioiTinh, 
	SDT=@DienThoai
	WHERE MaNhanVien=@MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatPhong]
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@SoPhong nvarchar(3),
	@SoLuongNguoi int
AS
BEGIN
	UPDATE Phong 
	SET
	MaLoaiPhong=@MaLoaiPhong, 
	SoPhong=@SoPhong,
	SoLuongNguoi=@SoLuongNguoi 
	WHERE MaPhong=@MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatSoPhongThue]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatSoPhongThue]
	@MaHopDong nvarchar(10)
AS
BEGIN
	UPDATE ChiTietHopDong 
	SET
	SoLuongPhongThue = SoLuongPhongThue + 1
	WHERE MaHopDong=@MaHopDong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatThanhPho]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCapNhatThanhPho]
@MaThanhPho nvarchar(10),
@TenThanhPho nvarchar(30)
AS
BEGIN
	UPDATE ThanhPho 
	SET
	TenThanhPho=@TenThanhPho
	WHERE MaThanhPho=@MaThanhPho
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTinhTrangPhongThue]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTinhTrangPhongThue]
	@MaHopDong nvarchar(10)
AS
BEGIN
	UPDATE Phong 
	SET
	PhongTrong = '1', 
	MaHopDong = NULL
	WHERE MaHopDong=@MaHopDong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTinhTrangThanhToan]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTinhTrangThanhToan]
	@MaHopDong nvarchar(10)
AS
BEGIN
	UPDATE ChiTietHopDong 
	SET
	TinhTrangThanhToan = '1'
	WHERE MaHopDong=@MaHopDong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatTongTien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCapNhatTongTien]
	@MaHopDong nvarchar(10),
	@TongTien int
AS
BEGIN
	UPDATE ChiTietHopDong 
	SET
	TongTien=@TongTien
	WHERE MaHopDong=@MaHopDong
END
GO
/****** Object:  StoredProcedure [dbo].[spDoiMatKhau]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDoiMatKhau]
	@TenDangNhap nvarchar(10),
	@MatKhau nvarchar(10)
AS
BEGIN
	UPDATE TaiKhoan 
	SET
	MatKhau = @MatKhau
	WHERE TenDangNhap=@TenDangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[spLocKhachHang]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLocKhachHang] 
	@MaKhachHang nvarchar(10),
	@TenKhachHang nvarchar(30),
	@CCCD nvarchar(12),
	@NgaySinh date,
	@GioiTinh nvarchar(3),
	@DienThoai nvarchar(10),
	@MaThanhPho nvarchar(10)
AS
BEGIN
	SELECT * FROM KhachHang
    WHERE (@MaKhachHang = N'' OR MaKhachHang LIKE '%' + @MaKhachHang + '%') 
		AND (@TenKhachHang = N'' OR TenKhachHang LIKE '%' + @TenKhachHang + '%')
        AND (@CCCD = N'' OR CCCD LIKE '%' + @CCCD + '%')
        AND (@NgaySinh = N'' OR NgaySinh = @NgaySinh)
		AND (@GioiTinh = N'' OR GioiTinh = @GioiTinh)
		AND (@DienThoai = N'' OR SDT LIKE '%' + @DienThoai + '%')
		AND (@MaThanhPho = N'' OR MaThanhPho = @MaThanhPho)
END
GO
/****** Object:  StoredProcedure [dbo].[spLocNhanVien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLocNhanVien] 
	@MaNhanVien nvarchar(10),
	@TenNhanVien nvarchar(30),
	@CCCD nvarchar(12),
	@NgaySinh date,
	@GioiTinh nvarchar(3),
	@DienThoai nvarchar(10)
AS
BEGIN
	SELECT * FROM NhanVien
    WHERE (@MaNhanVien = N'' OR MaNhanVien LIKE '%' + @MaNhanVien + '%') 
		AND (@TenNhanVien = N'' OR TenNhanVien LIKE '%' + @TenNhanVien + '%')
        AND (@CCCD = N'' OR CCCD LIKE '%' + @CCCD + '%')
        AND (@NgaySinh = N'' OR NgaySinh = @NgaySinh)
		AND (@GioiTinh = N'' OR GioiTinh = @GioiTinh)
		AND (@DienThoai = N'' OR SDT LIKE '%' + @DienThoai + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[spThemChiTietHopDong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemChiTietHopDong]
	@MaHopDong nvarchar(10),
	@MaNhanVien nvarchar(10),
	@MaKhachHang nvarchar(10),
	@NgayVao date,
	@SoNgayThue int,
	@SoLuongPhongThue int,
	@TongTien int,
	@TinhTrangThanhToan bit
AS
BEGIN
	INSERT INTO ChiTietHopDong VALUES(@MaHopDong, @MaNhanVien, @MaKhachHang, @NgayVao, @SoNgayThue, @SoLuongPhongThue, @TongTien, @TinhTrangThanhToan)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemHoaDon]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemHoaDon]
	@MaHoaDon nvarchar(10),
	@MaHopDong nvarchar(10),
	@TongTien int,
	@NgayThanhToan date
AS
BEGIN
	INSERT INTO HoaDon VALUES(@MaHoaDon, @MaHopDong, @TongTien, @NgayThanhToan)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemKhachHang]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemKhachHang]
@MaKhachHang nvarchar(10),
@TenKhachHang nvarchar(30),
@CCCD nvarchar(12),
@NgaySinh date,
@GioiTinh nvarchar(3),
@DienThoai nvarchar(10),
@MaThanhPho nvarchar(10)
AS
BEGIN
	INSERT INTO KhachHang VALUES(@MaKhachHang, @TenKhachHang, @CCCD, @NgaySinh, @GioiTinh, @DienThoai, @MaThanhPho)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemLoaiPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Loại Phòng
CREATE PROCEDURE [dbo].[spThemLoaiPhong]
@MaLoaiPhong nvarchar(10),
@TenLoaiPhong nvarchar(30),
@GiaPhong int
AS
BEGIN
	INSERT INTO LoaiPhong VALUES(@MaLoaiPhong, @TenLoaiPhong, @GiaPhong)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemNhanVien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Nhân Viên
CREATE PROCEDURE [dbo].[spThemNhanVien] 
@MaNhanVien nvarchar(10),
@TenNhanVien nvarchar(30),
@CCCD nvarchar(12),
@NgaySinh date,
@GioiTinh nvarchar(3),
@DienThoai nvarchar(10)
AS
BEGIN
	INSERT INTO NhanVien VALUES(@MaNhanVien, @TenNhanVien, @CCCD, @NgaySinh, @GioiTinh, @DienThoai)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemPhong]
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@SoPhong nvarchar(3),
	@SoLuongNguoi int,
	@PhongTrong bit
AS
BEGIN
	INSERT INTO Phong (MaPhong, MaLoaiPhong, SoPhong, SoLuongNguoi, PhongTrong)
	VALUES(@MaPhong, @MaLoaiPhong, @SoPhong, @SoLuongNguoi, @PhongTrong)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemTaiKhoan]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemTaiKhoan]
	@TenDangNhap nvarchar(10),
	@MatKhau nvarchar(10)
AS
BEGIN
	INSERT INTO TaiKhoan VALUES(@TenDangNhap, @MatKhau)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemThanhPho]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemThanhPho] 
@MaThanhPho nvarchar(10),
@TenThanhPho nvarchar(30)
AS
BEGIN
	INSERT INTO ThanhPho VALUES(@MaThanhPho, @TenThanhPho)
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaKhachHang]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spXoaKhachHang] 
@MaKhachHang nvarchar(10)
AS
BEGIN
	DELETE FROM KhachHang
	WHERE MaKhachHang=@MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaLoaiPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaLoaiPhong] 
@MaLoaiPhong nvarchar(10)
AS
BEGIN
	DELETE FROM LoaiPhong
	WHERE MaLoaiPhong=@MaLoaiPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaNhanVien]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spXoaNhanVien] 
@MaNhanVien nvarchar(10)
AS
BEGIN
	DELETE FROM NhanVien
	WHERE MaNhanVien=@MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaPhong]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaPhong] 
	@MaPhong nvarchar(10)
AS
BEGIN
	DELETE FROM Phong
	WHERE MaPhong=@MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaTaiKhoan]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spXoaTaiKhoan]
	@TenDangNhap nvarchar(10)
AS
BEGIN
	DELETE FROM TaiKhoan
	WHERE TenDangNhap=@TenDangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaThanhPho]    Script Date: 6/6/2023 1:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spXoaThanhPho]
@MaThanhPho nvarchar(10)
AS
BEGIN
	DELETE FROM ThanhPho
	WHERE MaThanhPho=@MaThanhPho
END
GO
