using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data.Models;

namespace World_Cup_Data.DAL
{


    public class MatchRepo : IRepoMatches
    {
        private const string ErrorMessageTitle = "Error!";
        private const string API_URL = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        static HttpClient client = new HttpClient();

        public IList<Match> LoadMatches(string Fifa_code)
        {
            IList<Match> matchList = new List<Match>();
            try
            {
                var webRequest = WebRequest.Create(API_URL + Fifa_code) as HttpWebRequest;


                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

               

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var matchAsJson = sr.ReadToEnd();
                        var matches = JsonConvert.DeserializeObject<List<Match>>(matchAsJson);
                        foreach (var match in matches)
                        {
                            matchList.Add(match);
                        }
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return matchList;
        }

        public IList<Player> LoadPlayers(IList<Match> matches, string Country)
        {
            IList<Player> players = new List<Player>();

            IList<TeamStatistics> stats = new List<TeamStatistics>();

         

            foreach (var match in matches)
            {
            
                stats.Add(match.HomeTeamStatistics);
            }
            
            int i = 0;
            while (stats[i].Country != Country)
                i++;
 
                foreach (Player player in stats[i].StartingEleven)
                {
                    players.Add(player);
                }
                foreach (Player player in stats[i].Substitutes)
                {
                    players.Add(player);
                }
            
            return players;
        }

        public IList<Player> LoadPlayersAsStartingEleven(IList<Match> matches, string Country)
        {
            IList<Player> players = new List<Player>();

            IList<TeamStatistics> stats = new List<TeamStatistics>();



            foreach (var match in matches)
            {

                stats.Add(match.HomeTeamStatistics);
                stats.Add(match.AwayTeamStatistics);
            }

            int i = 0;
            while (stats[i].Country != Country)
                i++;

            foreach (Player player in stats[i].StartingEleven)
            {
                players.Add(player);
            }

            return players;
        }

        public IList<Player> LoadAwayPlayersAsStartingEleven(IList<Match> matches, string Country)
        {
            IList<Player> players = new List<Player>();

            IList<TeamStatistics> stats = new List<TeamStatistics>();



            foreach (var match in matches)
            {

                stats.Add(match.AwayTeamStatistics);
            }

            int i = 0;
            while (stats[i].Country != Country)
                i++;

            foreach (Player player in stats[i].StartingEleven)
            {
                players.Add(player);
            }

            return players;
        }

        public IList<TeamPerMatch> LoadAwayTeam(IList<Match> matches, String fifaCode)
        {

            IList<TeamPerMatch> awayTeams = new List<TeamPerMatch>();



            foreach (var match in matches)
            {
                if (match.AwayTeam.Code != fifaCode)
                {
                    match.AwayTeam.FifaId = match.Fifa_Id;
                    match.AwayTeam.StageName = match.Stage_Name;
                    awayTeams.Add(match.AwayTeam);
                }
                else
                {
                    match.AwayTeam.FifaId = match.Fifa_Id;
                    match.HomeTeam.StageName = match.Stage_Name;
                    awayTeams.Add(match.HomeTeam);
                }


            }
      
            return awayTeams;
        }

        public IList<TeamEvents> LoadTeamEvents(IList<Match> matches, string country)
        {
            IList<TeamEvents> events = new List<TeamEvents>();

            foreach (var match in matches)
            {
              foreach(var thing in match.HomeTeamEvents)
                {
                    events.Add(thing);
                }
                foreach (var thing in match.AwayTeamEvents)
                {
                    events.Add(thing);
                }

            }

                return events;
        }

        public IList<TeamEvents> LoadSpecificTeamEvents(IList<Match> matches, string fifaId)
        {
            IList<TeamEvents> events = new List<TeamEvents>();

            foreach (var match in matches)
            {
                if (match.Fifa_Id == fifaId)
                {
                    foreach (var thing in match.HomeTeamEvents)
                    {
                        events.Add(thing);
                    }
                    foreach (var thing in match.AwayTeamEvents)
                    {
                        events.Add(thing);
                    }
                }
            }

            return events;
        }

    }
}
