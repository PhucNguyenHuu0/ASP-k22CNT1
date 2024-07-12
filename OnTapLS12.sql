USE [NguyenHuuPhuc_2210900117Db]
GO
/****** Object:  Table [dbo].[NHP_SACH]    Script Date: 12/07/2024 4:25:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHP_SACH](
	[Nhp_MaSach] [int] NULL,
	[Nhp_TenSach] [nvarchar](50) NULL,
	[Nhp_SoTrang] [int] NULL,
	[Nhp_NamXB] [int] NULL,
	[Nhp_MaTG] [int] NULL,
	[Nhp_TrangThai] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHP_TACGIA]    Script Date: 12/07/2024 4:25:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHP_TACGIA](
	[Nhp_MaTG] [int] NOT NULL,
	[Nhp_TenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHP_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Nhp_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
