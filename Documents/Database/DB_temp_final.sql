USE [FootballTournamentManager]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2017-05-21 11:52:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](255) NOT NULL,
	[pass] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Club]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetailRecord]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HumanInformation]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Match]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[MatchRecord]    Script Date: 2017-05-21 11:52:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatchRecord](
	[MatchID] [int] NOT NULL,
	[HomeClubRatio] [varchar](10) NOT NULL
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Player]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[Round]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[Rules]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)

GO
/****** Object:  Table [dbo].[TypeGoal]    Script Date: 2017-05-21 11:52:35 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
INSERT [dbo].[Account] ([username], [pass]) VALUES (N'admin1', N'1962026656160185351301320480154111117132155')
INSERT [dbo].[Account] ([username], [pass]) VALUES (N'admin2', N'2003011414115776479911161271372042013444')

INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'ARS', N'Arsenal 123', N'Emirates Stadium', N'\Images\ARS.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'BOU', N'AFC Bournemouth', N'Vitality Stadium', N'\Images\BOU.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'BUR', N'Burnley', N'Turf Moor', N'\Images\BUR.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'CHE', N'Chelsea', N'Stamford Bridge', N'\Images\CHE.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'CRY', N'Crystal Palace', N'Selhurst Park', N'\Images\CRY.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'EVE', N'Everton', N'Godison Park', N'\Images\EVE.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'HUL', N'Hull City', N'KCOM Stadium', N'\Images\HULL.png')
INSERT [dbo].[Club] ([ClubID], [ClubName], [StadiumName], [Path]) VALUES (N'LEI', N'Leicester City', N'King Power Stadium', N'\Images\LEI.png')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_ARS')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BOU')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_BUR')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CHE')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_CRY')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_EVE')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_HUL')
INSERT [dbo].[Coach] ([CoachID]) VALUES (N'C_LEI')
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'ARS', 2, 0, 0, 2, 0, 2, 2)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'CHE', 5, 1, 1, 2, -1, 4, 5)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'CRY', 4, 1, 0, 1, 1, 2, 1)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'EVE', 3, 1, 1, 0, 2, 4, 2)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'HUL', 3, 1, 1, 0, 2, 4, 2)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'BOU', 6, 1, 0, 3, 1, 4, 3)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'BUR', 5, 1, 2, 2, 0, 6, 6)
INSERT [dbo].[DetailRecord] ([ClubID], [TotalPoint], [NumberOfWinMatch], [NumberOfLoseMatch], [NumberOfDrawMatch], [Offset], [TotalWinGoal], [TotalLoseGoal]) VALUES (N'LEI', 0, 0, 1, 0, 1, 2, 1)
INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'F', N'Female')
INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'M', N'Male')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_ARS', N'M', N'ARS', N'Arsene Wenger', CAST(N'1949-10-22' AS Date), N'England', N'\Images\Arsene Wenger.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_BOU', N'M', N'BOU', N'Eddie Howe', CAST(N'1977-11-29' AS Date), N'England', N'\Images\Eddie Howe.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_BUR', N'M', N'BUR', N'Sean Dyche', CAST(N'1971-06-28' AS Date), N'England', N'\Images\Sean Dyche.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_CHE', N'M', N'CHE', N'Antonio Conte', CAST(N'1969-06-30' AS Date), N'Italy', N'\Images\Antonio Conte.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_CRY', N'M', N'CRY', N'Sam Allardyce', CAST(N'1954-10-19' AS Date), N'England', N'\Images\Sam Allardyce.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_EVE', N'M', N'EVE', N'Ronald Koeman', CAST(N'1963-03-21' AS Date), N'Netherland', N'\Images\Ronald Koeman.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_HUL', N'M', N'HUL', N'Marco Silva', CAST(N'1977-06-12' AS Date), N'Portugal', N'\Images\Marco Silva.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'C_LEI', N'M', N'LEI', N'Craig Shakespeare', CAST(N'1963-06-04' AS Date), N'England', N'\Images\Craig Shakespeare.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_1', N'M', N'ARS', N'Aaron Ramsey', CAST(N'1990-05-01' AS Date), N'Wales', N'\Images\Aaron Ramsey.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_2', N'M', N'ARS', N'Alex Iwobi', CAST(N'1996-05-03' AS Date), N'Nigeria', N'\Images\Alex Iwobi.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_3', N'M', N'ARS', N'Alex Oxlade-Champerlain', CAST(N'1993-08-15' AS Date), N'England', N'\Images\Alex Oxlade-Champerlain.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_4', N'M', N'ARS', N'Alexis Sanchez', CAST(N'1988-12-19' AS Date), N'Chile', N'\Images\Alexis Sanchez.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_ARS_5', N'M', N'ARS', N'Carl Jenkinson', CAST(N'1993-02-08' AS Date), N'England', N'\Images\Carl Jenkinson.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_1', N'M', N'BOU', N'Adam Federici', CAST(N'1986-01-31' AS Date), N'Australia', N'\Images\Adam Federici.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_2', N'M', N'BOU', N'Adam Smith', CAST(N'1991-04-29' AS Date), N'England', N'\Images\Adam Smith.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_3', N'M', N'BOU', N'Andrew Surman', CAST(N'1986-08-20' AS Date), N'England', N'\Images\Andrew Surman.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_4', N'M', N'BOU', N'Baily Cargill', CAST(N'1995-06-05' AS Date), N'England', N'\Images\Baily Cargill.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BOU_5', N'M', N'BOU', N'Benik Afobe', CAST(N'1993-02-12' AS Date), N'Congo', N'\Images\Benik Afobe.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_1', N'M', N'BUR', N'Paul Robinson', CAST(N'1989-10-15' AS Date), N'England', N'\Images\Paul Robinson.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_2', N'M', N'BUR', N'Ashley Barnes', CAST(N'1989-10-30' AS Date), N'Austria', N'\Images\Ashley Barnes.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_3', N'M', N'BUR', N'Ben Mee', CAST(N'1989-09-21' AS Date), N'England', N'\Images\Ben Mee.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_4', N'M', N'BUR', N'Jeff Hendrick', CAST(N'1992-01-31' AS Date), N'Ireland', N'\Images\Jeff Hendrick.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_BUR_5', N'M', N'BUR', N'Jon Flanagan', CAST(N'1993-01-01' AS Date), N'England', N'\Images\Jon Flanagan.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_1', N'M', N'CHE', N'Asmir Begovic', CAST(N'1989-06-20' AS Date), N'Bosnia And Herzegovina', N'\Images\Asmir Begovic.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_2', N'M', N'CHE', N'Cesar Azpilicueta', CAST(N'1989-08-20' AS Date), N'Spain', N'\Images\Cesar Azpilicueta.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_3', N'M', N'CHE', N'Cesc Fabregas', CAST(N'1987-05-04' AS Date), N'Spain', N'\Images\Cesc Fabregas.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_4', N'M', N'CHE', N'David Luiz', CAST(N'1987-04-02' AS Date), N'Brazil', N'\Images\David Luiz.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CHE_5', N'M', N'CHE', N'Diego Costa', CAST(N'1988-10-09' AS Date), N'Spain', N'\Images\Diego Costa.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_1', N'M', N'CRY', N'Andros Townsend', CAST(N'1991-06-18' AS Date), N'England', N'\Images\Andros Townsend.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_2', N'M', N'CRY', N'Steve Mandanda', CAST(N'1991-03-28' AS Date), N'France', N'\Images\Steve Mandanda.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_3', N'M', N'CRY', N'Bakary Sako', CAST(N'1988-04-20' AS Date), N'Mali', N'\Images\Bakary Sako.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_CRY_4', N'M', N'CRY', N'Christian Benteke', CAST(N'1990-12-03' AS Date), N'Belgium', N'\Images\Christian Benteke.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_EVE_1', N'M', N'EVE', N'Joel Robles', CAST(N'1990-06-17' AS Date), N'Spain', N'\Images\Joel Robles.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_EVE_2', N'M', N'EVE', N'Ashley Williams', CAST(N'1994-06-17' AS Date), N'Wales', N'\Images\Ashley Williams.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_EVE_3', N'M', N'EVE', N'Enner Valencia', CAST(N'1989-11-04' AS Date), N'Ecuado', N'\Images\Enner Valencia.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_HUL_1', N'M', N'HUL', N'David Marshall', CAST(N'1989-05-08' AS Date), N'Scotland', N'\Images\David Marshall.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_HUL_2', N'M', N'HUL', N'Abel Hernandez', CAST(N'1985-04-08' AS Date), N'Uruguay', N'\Images\Abel Hernandez.png')
INSERT [dbo].[HumanInformation] ([HumanID], [GenderID], [Human_ClubID], [Name], [Birthday], [Nation], [Path]) VALUES (N'P_LEI_1', N'M', N'LEI', N'Ahmed Musa', CAST(N'1992-10-13' AS Date), N'Nigeria', N'\Images\Ahmed Musa.png')
SET IDENTITY_INSERT [dbo].[Match] ON 

INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (1, CAST(N'2017-07-01' AS Date), CAST(N'07:00:00' AS Time), N'ARS', N'BOU', N'Emirates Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (2, CAST(N'2017-07-01' AS Date), CAST(N'07:00:00' AS Time), N'BUR', N'CHE', N'Turf Moor')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (3, CAST(N'2017-07-01' AS Date), CAST(N'07:00:00' AS Time), N'CRY', N'EVE', N'Selhurst Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (4, CAST(N'2017-07-01' AS Date), CAST(N'07:00:00' AS Time), N'HUL', N'LEI', N'KCOM Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (5, CAST(N'2017-07-08' AS Date), CAST(N'07:00:00' AS Time), N'LEI', N'ARS', N'King Power Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (6, CAST(N'2017-07-08' AS Date), CAST(N'07:00:00' AS Time), N'BOU', N'BUR', N'Vitality Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (7, CAST(N'2017-07-08' AS Date), CAST(N'07:00:00' AS Time), N'CHE', N'CRY', N'Stamford Bridge')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (8, CAST(N'2017-07-08' AS Date), CAST(N'07:00:00' AS Time), N'EVE', N'HUL', N'Godison Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (9, CAST(N'2017-07-15' AS Date), CAST(N'07:00:00' AS Time), N'HUL', N'LEI', N'KCOM Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (10, CAST(N'2017-07-15' AS Date), CAST(N'07:00:00' AS Time), N'ARS', N'BOU', N'Emirates Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (11, CAST(N'2017-07-15' AS Date), CAST(N'07:00:00' AS Time), N'BUR', N'CHE', N'Turf Moor')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (12, CAST(N'2017-07-15' AS Date), CAST(N'07:00:00' AS Time), N'CRY', N'EVE', N'Selhurst Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (13, CAST(N'2017-07-22' AS Date), CAST(N'07:00:00' AS Time), N'EVE', N'HUL', N'Godison Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (14, CAST(N'2017-07-22' AS Date), CAST(N'07:00:00' AS Time), N'LEI', N'ARS', N'King Power Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (15, CAST(N'2017-07-22' AS Date), CAST(N'07:00:00' AS Time), N'BOU', N'BUR', N'Vitality Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (16, CAST(N'2017-07-22' AS Date), CAST(N'07:00:00' AS Time), N'CHE', N'CRY', N'Stamford Bridge')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (17, CAST(N'2017-07-29' AS Date), CAST(N'07:00:00' AS Time), N'CRY', N'EVE', N'Selhurst Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (18, CAST(N'2017-07-29' AS Date), CAST(N'07:00:00' AS Time), N'HUL', N'LEI', N'KCOM Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (19, CAST(N'2017-07-29' AS Date), CAST(N'07:00:00' AS Time), N'ARS', N'BOU', N'Emirates Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (20, CAST(N'2017-07-29' AS Date), CAST(N'07:00:00' AS Time), N'BUR', N'CHE', N'Turf Moor')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (21, CAST(N'2017-08-05' AS Date), CAST(N'07:00:00' AS Time), N'CHE', N'CRY', N'Stamford Bridge')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (22, CAST(N'2017-08-05' AS Date), CAST(N'07:00:00' AS Time), N'EVE', N'HUL', N'Godison Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (23, CAST(N'2017-08-05' AS Date), CAST(N'07:00:00' AS Time), N'LEI', N'ARS', N'King Power Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (24, CAST(N'2017-08-05' AS Date), CAST(N'07:00:00' AS Time), N'BOU', N'BUR', N'Vitality Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (25, CAST(N'2017-08-12' AS Date), CAST(N'07:00:00' AS Time), N'BUR', N'CHE', N'Turf Moor')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (26, CAST(N'2017-08-12' AS Date), CAST(N'07:00:00' AS Time), N'CRY', N'EVE', N'Selhurst Park')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (27, CAST(N'2017-08-12' AS Date), CAST(N'07:00:00' AS Time), N'HUL', N'LEI', N'KCOM Stadium')
INSERT [dbo].[Match] ([MatchID], [MatchDate], [MatchTime], [HomeClubName], [GuestClubName], [Stadium]) VALUES (28, CAST(N'2017-08-12' AS Date), CAST(N'07:00:00' AS Time), N'ARS', N'BOU', N'Emirates Stadium')
SET IDENTITY_INSERT [dbo].[Match] OFF
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (1, N'1:1')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (2, N'2:0')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (6, N'1:1')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (7, N'1:1')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (8, N'2:1')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (9, N'2:1')
INSERT [dbo].[MatchRecord] ([MatchID], [HomeClubRatio]) VALUES (11, N'1:3')
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_1', 3, 2, 0, 8)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_2', 3, 0, 2, 17)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_3', 3, 0, 0, 15)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_4', 4, 0, 0, 7)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_ARS_5', 2, 0, 0, 25)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_1', 1, 0, 0, 23)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_2', 2, 0, 0, 15)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_3', 3, 0, 0, 6)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_4', 2, 3, 0, 19)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BOU_5', 4, 0, 0, 9)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_1', 1, 0, 0, 17)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_2', 4, 1, 0, 10)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_3', 2, 2, 0, 6)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_4', 2, 0, 0, 13)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_BUR_5', 2, 1, 0, 4)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_1', 1, 1, 0, 1)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_2', 2, 1, 0, 28)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_3', 3, 1, 0, 4)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_4', 2, 2, 0, 30)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CHE_5', 4, 0, 0, 19)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_1', 3, 1, 0, 10)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_2', 1, 1, 0, 30)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_3', 3, 0, 0, 26)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_CRY_4', 4, 0, 0, 17)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_EVE_1', 1, 1, 0, 1)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_EVE_2', 2, 0, 0, 5)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_EVE_3', 4, 1, 0, 19)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_HUL_1', 1, 1, 0, 23)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_HUL_2', 3, 2, 0, 9)
INSERT [dbo].[Player] ([PlayerID], [RoleID], [GoalNumber], [AssistNumber], [KitNum]) VALUES (N'P_LEI_1', 4, 1, 0, 7)
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
INSERT [dbo].[Rules] ([MaximumAge], [MinimumAge], [MinimumNumberPlayer], [MaximumNumberPlayer], [ScoreWin], [ScoreLose], [ScoreDraw]) VALUES (35, 16, 1, 15, 3, 0, 1)
SET IDENTITY_INSERT [dbo].[TypeGoal] ON 

INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (1, N'Direct')
INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (2, N'Penanty')
INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (3, N'OwnGoal')
INSERT [dbo].[TypeGoal] ([TypeGoalID], [TypeGoalName]) VALUES (4, N'Free kick')
SET IDENTITY_INSERT [dbo].[TypeGoal] OFF
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
/****** Object:  StoredProcedure [dbo].[Check_A_MatchRecord]    Script Date: 2017-05-21 11:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Check_A_MatchRecord]
@MatchID INT
AS	
BEGIN
	SELECT COUNT(*)
	FROM	dbo.MatchRecord
	WHERE @MatchID = MatchID
END

GO
/****** Object:  StoredProcedure [dbo].[check_belong_to_club]    Script Date: 2017-05-21 11:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[check_belong_to_club]
@PlayerID VARCHAR(10),
@ClubID VARCHAR(10)
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.HumanInformation
	WHERE HumanID = @PlayerID AND Human_ClubID = @ClubID
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_All_Matches]    Script Date: 2017-05-21 11:52:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Delete_All_Matches]
AS	
	DELETE FROM dbo.Match

GO
/****** Object:  StoredProcedure [dbo].[DeleteTypeGoal]    Script Date: 2017-05-21 11:52:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetDetailClub]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDetailClub]
@ClubID varchar(3)
AS
BEGIN
	SELECT *
	FROM	dbo.DetailRecord
	WHERE	ClubID = @ClubID
END

GO
/****** Object:  StoredProcedure [dbo].[InitializeDetailClub]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROC [dbo].[InitializeDetailClub]
@ClubID varchar(10)
AS	
BEGIN
	INSERT dbo.DetailRecord
	        ( ClubID ,
	          TotalPoint ,
	          NumberOfWinMatch ,
	          NumberOfLoseMatch ,
	          NumberOfDrawMatch ,
	          Offset ,
	          TotalWinGoal ,
	          TotalLoseGoal
	        )
	VALUES  ( @ClubID , -- ClubID - varchar(3)
	          0 , -- TotalPoint - int
	          0 , -- NumberOfWinMatch - int
	          0 , -- NumberOfLoseMatch - int
	          0 , -- NumberOfDrawMatch - int
	          0 , -- Offset - int
	          0 , -- TotalWinGoal - int
	          0  -- TotalLoseGoal - int
	        )	
END	

GO
/****** Object:  StoredProcedure [dbo].[Insert_A_MatchRecord]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Insert_A_MatchRecord]
@MatchID INT,
@HomeClubRatio VARCHAR(10)
AS	
BEGIN
	INSERT dbo.MatchRecord
	        ( MatchID, HomeClubRatio )
	VALUES  ( @MatchID, -- MatchID - int
	          @HomeClubRatio -- HomeClubRatio - int
	          )
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Matches]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Matches]
@MatchID INT,
@MatchDate DATETIME,
@MatchTime TIME,
@HomeClubName NVARCHAR(50),
@GuestClubName NVARCHAR(50),
@Stadium NVARCHAR(50)
AS 
BEGIN
SET IDENTITY_INSERT dbo.Match ON
	 INSERT dbo.Match
	         (MatchID , 
				MatchDate ,
	           MatchTime ,
	           HomeClubName ,
	           GuestClubName ,
	           Stadium
	         )
	 VALUES  (@MatchID ,
			  @MatchDate , -- MatchDate - date
	           @MatchTime , -- MatchTime - time
	           @HomeClubName , -- HomeClubName - nvarchar(50)
	           @GuestClubName , -- GuestClubName - nvarchar(50)
	           @Stadium  -- Stadium - nvarchar(50)
	         )
			 SET IDENTITY_INSERT dbo.Match OFF
END
GO
/****** Object:  StoredProcedure [dbo].[InsertClub]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertClub]
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
/****** Object:  StoredProcedure [dbo].[InsertCoach]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[InsertCoach]
@coach_id varchar(50)
as
Begin
	insert dbo.Coach (CoachID) values (@coach_id)
end



GO
/****** Object:  StoredProcedure [dbo].[InsertHumanInfor]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertHumanInfor]
@humanid varchar(50),
@gender_id varchar(5),
@club_id varchar(3),
@human_name nvarchar(50),
@birthday date,
@nation nvarchar(50),
@path varchar(50)
AS
BEGIN
		INSERT dbo.[HumanInformation]
		        (HumanID, /*cho nay viet bi sai thanh HumanInformationS*/
				GenderID,
				Human_ClubID,
				Name,
				Birthday,
				Nation,
				Path
		        )
		VALUES  ( @humanid,
				@gender_id,
				@club_id,
				@human_name,
				@birthday,
				@nation, 
				@path 			
		        )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPlayer]    Script Date: 2017-05-21 11:52:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Insert PlayerTable*/
