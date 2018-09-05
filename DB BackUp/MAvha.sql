USE [master]
GO
/****** Object:  Database [MAvha]    Script Date: 05/09/2018 11:45:49 ******/
CREATE DATABASE [MAvha]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MAvha', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MAvha.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MAvha_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\MAvha_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MAvha] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MAvha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MAvha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MAvha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MAvha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MAvha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MAvha] SET ARITHABORT OFF 
GO
ALTER DATABASE [MAvha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MAvha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MAvha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MAvha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MAvha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MAvha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MAvha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MAvha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MAvha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MAvha] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MAvha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MAvha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MAvha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MAvha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MAvha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MAvha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MAvha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MAvha] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MAvha] SET  MULTI_USER 
GO
ALTER DATABASE [MAvha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MAvha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MAvha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MAvha] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MAvha] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MAvha] SET QUERY_STORE = OFF
GO
USE [MAvha]
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
USE [MAvha]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 05/09/2018 11:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Nacimiento] [datetime] NOT NULL,
	[Femenino] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (1, N'Andrés Miretti', CAST(N'1985-11-07T00:00:00.000' AS DateTime), 0, 1)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (2, N'Leandro Romagnoli', CAST(N'1981-03-17T17:16:52.000' AS DateTime), 0, 1)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (3, N'Marcelo Tinelli', CAST(N'1968-07-12T00:00:00.000' AS DateTime), 0, 0)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (4, N'Julieta M. Ortega', CAST(N'1981-02-15T00:00:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (5, N'Liv Tyler', CAST(N'1977-07-01T00:00:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (6, N'Mauricio Macri', CAST(N'1961-08-12T00:00:00.000' AS DateTime), 0, 1)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (8, N'Micaela Mazzoni', CAST(N'1989-12-15T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[Persona] ([ID], [Nombre], [Nacimiento], [Femenino], [Activo]) VALUES (9, N'Bernabe Lopez', CAST(N'1990-12-12T00:00:00.000' AS DateTime), 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
USE [master]
GO
ALTER DATABASE [MAvha] SET  READ_WRITE 
GO
