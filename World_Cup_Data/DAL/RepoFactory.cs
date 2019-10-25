using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data.DAL
{
    public static class RepoFactory
    {

        public static IRepoTeams GetTeamRepo() => new TeamRepo();
        public static IRepoMatches GetMatchRepo() => new MatchRepo();
        public static IRepoFile GetFileRepo() => new FileRepo();

    }
}
