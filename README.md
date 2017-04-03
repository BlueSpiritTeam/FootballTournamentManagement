# FootballTournamentManagement
Football Tournament Management Application
Members:
14521166 – Nguyen Duc Huy
14521167 – Nguyen Dinh Khuong
14520131 – Vu Nguyen Hai Dang
I. Motivation: 
Building application in order to receive registration of football clubs, create schedule for competing, record results of , search informations of players in Football Tournament.
II. System requirement:
1. Function:
•	Receive registration
•	Create schedule for competing
•	View result of matchs
•	Search informations of players
•	Create report of tournament
2. Working environment:
•	Windows XP, 7, 8, 8.1, 10
•	Framework 4.0 and above
3. Design and deploy environment:
•	Programing language: C#
•	OS: windows XP, 7, 8, 8.1, 10
•	RAM: 2GB and above
•	HDD: 500MB
•	Graphic card: intel HD
III. Initialize:
•	Application allows user to set initial parameters such as:
•	Minimum and maximum age
•	Minimum and maximum numbers of each football club
•	If user do not set initial parameters, then those parameters will be default:
-	Age: 18->45
-	Number of players: 16->40
-	Maximum numbers of international players: 3
-	Goal classifing ( deafault ) : A, B, C analogous to normal, beautiful, so beautiful
-	Point will be gotten when win, lose or draw. But got point of win case must more than draw case and so on. Deafual : win 3 points, draw 1 point, lose 0 point
IV. Particular function (detail):
1. Receive registration:
•	Information of each football club:
-	Name
-	Foundation date
-	Founder
-	Home stadium
•	Informations of each players:
-	Name
-	Date of birth
-	Citizenship
-	Passport
-	Club
-	Role
-	Foot
-	Height
-	Weight
•	Note: this function will be deactive when the schedule already create before.
2. Schedule for competing:		

Rule for creating schedule:
•	Match is often hold at 6pm of Saturday and Sunday.
•	Arrange competitive pairs randomly. However, following rules such as:
-	2 clubs are in the same city or province then they have no match at the same day.
-	Each club has no more than two matchs with home stadium or away stadium continuously.
3. View result of match:			
After match, user will record the result of match. System will check and save data into database. User can also cancel and update the record as well.
4. Search information of player:
•	User can search player name, club.
•	User can view more detail about information of player by clicking (date of birth, foot, height, weight, …).
•	There is an image that is presented for corresponded player.

5. Report tourament:
			
•	Rank of club: which club has the largest number of point will be first and so on.
•	In case clubs have the same point, then rank will base on offset
•	Offset = total number of goal – total number of goal are scored by enemies.