Create proc [dbo].[InsertPlayer]
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



GO
/****** Object:  StoredProcedure [dbo].[InsertTypeGoal]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertTypeGoal]
@TypeGoalID INT,
@TypeGoalName NVARCHAR(50)
AS	
BEGIN
	SET IDENTITY_INSERT dbo.TypeGoal ON
	INSERT dbo.TypeGoal
	        ( TypeGoalID , TypeGoalName )
	VALUES  (@TypeGoalID, @TypeGoalName )
	SET IDENTITY_INSERT dbo.TypeGoal OFF
END




GO
/****** Object:  StoredProcedure [dbo].[ListPlayerToScore]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListPlayerToScore]
as
	select Row_number() over(order by p.GoalNumber DESC) as OrderingNumber,
		h.Name, c.ClubName, r.RoleName, p.GoalNumber
	from dbo.Player as p, dbo.HumanInformation as h,
	 dbo.Club as c, dbo.Role as r
	where p.PlayerID = h.HumanID and p.RoleID = r.RoleID
		and h.Human_ClubID = c.ClubID

GO
/****** Object:  StoredProcedure [dbo].[Load_Matches]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Load_Matches]
AS	
	SELECT *
	FROM dbo.Match

GO
/****** Object:  StoredProcedure [dbo].[LoadAllClub]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadAllClub]
AS	
BEGIN
	SELECT *
	FROM	dbo.Club
END




GO
/****** Object:  StoredProcedure [dbo].[LoadAllClubInfor]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadAllClubInfor] 
AS
	SELECT Row_number() over(order by ClubID) as OrderingNumber, c.ClubID, c.ClubName , c.StadiumName, h.Name as CoachName, c.Path as PathClub,
	 g.GenderName as CoachGender, h.Nation as CoachNation, h.Birthday as CoachBirthday, h.Path as CoachPath
	FROM	dbo.Club as c, dbo.HumanInformation as h, dbo.Coach as coach, dbo.Gender as g
	where h.Human_ClubID = c.ClubID and h.HumanID = coach.CoachID and g.GenderID = h.GenderID


GO
/****** Object:  StoredProcedure [dbo].[LoadClubInfor]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadClubInfor]
AS
	SELECT *
	FROM	dbo.Club



GO
/****** Object:  StoredProcedure [dbo].[LoadCoach]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-----Load Coach---------*/
create proc [dbo].[LoadCoach]
as
	select * from Coach



