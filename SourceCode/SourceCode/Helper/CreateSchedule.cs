using SourceCode.DAO;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Helper
{
    public class CreateSchedule
    {
        private static CreateSchedule instance;

        private static TimeSpan time = new TimeSpan(7, 0, 0);

        public static CreateSchedule Instance
        {
            get
            {
                if (instance == null)
                    instance = new CreateSchedule();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public CreateSchedule()
        {

        }

        public List<MatchDTO> Create()
        {
            List<MatchDTO> list_matchs = new List<MatchDTO>(); // list of matches

            List<ClubDTO> list_clubs = ClubDAO.Instance.LoadAllClubs(); // list of clubs

            if (list_clubs.Count == 0)
                return null;

            List<string> list_id_club = list_clubids(list_clubs); // list of ids of clubs

            int number_clubs = list_clubs.Count; // the number of clubs


            if (number_clubs < 4)
                return null;


            DateTime date = new DateTime();
            date = DateTime.Now.Date;

            date = GetNextWeekday(date, DayOfWeek.Saturday);

            for (int i = 0; i < 5; i++)
            {
                date = date.AddDays(7);
            }



            int round = (number_clubs - 1);
            int match_id = 0;


            if (number_clubs % 2 == 0) // case even number
            {
                for (int i = 0; i < round; i++)// rounds
                {
                    for (int j = 0; j < number_clubs ; j += 2)
                    {
                        match_id++;
                        string clubA = list_id_club[j];
                        string clubB = list_id_club[j + 1];
                        string stadium;


                        stadium = stadiumOfClub(list_id_club[j], list_clubs);
                        MatchDTO a_match = new MatchDTO(match_id, date, time, list_id_club[j], list_id_club[j + 1], stadium);
                        list_matchs.Add(a_match);

                    }
                    list_id_club = rotate(list_id_club); // rotate all clubs
                    date = date.AddDays(7);
                }
            }
            else
            {

                for (int i = 0; i < round; i++)// case odd number
                {
                    for (int j = 0; j < number_clubs; j += 2)
                    {
                        if (j + 1 >= number_clubs)
                            break;
                        match_id++;
                        string clubA = list_id_club[j];
                        string clubB = list_id_club[j + 1];
                        string stadium;


                        stadium = stadiumOfClub(list_id_club[j], list_clubs);
                        MatchDTO a_match = new MatchDTO(match_id, date, time, list_id_club[j], list_id_club[j + 1], stadium);
                        list_matchs.Add(a_match);

                    }
                    list_id_club = rotate(list_id_club); // rotate all clubs
                    date = date.AddDays(7);
                }
            }
            return list_matchs;
        }

        private string stadiumOfClub(string v, List<ClubDTO> list_clubs)
        {
            ClubDTO club = list_clubs.Find(x => x.Club_id == v);
            return club.Stadium;
        }

        private List<string> rotate(List<string> list)
        {

            List<string> temp = new List<string>();

            temp.Add(list[list.Count - 1]);
            for (int i = 0; i < list.Count - 1; i++)
            {
                temp.Add(list[i]);
            }


            return temp;
        }

        private List<string> list_clubids(List<ClubDTO> list)
        {
            List<string> list_id = new List<string>();

            for(int i = 0; i < list.Count;i++)
            {
                list_id.Add(list[i].Club_id.ToString());
            }

            return list_id;
        }
        private static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

    }
}
