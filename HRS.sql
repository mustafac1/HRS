USE [HRS]
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorAppointment]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorAppointment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[TimeId] [int] NOT NULL,
 CONSTRAINT [PK_DoctorAppointment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WorkerId] [int] NULL,
	[ClinicId] [int] NULL,
	[Rank] [nvarchar](50) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[TCNo] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Tel] [nvarchar](50) NOT NULL,
	[MotherName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[MotherTel] [nvarchar](50) NOT NULL,
	[FatherTel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientAppointments]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientAppointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClinicId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[TimeId] [int] NOT NULL,
	[TransactionDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PatientAppointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Times]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Times](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
 CONSTRAINT [PK_Times] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 8.01.2020 09:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[TcNo] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NULL,
	[Tel] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clinic] ON 

INSERT [dbo].[Clinic] ([Id], [Name]) VALUES (14, N'Acil Servis')
INSERT [dbo].[Clinic] ([Id], [Name]) VALUES (19, N'Çocuk Sağlığı Ve Hastalıkları')
SET IDENTITY_INSERT [dbo].[Clinic] OFF
SET IDENTITY_INSERT [dbo].[DoctorAppointment] ON 

INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (19, 14, 5)
INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (20, 14, 7)
INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (21, 14, 9)
INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (22, 14, 10)
INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (23, 4, 21)
INSERT [dbo].[DoctorAppointment] ([Id], [DoctorId], [TimeId]) VALUES (24, 4, 45)
SET IDENTITY_INSERT [dbo].[DoctorAppointment] OFF
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([Id], [WorkerId], [ClinicId], [Rank], [Status]) VALUES (16, 4, 19, N'2', 1)
INSERT [dbo].[Doctors] ([Id], [WorkerId], [ClinicId], [Rank], [Status]) VALUES (17, 12, 19, N'2', 1)
INSERT [dbo].[Doctors] ([Id], [WorkerId], [ClinicId], [Rank], [Status]) VALUES (18, 14, 14, N'2', 1)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
SET IDENTITY_INSERT [dbo].[PatientAppointments] ON 

INSERT [dbo].[PatientAppointments] ([Id], [ClinicId], [DoctorId], [TimeId], [TransactionDate]) VALUES (1, 14, 14, 5, CAST(N'2019-12-31T14:29:31.0766667' AS DateTime2))
INSERT [dbo].[PatientAppointments] ([Id], [ClinicId], [DoctorId], [TimeId], [TransactionDate]) VALUES (4, 19, 4, 0, CAST(N'2020-01-07T17:20:37.0933333' AS DateTime2))
INSERT [dbo].[PatientAppointments] ([Id], [ClinicId], [DoctorId], [TimeId], [TransactionDate]) VALUES (5, 14, 14, 7, CAST(N'2020-01-07T17:20:45.4766667' AS DateTime2))
INSERT [dbo].[PatientAppointments] ([Id], [ClinicId], [DoctorId], [TimeId], [TransactionDate]) VALUES (6, 19, 12, 0, CAST(N'2020-01-07T17:34:41.4100000' AS DateTime2))
INSERT [dbo].[PatientAppointments] ([Id], [ClinicId], [DoctorId], [TimeId], [TransactionDate]) VALUES (7, 19, 4, 45, CAST(N'2020-01-07T17:34:58.4133333' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PatientAppointments] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Güvenlik')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Doktor')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Times] ON 

INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (5, CAST(N'08:00:00' AS Time), CAST(N'08:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (7, CAST(N'08:15:00' AS Time), CAST(N'08:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (9, CAST(N'08:30:00' AS Time), CAST(N'08:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (10, CAST(N'08:45:00' AS Time), CAST(N'08:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (11, CAST(N'09:00:00' AS Time), CAST(N'09:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (12, CAST(N'09:15:00' AS Time), CAST(N'09:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (13, CAST(N'09:30:00' AS Time), CAST(N'09:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (14, CAST(N'09:45:00' AS Time), CAST(N'09:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (15, CAST(N'10:00:00' AS Time), CAST(N'10:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (16, CAST(N'10:15:00' AS Time), CAST(N'10:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (17, CAST(N'10:30:00' AS Time), CAST(N'10:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (19, CAST(N'10:45:00' AS Time), CAST(N'10:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (21, CAST(N'11:00:00' AS Time), CAST(N'11:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (23, CAST(N'11:15:00' AS Time), CAST(N'11:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (25, CAST(N'11:30:00' AS Time), CAST(N'11:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (27, CAST(N'11:45:00' AS Time), CAST(N'11:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (29, CAST(N'12:00:00' AS Time), CAST(N'12:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (31, CAST(N'12:15:00' AS Time), CAST(N'12:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (32, CAST(N'12:30:00' AS Time), CAST(N'12:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (33, CAST(N'12:45:00' AS Time), CAST(N'12:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (41, CAST(N'13:00:00' AS Time), CAST(N'13:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (42, CAST(N'13:15:00' AS Time), CAST(N'13:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (43, CAST(N'13:30:00' AS Time), CAST(N'13:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (44, CAST(N'13:45:00' AS Time), CAST(N'13:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (45, CAST(N'14:00:00' AS Time), CAST(N'14:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (46, CAST(N'14:15:00' AS Time), CAST(N'14:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (48, CAST(N'14:30:00' AS Time), CAST(N'14:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (50, CAST(N'14:45:00' AS Time), CAST(N'14:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (51, CAST(N'15:00:00' AS Time), CAST(N'15:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (52, CAST(N'15:15:00' AS Time), CAST(N'15:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (53, CAST(N'15:30:00' AS Time), CAST(N'15:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (54, CAST(N'15:45:00' AS Time), CAST(N'15:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (56, CAST(N'16:00:00' AS Time), CAST(N'16:10:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (57, CAST(N'16:15:00' AS Time), CAST(N'16:25:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (58, CAST(N'16:30:00' AS Time), CAST(N'16:40:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (59, CAST(N'16:45:00' AS Time), CAST(N'16:55:00' AS Time))
INSERT [dbo].[Times] ([Id], [StartTime], [EndTime]) VALUES (60, CAST(N'17:00:00' AS Time), CAST(N'17:10:00' AS Time))
SET IDENTITY_INSERT [dbo].[Times] OFF
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([Id], [RoleId], [Name], [Surname], [Gender], [TcNo], [DateOfBirth], [Tel], [Mail], [UserName], [Password]) VALUES (4, 2, N'Mustafaz', N'Cinoğlu', N'E', N'18719775522', CAST(N'2002-02-26' AS Date), N'5304702602', N'mustafa.c1@outlook.com', N'mustafastr', N'123456')
INSERT [dbo].[Workers] ([Id], [RoleId], [Name], [Surname], [Gender], [TcNo], [DateOfBirth], [Tel], [Mail], [UserName], [Password]) VALUES (12, 2, N'Ayşe', N'Yıldırım', N'K', N'14725836933', CAST(N'2001-01-18' AS Date), N'05304702825', N'ayse@outlook.com', N'yılayse', N'123456')
INSERT [dbo].[Workers] ([Id], [RoleId], [Name], [Surname], [Gender], [TcNo], [DateOfBirth], [Tel], [Mail], [UserName], [Password]) VALUES (14, 2, N'Abdullah', N'Sarıçam', N'E', N'1111111111', CAST(N'2000-02-16' AS Date), N'5317443933', N'abdullah.saricam@hedefltd.com', N'asaricam', N'123')
SET IDENTITY_INSERT [dbo].[Workers] OFF
