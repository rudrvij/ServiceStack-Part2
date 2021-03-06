﻿USE [master]
GO

/****** Object:  Database [ServiceStackDemoDB]    Script Date: 3/10/2017 4:38:26 PM ******/
CREATE DATABASE [ServiceStackDemoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ServiceStackDemoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ServiceStackDemoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ServiceStackDemoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ServiceStackDemoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ServiceStackDemoDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ServiceStackDemoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ServiceStackDemoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ServiceStackDemoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ServiceStackDemoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ServiceStackDemoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ServiceStackDemoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ServiceStackDemoDB] SET  MULTI_USER 
GO
ALTER DATABASE [ServiceStackDemoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ServiceStackDemoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ServiceStackDemoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ServiceStackDemoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ServiceStackDemoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ServiceStackDemoDB] SET QUERY_STORE = OFF
GO
USE [ServiceStackDemoDB]
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
USE [ServiceStackDemoDB]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 3/10/2017 4:38:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](75) NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/10/2017 4:38:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[SSN] [varchar](20) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Company] ON 

GO
INSERT [dbo].[Company] ([CompanyId], [CompanyName]) VALUES (1, N'USTA')
GO
INSERT [dbo].[Company] ([CompanyId], [CompanyName]) VALUES (2, N'NFL')
GO
SET IDENTITY_INSERT [dbo].[Company] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (1, N'Roger', N'Federer', N'111-11-1111', N'federer@mail.com', 1)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (3, N'Rafael', N'Nadal', N'222-22-2222', N'nadal@mail.com', 1)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (4, N'Andy', N'Murray', N'333-33-3333', N'murray@mail.com', 1)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (5, N'Novak', N'Djokovic', N'444-44-4444', N'novak@mail.com', 1)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (6, N'Peyton', N'Manning', N'555-55-5555', N'peyton@mail.com', 2)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (7, N'Matt', N'Ryan', N'666-66-6666', N'matt@mail.com', 2)
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [SSN], [EmailAddress], [CompanyId]) VALUES (8, N'Aaron', N'Rodgers', N'777-77-7777', N'aaron@mail.com', 2)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Company]
GO
USE [master]
GO
ALTER DATABASE [ServiceStackDemoDB] SET  READ_WRITE 
GO
