using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data.DAL
{
    public interface IRepoFile
    {
        IList<Player> LoadFavoritePlayers(string country,IList<Player> favoritePlayers);
        void LoadPlayerImages(string countryName, Player player);
        void SaveFavoritePlayers(string country, IList<Player> favoritePlayers);
        void SavePlayerImages(string country, IList<Player> players);
        IList<string> LoadFavoriteCountry();
        void SaveFavoriteCountry(string country, string fifaCode);
        IList<string> LoadAwayCountry();
        void SaveAwayCountry(string country, string fifaCode, string fifaId);
        string LoadCulture();
        void SaveCulture(string culture);
        string LoadWindowSize();
        void SaveWindowSize(string windowState);

    }
}
