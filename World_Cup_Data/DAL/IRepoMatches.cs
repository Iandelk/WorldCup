using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World_Cup_Data.Models;

namespace World_Cup_Data.DAL
{
    public interface IRepoMatches
    {
        IList<Match> LoadMatches(string Fifa_code);
        IList<Player> LoadPlayers(IList<Match> matches, string country);
        IList<TeamEvents> LoadTeamEvents(IList<Match> matches, string country);
        IList<Player> LoadPlayersAsStartingEleven(IList<Match> matches, string Country);
        IList<TeamPerMatch> LoadAwayTeam(IList<Match> matches, String fifaCode);
        IList<TeamEvents> LoadSpecificTeamEvents(IList<Match> matches, string fifaId);
    }
}
