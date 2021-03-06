USE [master]
GO
/****** Object:  Database [FOOBOSDB]    Script Date: 1/16/2017 1:21:35 PM ******/
CREATE DATABASE [FOOBOSDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FOOBOSDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\FOOBOSDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FOOBOSDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\FOOBOSDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FOOBOSDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FOOBOSDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FOOBOSDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FOOBOSDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FOOBOSDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FOOBOSDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FOOBOSDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FOOBOSDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FOOBOSDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FOOBOSDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FOOBOSDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FOOBOSDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FOOBOSDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FOOBOSDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FOOBOSDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FOOBOSDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FOOBOSDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FOOBOSDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FOOBOSDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FOOBOSDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FOOBOSDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FOOBOSDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FOOBOSDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FOOBOSDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FOOBOSDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FOOBOSDB] SET  MULTI_USER 
GO
ALTER DATABASE [FOOBOSDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FOOBOSDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FOOBOSDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FOOBOSDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FOOBOSDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FOOBOSDB] SET QUERY_STORE = OFF
GO
USE [FOOBOSDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [FOOBOSDB]
GO
/****** Object:  Table [dbo].[Calendar]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendar](
	[DateKey] [datetime] NOT NULL,
	[DateInt] [int] NULL,
	[YearKey] [int] NULL,
	[HalfYearKey] [int] NULL,
	[QuarterKey] [int] NULL,
	[MonthKey] [int] NULL,
	[MonthOfYear] [int] NULL,
	[MonthOfHalfYear] [int] NULL,
	[MonthOfQuarter] [int] NULL,
	[QuarterOfYear] [int] NULL,
	[QuarterOfHalfYear] [int] NULL,
	[HalfYearOfYear] [int] NULL,
	[DayOfYear] [int] NULL,
	[DayOfHalfYear] [int] NULL,
	[DayOfQuarter] [int] NULL,
	[DayOfMonth] [int] NULL,
	[DayOfWeekMon] [int] NULL,
	[DayOfWeekSun] [int] NULL,
	[WeekOfYearISO] [int] NULL,
 CONSTRAINT [PK_Calendar] PRIMARY KEY CLUSTERED 
(
	[DateKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](500) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[UN] [nvarchar](100) NULL,
	[PW] [nvarchar](100) NULL,
	[Admin] [int] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[County] [nvarchar](50) NULL,
	[Neighborhood] [nvarchar](50) NULL,
	[Aux1] [nvarchar](50) NULL,
	[Aux2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[ParentLocationID] [int] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[OrderNum] [nvarchar](10) NULL,
	[SupplierID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[Description] [nvarchar](100) NULL,
	[OrderedBy] [int] NULL,
	[ExpectedDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_OrderNum] UNIQUE NONCLUSTERED 
(
	[OrderNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderLine]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLine](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[ProductCategoryID] [int] NULL,
	[Qty] [float] NULL,
	[ReceivedDate] [datetime] NULL,
	[ProductLocationID] [int] NULL,
	[LineNum] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[UnitPrice] [float] NULL,
 CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderLog]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLog](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[SupplierID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ExpectedDate] [datetime] NULL,
	[OrderlineID] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[ProductID] [int] NULL,
	[ProductCategoryID] [int] NULL,
	[Qty] [float] NULL,
	[LineNum] [int] NULL,
	[UnitPrice] [float] NULL,
	[ReceivedDate] [datetime] NULL,
	[ChangeType] [nvarchar](1) NULL,
	[ChangeTime] [datetime] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_OrderLog] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[pkid] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](100) NULL,
	[ProductCategoryID] [int] NULL,
	[UOMID] [int] NULL,
	[AvgValue] [float] NULL,
	[WarningQty] [float] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
	[ParentCategoryID] [int] NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
	[InheritValidity] [int] NULL,
	[UOMID] [int] NULL,
	[InheritUOM] [int] NULL,
	[AvgValue] [float] NULL,
	[InheritAvgValue] [int] NULL,
	[WarningQty] [float] NULL,
	[InheritWarningQty] [int] NULL,
	[Perishable] [int] NULL,
	[InheritPerishable] [int] NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductLocation]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLocation](
	[pkid] [int] NOT NULL,
	[ProductID] [int] NULL,
	[ProductCategoryID] [int] NULL,
	[LocationID] [int] NULL,
	[Location] [nvarchar](50) NULL,
	[Quantity] [float] NULL,
	[AvgValue] [float] NULL,
 CONSTRAINT [PK_ProductLocation] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductLocationLog]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLocationLog](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[ProductLocationID] [int] NULL,
	[ProductID] [int] NULL,
	[ProductCategoryID] [int] NULL,
	[LocationID] [int] NULL,
	[Location] [nvarchar](50) NULL,
	[Qty] [float] NULL,
	[AvgValue] [float] NULL,
	[ChangeType] [nvarchar](1) NULL,
	[ChangeTime] [datetime] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_ProductLocationLog] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sale]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[SaleDate] [datetime] NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleLine]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleLine](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NULL,
	[ProductLocationID] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[LineNum] [int] NULL,
	[DeliveryDate] [datetime] NULL,
	[Qty] [float] NULL,
	[UnitPrice] [float] NULL,
 CONSTRAINT [PK_SaleLine] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleLog]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleLog](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NULL,
	[CustomerID] [int] NULL,
	[SaleDate] [datetime] NULL,
	[SaleLineID] [int] NULL,
	[SaleLineSaleID] [int] NULL,
	[ProductLocationID] [int] NULL,
	[DeliveryDate] [datetime] NULL,
	[Qty] [float] NULL,
	[Description] [nvarchar](100) NULL,
	[ChangeType] [nvarchar](1) NULL,
	[ChangeTime] [datetime] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_SaleLog] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[Supplier] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[ContactID] [int] NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[ValidFrom] [datetime] NULL,
	[ValidTo] [datetime] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UOM]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UOM](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[BaseID] [int] NULL,
	[ConversionFactor] [float] NULL,
	[Abbrev] [nvarchar](50) NULL,
 CONSTRAINT [PK_UOM] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserLog]    Script Date: 1/16/2017 1:21:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLog](
	[pkid] [int] IDENTITY(1,1) NOT NULL,
	[ContactID] [int] NULL,
	[LoginTime] [datetime] NULL,
	[LogoutTime] [datetime] NULL,
 CONSTRAINT [PK_UserLog] PRIMARY KEY CLUSTERED 
(
	[pkid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[OrderLog] ADD  CONSTRAINT [DF_OrderLog_ChangeTime]  DEFAULT (getdate()) FOR [ChangeTime]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Location] FOREIGN KEY([ParentLocationID])
REFERENCES [dbo].[Location] ([pkid])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Location]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Contact] FOREIGN KEY([OrderedBy])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Contact]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([pkid])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Supplier]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([pkid])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Order]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([pkid])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Product]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([pkid])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_ProductCategory]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_ProductLocation] FOREIGN KEY([ProductLocationID])
REFERENCES [dbo].[ProductLocation] ([pkid])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_ProductLocation]
GO
ALTER TABLE [dbo].[OrderLog]  WITH CHECK ADD  CONSTRAINT [FK_OrderLog_Contact] FOREIGN KEY([UserID])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[OrderLog] CHECK CONSTRAINT [FK_OrderLog_Contact]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([pkid])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductCategory]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_UOM] FOREIGN KEY([UOMID])
REFERENCES [dbo].[UOM] ([pkid])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_UOM]
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategory_ProductCategory] FOREIGN KEY([ParentCategoryID])
REFERENCES [dbo].[ProductCategory] ([pkid])
GO
ALTER TABLE [dbo].[ProductCategory] CHECK CONSTRAINT [FK_ProductCategory_ProductCategory]
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategory_UOM] FOREIGN KEY([UOMID])
REFERENCES [dbo].[UOM] ([pkid])
GO
ALTER TABLE [dbo].[ProductCategory] CHECK CONSTRAINT [FK_ProductCategory_UOM]
GO
ALTER TABLE [dbo].[ProductLocation]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocation_Location] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([pkid])
GO
ALTER TABLE [dbo].[ProductLocation] CHECK CONSTRAINT [FK_ProductLocation_Location]
GO
ALTER TABLE [dbo].[ProductLocation]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocation_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([pkid])
GO
ALTER TABLE [dbo].[ProductLocation] CHECK CONSTRAINT [FK_ProductLocation_Product]
GO
ALTER TABLE [dbo].[ProductLocation]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocation_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([pkid])
GO
ALTER TABLE [dbo].[ProductLocation] CHECK CONSTRAINT [FK_ProductLocation_ProductCategory]
GO
ALTER TABLE [dbo].[ProductLocationLog]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocationLog_Contact] FOREIGN KEY([UserID])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[ProductLocationLog] CHECK CONSTRAINT [FK_ProductLocationLog_Contact]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([pkid])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Customer]
GO
ALTER TABLE [dbo].[SaleLine]  WITH CHECK ADD  CONSTRAINT [FK_SaleLine_ProductLocation] FOREIGN KEY([ProductLocationID])
REFERENCES [dbo].[ProductLocation] ([pkid])
GO
ALTER TABLE [dbo].[SaleLine] CHECK CONSTRAINT [FK_SaleLine_ProductLocation]
GO
ALTER TABLE [dbo].[SaleLine]  WITH CHECK ADD  CONSTRAINT [FK_SaleLine_Sale] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sale] ([pkid])
GO
ALTER TABLE [dbo].[SaleLine] CHECK CONSTRAINT [FK_SaleLine_Sale]
GO
ALTER TABLE [dbo].[SaleLog]  WITH CHECK ADD  CONSTRAINT [FK_SaleLog_Contact] FOREIGN KEY([UserID])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[SaleLog] CHECK CONSTRAINT [FK_SaleLog_Contact]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Contact1] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Contact1]
GO
ALTER TABLE [dbo].[UOM]  WITH CHECK ADD  CONSTRAINT [FK_UOM_UOM] FOREIGN KEY([BaseID])
REFERENCES [dbo].[UOM] ([pkid])
GO
ALTER TABLE [dbo].[UOM] CHECK CONSTRAINT [FK_UOM_UOM]
GO
ALTER TABLE [dbo].[UserLog]  WITH CHECK ADD  CONSTRAINT [FK_UserLog_Contact] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contact] ([pkid])
GO
ALTER TABLE [dbo].[UserLog] CHECK CONSTRAINT [FK_UserLog_Contact]
GO
USE [master]
GO
ALTER DATABASE [FOOBOSDB] SET  READ_WRITE 
GO