GO
/****** Object:  StoredProcedure [dbo].[LoadGender]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadGender]
AS
	SELECT *
	FROM	dbo.Gender



GO
/****** Object:  StoredProcedure [dbo].[LoadPlayerBelongToMatch]    Script Date: 2017-05-21 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadPlayerBelongToMatch]
@ClubID_A VARCHAR(10),
@ClubID_B VARCHAR(10)
AS	
BEGIN
	SELECT P.PlayerID AS ID, H.Name AS Name
	FROM dbo.Player AS P, dbo.HumanInformation AS H
	WHERE P.PlayerID = H.HumanID AND (H.Human_ClubID = @ClubID_A OR H.Human_ClubID = @ClubID_B)
END	
GO
/****** Object:  StoredProcedure [dbo].[LoadPlayerInformation]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[LoadPlayerInformation]
as
	select Row_number() over(order by h.HumanID) as OrderingNumber, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age, g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum, h.Path, h.HumanID
	from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
	where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
		  and p.RoleID = r.RoleID

GO
/****** Object:  StoredProcedure [dbo].[LoadRankOfClub]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadRankOfClub]
as
	select Row_number() over(order by d.TotalPoint DESC) as OrderingNumber,
	   c.ClubName, d.NumberOfWinMatch as Win, d.NumberOfDrawMatch as Draw,
	   d.NumberOfLoseMatch as Lose, d.Offset, d.TotalPoint, 
	   d.TotalWinGoal, d.TotalLoseGoal, Row_number() over(order by d.TotalPoint  DESC) as RankClub
	from dbo.DetailRecord as d, dbo.Club as c
	where d.ClubID = c.ClubID

GO
/****** Object:  StoredProcedure [dbo].[LoadRoles]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-----Load rules-----------*/
create proc [dbo].[LoadRoles]
as
	select * from Role



