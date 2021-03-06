USE [master]
GO
/****** Object:  Database [catalogo_autos]    Script Date: 24/10/2020 4:09:48 ******/
CREATE DATABASE [catalogo_autos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'catalogo_auots', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER\MSSQL\DATA\catalogo_auots.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'catalogo_auots_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER\MSSQL\DATA\catalogo_auots_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [catalogo_autos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [catalogo_autos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [catalogo_autos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [catalogo_autos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [catalogo_autos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [catalogo_autos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [catalogo_autos] SET ARITHABORT OFF 
GO
ALTER DATABASE [catalogo_autos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [catalogo_autos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [catalogo_autos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [catalogo_autos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [catalogo_autos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [catalogo_autos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [catalogo_autos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [catalogo_autos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [catalogo_autos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [catalogo_autos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [catalogo_autos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [catalogo_autos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [catalogo_autos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [catalogo_autos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [catalogo_autos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [catalogo_autos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [catalogo_autos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [catalogo_autos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [catalogo_autos] SET  MULTI_USER 
GO
ALTER DATABASE [catalogo_autos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [catalogo_autos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [catalogo_autos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [catalogo_autos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [catalogo_autos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [catalogo_autos]
GO
/****** Object:  Table [dbo].[autos]    Script Date: 24/10/2020 4:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
	[anio] [int] NULL,
	[precio] [decimal](10, 0) NULL,
	[fecha_venta] [varchar](50) NULL,
	[imagen] [varchar](255) NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_autos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateAuto]    Script Date: 24/10/2020 4:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUpdateAuto] 
	(@Id int, 
	@Marca varchar(50),
	@Modelo varchar(50),
	@Anio int,
	@Precio decimal(10),
	@FechaVenta varchar(50),
	@Imagen varchar(255),
	@Detalle text)

AS
IF (@Id = 0)
	BEGIN
		INSERT INTO autos(marca, modelo, anio, precio, fecha_venta, imagen, detalle) 
		VALUES(@Marca, @Modelo, @Anio, @Precio, @FechaVenta, @Imagen, @Detalle);
	END
ELSE
	BEGIN
		UPDATE autos SET marca = @Marca, modelo = @Modelo, anio = @Anio, 
		precio = @Precio, fecha_venta = @FechaVenta, imagen = @Imagen, detalle = @Detalle
		WHERE id = @Id;
	END
GO
USE [master]
GO
ALTER DATABASE [catalogo_autos] SET  READ_WRITE 
GO
