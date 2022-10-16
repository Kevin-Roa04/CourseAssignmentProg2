USE [master]
GO
/****** Object:  Database [Economy]    Script Date: 11/10/2022 12:15:02 ******/
CREATE DATABASE [Economy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Economy', FILENAME = N'C:\Archivos de programa\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Economy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Economy_log', FILENAME = N'C:\Archivos de programa\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Economy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Economy] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Economy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Economy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Economy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Economy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Economy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Economy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Economy] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Economy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Economy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Economy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Economy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Economy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Economy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Economy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Economy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Economy] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Economy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Economy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Economy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Economy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Economy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Economy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Economy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Economy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Economy] SET  MULTI_USER 
GO
ALTER DATABASE [Economy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Economy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Economy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Economy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Economy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Economy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Economy] SET QUERY_STORE = OFF
GO
USE [Economy]
GO
/****** Object:  Table [dbo].[Annuity]    Script Date: 11/10/2022 12:15:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Annuity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[projectId] [int] NOT NULL,
	[initial] [int] NOT NULL,
	[end] [int] NOT NULL,
	[payment] [decimal](9, 2) NULL,
	[present] [decimal](18, 2) NULL,
	[future] [decimal](18, 2) NULL,
	[type] [varchar](50) NULL,
	[flowType] [varchar](50) NULL,
	[rate] [decimal](9, 2) NOT NULL,
	[totalPeriod] [int] NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK__Annuity__3213E83FF8CFE58F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interest]    Script Date: 11/10/2022 12:15:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[projectId] [int] NOT NULL,
	[initial] [int] NOT NULL,
	[end] [int] NOT NULL,
	[present] [decimal](18, 2) NULL,
	[future] [decimal](18, 2) NULL,
	[flowType] [varchar](50) NOT NULL,
	[rate] [decimal](9, 2) NOT NULL,
	[payment] [decimal](9, 2) NOT NULL,
	[totalPeriod] [int] NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK__Interest__3213E83F877940F9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 11/10/2022 12:15:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[creation] [date] NOT NULL,
	[type] [varchar](50) NULL,
	[path] [varchar](200) NULL,
	[period] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serie]    Script Date: 11/10/2022 12:15:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[projectId] [int] NOT NULL,
	[initial] [int] NOT NULL,
	[end] [int] NOT NULL,
	[downPayment] [decimal](9, 2) NULL,
	[finalPayment] [decimal](9, 2) NULL,
	[quantity] [decimal](9, 2) NOT NULL,
	[present] [decimal](18, 2) NULL,
	[future] [decimal](18, 2) NULL,
	[type] [varchar](50) NULL,
	[flowType] [varchar](50) NULL,
	[rate] [decimal](9, 2) NOT NULL,
	[incremental] [bit] NOT NULL,
	[totalPeriod] [int] NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK__Serie__3213E83FE6372CD2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/10/2022 12:15:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[phone] [varchar](16) NULL,
	[email] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Annuity]  WITH CHECK ADD  CONSTRAINT [fk_projects] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
GO
ALTER TABLE [dbo].[Annuity] CHECK CONSTRAINT [fk_projects]
GO
ALTER TABLE [dbo].[Interest]  WITH CHECK ADD  CONSTRAINT [fk_projectss] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
GO
ALTER TABLE [dbo].[Interest] CHECK CONSTRAINT [fk_projectss]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [fk_user] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [fk_user]
GO
ALTER TABLE [dbo].[Serie]  WITH CHECK ADD  CONSTRAINT [fk_project] FOREIGN KEY([projectId])
REFERENCES [dbo].[Project] ([id])
GO
ALTER TABLE [dbo].[Serie] CHECK CONSTRAINT [fk_project]
GO
USE [master]
GO
ALTER DATABASE [Economy] SET  READ_WRITE 
GO


--drop TABLE FNEProject(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	UserId INT NOT NULL
--	)

--ALTER TABLE FNEProject
--ADD FOREIGN KEY (UserId)
--REFERENCES [dbo].[User]([id])
GO
USE [Economy]
GO

CREATE TABLE Activo(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NombreActivo VARCHAR(75) NOT NULL,
	DescripcionActivo VARCHAR(255),
	VidaUtil SMALLINT NOT NULL,
	Depreciable BIT NOT NULL,
	)

CREATE TABLE Depreciacion(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	UserId INT,
	ActivoId INT,
	TipoDepreciacion SMALLINT NOT NULL,
	Valor MONEY NOT NULL,
	ValorResidual MONEY NOT NULL,
	ProjectId INT
	)
	
ALTER TABLE Depreciacion
ADD FOREIGN KEY (UserId)
REFERENCES [dbo].[User]([id])

ALTER TABLE Depreciacion
ADD FOREIGN KEY (ProjectId)
REFERENCES [dbo].[Project](id)

ALTER TABLE Depreciacion
ADD FOREIGN KEY (ActivoId)
REFERENCES Activo(Id)


CREATE TABLE Amortizacion(
	Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	UserId INT,
	TasaPrestamo MONEY NOT NULL,
	ValorInversion MONEY NOT NULL,
	Plazo INT NOT NULL,
	TipoAmortizacion SMALLINT NOT NULL,
	ProjectId INT
	)
ALTER TABLE Amortizacion
ADD FOREIGN KEY (UserId)
REFERENCES [dbo].[User]([id])

ALTER TABLE Amortizacion
ADD FOREIGN KEY (ProjectId)
REFERENCES [dbo].[Project](id)

CREATE TABLE Profit(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	ValorInicial MONEY NOT NULL,
	TipoIncremento SMALLINT NOT NULL,
	ValorIncremento MONEY NOT NULL,
	ProjectId INT NOT NULL,
	)
ALTER TABLE Profit
ADD FOREIGN KEY (ProjectId)
REFERENCES [dbo].[Project](id)

CREATE TABLE Cost(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	ValorInicial MONEY NOT NULL,
	TipoIncremento SMALLINT NOT NULL,
	ValorIncremento MONEY NOT NULL,
	ProjectId INT NOT NULL,
	)
ALTER TABLE Cost
ADD FOREIGN KEY (ProjectId)
REFERENCES [dbo].[Project](id)

CREATE TABLE InversionFNE(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Monto MONEY NOT NULL,
	ActivoId INT NOT NULL,
	ProjectId INT NOT NULL
	)
ALTER TABLE InversionFNE
ADD FOREIGN KEY (ProjectId)
REFERENCES [dbo].[Project](id)

ALTER TABLE InversionFNE
ADD FOREIGN KEY (ActivoId)
REFERENCES Activo(Id)

GO
USE [master]
GO
ALTER DATABASE [Economy] SET  READ_WRITE 
GO