USE [NhpK22CNT1Lesson07Db]
GO
/****** Object:  Table [dbo].[nhpKhoa]    Script Date: 17/06/2024 8:59:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhpKhoa](
	[NhpMaKH] [nchar](10) NOT NULL,
	[NhpTenKH] [nvarchar](50) NULL,
	[NhpTrangThai] [bit] NULL,
 CONSTRAINT [PK_nhpKhoa] PRIMARY KEY CLUSTERED 
(
	[NhpMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhpSinhVien]    Script Date: 17/06/2024 8:59:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhpSinhVien](
	[NhpMaSv] [nvarchar](50) NOT NULL,
	[NhpHoSv] [nvarchar](50) NULL,
	[NhpTenSV] [nvarchar](50) NULL,
	[NhpNgaySinh] [date] NULL,
	[NhpPhai] [bit] NULL,
	[NhpPhone] [nchar](10) NULL,
	[NhpEmail] [nvarchar](50) NULL,
	[NhpMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_nhpSinhVien] PRIMARY KEY CLUSTERED 
(
	[NhpMaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[nhpKhoa] ([NhpMaKH], [NhpTenKH], [NhpTrangThai]) VALUES (N'K22CNT1   ', N'K22CNT2', 1)
INSERT [dbo].[nhpSinhVien] ([NhpMaSv], [NhpHoSv], [NhpTenSV], [NhpNgaySinh], [NhpPhai], [NhpPhone], [NhpEmail], [NhpMaKH]) VALUES (N'2210900117', N'Nguyen', N'Huu Phuc', CAST(N'2003-12-10' AS Date), 1, N'0398227601', N'nguyenphuc10122003@gmail.com', N'CNT1      ')
