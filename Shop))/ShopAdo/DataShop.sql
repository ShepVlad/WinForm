USE [master]
GO
/****** Object:  Database [ShopAdo]    Script Date: 11/23/2016 12:04:18 ******/
CREATE DATABASE [ShopAdo] 
GO
USE [ShopAdo]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 11/23/2016 12:04:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[SaleDate] [datetime] NOT NULL,
	[SaleNumber] [nvarchar](24) NOT NULL,
	[SaleSumma] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/23/2016 12:04:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Smartphone')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Notebook')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Printer')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Telephon')
SET IDENTITY_INSERT [dbo].[Category] OFF
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 11/23/2016 12:04:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerId] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (1, N'Samsung')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (2, N'Lenovo')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (3, N'Nokia')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (4, N'Huawei')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (5, N'Sony')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (6, N'LG')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (7, N'Acer')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (8, N'HP')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (9, N'Canon')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (10, N'Asus')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
/****** Object:  StoredProcedure [dbo].[InsertSale]    Script Date: 11/23/2016 12:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSale]
    @SaleNumber nvarchar(24),
    @SaleId int OUTPUT
AS
BEGIN
  INSERT INTO Sale(SaleNumber)
  VALUES (@SaleNumber);
  SET @SaleId = SCOPE_IDENTITY();

END
GO
/****** Object:  Table [dbo].[Good]    Script Date: 11/23/2016 12:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Good](
	[GoodId] [int] IDENTITY(1,1) NOT NULL,
	[GoodName] [varchar](100) NOT NULL,
	[ManufacturerId] [int] NULL,
	[CategoryId] [int] NULL,
	[Price] [money] NOT NULL,
	[GoodCount] [numeric](18, 3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GoodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Good] ON
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (1, N'HP LaserJet P2035 (CE461A)', 8, 3, 5445.0000, CAST(12.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (2, N'Canon i-SENSYS MF212W with Wi-F', 9, 3, 3999.0000, CAST(7.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (3, N'Samsung SCX-4650N ', 1, 3, 3999.0000, CAST(15.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (4, N'HP DJ1510 (B2L56C) ', 8, 3, 1199.0000, CAST(2.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (5, N'Asus Transformer Book T100TAF 32GB', 10, 2, 4999.0000, CAST(11.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (6, N'Lenovo Flex 10 (59427902)', 2, 2, 5555.0000, CAST(11.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (7, N'Acer Aspire ES1-411-C1XZ', 7, 2, 6399.0000, CAST(7.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (8, N'HP 255 G4 (N0Y69ES)', NULL, 2, 6199.0000, CAST(5.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (9, N'HP ProBook 430 (N0Y70ES)', 8, 2, 12400.0000, CAST(3.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (10, N'Ultrabook Samsung 535U3', 1, NULL, 8000.0000, CAST(10.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (11, N'Samsung Galaxy S3 Neo Duos I9300i Black', 1, 1, 3999.0000, CAST(7.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (12, N'Lenovo A5000 Black', 2, 1, 3299.0000, CAST(5.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (13, N'Microsoft Lumia 640 XL (Nokia)', 3, 1, 4888.0000, CAST(5.000 AS Numeric(18, 3)))
INSERT [dbo].[Good] ([GoodId], [GoodName], [ManufacturerId], [CategoryId], [Price], [GoodCount]) VALUES (14, N'LG G3s Dual D724 Titan', 6, 1, 3999.0000, CAST(0.000 AS Numeric(18, 3)))
SET IDENTITY_INSERT [dbo].[Good] OFF
/****** Object:  Table [dbo].[SalePos]    Script Date: 11/23/2016 12:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalePos](
	[SalePosId] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[GoodId] [int] NULL,
	[GoodCount] [numeric](18, 3) NOT NULL,
	[Summa] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SalePosId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 11/23/2016 12:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photo](
	[PhotoId] [int] IDENTITY(1,1) NOT NULL,
	[GoodId] [int] NULL,
	[PhotoPath] [nvarchar](200) NOT NULL,
	[IsMain] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PhotoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[InsertSalePos]    Script Date: 11/23/2016 12:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSalePos]
   @SaleId INT, 
   @GoodId INT, 
   @GoodCount NUMERIC(18,3)
AS
BEGIN
   DECLARE @Price money = (SELECT Price
                           FROM dbo.Good
                           WHERE GoodId = @GoodId);
   BEGIN TRAN
     BEGIN TRY
   
	   UPDATE dbo.Good
	   SET
	   GoodCount = GoodCount - @GoodCount
	   WHERE GoodId=@GoodId;
	   
	   INSERT INTO dbo.SalePos(SaleId, GoodId, GoodCount, Summa)
	   VALUES (@SaleId, @GoodId, @GoodCount, @GoodCount * @Price);
	   
	   UPDATE dbo.Sale
	   SET SaleSumma = SaleSumma + @GoodCount * @Price
	   WHERE SaleId = @SaleId;
	   COMMIT;
     END TRY
     BEGIN CATCH
       ROLLBACK;
     END CATCH
   
END
GO
/****** Object:  Default [DF__Sale__SaleDate__164452B1]    Script Date: 11/23/2016 12:04:19 ******/
ALTER TABLE [dbo].[Sale] ADD  DEFAULT (getdate()) FOR [SaleDate]
GO
/****** Object:  Default [DF__Sale__SaleSumma__173876EA]    Script Date: 11/23/2016 12:04:19 ******/
ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [SaleSumma]
GO
/****** Object:  Default [DF__Good__Price__0AD2A005]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Good] ADD  DEFAULT ((0)) FOR [Price]
GO
/****** Object:  Default [DF__Good__GoodCount__0BC6C43E]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Good] ADD  DEFAULT ((0)) FOR [GoodCount]
GO
/****** Object:  Default [DF__Photo__IsMain__2E1BDC42]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Photo] ADD  DEFAULT ((0)) FOR [IsMain]
GO
/****** Object:  ForeignKey [FK__Good__CategoryId__09DE7BCC]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Good]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
/****** Object:  ForeignKey [FK__Good__Manufactur__08EA5793]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Good]  WITH CHECK ADD FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
GO
/****** Object:  ForeignKey [FK__SalePos__GoodId__1CF15040]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[SalePos]  WITH CHECK ADD FOREIGN KEY([GoodId])
REFERENCES [dbo].[Good] ([GoodId])
GO
/****** Object:  ForeignKey [FK__SalePos__SaleId__1BFD2C07]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[SalePos]  WITH CHECK ADD FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sale] ([SaleId])
GO
/****** Object:  ForeignKey [FK__Photo__GoodId__2D27B809]    Script Date: 11/23/2016 12:04:20 ******/
ALTER TABLE [dbo].[Photo]  WITH CHECK ADD FOREIGN KEY([GoodId])
REFERENCES [dbo].[Good] ([GoodId])
GO
