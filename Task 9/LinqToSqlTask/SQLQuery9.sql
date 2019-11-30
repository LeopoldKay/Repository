USE [Cinema]
GO

/****** Object:  Table [dbo].[Movies]    Script Date: 30.11.2019 17:55:01 ******/
DROP TABLE [dbo].[Movies]
GO

/****** Object:  Table [dbo].[Movies]    Script Date: 30.11.2019 17:55:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Year] [int] NOT NULL,
	[DirectorId] [int] FOREIGN KEY REFERENCES [dbo].[Directors](Id),
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


