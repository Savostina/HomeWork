USE [master]
GO
/****** Object:  Database [Magazin_ZD2_S]    Script Date: 28.04.2021 13:04:45 ******/
CREATE DATABASE [Magazin_ZD2_S]
GO
ALTER DATABASE [Magazin_ZD2_S] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Magazin_ZD2_S].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Magazin_ZD2_S] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ARITHABORT OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Magazin_ZD2_S] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Magazin_ZD2_S] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Magazin_ZD2_S] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Magazin_ZD2_S] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Magazin_ZD2_S] SET  MULTI_USER 
GO
ALTER DATABASE [Magazin_ZD2_S] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Magazin_ZD2_S] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Magazin_ZD2_S] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Magazin_ZD2_S] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Magazin_ZD2_S] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Magazin_ZD2_S] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Magazin_ZD2_S] SET QUERY_STORE = OFF
GO
USE [Magazin_ZD2_S]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ud_id] [int] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[name] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersHasProduct]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersHasProduct](
	[id_orders] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_OrdersHasProduct] PRIMARY KEY CLUSTERED 
(
	[id_orders] ASC,
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[description] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ud_id] [int] NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_UserData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserData]    Script Date: 28.04.2021 13:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[middlename] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_UserData_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id], [ud_id], [IsDeleted]) VALUES (1, 4, 0)
INSERT [dbo].[Client] ([id], [ud_id], [IsDeleted]) VALUES (2, 5, 0)
INSERT [dbo].[Client] ([id], [ud_id], [IsDeleted]) VALUES (3, 6, 0)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([id], [client_id], [name], [IsDeleted]) VALUES (0, NULL, N'aaa', NULL)
INSERT [dbo].[Orders] ([id], [client_id], [name], [IsDeleted]) VALUES (1, 1, N'order_1', NULL)
INSERT [dbo].[Orders] ([id], [client_id], [name], [IsDeleted]) VALUES (2, 2, N'order_2', NULL)
INSERT [dbo].[Orders] ([id], [client_id], [name], [IsDeleted]) VALUES (3, 3, N'order_3', NULL)
INSERT [dbo].[Orders] ([id], [client_id], [name], [IsDeleted]) VALUES (4, NULL, N'апвп', NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (1, 1, 0)
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (1, 2, 0)
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (1, 3, 0)
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (2, 2, 0)
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (3, 1, 0)
INSERT [dbo].[OrdersHasProduct] ([id_orders], [id_product], [IsDeleted]) VALUES (3, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [price], [description], [IsDeleted]) VALUES (1, N'Tea', CAST(13.37 AS Decimal(18, 2)), N'', 0)
INSERT [dbo].[Product] ([id], [name], [price], [description], [IsDeleted]) VALUES (2, N'Chocolate', CAST(420.69 AS Decimal(18, 2)), N'', 0)
INSERT [dbo].[Product] ([id], [name], [price], [description], [IsDeleted]) VALUES (3, N'Apple', CAST(14.88 AS Decimal(18, 2)), N'', 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [ud_id], [login], [password], [IsDeleted]) VALUES (1, 1, N'LoginPassword', N'Asdcxzaseqw', 0)
INSERT [dbo].[User] ([id], [ud_id], [login], [password], [IsDeleted]) VALUES (2, 2, N'PasswordLogin', N'VZXcasdasdqw', 0)
INSERT [dbo].[User] ([id], [ud_id], [login], [password], [IsDeleted]) VALUES (3, 3, N'Parol', N'45645adSq', 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserData] ON 

INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (1, N'Иванов', N'Иван', N'Петрович', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (2, N'Петр', N'Иванович', N'Данилов', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (3, N'Елизавета', N'Олеговна', N'Пашковская ', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (4, N'Уваров', N'Савелий', N'Игоревич', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (5, N'Никонов', N'Роберт', N'Максимович', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (6, N'Кабанов', N'Эльдар', N'Максович', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (7, N'aaa', N'aaa', N'aaa', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (8, N'SGSFGSDFGS', N'SDFSDF', N'DFSDF', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (9, N'RGYTRTE', N'RTERTERT', N'WSERWER', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (10, N'FGDFG', N'DFGDFG', N'DFGDF', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (11, N'DFDSF', N'SDFFD', N'SDFDF', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (12, N'да', N'да', N'да', NULL)
INSERT [dbo].[UserData] ([id], [firstname], [lastname], [middlename], [IsDeleted]) VALUES (13, N'апвап', N'пвап', N'апвап', NULL)
SET IDENTITY_INSERT [dbo].[UserData] OFF
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF__Client__IsDelete__44FF419A]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF__Orders__IsDelete__0C85DE4D]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[OrdersHasProduct] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF__Product__IsDelet__47DBAE45]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__UserData__IsDele__48CFD27E]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UserData] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_UserData] FOREIGN KEY([ud_id])
REFERENCES [dbo].[UserData] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_UserData]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Client] FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Client]
GO
ALTER TABLE [dbo].[OrdersHasProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrdersHasProduct_Orders] FOREIGN KEY([id_orders])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrdersHasProduct] CHECK CONSTRAINT [FK_OrdersHasProduct_Orders]
GO
ALTER TABLE [dbo].[OrdersHasProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrdersHasProduct_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[OrdersHasProduct] CHECK CONSTRAINT [FK_OrdersHasProduct_Product]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserData] FOREIGN KEY([ud_id])
REFERENCES [dbo].[UserData] ([id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserData]
GO
USE [master]
GO
ALTER DATABASE [Magazin_ZD2_S] SET  READ_WRITE 
GO