GO
/****** Object:  StoredProcedure [dbo].[LoadRuleS]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[LoadRuleS]
AS	
	SELECT	*
	FROM dbo.Rules





GO
/****** Object:  StoredProcedure [dbo].[LoadTypeGoal]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadTypeGoal]
AS
	SELECT *
	FROM	dbo.TypeGoal





GO
/****** Object:  StoredProcedure [dbo].[ReviewMatchResult]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReviewMatchResult]
as
	select Row_number() over(order by mr.MatchID DESC) as OrderingNumber,
	   m.HomeClubName as Home, m.GuestClubName as Away,
	   mr.HomeClubRatio as Ratio, m.MatchDate as Date, m.MatchTime as Time,
	   m.Stadium 
	from Match as m, MatchRecord as mr
	where m.MatchID = mr.MatchID

GO
/****** Object:  StoredProcedure [dbo].[Update_Match]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Update_Match]
@MatchID INT,
@MatchDate DATETIME,
@MatchTime TIME,
@HomeClubName NVARCHAR(50),
@GuestClubName NVARCHAR(50),
@Stadium NVARCHAR(50)
AS 
BEGIN
	UPDATE dbo.Match
	SET MatchDate = @MatchDate, MatchTime = @MatchTime
	WHERE MatchID = @MatchID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateAssistance]    Script Date: 2017-05-21 11:52:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateAssistance]
@PlayerID VARCHAR(10)
AS	
BEGIN
	UPDATE dbo.Player
	SET	AssistNumber = AssistNumber + 1
	WHERE @PlayerID = PlayerID
END	

GO
/****** Object:  StoredProcedure [dbo].[UpdateClub]    Script Date: 2017-05-21 11:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateClub]
@club_name nvarchar(50),
@stadium_name nvarchar(50),
@club_id varchar(3)
AS	
BEGIN
	UPDATE dbo.Club
	SET ClubName = @club_name,
		StadiumName = @stadium_name
	WHERE ClubID = @club_id
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateDetailClub]    Script Date: 2017-05-21 11:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateDetailClub]
@ClubID varchar(3),
@TotalPoint int,
@NumberOfWinMatch int,
@NumberOfLoseMatch int,
@NumberOfDrawMatch int,
@Offset int,
@TotalWinGoal int,
@TotalLoseGoal int
AS
BEGIN
	UPDATE dbo.DetailRecord
	SET TotalPoint = @TotalPoint , NumberOfWinMatch = @NumberOfWinMatch , NumberOfLoseMatch = @NumberOfLoseMatch , NumberOfDrawMatch = @NumberOfDrawMatch , Offset = @Offset , TotalWinGoal = @TotalWinGoal , TotalLoseGoal = @TotalLoseGoal
	WHERE ClubID = @ClubID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateGoalPlayer]    Script Date: 2017-05-21 11:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateGoalPlayer]
@PlayerID VARCHAR(10)
AS	
BEGIN
	UPDATE dbo.Player
	SET GoalNumber = GoalNumber + 1
	WHERE @PlayerID = PlayerID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateHuman]    Script Date: 2017-05-21 11:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateHuman]
@human_name nvarchar(50),
@human_gender_id varchar(5),
@human_birthday date,
@human_nation nvarchar(50),
@human_id varchar(50)
as
begin
	UPDATE dbo.HumanInformation
	SET	Name = @human_name,
		GenderID = @human_gender_id,
		Birthday = @human_birthday,
		Nation = @human_nation
	WHERE HumanID = @human_id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePlayer]    Script Date: 2017-05-21 11:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePlayer]
@player_id varchar(50),
@role_id int,
@kitnum int
as
begin
	UPDATE dbo.Player
	SET RoleID = @role_id,
		KitNum = @kitnum
	WHERE PlayerID = @player_id
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateRule]    Script Date: 2017-05-21 11:52:40 PM ******/
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




select * from Player
Delete HumanInformation
where Human_ClubID = 'LIV'

Delete Club
where ClubID = 'SSS' or ClubID = 'SUN'