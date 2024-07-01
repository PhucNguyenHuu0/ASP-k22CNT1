USE [NhpLesson11Db]
GO
/****** Object:  Table [dbo].[NhpTaiKhoan]    Script Date: 01/07/2024 3:49:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhpTaiKhoan](
	[NhpId] [int] NOT NULL,
	[NhpUserName] [nvarchar](50) NULL,
	[NhpPassword] [nvarchar](50) NULL,
	[NhpFullName] [nvarchar](50) NULL,
	[NhpAge] [int] NULL,
	[NhpEmail] [nvarchar](50) NULL,
	[NhpPhone] [nvarchar](50) NULL,
	[NhpStatus] [bit] NULL,
 CONSTRAINT [PK_NhpTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[NhpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
