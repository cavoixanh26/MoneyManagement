create database [MoneyManagement]
go
USE [MoneyManagement]
GO
/****** Object:  Table [dbo].[Borrow]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Describe] [nvarchar](max) NULL,
	[Time] [date] NOT NULL,
	[Money] [money] NOT NULL,
	[Rate] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[UserID] [int] NOT NULL,
	[Deadline] [date] NULL,
 CONSTRAINT [PK_Borrow] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CateIncome]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CateIncome](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CateSpend]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CateSpend](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CateSpend] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Income]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Income](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Describe] [nvarchar](max) NULL,
	[Time] [date] NOT NULL,
	[Money] [money] NOT NULL,
	[UserID] [int] NOT NULL,
	[CateID] [int] NULL,
 CONSTRAINT [PK_Income] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Describe] [nvarchar](max) NULL,
	[Time] [date] NOT NULL,
	[Money] [money] NOT NULL,
	[Rate] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[UserID] [int] NOT NULL,
	[Deadline] [date] NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Spend]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spend](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Describe] [nvarchar](max) NULL,
	[Time] [date] NOT NULL,
	[Money] [money] NOT NULL,
	[UserID] [int] NOT NULL,
	[CateID] [int] NULL,
 CONSTRAINT [PK_Spend] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16/03/2023 08:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Borrow] ON 

INSERT [dbo].[Borrow] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (1, N'User3', N'đi chơi', CAST(N'2023-02-15' AS Date), 1300000.0000, 0, 0, 1, CAST(N'2023-03-05' AS Date))
INSERT [dbo].[Borrow] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (2, N'User4', N'đi net', CAST(N'2023-02-10' AS Date), 1000000.0000, 0, 0, 1, CAST(N'2023-03-07' AS Date))
INSERT [dbo].[Borrow] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (3, N'mẹ', N'đi học', CAST(N'2023-02-09' AS Date), 2000000.0000, 0, 0, 1, CAST(N'2023-02-26' AS Date))
INSERT [dbo].[Borrow] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (4, N'User4', N'sửa xe', CAST(N'2023-01-11' AS Date), 300000.0000, 0, 0, 1, CAST(N'2023-03-02' AS Date))
SET IDENTITY_INSERT [dbo].[Borrow] OFF
GO
SET IDENTITY_INSERT [dbo].[CateIncome] ON 

INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (1, N'Tiền lương')
INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (2, N'Tiền phụ cấp')
INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (3, N'Tiền thưởng')
INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (4, N'Thu nhập phụ')
INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (5, N'Đầu tư')
INSERT [dbo].[CateIncome] ([ID], [Name]) VALUES (6, N'Thu nhập tạm thời')
SET IDENTITY_INSERT [dbo].[CateIncome] OFF
GO
SET IDENTITY_INSERT [dbo].[CateSpend] ON 

INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (1, N'Ăn uống')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (2, N'Chi tiều hàng ngày')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (3, N'Quần áo')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (4, N'Mỹ phẩm')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (5, N'Phí giao lưu')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (6, N'Y tế')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (7, N'Giáo dục')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (8, N'Tiền điện, nước')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (9, N'Đi lại')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (10, N'Phí liên lạc')
INSERT [dbo].[CateSpend] ([ID], [Name]) VALUES (11, N'Tiền nhà')
SET IDENTITY_INSERT [dbo].[CateSpend] OFF
GO
SET IDENTITY_INSERT [dbo].[Income] ON 

INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (1, N'bố cho', CAST(N'2023-01-01' AS Date), 1000000.0000, 1, 2)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (2, N'mẹ cho', CAST(N'2023-02-11' AS Date), 1500000.0000, 1, 2)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (3, N'lương tự bịa ra ', CAST(N'2023-02-10' AS Date), 3000000.0000, 1, 1)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (7, N'OKOK00', CAST(N'2023-02-27' AS Date), 1200000.0000, 1, 3)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (10, N'abcd', CAST(N'2023-01-03' AS Date), 1800000.0000, 1, 1)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (12, N'choi sam', CAST(N'2023-03-04' AS Date), 1000000.0000, 1, 5)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (13, N'uuuu', CAST(N'2023-03-07' AS Date), 1300000.0000, 1, 3)
INSERT [dbo].[Income] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (14, N'heheh', CAST(N'2023-03-02' AS Date), 1300000.0000, 1, 6)
SET IDENTITY_INSERT [dbo].[Income] OFF
GO
SET IDENTITY_INSERT [dbo].[Loan] ON 

INSERT [dbo].[Loan] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (1, N'User1', N'cho vay đi chơi với gái', CAST(N'2022-12-12' AS Date), 1500000.0000, 0, 1, 1, CAST(N'2023-03-10' AS Date))
INSERT [dbo].[Loan] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (2, N'User2', N'cho vay tặng quà ny', CAST(N'2023-02-12' AS Date), 2000000.0000, 0, 0, 1, CAST(N'2023-03-10' AS Date))
INSERT [dbo].[Loan] ([ID], [Name], [Describe], [Time], [Money], [Rate], [Status], [UserID], [Deadline]) VALUES (3, N'User2', N'vay đi ăn với ny', CAST(N'2023-02-14' AS Date), 1000000.0000, 0, 1, 1, CAST(N'2023-03-10' AS Date))
SET IDENTITY_INSERT [dbo].[Loan] OFF
GO
SET IDENTITY_INSERT [dbo].[Spend] ON 

INSERT [dbo].[Spend] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (1, N'đóng tiền học trường', CAST(N'2022-11-12' AS Date), 3000000.0000, 1, 7)
INSERT [dbo].[Spend] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (2, N'mua màn cho máy tính ', CAST(N'2023-01-11' AS Date), 4500000.0000, 1, 7)
INSERT [dbo].[Spend] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (3, N'mùa quần áo hè', CAST(N'2023-02-15' AS Date), 2000000.0000, 1, 3)
INSERT [dbo].[Spend] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (4, N'Đổ xăng 123', CAST(N'2023-02-21' AS Date), 100000.0000, 1, 9)
INSERT [dbo].[Spend] ([ID], [Describe], [Time], [Money], [UserID], [CateID]) VALUES (6, N'abcdef', CAST(N'2023-03-07' AS Date), 2300000.0000, 1, 5)
SET IDENTITY_INSERT [dbo].[Spend] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Name], [Password], [DateOfBirth]) VALUES (1, N'user', N'123', CAST(N'2002-12-21' AS Date))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Borrow]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Borrow] CHECK CONSTRAINT [FK_Borrow_User]
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD  CONSTRAINT [FK_Income_Category] FOREIGN KEY([CateID])
REFERENCES [dbo].[CateIncome] ([ID])
GO
ALTER TABLE [dbo].[Income] CHECK CONSTRAINT [FK_Income_Category]
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD  CONSTRAINT [FK_Income_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Income] CHECK CONSTRAINT [FK_Income_User]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_User]
GO
ALTER TABLE [dbo].[Spend]  WITH CHECK ADD  CONSTRAINT [FK_Spend_CateSpend] FOREIGN KEY([CateID])
REFERENCES [dbo].[CateSpend] ([ID])
GO
ALTER TABLE [dbo].[Spend] CHECK CONSTRAINT [FK_Spend_CateSpend]
GO
ALTER TABLE [dbo].[Spend]  WITH CHECK ADD  CONSTRAINT [FK_Spend_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Spend] CHECK CONSTRAINT [FK_Spend_User]
GO
