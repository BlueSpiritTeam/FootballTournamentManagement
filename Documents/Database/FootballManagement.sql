
USE FootballManagement
DROP DATABASE [FootballManagement_Version02]
CREATE DATABASE [FootballManagement_Version02]
USE [FootballManagement_Version02]

/****** Object:  Table [dbo].[Coach]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Coach](
	[TeamID] [nvarchar](3) NOT NULL,
	[CoachName] [nvarchar](50) NOT NULL,
	[BirthdayOfCoach] [date] NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Nation] [nvarchar](50) NOT NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[Goal]    Script Date: 2017-05-06 10:51:55 PM ******/
CREATE TABLE [dbo].[Goal](
	[GoalID] [int] IDENTITY(1,1) NOT NULL,
	[MatchID] [int] NOT NULL,
	[PlayerID] [int] NOT NULL,
	[TimeLine] [datetime] NOT NULL,
	[KindOfGoalID] [int] NOT NULL,
	[Round] [int] NOT NULL,
 CONSTRAINT [PK_Goal] PRIMARY KEY CLUSTERED 
(
	[GoalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[KindOfGoal]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[KindOfGoal](
	[KindOfGoalID] [int] IDENTITY(1,1) NOT NULL,
	[KindOfGoalName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KindOfGoal] PRIMARY KEY CLUSTERED 
(
	[KindOfGoalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Login]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Login](
	[UserName] [varchar](50) NOT NULL,
	[Password] [char](10) NOT NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[Match]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Match](
	[MatchID] [int] IDENTITY(1,1) NOT NULL,
	[MatchRoundID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [time](7) NOT NULL,
	[StadiumName] [nvarchar](100) NOT NULL,
	[HomeTeamName] [nvarchar](100) NOT NULL,
	[GuestTeamName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED 
(
	[MatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[MatchResult]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[MatchResult](
	[MatchID] [int] NOT NULL,
	[Ratio] [varchar](10) NOT NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[MatchRound]    Script Date: 2017-05-06 10:51:55 PM ******/
CREATE TABLE [dbo].[MatchRound](
	[MatchRoundID] [int] IDENTITY(1,1) NOT NULL,
	[MatchRoundName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MatchRound] PRIMARY KEY CLUSTERED 
(
	[MatchRoundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Player]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Player](
	[PlayerID] [int] IDENTITY(1,1) NOT NULL,
	[TeamID] [nvarchar](3) NOT NULL,
	[PlayerName] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Gender] [nvarchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Nation] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[KitNum] [int] NOT NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[RankingOrder]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[RankingOrder](
	[RankID] [int] NOT NULL,
	[MatchID] [int] NOT NULL,
	[TotalScore] [int] NOT NULL,
	[Offset] [int] NOT NULL,
	[TotalNumberOfGoal] [int] NOT NULL,
 CONSTRAINT [PK_RankingOrder] PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Rules]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Rules](
	[MinimumAge] [int] NOT NULL,
	[MaximumAge] [int] NOT NULL,
	[MinimumNumberPlayer] [int] NOT NULL,
	[MaximumNumberPlayer] [int] NOT NULL,
	[MaximumNumberForiegnNumber] [int] NOT NULL,
	[ScoreWins] [int] NOT NULL,
	[ScoreLoses] [int] NOT NULL,
	[ScoreDraw] [int] NOT NULL,
	[MaximunScoreTime] [int] NOT NULL
) ON [PRIMARY]


/****** Object:  Table [dbo].[Team]    Script Date: 2017-05-06 10:51:55 PM ******/

CREATE TABLE [dbo].[Team](
	[TeamID] [nvarchar](3) NOT NULL,
	[TeamName] [nvarchar](50) NOT NULL,
	[HomeStadiumName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/********************************/
INSERT [dbo].[Team] ([TeamID], [TeamName], [HomeStadiumName]) VALUES (N'ARS', N'Arsenal', N'Emirates Stadium')
INSERT [dbo].[Team] ([TeamID], [TeamName], [HomeStadiumName]) VALUES (N'BOU', N'AFC Bournemouth', N'Vitality Stadium')


INSERT [dbo].[Coach] ([TeamID], [CoachName], [BirthdayOfCoach], [Gender], [Age], [Nation]) VALUES (N'ARS', N'Arsene Wenger', CAST(N'1949-10-22' AS Date), N'Male', 55, N'France')
INSERT [dbo].[Coach] ([TeamID], [CoachName], [BirthdayOfCoach], [Gender], [Age], [Nation]) VALUES (N'BOU', N'Eddie Howe', CAST(N'1977-11-29' AS Date), N'Male', 45, N'England')
SET IDENTITY_INSERT [dbo].[Player] ON 

INSERT [dbo].[Player] ([PlayerID], [TeamID], [PlayerName], [Birthday], [Gender], [Age], [Nation], [Position], [KitNum]) VALUES (1, N'ARS', N'Petr Cech', CAST(N'1982-05-20' AS Date), N'Male', 27, N'Czech Republic', N'Goalkeeper', 33)
INSERT [dbo].[Player] ([PlayerID], [TeamID], [PlayerName], [Birthday], [Gender], [Age], [Nation], [Position], [KitNum]) VALUES (2, N'ARS', N'Mathieu Debuchy', CAST(N'1985-07-28' AS Date), N'Male', 28, N'France', N'Defender', 2)
INSERT [dbo].[Player] ([PlayerID], [TeamID], [PlayerName], [Birthday], [Gender], [Age], [Nation], [Position], [KitNum]) VALUES (4, N'ARS', N'Kieran Gibbs', CAST(N'1989-09-26' AS Date), N'Male', 29, N'Germany', N'Defender', 3)
INSERT [dbo].[Player] ([PlayerID], [TeamID], [PlayerName], [Birthday], [Gender], [Age], [Nation], [Position], [KitNum]) VALUES (6, N'ARS', N'Per Mertesacker', CAST(N'1984-09-29' AS Date), N'Male', 27, N'Germany', N'Defender', 4)
INSERT [dbo].[Player] ([PlayerID], [TeamID], [PlayerName], [Birthday], [Gender], [Age], [Nation], [Position], [KitNum]) VALUES (7, N'BOU', N'Adam Federici', CAST(N'1985-01-31' AS Date), N'Male', 29, N'Germany', N'Goalkeeper', 1)
SET IDENTITY_INSERT [dbo].[Player] OFF

/** FOREIGN KEY **/

ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Team] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Team] ([TeamID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Team]
GO

ALTER TABLE [dbo].[Coach]  WITH CHECK ADD  CONSTRAINT [FK_Coach_Team] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Team] ([TeamID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Coach] CHECK CONSTRAINT [FK_Coach_Team]
GO

ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_KindOfGoal] FOREIGN KEY([KindOfGoalID])
REFERENCES [dbo].[KindOfGoal] ([KindOfGoalID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_KindOfGoal]
GO

ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_Match]
GO

ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_Player] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[Player] ([PlayerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_Player]
GO

ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_MatchRound] FOREIGN KEY([MatchRoundID])
REFERENCES [dbo].[MatchRound] ([MatchRoundID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_MatchRound]
GO

ALTER TABLE [dbo].[MatchResult]  WITH CHECK ADD  CONSTRAINT [FK_MatchResult_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MatchResult] CHECK CONSTRAINT [FK_MatchResult_Match]
GO



ALTER TABLE [dbo].[RankingOrder]  WITH CHECK ADD  CONSTRAINT [FK_RankingOrder_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RankingOrder] CHECK CONSTRAINT [FK_RankingOrder_Match]
GO






