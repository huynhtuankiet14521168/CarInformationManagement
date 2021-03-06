USE [CarsDB]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 5/10/2017 1:45:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[STT] [float] NULL,
	[Brand] [nvarchar](255) NULL,
	[Founded] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL,
	[CEO] [nvarchar](255) NULL,
	[Information] [nvarchar](max) NULL,
	[Customer Service] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 5/10/2017 1:45:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[STT] [float] NULL,
	[Car Name] [nvarchar](255) NULL,
	[Brand] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[Source] [nvarchar](255) NULL,
	[Price (million VND)] [float] NULL,
	[Engine] [nvarchar](255) NULL,
	[Horsepower] [float] NULL,
	[Torque N/m] [float] NULL
) ON [PRIMARY]

GO
