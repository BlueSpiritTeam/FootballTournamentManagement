/****** Object:  StoredProcedure [dbo].[DeleteTypeGoal]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[InsertClub]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[InsertCoach]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[InsertHumanInfor]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertHumanInfor]
@human_id varchar(50),
@gender_id varchar(5),
@human_clubid varchar(3),
@human_name nvarchar(50),
@birthday date,
@nation nvarchar(50),
@path varchar(50)
AS
BEGIN
		INSERT dbo.[HumandInformation]
		        (HumandID,
				GenderID,
				Human_ClubID,
				Name,
				Birthday,
				Nation,
				Path
		        )
		VALUES  (
				@human_id,
				@gender_id,
				@human_clubid,
				@human_name,
				@birthday,
				@nation, 
				@path 			
		        )
END


GO
/****** Object:  StoredProcedure [dbo].[InsertPlayer]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[InsertTypeGoal]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[LoadAllClub]    Script Date: 15/05/2017 10:09:33 AM ******/
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
/****** Object:  StoredProcedure [dbo].[LoadClubInfor]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadClubInfor]
AS
	SELECT *
	FROM	dbo.Club


GO
/****** Object:  StoredProcedure [dbo].[LoadCoach]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-----Load Coach---------*/
create proc [dbo].[LoadCoach]
as
	select * from Coach


GO
/****** Object:  StoredProcedure [dbo].[LoadGender]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadGender]
AS
	SELECT *
	FROM	dbo.Gender


GO
/****** Object:  StoredProcedure [dbo].[LoadPlayerInformation]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------ LoadPlayerInfor --------*/
Create proc [dbo].[LoadPlayerInformation]
as
	select Row_number() over(order by h.HumandID) as OrderingNumber, p.PlayerID, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age, g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum
	from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
	where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
		  and p.RoleID = r.RoleID




GO
/****** Object:  StoredProcedure [dbo].[LoadRoles]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-----Load rules-----------*/
create proc [dbo].[LoadRoles]
as
	select * from Role


GO
/****** Object:  StoredProcedure [dbo].[LoadRuleS]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[LoadRuleS]
AS	
	SELECT	*
	FROM dbo.Rules




GO
/****** Object:  StoredProcedure [dbo].[LoadTypeGoal]    Script Date: 15/05/2017 10:09:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadTypeGoal]
AS
	SELECT *
	FROM	dbo.TypeGoal




GO
/****** Object:  StoredProcedure [dbo].[UpdateRule]    Script Date: 15/05/2017 10:09:33 AM ******/
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


CREATE PROC Insert_Matches
@MatchID INT,
@MatchDate DATETIME,
@MatchTime TIME,
@HomeClubName NVARCHAR(50),
@GuestClubName NVARCHAR(50),
@Stadium NVARCHAR(50)
AS 
BEGIN
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
END
GO	


CREATE PROC Load_Matches
AS	
	SELECT *
	FROM dbo.Match
GO

CREATE PROC Delete_All_Matches
AS	
	DELETE FROM dbo.Match
GO	

CREATE PROC Update_Match
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

CREATE PROC Check_A_MatchRecord
@MatchID INT
AS	
BEGIN
	SELECT COUNT(*)
	FROM	dbo.MatchRecord
	WHERE @MatchID = MatchID
END
GO	


CREATE PROC Insert_A_MatchRecord
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


/****** Object:  StoredProcedure [dbo].[UpdatePlayer]    Script Date: 2017-05-17 2:26:09 AM ******/
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


/****** Object:  StoredProcedure [dbo].[UpdateHuman]    Script Date: 2017-05-17 2:26:09 AM ******/
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
	UPDATE dbo.HumandInformation
	SET	Name = @human_name,
		GenderID = @human_gender_id,
		Birthday = @human_birthday,
		Nation = @human_nation
	WHERE HumandID = @human_id
end

GO


/****** Object:  StoredProcedure [dbo].[UpdateClub]    Script Date: 2017-05-17 2:26:09 AM ******/
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



/****** Object:  StoredProcedure [dbo].[LoadClubByDataTable]    Script Date: 2017-05-17 2:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadClubByDataTable]
AS
	SELECT Row_number() over(order by ClubID) as OrderingNumber, c.ClubID, c.ClubName , c.StadiumName, h.Name as CoachName, c.Path as PathClub,
	 g.GenderName as CoachGender, h.Nation as CoachNation, h.Birthday as CoachBirthday, h.Path as CoachPath
	FROM	dbo.Club as c, dbo.HumandInformation as h, dbo.Coach as coach, dbo.Gender as g
	where h.Human_ClubID = c.ClubID and h.HumandID = coach.CoachID and g.GenderID = h.GenderID

GO