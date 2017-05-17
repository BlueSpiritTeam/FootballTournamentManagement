INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'F', N'Female')
INSERT [dbo].[Gender] ([GenderID], [GenderName]) VALUES (N'M', N'Male')




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