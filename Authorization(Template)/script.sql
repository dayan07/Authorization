USE [master]
GO
/****** Object:  Database [Authorization]    Script Date: 08.03.2017 22:50:45 ******/
CREATE DATABASE [Authorization]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Authorization', FILENAME = N'C:\Users\User\Authorization.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Authorization_log', FILENAME = N'C:\Users\User\Authorization_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Authorization].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Authorization] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Authorization] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Authorization] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Authorization] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Authorization] SET ARITHABORT OFF 
GO
ALTER DATABASE [Authorization] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Authorization] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Authorization] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Authorization] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Authorization] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Authorization] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Authorization] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Authorization] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Authorization] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Authorization] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Authorization] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Authorization] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Authorization] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Authorization] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Authorization] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Authorization] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Authorization] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Authorization] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Authorization] SET  MULTI_USER 
GO
ALTER DATABASE [Authorization] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Authorization] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Authorization] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Authorization] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Authorization] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Authorization]
GO
/****** Object:  Table [dbo].[UserActions]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserActions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BeginDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[ComputerName] [nvarchar](50) NULL,
	[UserId] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](16) NOT NULL,
	[Password] [nvarchar](32) NOT NULL,
	[Email] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersInfo](
	[Id] [bigint] NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](128) NULL,
	[Phone] [nvarchar](30) NULL,
	[Code] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[UserActions] ON 

INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (1, CAST(N'2016-12-19 08:00:00.000' AS DateTime), CAST(N'2016-12-19 17:00:00.000' AS DateTime), N'1111', 1)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (2, CAST(N'2016-12-20 08:30:00.000' AS DateTime), CAST(N'2016-12-20 17:30:00.000' AS DateTime), N'1111', 1)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (3, CAST(N'2016-12-19 08:00:00.000' AS DateTime), CAST(N'2016-12-19 17:00:00.000' AS DateTime), N'2222', 2)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (4, CAST(N'2016-12-19 09:00:00.000' AS DateTime), CAST(N'2016-12-19 18:00:00.000' AS DateTime), N'3333', 3)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (6, CAST(N'2016-12-19 07:56:00.000' AS DateTime), CAST(N'2016-12-19 17:30:00.000' AS DateTime), N'4444', 4)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (7, CAST(N'2016-12-19 08:00:00.000' AS DateTime), CAST(N'2016-12-19 19:00:00.000' AS DateTime), N'5555', 5)
INSERT [dbo].[UserActions] ([Id], [BeginDate], [EndDate], [ComputerName], [UserId]) VALUES (11, CAST(N'2016-12-19 00:00:00.000' AS DateTime), CAST(N'2016-12-21 00:00:00.000' AS DateTime), N'9999', 13)
SET IDENTITY_INSERT [dbo].[UserActions] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (1, N'Fox', N'1133', N'Fox@mail.by')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (2, N'SunKot', N'990', N'Sun@mail.by')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (3, N'Rulon', N'Run456', N'rulon@mail.by')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (4, N'Loput7', N'qwerty', N'Loput@mail.by')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (5, N'Rewa', N'asd44', N'Rewa@mail.by')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (13, N'lobach', N'8888', N'lobach@mail.ru')
INSERT [dbo].[Users] ([Id], [Login], [Password], [Email]) VALUES (24, N'Admin', N'999999', N'admin@tut.by')
SET IDENTITY_INSERT [dbo].[Users] OFF
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (1, N'Liza', N'Ivanova', N'Grodno', N'+37529741235', 123565)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (2, N'Alex', N'Smirnov', N'Brest', N'+37529111421', 34532423)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (3, N'Vova', N'Sidorov', N'Brest', N'+37529865221', 356321)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (4, N'Inna', N'Krot', N'Minsk', N'+37529865421', 56312365)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (5, N'Nikolaj', N'Guk', N'Minsk', N'+37529844421', 7865333)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (13, N'Mia', N'Petrova', NULL, NULL, 56789)
INSERT [dbo].[UsersInfo] ([Id], [LastName], [FirstName], [Adres], [Phone], [Code]) VALUES (24, N'Lobach', N'Diana', N'Minsk', N'+375336202267', 111111)
ALTER TABLE [dbo].[UserActions]  WITH CHECK ADD  CONSTRAINT [FK_UserActions_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserActions] CHECK CONSTRAINT [FK_UserActions_Users]
GO
ALTER TABLE [dbo].[UsersInfo]  WITH CHECK ADD  CONSTRAINT [FK_UsersInfo_Users1] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UsersInfo] CHECK CONSTRAINT [FK_UsersInfo_Users1]
GO
/****** Object:  StoredProcedure [dbo].[ForDelete]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ForDelete]
	@paramFrom DATETIME,
	@paramTo DATETIME, 
	@counter INT OUTPUT
AS
SELECT @counter = COUNT(*) FROM Users WHERE Id NOT IN (SELECT UserId FROM UserActions 
WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
OR (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
OR (@paramFrom<BeginDate AND @paramTo>EndDate)
OR (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate));

SELECT Login FROM Users WHERE Id NOT IN (SELECT UserId FROM UserActions 
WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
OR (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
OR (@paramFrom<BeginDate AND @paramTo>EndDate)
OR (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate))
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report1]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report1]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT MAX(LastName), MAX(FirstName), MAX(ComputerName), 
	SUM(DATEDIFF (MINUTE, @paramFrom, @paramTo)) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
	GROUP BY UsersInfo.Id
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report2]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report2]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	
	SELECT MAX(LastName), MAX(FirstName), MAX(ComputerName), 
	SUM(DATEDIFF (MINUTE, BeginDate, @paramTo)) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
	GROUP BY UsersInfo.Id

RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report21]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report21]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT LastName, FirstName, BeginDate, EndDate, DATEDIFF (SECOND, @paramFrom, @paramTo) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
	ORDER BY UsersInfo.LastName;
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report22]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report22]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT LastName, FirstName, BeginDate, EndDate, DATEDIFF (SECOND, BeginDate, @paramTo) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
	ORDER BY UsersInfo.LastName
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report23]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report23]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT LastName, FirstName, BeginDate, EndDate, DATEDIFF (SECOND, BeginDate, EndDate) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<BeginDate AND @paramTo>EndDate)
	ORDER BY UsersInfo.LastName
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report24]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report24]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT LastName, FirstName, BeginDate, EndDate, DATEDIFF (SECOND, @paramFrom, EndDate) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate)
	ORDER BY UsersInfo.LastName
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report3]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report3]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	
	SELECT MAX(LastName), MAX(FirstName), MAX(ComputerName), 
	SUM(DATEDIFF (MINUTE, BeginDate, EndDate)) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<BeginDate AND @paramTo>EndDate)
	GROUP BY UsersInfo.Id

RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report31]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report31]
	@paramFrom DATETIME,
	@paramTo DATETIME,
	@paramLimit INT
AS
	SELECT LastName, FirstName, DATEDIFF (SECOND, @paramFrom, @paramTo) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) AND DATEDIFF (SECOND, @paramFrom, @paramTo)>@paramLimit
	
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report32]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report32]
	@paramFrom DATETIME,
	@paramTo DATETIME,
	@paramLimit INT
AS
	SELECT LastName, FirstName, DATEDIFF (SECOND, BeginDate, @paramTo) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate) AND DATEDIFF (SECOND, BeginDate, @paramTo)>@paramLimit
	
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report33]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report33]
	@paramFrom DATETIME,
	@paramTo DATETIME,
	@paramLimit INT
AS
	SELECT LastName, FirstName, DATEDIFF (SECOND, BeginDate, EndDate) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<BeginDate AND @paramTo>EndDate) AND DATEDIFF (SECOND, BeginDate, EndDate)>@paramLimit
	
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report34]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report34]
	@paramFrom DATETIME,
	@paramTo DATETIME,
	@paramLimit INT
AS
	SELECT LastName, FirstName, DATEDIFF (SECOND, @paramFrom, EndDate) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate) AND DATEDIFF (SECOND, @paramFrom, EndDate)>@paramLimit
	
	
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report4]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report4]
	@paramFrom DATETIME,
	@paramTo DATETIME
AS
	SELECT MAX(LastName), MAX(FirstName), MAX(ComputerName), 
	SUM(DATEDIFF (MINUTE, @paramFrom, EndDate)) 
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate)
	GROUP BY UsersInfo.Id
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Report41]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report41]
	@paramFrom DATETIME,
	@paramTo DATETIME, 
	@sum INT OUTPUT
AS
DECLARE @sum1 INT;
DECLARE @sum2 INT;
DECLARE @sum3 INT;
DECLARE @sum4 INT;

	SELECT @sum1= IIF(SUM(DATEDIFF (MINUTE, @paramFrom, @paramTo)) IS NULL,0,SUM(DATEDIFF (MINUTE, @paramFrom, @paramTo)))
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>BeginDate AND @paramTo<EndDate);

	SELECT @sum2= IIF(SUM(DATEDIFF (MINUTE, BeginDate, @paramTo)) IS NULL,0,SUM(DATEDIFF (MINUTE, BeginDate, @paramTo)))
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate);

	SELECT @sum3= IIF(SUM(DATEDIFF (MINUTE, BeginDate, EndDate)) IS NULL,0,SUM(DATEDIFF (MINUTE, BeginDate, EndDate)))
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom<BeginDate AND @paramTo>EndDate);

	SELECT @sum4= IIF(SUM(DATEDIFF (MINUTE, @paramFrom, EndDate)) IS NULL,0,SUM(DATEDIFF (MINUTE, @paramFrom, EndDate)))
	FROM UsersInfo INNER JOIN UserActions ON UsersInfo.Id=UserActions.UserId 
	WHERE (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate);
	
	SET @sum=@sum1+@sum2+@sum3+@sum4;

	RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[TransDelete]    Script Date: 08.03.2017 22:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[TransDelete]
	@paramFrom DATETIME,
	@paramTo DATETIME, 
	@YesNo BIT
AS
	BEGIN TRANSACTION
	DELETE FROM UsersInfo WHERE Id NOT IN (SELECT UserId FROM UserActions 
WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
OR (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
OR (@paramFrom<BeginDate AND @paramTo>EndDate)
OR (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate))
	IF (@@ERROR > 0)
		GOTO PROBLEM

	DELETE FROM Users WHERE Id NOT IN (SELECT UserId FROM UserActions 
WHERE (@paramFrom>BeginDate AND @paramTo<EndDate) 
OR (@paramFrom<=BeginDate AND @paramTo<=EndDate AND @paramTo>=BeginDate)
OR (@paramFrom<BeginDate AND @paramTo>EndDate)
OR (@paramFrom>=BeginDate AND @paramFrom<=EndDate AND @paramTo>=EndDate))
	IF (@@ERROR > 0)
		GOTO PROBLEM
        
	

	IF(@YesNo=1)
	BEGIN-- Никаких проблем обнаружено не было
	COMMIT RETURN
	END
	ELSE
	ROLLBACK;    
	-- Код для обработки ошибок
	PROBLEM:
		ROLLBACK;
		RAISERROR('Обновление выполнить не удалось', 16, 1)
GO
USE [master]
GO
ALTER DATABASE [Authorization] SET  READ_WRITE 
GO
