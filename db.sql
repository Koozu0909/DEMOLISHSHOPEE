USE [QUANLYTHUONGMAI]
GO
/****** Object:  User [root]    Script Date: 5/13/2023 2:47:54 PM ******/
CREATE USER [root] FOR LOGIN [root] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tb_Address]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Address](
	[MaAddress] [int] IDENTITY(1,1) NOT NULL,
	[MaA1] [int] NULL,
	[MaA2] [int] NULL,
	[MaA3] [int] NULL,
	[ChiTiet] [nvarchar](200) NULL,
	[MaUser] [int] NULL,
 CONSTRAINT [PK_tb_Address] PRIMARY KEY CLUSTERED 
(
	[MaAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_AddressLV1]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_AddressLV1](
	[MaA1] [int] IDENTITY(1,1) NOT NULL,
	[TenA1] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_AddressLV1] PRIMARY KEY CLUSTERED 
(
	[MaA1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_AddressLV2]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_AddressLV2](
	[MaA2] [int] IDENTITY(1,1) NOT NULL,
	[TenA2] [nvarchar](50) NOT NULL,
	[MaA1] [int] NULL,
 CONSTRAINT [PK_tb_AddressLV2] PRIMARY KEY CLUSTERED 
(
	[MaA2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_AddressLV3]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_AddressLV3](
	[MaA3] [int] IDENTITY(1,1) NOT NULL,
	[TenA3] [nvarchar](50) NULL,
	[MaA2] [int] NULL,
 CONSTRAINT [PK_tb_AddressLV3] PRIMARY KEY CLUSTERED 
(
	[MaA3] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Branch]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Branch](
	[MaCuaHang] [int] IDENTITY(1,1) NOT NULL,
	[TenCuaHang] [nvarchar](50) NULL,
	[isMail] [int] NULL,
	[MieuTa] [ntext] NULL,
	[MaUser] [int] NULL,
 CONSTRAINT [PK_tb_Branch] PRIMARY KEY CLUSTERED 
(
	[MaCuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Branch_Product]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Branch_Product](
	[MaBranchProduct] [int] IDENTITY(1,1) NOT NULL,
	[MaCuaHang] [int] NULL,
	[MaSP] [int] NULL,
	[SoLuongSP] [int] NULL,
 CONSTRAINT [PK_tb_Branch_Product] PRIMARY KEY CLUSTERED 
(
	[MaBranchProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_BranchFollow]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BranchFollow](
	[MaBranchFollow] [int] IDENTITY(1,1) NOT NULL,
	[MaUser] [int] NULL,
	[MaCuaHang] [int] NULL,
 CONSTRAINT [PK_tb_BranchFollow] PRIMARY KEY CLUSTERED 
(
	[MaBranchFollow] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Brand]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Brand](
	[MaThuongHieu] [int] IDENTITY(1,1) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Brand] PRIMARY KEY CLUSTERED 
(
	[MaThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Cart]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Cart](
	[MaCart] [int] IDENTITY(1,1) NOT NULL,
	[MaUser] [int] NULL,
 CONSTRAINT [PK_tb_Cart] PRIMARY KEY CLUSTERED 
(
	[MaCart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Cart_Branch_Product]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Cart_Branch_Product](
	[MaCart] [int] NOT NULL,
	[MaBranchProduct] [int] NOT NULL,
 CONSTRAINT [PK_tb_Cart_Branch_Product] PRIMARY KEY CLUSTERED 
(
	[MaCart] ASC,
	[MaBranchProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Categories]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Categories](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[Parent] [int] NULL,
	[Role] [int] NULL,
	[ImagePath] [nvarchar](200) NULL,
	[TenLoaiSP] [nchar](50) NULL,
 CONSTRAINT [PK_tb_Categories] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Comment]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Comment](
	[MaComment] [int] IDENTITY(1,1) NOT NULL,
	[MaUser] [int] NULL,
	[MaSP] [int] NULL,
	[Rate] [int] NULL,
	[IDReply] [int] NULL,
	[NoiDung] [nvarchar](max) NULL,
	[CreateDay] [date] NULL,
	[CreateBy] [int] NULL,
	[UpdateDay] [date] NULL,
	[UpdateBy] [int] NULL,
 CONSTRAINT [PK_tb_Comment] PRIMARY KEY CLUSTERED 
(
	[MaComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Description]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Description](
	[MaMoTa] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[MoTa] [ntext] NULL,
 CONSTRAINT [PK_tb_Description] PRIMARY KEY CLUSTERED 
(
	[MaMoTa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Favourite]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Favourite](
	[MaYeuThich] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[MaUser] [int] NULL,
 CONSTRAINT [PK_tb_Favourite] PRIMARY KEY CLUSTERED 
(
	[MaYeuThich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ImageSlide]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ImageSlide](
	[MaImageSlide] [int] IDENTITY(1,1) NOT NULL,
	[ImageSlidePath] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_ImageSlide] PRIMARY KEY CLUSTERED 
(
	[MaImageSlide] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Order]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Order](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaUser] [int] NULL,
	[MaPayment] [int] NULL,
	[MaTrangThai] [int] NULL,
	[CreateDay] [nchar](10) NULL,
 CONSTRAINT [PK_tb_Order] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_OrderDetail]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_OrderDetail](
	[MaDonHangCT] [int] IDENTITY(1,1) NOT NULL,
	[MaDonHang] [int] NULL,
	[MaBranchProduct] [int] NULL,
	[SoLuongSP] [int] NULL,
 CONSTRAINT [PK_tb_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[MaDonHangCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Origin]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Origin](
	[MaXuatXu] [int] IDENTITY(1,1) NOT NULL,
	[TenXuatXu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Origin] PRIMARY KEY CLUSTERED 
(
	[MaXuatXu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_PaymentMethod]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PaymentMethod](
	[MaPayment] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethod] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[MaPayment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Product]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Product](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[SeoName] [nvarchar](50) NULL,
	[MaLoaiSP] [int] NULL,
	[MaThuongHieu] [int] NULL,
	[MaLoaiBaoHanh] [nchar](10) NULL,
	[MaHanBaoHanh] [int] NULL,
	[MaXuatXu] [int] NULL,
	[TotalRate] [int] NULL,
	[GiaSP] [int] NULL,
	[CreateDay] [date] NULL,
	[CreateBy] [int] NULL,
	[UpdateDay] [date] NULL,
	[UpdateBy] [int] NULL,
	[DeleteDay] [date] NULL,
	[DeleteBy] [int] NULL,
 CONSTRAINT [PK_tb_Product] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Product_Tag]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Product_Tag](
	[MaProductTag] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[MaTag] [int] NULL,
 CONSTRAINT [PK_tb_Product_Tag] PRIMARY KEY CLUSTERED 
(
	[MaProductTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ProductImage]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ProductImage](
	[MaImage] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](50) NULL,
	[MaSP] [int] NULL,
 CONSTRAINT [PK_tb_ProductImage] PRIMARY KEY CLUSTERED 
(
	[MaImage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_RoleCate]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_RoleCate](
	[MaRole] [int] IDENTITY(1,1) NOT NULL,
	[TenRole] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_RoleCate] PRIMARY KEY CLUSTERED 
(
	[MaRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Status_Order]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Status_Order](
	[MaTrangThai] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Status_Order] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Tag]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Tag](
	[MaTag] [int] IDENTITY(1,1) NOT NULL,
	[TenTag] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_Tag] PRIMARY KEY CLUSTERED 
(
	[MaTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[MaUser] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Gmail] [nvarchar](50) NULL,
	[SDT] [nvarchar](20) NULL,
	[UserName] [nvarchar](50) NULL,
	[PassWord] [nvarchar](max) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [date] NULL,
	[Avatar] [varbinary](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tb_User] PRIMARY KEY CLUSTERED 
(
	[MaUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_WarrantyPeriod]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_WarrantyPeriod](
	[MaHanBaoHanh] [int] IDENTITY(1,1) NOT NULL,
	[HanBaoHanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_WarrantyPeriod] PRIMARY KEY CLUSTERED 
(
	[MaHanBaoHanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_WarrantyType]    Script Date: 5/13/2023 2:47:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_WarrantyType](
	[MaLoaiBaoHanh] [int] IDENTITY(1,1) NOT NULL,
	[LoaiBaoHanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_WarrantyType] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBaoHanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_Address] ON 

INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (1, 1, 4, 1, N'ở trên núi', 1)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (2, 1, 4, 2, N'ở dưới biển', 2)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (3, 1, 4, 3, N'ở đồng bằng', 3)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (4, 1, 5, 5, N'siêu cấp tầng trời', 4)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (5, 1, 5, 6, N'siêu cấp tầng trời', 5)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (6, 1, 6, 9, NULL, 6)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (7, 1, 7, 13, NULL, 7)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (8, 2, 20, 29, NULL, 8)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (9, 2, 21, 33, N'', 9)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (10, 2, 22, 37, NULL, 10)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (11, 1, 4, 2, N'siêu cấp tầng trời', 1)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (12, 1, 4, 3, N'siêu cấp tầng trời', 2)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (13, 1, 4, 4, N'siêu cấp tầng trời', 3)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (14, 1, 5, 6, N'siêu cấp tầng trời', 4)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (15, 1, 5, 7, N'siêu cấp tầng trời', 5)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (16, 1, 6, 10, N'siêu cấp tầng trời', 6)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (17, 1, 7, 14, N'siêu cấp tầng trời', 7)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (18, 2, 20, 30, N'ở đồng bằng', 8)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (19, 2, 21, 34, N'ở đồng bằng', 9)
INSERT [dbo].[tb_Address] ([MaAddress], [MaA1], [MaA2], [MaA3], [ChiTiet], [MaUser]) VALUES (20, 2, 22, 38, N'ở đồng bằng', 10)
SET IDENTITY_INSERT [dbo].[tb_Address] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_AddressLV1] ON 

INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (1, N'An Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (2, N'Bà Rịa - Vũng Tàu')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (3, N'Bắc Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (4, N'Bắc Kạn')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (5, N'Bạc Liêu')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (6, N'Bắc Ninh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (7, N'Bến Tre')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (8, N'Bình Định')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (9, N'Bình Dương')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (10, N'Bình Phước')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (11, N'Bình Thuận')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (12, N'Cà Mau')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (13, N'Cần Thơ')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (14, N'Cao Bằng')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (15, N'Đà Nẵng')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (16, N'Đắk Lắk')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (17, N'Đắk Nông')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (18, N'Điện Biên')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (19, N'Đồng Nai')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (20, N'Đồng Tháp')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (21, N'Gia Lai')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (22, N'Hà Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (23, N'Hà Nam')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (24, N'Hà Nội')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (25, N'Hà Tĩnh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (26, N'Hải Dương')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (27, N'Hải Phòng')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (28, N'Hậu Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (29, N'Hòa Bình')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (30, N'Hưng Yên')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (31, N'Khánh Hòa')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (32, N'Kiên Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (33, N'Kon Tum')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (34, N'Lai Châu')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (35, N'Lâm Đồng')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (36, N'Lạng Sơn')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (37, N'Lào Cai')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (38, N'Long An')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (39, N'Nam Định')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (40, N'Nghệ An')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (41, N'Ninh Bình')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (42, N'Ninh Thuận')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (43, N'Phú Thọ')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (44, N'Phú Yên')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (45, N'Quảng Bình')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (46, N'Quảng Nam')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (47, N'Quảng Ngãi')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (48, N'Quảng Ninh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (49, N'Quảng Trị')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (50, N'Sóc Trăng')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (51, N'Sơn La')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (52, N'Tây Ninh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (53, N'Thái Bình')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (54, N'Thái Nguyên')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (55, N'Thanh Hóa')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (56, N'Thừa Thiên Huế')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (57, N'Tiền Giang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (58, N'TP Hồ Chí Minh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (59, N'Trà Vinh')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (60, N'Tuyên Quang')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (61, N'Vĩnh Long')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (62, N'Vĩnh Phúc')
INSERT [dbo].[tb_AddressLV1] ([MaA1], [TenA1]) VALUES (63, N'Yên Bái')
SET IDENTITY_INSERT [dbo].[tb_AddressLV1] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_AddressLV2] ON 

INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (4, N'Huyện Châu Phú', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (5, N'Huyện Châu Thành', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (6, N'Huyện Chợ Mới', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (7, N'Huyện Phú Tân', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (8, N'Huyện Thoại Sơn', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (9, N'Huyện Tịnh Biên', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (10, N'Huyện Tri Tôn', 1)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (20, N'Thành phố Bà Rịa', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (21, N'Thành phố Vũng Tàu', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (22, N'Thị xã Phú Mỹ', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (23, N'Huyện Châu Đức', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (24, N'Huyện Côn Đảo', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (25, N'Huyện Đất Đỏ', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (26, N'Huyện Long Điền', 2)
INSERT [dbo].[tb_AddressLV2] ([MaA2], [TenA2], [MaA1]) VALUES (27, N'Huyện Xuyên Mộc', 2)
SET IDENTITY_INSERT [dbo].[tb_AddressLV2] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_AddressLV3] ON 

INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (1, N'Xã Châu Phong', 4)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (2, N'Xã Núi Voi', 4)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (3, N'Xã Bình Long', 4)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (4, N'Xã Phú Hội', 4)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (5, N'Xã Châu Thành', 5)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (6, N'Xã An Châu', 5)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (7, N'Xã Phú Hòa', 5)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (8, N'Xã Phú Hựu', 5)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (9, N'Xã Mỹ An', 6)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (10, N'Xã Mỹ Hội Đông', 6)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (11, N'Xã Mỹ Luông', 6)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (12, N'Xã Long Điền A', 6)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (13, N'Xã Phú Thạnh A', 7)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (14, N'Xã Phú Sơn', 7)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (15, N'Xã Phú Thạnh B', 7)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (16, N'Xã Phú Lộc', 7)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (17, N'Thoại Giang', 8)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (18, N'Thoại Sơn', 8)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (19, N'Thoại Lương', 8)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (20, N'Thoại Thành', 8)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (21, N'Xã Tịnh Biên', 9)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (22, N'Xã An Hảo', 9)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (23, N'Xã An Nông', 9)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (24, N'Xã An Phước', 9)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (25, N'Xã Tri Tôn', 10)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (26, N'Xã Lạc Quới', 10)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (27, N'Xã Lương Tâm', 10)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (28, N'Xã Vĩnh Gia', 10)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (29, N'Xã Kim Dinh', 20)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (30, N'Xã Long Hương', 20)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (31, N'Xã Long Tâm', 20)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (32, N'Xã Phước Hưng', 20)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (33, N'Xã Long Sơn', 21)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (34, N'Xã Long Hương', 21)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (35, N'Xã Long Tâm', 21)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (36, N'Xã Phước Tân', 21)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (37, N'Xã Mỹ Xuân', 22)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (38, N'Xã Mỹ Thạnh', 22)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (39, N'Xã Phước Hoà', 22)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (40, N'Xã Tân Hải', 22)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (41, N'Xã Bàu Chinh', 23)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (42, N'Xã Bình Châu', 23)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (43, N'Xã Cù Bị', 23)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (44, N'Xã Láng Lớn', 23)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (45, N'Xã An Hải', 24)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (46, N'Xã An Vĩnh', 24)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (47, N'Xã Côn Đảo', 24)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (48, N'Xã Bà Rịa', 24)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (49, N'Xã Phước Hải', 25)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (50, N'Xã Long Mỹ', 25)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (51, N'Xã Long Điền', 25)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (52, N'Xã An Ngãi', 25)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (53, N'Xã An Quý', 26)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (54, N'Xã Long Điền Đông', 26)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (55, N'Xã Long Điền Tây', 26)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (56, N'Xã An Ngãi Trung', 26)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (57, N'Xã Xuyên Mộc', 27)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (58, N'Xã Bàu Lâm', 27)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (59, N'Xã Hòa Bình', 27)
INSERT [dbo].[tb_AddressLV3] ([MaA3], [TenA3], [MaA2]) VALUES (60, N'Xã Bình Châu', 27)
SET IDENTITY_INSERT [dbo].[tb_AddressLV3] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Branch] ON 

INSERT [dbo].[tb_Branch] ([MaCuaHang], [TenCuaHang], [isMail], [MieuTa], [MaUser]) VALUES (1, N'Của hàng của 1', 0, N'bán đồ gia dụng', 1)
INSERT [dbo].[tb_Branch] ([MaCuaHang], [TenCuaHang], [isMail], [MieuTa], [MaUser]) VALUES (2, N'của hàng của én', 0, N'bán tủ quần áo', 2)
INSERT [dbo].[tb_Branch] ([MaCuaHang], [TenCuaHang], [isMail], [MieuTa], [MaUser]) VALUES (3, N'cửa hàng của ngạn', 1, N'bán xà bông', 3)
INSERT [dbo].[tb_Branch] ([MaCuaHang], [TenCuaHang], [isMail], [MieuTa], [MaUser]) VALUES (4, N'Omimi', 1, N'Điện thaoij', 4)
INSERT [dbo].[tb_Branch] ([MaCuaHang], [TenCuaHang], [isMail], [MieuTa], [MaUser]) VALUES (5, N'Kiki', 1, N'Áo quần', 5)
SET IDENTITY_INSERT [dbo].[tb_Branch] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Branch_Product] ON 

INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (2, 1, 1, 10)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (3, 1, 2, 20)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (4, 1, 3, 4)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (5, 1, 4, 2)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (6, 2, 5, 4)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (7, 2, 6, 3)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (8, 3, 7, 4)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (9, 3, 8, 3)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (10, 4, 9, 10)
INSERT [dbo].[tb_Branch_Product] ([MaBranchProduct], [MaCuaHang], [MaSP], [SoLuongSP]) VALUES (11, 5, 10, 10)
SET IDENTITY_INSERT [dbo].[tb_Branch_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_BranchFollow] ON 

INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (3, 1, 1)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (4, 1, 2)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (5, 1, 3)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (6, 1, 4)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (7, 2, 1)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (8, 2, 2)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (9, 2, 3)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (10, 2, 4)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (11, 3, 1)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (12, 3, 1)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (13, 4, 1)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (14, 4, 3)
INSERT [dbo].[tb_BranchFollow] ([MaBranchFollow], [MaUser], [MaCuaHang]) VALUES (15, 5, 1)
SET IDENTITY_INSERT [dbo].[tb_BranchFollow] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Brand] ON 

INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (1, N'Gucci')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (2, N'ViKup')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (3, N'Kalaki')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (4, N'Suki')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (5, N'Adidas')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (6, N'Oke')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (7, N'Nhật Hà')
INSERT [dbo].[tb_Brand] ([MaThuongHieu], [TenThuongHieu]) VALUES (8, N'Nice')
SET IDENTITY_INSERT [dbo].[tb_Brand] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Cart] ON 

INSERT [dbo].[tb_Cart] ([MaCart], [MaUser]) VALUES (1, 1)
INSERT [dbo].[tb_Cart] ([MaCart], [MaUser]) VALUES (2, 2)
INSERT [dbo].[tb_Cart] ([MaCart], [MaUser]) VALUES (3, 3)
SET IDENTITY_INSERT [dbo].[tb_Cart] OFF
GO
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (1, 2)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (1, 3)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (1, 4)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (2, 2)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (2, 4)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (3, 7)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (3, 8)
INSERT [dbo].[tb_Cart_Branch_Product] ([MaCart], [MaBranchProduct]) VALUES (3, 9)
GO
SET IDENTITY_INSERT [dbo].[tb_Categories] ON 

INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (1, NULL, 1, NULL, N'Thời Trang Nữ                                     ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (2, NULL, 1, NULL, N'Thời Trang Nam                                    ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (3, NULL, 1, NULL, N'Sắc Đẹp                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (4, NULL, 1, NULL, N'Sức Khỏe                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (5, 1, 2, NULL, N'Áo                                                ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (6, 1, 2, NULL, N'Quần                                              ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (7, 1, 2, NULL, N'Quần đùi                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (8, 1, 2, NULL, N'Váy                                               ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (9, 2, 2, NULL, N'Quần jean                                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (10, 2, 2, NULL, N'Hoodie & Áo nỉ                                    ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (11, 2, 2, NULL, N'Áo len                                            ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (12, 3, 2, NULL, N'Chăm sóc tay, chân & móng                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (13, 3, 2, NULL, N'Chăm sóc tóc                                      ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (14, 3, 2, NULL, N'Chăm sóc nam giới                                 ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (15, 4, 2, NULL, N'Thực phẩm chức năng                               ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (16, 4, 2, NULL, N'Hỗ trợ tình dục                                   ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (17, 4, 2, NULL, N'Vật tư y tế                                       ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (18, 5, 3, NULL, N'Áo hai dây và ba lỗ                               ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (19, 5, 3, NULL, N'Áo ống                                            ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (20, 5, 3, NULL, N'Áo thun                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (21, 6, 3, NULL, N'Quần legging                                      ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (22, 6, 3, NULL, N'Quần dài                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (23, 6, 3, NULL, N'Khác                                              ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (24, 7, 3, NULL, N'Quần đùi                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (25, 7, 3, NULL, N'Quần váy                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (26, 7, 3, NULL, N'Khác                                              ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (27, 8, 3, NULL, N'Váy ngắn                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (28, 8, 3, NULL, N'Váy dày                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (29, 8, 3, NULL, N'Váy bơi                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (30, 9, 3, NULL, N'Jean ngắn                                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (31, 9, 3, NULL, N'Jean bò                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (32, 9, 3, NULL, N'jean rách                                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (33, 10, 3, NULL, N'Áo hoodie                                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (34, 10, 3, NULL, N'Áo nỉ                                             ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (35, 10, 3, NULL, N'Khác                                              ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (36, 11, 3, NULL, N'Len nilon                                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (37, 11, 3, NULL, N'Len tăm                                           ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (38, 11, 3, NULL, N'Len ấm                                            ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (39, 12, 3, NULL, N'Chăm sóc tay                                      ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (40, 12, 3, NULL, N'Kem dưỡng, dầu dưỡng & sữa                        ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (41, 12, 3, NULL, N'Xà phòng rửa tay                                  ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (42, 13, 3, NULL, N'Khử mùi hôi chân                                  ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (43, 13, 3, NULL, N'Mặt nạ cho chân                                   ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (44, 13, 3, NULL, N'Kem dưỡng, dầu dưỡng & sữa                        ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (45, 14, 3, NULL, N'Sơn nền & sơn bóng                                ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (46, 14, 3, NULL, N'Sơn móng                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (47, 14, 3, NULL, N'Dụng cụ tẩy sơn móng                              ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (48, 15, 3, NULL, N'Hỗ trợ kiểm soát cân nặng                         ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (49, 15, 3, NULL, N'Hỗ trợ làm đẹp                                    ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (50, 15, 3, NULL, N'Hỗ trợ tăng cơ                                    ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (51, 16, 3, NULL, N'Bao cao su                                        ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (52, 16, 3, NULL, N'Bôi trơn                                          ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (53, 16, 3, NULL, N'Tăng cường sinh lý                                ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (54, 17, 3, NULL, N'Chăm sóc mũi                                      ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (55, 17, 3, NULL, N'Ống nghe y tế                                     ')
INSERT [dbo].[tb_Categories] ([MaLoaiSP], [Parent], [Role], [ImagePath], [TenLoaiSP]) VALUES (56, 17, 3, NULL, N'Dụng cụ thí nghiệm                                ')
SET IDENTITY_INSERT [dbo].[tb_Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Comment] ON 

INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (1, 1, 1, 4, NULL, N'Quá tuyệt vời', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (2, 2, 1, 5, NULL, N'Xuất xắc', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (3, 3, 1, 4, 1, N'đúng rồi hàng rất chuẩn', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (4, 4, 2, 3, NULL, N'đúng rồi hàng rất chuẩn', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (5, 5, 2, 3, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (6, 1, 2, 3, NULL, N'chuẩn', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
INSERT [dbo].[tb_Comment] ([MaComment], [MaUser], [MaSP], [Rate], [IDReply], [NoiDung], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy]) VALUES (7, 1, 2, 2, NULL, N'không oke', CAST(N'2023-05-13' AS Date), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tb_Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Favourite] ON 

INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (1, 1, 1)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (2, 2, 1)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (3, 3, 1)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (4, 1, 2)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (5, 2, 2)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (6, 1, 3)
INSERT [dbo].[tb_Favourite] ([MaYeuThich], [MaSP], [MaUser]) VALUES (7, 4, 3)
SET IDENTITY_INSERT [dbo].[tb_Favourite] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Order] ON 

INSERT [dbo].[tb_Order] ([MaDonHang], [MaUser], [MaPayment], [MaTrangThai], [CreateDay]) VALUES (1, 1, 1, 1, NULL)
INSERT [dbo].[tb_Order] ([MaDonHang], [MaUser], [MaPayment], [MaTrangThai], [CreateDay]) VALUES (2, 2, 1, 1, NULL)
INSERT [dbo].[tb_Order] ([MaDonHang], [MaUser], [MaPayment], [MaTrangThai], [CreateDay]) VALUES (3, 3, 2, 0, NULL)
SET IDENTITY_INSERT [dbo].[tb_Order] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_OrderDetail] ON 

INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (1, 1, 1, 2)
INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (2, 1, 1, 3)
INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (3, 2, 3, 3)
INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (4, 2, 4, 3)
INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (5, 3, 1, 5)
INSERT [dbo].[tb_OrderDetail] ([MaDonHangCT], [MaDonHang], [MaBranchProduct], [SoLuongSP]) VALUES (6, 3, 2, 5)
SET IDENTITY_INSERT [dbo].[tb_OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Origin] ON 

INSERT [dbo].[tb_Origin] ([MaXuatXu], [TenXuatXu]) VALUES (1, N'Việt Nam')
INSERT [dbo].[tb_Origin] ([MaXuatXu], [TenXuatXu]) VALUES (2, N'China')
INSERT [dbo].[tb_Origin] ([MaXuatXu], [TenXuatXu]) VALUES (3, N'USA')
SET IDENTITY_INSERT [dbo].[tb_Origin] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_PaymentMethod] ON 

INSERT [dbo].[tb_PaymentMethod] ([MaPayment], [PaymentMethod]) VALUES (1, N'Trả khi nhận')
INSERT [dbo].[tb_PaymentMethod] ([MaPayment], [PaymentMethod]) VALUES (2, N'thanh toán online')
SET IDENTITY_INSERT [dbo].[tb_PaymentMethod] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Product] ON 

INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (1, N'Áo Sơ mi', N'Áo Sư mi', 18, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), 1, CAST(N'2023-05-13' AS Date), 1, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (2, N'Áo 3 lỗ mát', N'Áo 3 lỗ mát', 18, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (3, N'Áo 3 lỗ ngắn', N'Áo 3 lỗ ngắn', 18, 1, N'1         ', 1, 1, 1, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (4, N'áo ống rộng ', N'áo ống rộng ', 19, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (5, N'Áo ống ngắn', N'Áo ống ngắn', 19, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (6, N'quần tây đen', N'quần tây đen', 22, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (7, N'quân tây kaki', N'quân tây kaki', 22, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (8, N'nón len ', N'nón len ', 36, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (9, N'xà phòng playboy', N'xà phòng playboy', 41, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_Product] ([MaSP], [TenSP], [SeoName], [MaLoaiSP], [MaThuongHieu], [MaLoaiBaoHanh], [MaHanBaoHanh], [MaXuatXu], [TotalRate], [GiaSP], [CreateDay], [CreateBy], [UpdateDay], [UpdateBy], [DeleteDay], [DeleteBy]) VALUES (10, N'sơn móng tay', N'sơn móng tay', 46, 1, N'1         ', 1, 1, NULL, NULL, CAST(N'2023-05-13' AS Date), NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tb_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Product_Tag] ON 

INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (1, 1, 1)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (2, 2, 1)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (3, 3, 1)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (4, 4, 2)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (5, 5, 2)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (6, 6, 3)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (7, 6, 3)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (8, 7, 2)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (9, 8, 2)
INSERT [dbo].[tb_Product_Tag] ([MaProductTag], [MaSP], [MaTag]) VALUES (10, 9, 2)
SET IDENTITY_INSERT [dbo].[tb_Product_Tag] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_RoleCate] ON 

INSERT [dbo].[tb_RoleCate] ([MaRole], [TenRole]) VALUES (1, N'cấp 1')
INSERT [dbo].[tb_RoleCate] ([MaRole], [TenRole]) VALUES (2, N'cấp 2')
INSERT [dbo].[tb_RoleCate] ([MaRole], [TenRole]) VALUES (3, N'cấp 3')
SET IDENTITY_INSERT [dbo].[tb_RoleCate] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Status_Order] ON 

INSERT [dbo].[tb_Status_Order] ([MaTrangThai], [TenTrangThai]) VALUES (1, N'đang xử lý')
INSERT [dbo].[tb_Status_Order] ([MaTrangThai], [TenTrangThai]) VALUES (2, N'đang giao')
SET IDENTITY_INSERT [dbo].[tb_Status_Order] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Tag] ON 

INSERT [dbo].[tb_Tag] ([MaTag], [TenTag], [GhiChu]) VALUES (2, N'Vip', N'hàng vip')
INSERT [dbo].[tb_Tag] ([MaTag], [TenTag], [GhiChu]) VALUES (3, N'xuhuong', N'bán chạy gần đây')
INSERT [dbo].[tb_Tag] ([MaTag], [TenTag], [GhiChu]) VALUES (4, N'giacla', N'giặc ủi')
INSERT [dbo].[tb_Tag] ([MaTag], [TenTag], [GhiChu]) VALUES (5, N'muahe', N'đồ liên quan mùa hè')
INSERT [dbo].[tb_Tag] ([MaTag], [TenTag], [GhiChu]) VALUES (6, N'hanggiadungxin', N'hàng tốt gia dụng')
SET IDENTITY_INSERT [dbo].[tb_Tag] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_User] ON 

INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Nguyễn Văn A', N'A', N'nguyenvana@gmail.com', N'0123456789', N'user1', N'password1', 0, CAST(N'2000-01-01' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Trần Thị B', N'B', N'tranthib@gmail.com', N'0987654321', N'user2', N'password2', 1, CAST(N'2001-02-02' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Lê Văn C', N'C', N'levanc@gmail.com', N'0123456789', N'user3', N'password3', 0, CAST(N'2002-03-03' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Phạm Thị D', N'D', N'phamthid@gmail.com', N'0987654321', N'user4', N'password4', 1, CAST(N'2003-04-04' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Trần Văn E', N'E', N'tranvane@gmail.com', N'0123456789', N'user5', N'password5', 0, CAST(N'2004-05-05' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Hoàng Thị F', N'F', N'hoangthif@gmail.com', N'0987654321', N'user6', N'password6', 1, CAST(N'2005-06-06' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, N'Lý Văn G', N'G', N'lyvang@gmail.com', N'0123456789', N'user7', N'password7', 0, CAST(N'2006-07-07' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, N'Đinh Thị H', N'H', N'dinhthih@gmail.com', N'0987654321', N'user8', N'password8', 1, CAST(N'2007-08-08' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, N'Nguyễn Văn I', N'I', N'nguyenvani@gmail.com', N'0123456789', N'user9', N'password9', 1, CAST(N'2008-09-09' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
INSERT [dbo].[tb_User] ([MaUser], [HoTen], [Ten], [Gmail], [SDT], [UserName], [PassWord], [GioiTinh], [NgaySinh], [Avatar], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, N'Trần Thị K', N'K', N'tranthik@gmail.com', N'0987654321', N'user10', N'password10', 1, CAST(N'2009-10-10' AS Date), NULL, 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime), 0, CAST(N'2023-05-13T12:56:05.033' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_User] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_WarrantyPeriod] ON 

INSERT [dbo].[tb_WarrantyPeriod] ([MaHanBaoHanh], [HanBaoHanh]) VALUES (1, N'3 tháng')
INSERT [dbo].[tb_WarrantyPeriod] ([MaHanBaoHanh], [HanBaoHanh]) VALUES (2, N'6 tháng')
INSERT [dbo].[tb_WarrantyPeriod] ([MaHanBaoHanh], [HanBaoHanh]) VALUES (3, N'12 tháng')
SET IDENTITY_INSERT [dbo].[tb_WarrantyPeriod] OFF
GO
ALTER TABLE [dbo].[tb_Comment] ADD  CONSTRAINT [DF_tb_Comment_CreateDay]  DEFAULT (getdate()) FOR [CreateDay]
GO
ALTER TABLE [dbo].[tb_Product] ADD  CONSTRAINT [DF_tb_Product_CreateDay]  DEFAULT (getdate()) FOR [CreateDay]
GO
ALTER TABLE [dbo].[tb_User] ADD  CONSTRAINT [DF_tb_User_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
