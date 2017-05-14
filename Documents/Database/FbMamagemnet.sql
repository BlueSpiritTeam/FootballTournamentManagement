use BongDa
drop database [FootballManagement]
CREATE database [FootballManagement]
USE [FootballManagement]
GO
/****** Object:  Table [dbo].[Club]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[Coach]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[DetailRecord]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[Gender]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[GoalRecord]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[HumandInformation]    Script Date: 2017-05-13 7:18:31 PM ******/
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
	[Path] [varchar](50) NULL,
 CONSTRAINT [PK_HumandInformation] PRIMARY KEY CLUSTERED 
(
	[HumandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Match]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[MatchRecord]    Script Date: 2017-05-13 7:18:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchRecord](
	[MatchID] [int] NOT NULL,
	[HomeClubRatio] [int] NOT NULL,
	[GuestClub] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Player]    Script Date: 2017-05-13 7:18:31 PM ******/
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

/****** Object:  Table [dbo].[Role]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[Round]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[Rules]    Script Date: 2017-05-13 7:18:31 PM ******/
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
/****** Object:  Table [dbo].[TypeGoal]    Script Date: 2017-05-13 7:18:31 PM ******/
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
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'ARS', N'Arsenal', N'Emirates Stadium', NULL)
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'BOU', N'AFC Bournemouth', N'Vitality Stadium', NULL)
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'BUR', N'Burnley', N'Turf Moor', NULL)
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'CHE', N'Chelsea', N'Stamford Bridge', NULL)
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'CRY', N'Crystal Palace', N'Selhurst Park', NULL)

INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_ARS')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BOU')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BUR')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CHE')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CRY')

INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'F', N'Female')
INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'M', N'Male')

INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_ARS', N'M', N'ARS', N'Arsene Wenger', CAST(N'1949-10-22' AS Date), N'France', N'\Images\Arsene Wenger.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_BOU', N'M', N'BOU', N'Eddie Howe', CAST(N'1977-11-29' AS Date), N'England', N'\Images\Eddie Howe.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_BUR', N'M', N'BUR', N'Sean Dyche', CAST(N'1971-06-28' AS Date), N'England', N'\Images\Sean Dyche.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_CHE', N'M', N'CHE', N'Antonio Conte', CAST(N'1969-07-31' AS Date), N'Italy', N'\Images\Antonio Conte.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_CRY', N'M', N'CRY', N'Sam Allardyce', CAST(N'1954-10-19' AS Date), N'England', N'\Images\Sam Allardyce.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_1', N'M', N'ARS', N'Petr Cech', CAST(N'1982-05-20' AS Date), N'Czech Republic', N'\Images\Petr Cech.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_2', N'M', N'ARS', N'Mathieu Debuchy', CAST(N'1985-07-28' AS Date), N'France', N'\Images\Mathieu Debuchy.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_1', N'M', N'BOU', N'Adam Federici', CAST(N'1985-01-31' AS Date), N'Australia', N'\Images\Adam Federici.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_2', N'M', N'BOU', N'Simon Francis', CAST(N'1985-02-16' AS Date), N'England', N'\Images\Simon Francis.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_1', N'M', N'BUR', N'Tom Heaton', CAST(N'1986-04-15' AS Date), N'England', N'\Images\Tom Heaton.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_2', N'M', N'BUR', N'Matthew Lowton', CAST(N'1989-08-09' AS Date), N'England', N'\Images\Matthew Lowton.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_1', N'M', N'CHE', N'Asmir Begovic', CAST(N'1989-06-20' AS Date), N'Bosnia And Herzegovina', N'\Images\Asmir Begovic.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_2', N'M', N'CHE', N'Gary Cahill', CAST(N'1985-12-19' AS Date), N'England', N'\Images\Gary Cahill.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_1', N'M', N'CRY', N'Wayne Hennessey', CAST(N'1987-01-24' AS Date), N'Wales', N'\Images\Wayne Hennessey.png')
INSERT [dbo].[HumandInformation] ([HumandID], [GenderID], [ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_2', N'M', N'CRY', N'Joel Ward', CAST(N'1989-10-29' AS Date), N'England', N'\Images\Joel Ward.png')

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
ALTER TABLE [dbo].[DetailRecord]  WITH CHECK ADD  CONSTRAINT [FK_DetailRecord_Club] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Club] ([ClubID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailRecord] CHECK CONSTRAINT [FK_DetailRecord_Club]
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
GO
/****** Object:  StoredProcedure [dbo].[DeleteTypeGoal]    Script Date: 2017-05-13 7:18:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*---------------------------------*/
CREATE PROC [dbo].[DeleteTypeGoal]
@TypeGoalID INT
AS	
BEGIN
	DELETE dbo.TypeGoal
	WHERE TypeGoalID = @TypeGoalID
END

GO
/****** Object:  StoredProcedure [dbo].[LoadPlayerInformation]    Script Date: 2017-05-13 7:18:31 PM ******/
/*------ LoadPlayerInfor --------*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[LoadPlayerInformation]
as
	select Row_number() over(order by h.HumandID) as OrderingNumber, p.PlayerID, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age, g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum
	from HumandInformation as h, Club as c, Player as p, Role as r, Gender as g
	where h.HumandID = p.PlayerID and h.ClubID = c.ClubID and h.GenderID = g.GenderID
		  and p.RoleID = r.RoleID
GO
/****** Object:  StoredProcedure [dbo].[LoadRuleS]    Script Date: 2017-05-13 7:18:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[LoadRuleS]
AS	
	SELECT	*
	FROM dbo.Rules
GO
/****** Object:  StoredProcedure [dbo].[LoadTypeGoal]    Script Date: 2017-05-13 7:18:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LoadTypeGoal]
AS
	SELECT *
	FROM	dbo.TypeGoal
GO
/****** Object:  StoredProcedure [dbo].[UpdateRule]    Script Date: 2017-05-13 7:18:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------------------------*/
CREATE PROC [dbo].[UpdateRule]
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

/* -------- LoadGender--------------*/
CREATE PROC [dbo].[LoadGender]
AS
	SELECT *
	FROM	dbo.Gender
GO

/*----------------------------------*/
CREATE PROC [dbo].[LoadClubInfor]
AS
	SELECT *
	FROM	dbo.Club
GO


/*---------------INSERT New Club-----------------*/
CREATE PROC InsertClub
@club_id varchar(3),
@club_name nvarchar(50),
@stadium_name nvarchar(50),
@path varchar(50)
AS
BEGIN
		INSERT dbo.[Club]
		        ( ClubID,
		          ClubName ,
		          StadiumName ,
		          Path
		        )
		VALUES  ( @club_id,
				@club_name,
				@stadium_name ,
				@path 			
		        )
END
GO	

/*---------------INSERT HumanInformationTable-----------------*/
CREATE PROC InsertHumandInfor
@human_id varchar(50),
@gender_id varchar(5),
@club_id varchar(3),
@human_name nvarchar(50),
@birthday date,
@nation nvarchar(50),
@path varchar(50)
AS
BEGIN
		INSERT dbo.[HumanInformation]
		        ( HumanID,
				GenderID,
				ClubID,
				Name,
				Birthday,
				Nation,
				Path
		        )
		VALUES  (
				@human_id,
				@gender_id,
				@club_id,
				@human_name,
				@birthday,
				@nation, 
				@path 			
		        )
END
GO	

/*---------Insert CoachTable*/
Create proc InsertCoach
@coach_id varchar(50)
as
Begin
	insert dbo.Coach (CoachID) values (@coach_id)
end
go


/*Insert PlayerTable*/
Create proc InsertPlayer
@player_id varchar(50),
@role_id int,
@goal_number int,
@assist_number int,
@kitnum int
as
Begin
	insert dbo.Player (PlayerID,
					   RoleID,
					   GoalNumber,
					   AssistNumber,
					   KitNum) values
					   (@player_id, @role_id, @goal_number, @assist_number, @kitnum)
end
go

/*-----Load rules-----------*/
create proc LoadRoles
as
	select * from Role
go

/*-----Load Coach---------*/
create proc LoadCoach
as
	select * from Coach
go

