USE [catalogo_autos]
GO
/****** Object:  Table [dbo].[autos]    Script Date: 24/10/2020 3:38:33 ******/
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
