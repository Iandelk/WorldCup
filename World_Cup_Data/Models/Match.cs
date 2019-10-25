using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data.Models
{
   public class Match
    {
        public List<Player> Team { get; set; }
        public List<TeamEvents> Events { get; set; }
        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }


        [JsonProperty("fifa_id")]
        public string Fifa_Id { get; set; }

        [JsonProperty("stage_name")]
        public string Stage_Name { get; set; }

        [JsonProperty("attendance")]
        public long Attendance { get; set; }

        [JsonProperty("away_team")]
        public TeamPerMatch AwayTeam { get; set; }

        [JsonProperty("home_team")]
        public TeamPerMatch HomeTeam { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }


        [JsonProperty("home_team_events")]
        public List<TeamEvents> HomeTeamEvents { get; set; }


        [JsonProperty("away_team_events")]
        public List<TeamEvents> AwayTeamEvents { get; set; }


        [JsonProperty("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }


    }

    public class TeamStatistics
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("yellow_cards")]
        public long YellowCards { get; set; }


        [JsonProperty("starting_eleven")]
        public List<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public List<Player> Substitutes { get; set; }
    }

    public class TeamPerMatch
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }


        [JsonProperty("goals")]
        public long Goals { get; set; }

        [JsonProperty("penalties")]
        public long Penalties { get; set; }

        public String StageName { get; set; }

        public String FifaId { get; set; }

        public override string ToString() => $"{Country} - {StageName}";
    }

}
