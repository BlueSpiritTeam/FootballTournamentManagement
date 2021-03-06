USE [FootballManagement]
GO
/****** Object:  Table [dbo].[Club]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Club](
	[ClubID] [varchar](3) NOT NULL,
	[ClubName] [nvarchar](50) NOT NULL,
	[StadiumName] [nvarchar](50) NOT NULL,
	[Path] [varchar](50) NULL,
 CONSTRAINT [PK_Club] PRIMARY KEY CLUSTERED 
(
	[ClubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Coach](
	[CoachID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Coach_1] PRIMARY KEY CLUSTERED 
(
	[CoachID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetailRecord]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetailRecord](
	[ClubID] [varchar](3) NOT NULL,
	[TotalPoint] [int] NOT NULL,
	[NumberOfWinMatch] [int] NOT NULL,
	[NumberOfLoseMatch] [int] NOT NULL,
	[NumberOfDrawMatch] [int] NOT NULL,
	[Offset] [int] NOT NULL,
	[TotalWinGoal] [int] NOT NULL,
	[TotalLoseGoal] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gender](
	[GenderID] [varchar](5) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HumanInformation]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HumanInformation](
	[HumanID] [varchar](50) NOT NULL,
	[GenderID] [varchar](5) NOT NULL,
	[Human_ClubID] [varchar](3) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Nation] [nvarchar](50) NOT NULL,
	[Path] [varchar](50) NULL,
 CONSTRAINT [PK_HumandInformation] PRIMARY KEY CLUSTERED 
(
	[HumanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Match]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match](
	[MatchID] [int] IDENTITY(1,1) NOT NULL,
	[MatchDate] [date] NOT NULL,
	[MatchTime] [time](7) NOT NULL,
	[HomeClubName] [nvarchar](50) NOT NULL,
	[GuestClubName] [nvarchar](50) NOT NULL,
	[Stadium] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED 
(
	[MatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MatchRecord]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatchRecord](
	[MatchID] [int] NOT NULL,
	[HomeClubRatio] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Player]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerID] [varchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[GoalNumber] [int] NOT NULL,
	[AssistNumber] [int] NOT NULL,
	[KitNum] [int] NULL,
 CONSTRAINT [PK_Player_1] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Round]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Round](
	[RoundID] [int] IDENTITY(1,1) NOT NULL,
	[RoundNumber] [int] NOT NULL,
 CONSTRAINT [PK_Round] PRIMARY KEY CLUSTERED 
(
	[RoundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rules]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rules](
	[MaximumAge] [int] NOT NULL,
	[MinimumAge] [int] NOT NULL,
	[MinimumNumberPlayer] [int] NOT NULL,
	[MaximumNumberPlayer] [int] NOT NULL,
	[ScoreWin] [int] NOT NULL,
	[ScoreLose] [int] NOT NULL,
	[ScoreDraw] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeGoal]    Script Date: 17/05/2017 5:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeGoal](
	[TypeGoalID] [int] IDENTITY(1,1) NOT NULL,
	[TypeGoalName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeGoal] PRIMARY KEY CLUSTERED 
(
	[TypeGoalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Coach]  WITH CHECK ADD  CONSTRAINT [FK_Coach_HumandInformation] FOREIGN KEY([CoachID])
REFERENCES [dbo].[HumanInformation] ([HumanID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Coach] CHECK CONSTRAINT [FK_Coach_HumandInformation]
GO
ALTER TABLE [dbo].[DetailRecord]  WITH CHECK ADD  CONSTRAINT [FK_DetailRecord_Club] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Club] ([ClubID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailRecord] CHECK CONSTRAINT [FK_DetailRecord_Club]
GO
ALTER TABLE [dbo].[HumanInformation]  WITH CHECK ADD  CONSTRAINT [FK_HumandInformation_Club] FOREIGN KEY([Human_ClubID])
REFERENCES [dbo].[Club] ([ClubID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HumanInformation] CHECK CONSTRAINT [FK_HumandInformation_Club]
GO
ALTER TABLE [dbo].[HumanInformation]  WITH CHECK ADD  CONSTRAINT [FK_HumandInformation_Gender] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Gender] ([GenderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HumanInformation] CHECK CONSTRAINT [FK_HumandInformation_Gender]
GO
ALTER TABLE [dbo].[MatchRecord]  WITH CHECK ADD  CONSTRAINT [FK_MatchRecord_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MatchRecord] CHECK CONSTRAINT [FK_MatchRecord_Match]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_HumandInformation] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[HumanInformation] ([HumanID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_HumandInformation]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Role]
GO
