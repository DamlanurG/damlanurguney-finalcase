USE [daireYonetim]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aidat]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aidat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DaireID] [int] NOT NULL,
	[Tutar] [int] NOT NULL,
	[Odendimi] [bit] NOT NULL,
	[Ay] [int] NOT NULL,
 CONSTRAINT [PK_Aidat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Daire]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Daire](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BlokAdi] [nvarchar](max) NULL,
	[Bosmu] [bit] NOT NULL,
	[Tipi] [nvarchar](max) NULL,
	[BulunduguKat] [int] NOT NULL,
	[DaireNo] [int] NOT NULL,
	[SahibiYadaKiraci] [nvarchar](max) NULL,
 CONSTRAINT [PK_Daire] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DaireID] [int] NOT NULL,
	[Tutar] [int] NOT NULL,
	[Odendimi] [bit] NOT NULL,
	[Ay] [int] NOT NULL,
 CONSTRAINT [PK_Fatura] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](max) NULL,
	[TCNo] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
	[AracPlaka] [nvarchar](max) NULL,
	[DaireID] [int] NOT NULL,
	[Sifre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesaj]    Script Date: 03.08.2023 16:44:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesaj](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıID] [int] NOT NULL,
	[Metin] [nvarchar](max) NULL,
	[Tarih] [datetime2](7) NOT NULL,
	[Okundumu] [bit] NOT NULL,
 CONSTRAINT [PK_Mesaj] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731185746_Initial', N'5.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731205756_Initial2', N'5.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230731213225_Initial_3', N'5.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230801211829_Initial_4', N'5.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230802192020_Initial_5', N'5.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230802193702_Initial_5', N'5.0.4')
GO
SET IDENTITY_INSERT [dbo].[Aidat] ON 
GO
INSERT [dbo].[Aidat] ([ID], [DaireID], [Tutar], [Odendimi], [Ay]) VALUES (1, 5, 500, 1, 1)
GO
INSERT [dbo].[Aidat] ([ID], [DaireID], [Tutar], [Odendimi], [Ay]) VALUES (2, 5, 750, 0, 2)
GO
SET IDENTITY_INSERT [dbo].[Aidat] OFF
GO
SET IDENTITY_INSERT [dbo].[Daire] ON 
GO
INSERT [dbo].[Daire] ([ID], [BlokAdi], [Bosmu], [Tipi], [BulunduguKat], [DaireNo], [SahibiYadaKiraci]) VALUES (5, N'A1', 0, N'1', 1, 1, N'kiracı')
GO
INSERT [dbo].[Daire] ([ID], [BlokAdi], [Bosmu], [Tipi], [BulunduguKat], [DaireNo], [SahibiYadaKiraci]) VALUES (6, N'A2', 1, N'2', 2, 2, N'sahibi')
GO
INSERT [dbo].[Daire] ([ID], [BlokAdi], [Bosmu], [Tipi], [BulunduguKat], [DaireNo], [SahibiYadaKiraci]) VALUES (7, N'A3', 0, N'3', 3, 3, N'kiracı')
GO
SET IDENTITY_INSERT [dbo].[Daire] OFF
GO
SET IDENTITY_INSERT [dbo].[Fatura] ON 
GO
INSERT [dbo].[Fatura] ([ID], [DaireID], [Tutar], [Odendimi], [Ay]) VALUES (1, 5, 1200, 1, 1)
GO
INSERT [dbo].[Fatura] ([ID], [DaireID], [Tutar], [Odendimi], [Ay]) VALUES (2, 5, 1000, 0, 2)
GO
SET IDENTITY_INSERT [dbo].[Fatura] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 
GO
INSERT [dbo].[Kullanici] ([ID], [AdSoyad], [TCNo], [Email], [Telefon], [AracPlaka], [DaireID], [Sifre]) VALUES (3, N'serhat akın 2', N'321456', N'serhat@akin2.com', N'0216', N'34', 5, N'123456')
GO
INSERT [dbo].[Kullanici] ([ID], [AdSoyad], [TCNo], [Email], [Telefon], [AracPlaka], [DaireID], [Sifre]) VALUES (5, N'tuncay şanlı', N'123', N'tuncay@sanli.com', N'0212', N'', 6, N'321')
GO
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Mesaj] ON 
GO
INSERT [dbo].[Mesaj] ([ID], [KullanıcıID], [Metin], [Tarih], [Okundumu]) VALUES (1, 3, N'deneme', CAST(N'2023-08-02T22:38:40.0308447' AS DateTime2), 1)
GO
INSERT [dbo].[Mesaj] ([ID], [KullanıcıID], [Metin], [Tarih], [Okundumu]) VALUES (2, 3, N'deneme 2', CAST(N'2023-08-02T22:41:21.8721161' AS DateTime2), 0)
GO
INSERT [dbo].[Mesaj] ([ID], [KullanıcıID], [Metin], [Tarih], [Okundumu]) VALUES (3, 3, N'deneme 3', CAST(N'2023-08-02T22:41:34.0622375' AS DateTime2), 0)
GO
SET IDENTITY_INSERT [dbo].[Mesaj] OFF
GO
ALTER TABLE [dbo].[Aidat] ADD  DEFAULT ((0)) FOR [Ay]
GO
ALTER TABLE [dbo].[Fatura] ADD  DEFAULT ((0)) FOR [Ay]
GO
ALTER TABLE [dbo].[Kullanici] ADD  DEFAULT ((0)) FOR [DaireID]
GO
