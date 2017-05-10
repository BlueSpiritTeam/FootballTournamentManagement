
/****** Object:  Database [Football_ver02]    Script Date: 5/9/2017 11:01:17 AM ******/
CREATE DATABASE [Football_ver02]
 
USE [Football_ver02]

/****** Object:  Table [dbo].[Club]    Script Date: 5/9/2017 11:01:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Club](
	[ClubID] [varchar](3) NOT NULL,
	[ClubName] [nvarchar](50) NOT NULL,
	[SatdiumName] [nvarchar](50) NOT NULL,
	[TotalPoint] [int] NOT NULL,
 CONSTRAINT [PK_Club] PRIMARY KEY CLUSTERED 
(
	[ClubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[Gender]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[GoalRecord]    Script Date: 5/9/2017 11:01:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GoalRecord](
	[MatchID] [int] NOT NULL,
	[PlayerScoreID] [varchar](50) NOT NULL,
	[PlayerAssistID] [varbinary](50) NULL,
	[RoundID] [int] NOT NULL,
	[TypeGoalID] [int] NOT NULL,
	[TimeToGoal] [time](7) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HumandInformation]    Script Date: 5/9/2017 11:01:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HumandInformation](
	[HumandID] [varchar](50) NOT NULL,
	[GenderID] [varchar](5) NOT NULL,
	[ClubID] [varchar](3) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Nation] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HumandInformation] PRIMARY KEY CLUSTERED 
(
	[HumandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Match]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[MatchRecord]    Script Date: 5/9/2017 11:01:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchRecord](
	[MatchID] [int] NOT NULL,
	[HomeClubRatio] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Player]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[Round]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[Rules]    Script Date: 5/9/2017 11:01:17 AM ******/
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
/****** Object:  Table [dbo].[TypeGoal]    Script Date: 5/9/2017 11:01:17 AM ******/
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

INSERT [dbo].[Club] ([ClubID], [ClubName], [SatdiumName], [TotalPoint]) VALUES (N'ARS', N'Arsenal', N'Emirates Stadium', 0)
INSERT [dbo].[Club] ([ClubID], [ClubName], [SatdiumName], [TotalPoint]) VALUES (N'BOU', N'AFC Bournemouth', N'Vitality Stadium', 0)
INSERT [dbo].[Club] ([ClubID], [ClubName], [SatdiumName], [TotalPoint]) VALUES (N'BUR', N'Burnley', N'Turf Moor', 0)
INSERT [dbo].[Club] ([ClubID], [ClubName], [SatdiumName], [TotalPoint]) VALUES (N'CHE', N'Chelsea', N'Stamford Bridge', 0)
INSERT [dbo].[Club] ([ClubID], [ClubName], [SatdiumName], [TotalPoint]) VALUES (N'CRY', N'Crystal Palace', N'Selhurst Park', 0)

INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_ARS')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BOU')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BUR')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CHE')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CRY')

INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'F', N'Female')
INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'M', N'Male')

INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'C_ARS', N'M', N'ARS', N'Arsene Wenger', CAST(N'1949-10-22' AS Date), N'France')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'C_BOU', N'M', N'BOU', N'Eddie Howe', CAST(N'1977-11-29' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'C_BUR', N'M', N'BUR', N'Sean Dyche
', CAST(N'1971-06-28' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'C_CHE', N'M', N'CHE', N'Antonio Conte', CAST(N'1969-07-31' AS Date), N'Italy')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'C_CRY', N'M', N'CRY', N'Sam Allardyce', CAST(N'1954-10-19' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_ARS_1', N'M', N'ARS', N'Petr Cech', CAST(N'1982-05-20' AS Date), N'Czech Republic')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_ARS_2', N'M', N'ARS', N'Mathieu Debuchy
', CAST(N'1985-07-28' AS Date), N'France')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_BOU_1', N'M', N'BOU', N'Adam Federici', CAST(N'1985-01-31' AS Date), N'Australia')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_BOU_2', N'M', N'BOU', N'Simon Francis
', CAST(N'1985-02-16' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_BUR_1', N'M', N'BUR', N'Tom Heaton
', CAST(N'1986-04-15' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_BUR_2', N'M', N'BUR', N'Matthew Lowton
', CAST(N'1989-08-09' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_CHE_1', N'M', N'CHE', N'Asmir Begovic
', CAST(N'1989-06-20' AS Date), N'Bosnia And Herzegovina
')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_CHE_2', N'M', N'CHE', N'Gary Cahill
', CAST(N'1985-12-19' AS Date), N'England')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_CRY_1', N'M', N'CRY', N'Wayne Hennessey
', CAST(N'1987-01-24' AS Date), N'Wales')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation]) VALUES (N'P_CRY_2', N'M', N'CRY', N'Joel Ward
', CAST(N'1989-10-29' AS Date), N'England')

INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_1', 1, 0, 0, 33)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_2', 2, 0, 0, 2)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_1', 1, 0, 0, 23)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_2', 2, 0, 0, 2)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_1', 1, 0, 0, 1)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_2', 2, 0, 0, 2)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_1', 1, 0, 0, 1)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_2', 2, 0, 0, 24)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_1', 1, 0, 0, 13)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_2', 2, 0, 0, 2)
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Goalkeeper')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Defender')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Midfielder')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (4, N'Forward')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Round] ON 

INSERT [dbo].[Round] ([RoundID], [RoundNumber]) VALUES (1, 1)
INSERT [dbo].[Round] ([RoundID], [RoundNumber]) VALUES (2, 2)

SET IDENTITY_INSERT [dbo].[Round] OFF
INSERT [dbo].[Rules] ([MaximumAge], [MinimumAge], [MinimumNumberPlayer], [MaximumNumberPlayer], [ScoreWin], [ScoreLose], [ScoreDraw]) VALUES (45, 16, 11, 20, 3, 0, 1)
SET IDENTITY_INSERT [dbo].[TypeGoal] ON 

INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (1, N'Direct')
INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (2, N'Penanty')
INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (3, N'OwnGoal')

SET IDENTITY_INSERT [dbo].[TypeGoal] OFF
ALTER TABLE [dbo].[Coach]  WITH CHECK ADD  CONSTRAINT [FK_Coach_HumandInformation] FOREIGN KEY([CoachID])
REFERENCES [dbo].[HumandInformation] ([HumandID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Coach] CHECK CONSTRAINT [FK_Coach_HumandInformation]

GO
ALTER TABLE [dbo].[GoalRecord]  WITH CHECK ADD  CONSTRAINT [FK_GoalRecord_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GoalRecord] CHECK CONSTRAINT [FK_GoalRecord_Match]

GO
ALTER TABLE [dbo].[GoalRecord]  WITH CHECK ADD  CONSTRAINT [FK_GoalRecord_Player] FOREIGN KEY([PlayerScoreID])
REFERENCES [dbo].[Player] ([PlayerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GoalRecord] CHECK CONSTRAINT [FK_GoalRecord_Player]

GO
ALTER TABLE [dbo].[GoalRecord]  WITH CHECK ADD  CONSTRAINT [FK_GoalRecord_Round] FOREIGN KEY([RoundID])
REFERENCES [dbo].[Round] ([RoundID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GoalRecord] CHECK CONSTRAINT [FK_GoalRecord_Round]

GO
ALTER TABLE [dbo].[GoalRecord]  WITH CHECK ADD  CONSTRAINT [FK_GoalRecord_TypeGoal] FOREIGN KEY([TypeGoalID])
REFERENCES [dbo].[TypeGoal] ([TypeGoalID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GoalRecord] CHECK CONSTRAINT [FK_GoalRecord_TypeGoal]

GO
ALTER TABLE [dbo].[HumandInformation]  WITH CHECK ADD  CONSTRAINT [FK_HumandInformation_Club] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Club] ([ClubID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HumandInformation] CHECK CONSTRAINT [FK_HumandInformation_Club]

GO
ALTER TABLE [dbo].[HumandInformation]  WITH CHECK ADD  CONSTRAINT [FK_HumandInformation_Gender] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Gender] ([GenderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HumandInformation] CHECK CONSTRAINT [FK_HumandInformation_Gender]

GO
ALTER TABLE [dbo].[MatchRecord]  WITH CHECK ADD  CONSTRAINT [FK_MatchRecord_Match] FOREIGN KEY([MatchID])
REFERENCES [dbo].[Match] ([MatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MatchRecord] CHECK CONSTRAINT [FK_MatchRecord_Match]

GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_HumandInformation] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[HumandInformation] ([HumandID])
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





CREATE PROC	LoadRuleS
AS	
	SELECT	*
	FROM dbo.Rules
GO	

EXECUTE LoadRuleS
GO	

CREATE PROC LoadTypeGoal
AS
	SELECT *
	FROM	dbo.TypeGoal
GO	

EXECUTE dbo.LoadTypeGoal
GO

CREATE PROC UpdateRule
@MaximumAge INT,
@MinimumAge INT,
@MinimumNumberPlayer INT,
@MaximumNumberPlayer INT,
@ScoreWin INT,
@ScoreLose INT,
@ScoreDraw INT
AS	
BEGIN
	UPDATE dbo.Rules
	SET MaximumAge = @MaximumAge, MinimumAge = @MinimumAge, MinimumNumberPlayer = @MinimumNumberPlayer, MaximumNumberPlayer = @MaximumNumberPlayer, ScoreWin = @ScoreWin, ScoreLose = @ScoreLose, ScoreDraw = @ScoreDraw
END	
GO	

CREATE PROC DeleteTypeGoal
@TypeGoalID INT
AS	
BEGIN
	DELETE dbo.TypeGoal
	WHERE TypeGoalID = @TypeGoalID
END
GO	


CREATE PROC Arrange_TypeGoalID
@TypeGoalID INT
AS	
BEGIN
	UPDATE dbo.TypeGoal
	SET TypeGoalID = TypeGoalID - 1 , TypeGoalName = TypeGoalName
	WHERE TypeGoalID > @TypeGoalID
END
GO	