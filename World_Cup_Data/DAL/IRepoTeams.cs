using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data.DAL
{
   public interface IRepoTeams
    {
        IList<Team> LoadTeams();
    }
}
