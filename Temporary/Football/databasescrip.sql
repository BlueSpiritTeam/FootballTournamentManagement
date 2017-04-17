CREATE database Football
USE Football
GO
/****** Object:  Table [dbo].[Match]    Script Date: 4/3/2017 4:21:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match](
	[MatchId] [int] NOT NULL,
	[Date] [datetime] NULL,
	[StadiumName] [nvarchar](150) NULL,
	[Team1] [int] NULL,
	[Team2] [int] NULL,
 CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED 
(
	[MatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MatchPlayer]    Script Date: 4/3/2017 4:21:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchPlayer](
	[MatchPlayerId] [int] IDENTITY(1,1) NOT NULL,
	[MatchId] [int] NULL,
	[PlayerId] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MatchPlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MatchScore]    Script Date: 4/3/2017 4:21:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchScore](
	[MatchId] [int] NULL,
	[PlayerId] [int] NULL,
	[DateTime] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Player]    Script Date: 4/3/2017 4:21:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerId] [int] NOT NULL,
	[TeamId] [int] NULL,
	[PlayerName] [varchar](150) NULL,
	[Birthday] [date] NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Team]    Script Date: 4/3/2017 4:21:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [varchar](150) NULL,
	[Stadium] [varchar](150) NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
