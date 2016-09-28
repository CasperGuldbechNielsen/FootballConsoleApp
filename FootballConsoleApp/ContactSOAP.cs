using System;
using System.Collections.Generic;
using System.Linq;
using FootballConsoleApp.ServiceReference1;

namespace FootballConsoleApp
{
    public class ContactSOAP
    {
        private ServiceReference1.SportsdataSoapClient client;

        public ContactSOAP()
        {
            client = new SportsdataSoapClient();
        }

        public void GetLeagueStanding()
        {
            //TODO get current standing
            Team[] allLeages = client.GetTeamsByLeagueSaison("bl1", "2016")
                ;
            List<Team> test = allLeages.ToList();

            foreach (var team in test)
            {
                if (team.teamName.Contains("S"))
                {
                    Console.WriteLine(team.teamName);
                }
            }

            Console.ReadLine();
        }

        public void GetUpcomingMatches()
        {
            //DateTime endOfSeason = new DateTime(2017, 6, 23);

            //Matchdata[] allMatches = client.GetMatchdataByLeagueDateTime(DateTime.Now, endOfSeason, "bl1");

            //foreach (Matchdata match in allMatches)
            //{
            //    Console.WriteLine(match.nameTeam1 + " : " + match.nameTeam2);
            //}
        }
    }
}