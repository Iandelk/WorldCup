using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Cup_Data.DAL
{
    class FileRepo : IRepoFile
    {
        private const string DEFAULT_PATH = @"C:\Users\Phyrexian\source\repos\WorldCup_Projekt\LoadFrom\";
        private const string PLAYER_IMAGES_PATH = DEFAULT_PATH+"PlayerImages.txt";
        private const string FAVORITE_PLAYERS_PATH = DEFAULT_PATH + "FavoritePlayers.txt";
        private const string FAVORITE_COUNTRY_PATH = DEFAULT_PATH + "FavoriteCountry.txt";
        private const string AWAY_COUNTRY_PATH = DEFAULT_PATH + "AwayCountry.txt";
        private const string CULTURE_PATH = DEFAULT_PATH + "Culture.txt";
        private const string WINDOW_PATH = DEFAULT_PATH + "WindowState.txt";
        private const string ErrorMessageTitle = "Error!";
        private const char CountrySeparator = ';';
        private const char CountryPlayerSeparator = '|';
        private const char PlayerSeparator = ',';
        private const string DEFAULT_IMAGE_PATH = "PlayerNoImage.png";

        private void CreateFileIfNotExists(string Path)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
        }

        public IList<Player> LoadFavoritePlayers(string country, IList<Player> favoritePlayers)
        {
            CreateFileIfNotExists(FAVORITE_PLAYERS_PATH);

            List<Player> loadedFavoritePlayer = new List<Player>();

            try
            {
                string[] lines = File.ReadAllLines(FAVORITE_PLAYERS_PATH);
                foreach (var line in lines)
                {
                    string[] countryPlayers = line.Split(CountrySeparator);

                    if (countryPlayers[0] == country)
                    {
                        loadedFavoritePlayer.Clear();
                        string[] players = countryPlayers[1].Split(PlayerSeparator);
                        foreach (var player in players)
                        {
                            string[] details = player.Split(CountryPlayerSeparator);

                            if (details[0] != "")
                            {

                                loadedFavoritePlayer.Add(new Player
                                {
                                    Name = details[0],
                                    ShirtNumber = Int32.Parse(details[1]),
                                    Position = details[2]
                                });
                            }
                        }

                    }

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle,MessageBoxButtons.OK ,MessageBoxIcon.Error);
                
            }
          


            return loadedFavoritePlayer;

        }



        public void LoadPlayerImages(String countryName, Player player)
        {

            CreateFileIfNotExists(PLAYER_IMAGES_PATH);

            try
            {
                string[] lines = File.ReadAllLines(PLAYER_IMAGES_PATH);

                foreach (var line in lines)
                {
                    string[] countryPlayers = line.Split(CountrySeparator);
                    if (countryPlayers[0] == countryName)
                    {
                        string[] shirtnumberLocation = countryPlayers[1].Split(CountryPlayerSeparator);



                        for (int i = 0; i <= shirtnumberLocation.Count() - 1; i++)
                        {
                            if (shirtnumberLocation[i] == player.ShirtNumber.ToString())
                            {
                                player.ImagePath = shirtnumberLocation[i + 1];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void SaveFavoritePlayers(string country, IList<Player> favoritePlayers)
        {
            string playersForSave = "";

            if (favoritePlayers.Count > 0)
            {
                foreach (var player in favoritePlayers)
                {
                    playersForSave = $"{playersForSave}{player.Name}{CountryPlayerSeparator}{player.ShirtNumber}{CountryPlayerSeparator}{player.Position},";
                }
                RefreshAndWrite(country, FAVORITE_PLAYERS_PATH, playersForSave);

            }
        }


        public void SavePlayerImages(String country, IList<Player> players)
        {
            String imagesForSave = "";


            foreach (var player in players)
            {
                if (player.ImagePath != DEFAULT_IMAGE_PATH)
                {
                    imagesForSave = $"{imagesForSave}{player.ShirtNumber.ToString()}{CountryPlayerSeparator}{player.ImagePath}{CountryPlayerSeparator}";

                }
            }
            RefreshAndWrite(country, PLAYER_IMAGES_PATH, imagesForSave);

        }


        private void RefreshAndWrite(string country, string Path, string dataForSave)
        {
            string[] lines = File.ReadAllLines(Path);
            int i = 0;
            bool CountryFound = false;
            try
            {
                if (lines.Length == 0)
                {
                    File.WriteAllText(Path, country + CountrySeparator + dataForSave);
                    return;
                }
                else
                {

                    foreach (var line in lines)
                    {

                        string[] countryPlayers = line.Split(CountrySeparator);
                        if (countryPlayers[0] == country || lines[0] == "")
                        {
                            lines[i] = country + CountrySeparator + dataForSave;
                            i++;
                            CountryFound = true;
                        }
                        else if (lines[i] != "")
                        {
                            lines[i] = lines[i];
                            i++;
                        }

                    }

                }
                if (CountryFound)
                    File.WriteAllLines(Path, lines);
                else
                    File.AppendAllText(Path, Environment.NewLine + country + CountrySeparator + dataForSave);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public IList<string> LoadFavoriteCountry()
        {
            List<string> favoriteCountryData = new List<string>();
            CreateFileIfNotExists(FAVORITE_COUNTRY_PATH);
            string[] country = File.ReadAllLines(FAVORITE_COUNTRY_PATH);

            if (country.Length == 1)
            {

                string[] countryData = country[0].Split(CountryPlayerSeparator);

                favoriteCountryData.Add(countryData[0]);
                favoriteCountryData.Add(countryData[1]);
            }
            return favoriteCountryData;
        }

        public void SaveFavoriteCountry(string country, string fifaCode)
        {
            try
            {
                File.WriteAllText(FAVORITE_COUNTRY_PATH, $"{country}{CountryPlayerSeparator}{fifaCode}");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public IList<string> LoadAwayCountry()
        {
            List<string> awayCountryData = new List<string>();
            CreateFileIfNotExists(AWAY_COUNTRY_PATH);
            string[] country = File.ReadAllLines(AWAY_COUNTRY_PATH);

            if (country.Length == 1)
            {

                string[] countryData = country[0].Split(CountryPlayerSeparator);

                awayCountryData.Add(countryData[0]);
                awayCountryData.Add(countryData[1]);
                awayCountryData.Add(countryData[2]);
            }
            return awayCountryData;
        }

        public void SaveAwayCountry(string country, string fifaCode, string fifaid)
        {
            try
            {
                File.WriteAllText(AWAY_COUNTRY_PATH, $"{country}{CountryPlayerSeparator}{fifaCode}{CountryPlayerSeparator}{fifaid}");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string LoadWindowSize()
        {
            String size = "";

            CreateFileIfNotExists(WINDOW_PATH);

            try
            {
                size = File.ReadAllText(WINDOW_PATH);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return size;
        }

        public void SaveWindowSize(string windowState)
        {
            try
            {
                File.WriteAllText(WINDOW_PATH, windowState);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string LoadCulture()
        {
            String culture ="en";

            CreateFileIfNotExists(CULTURE_PATH);

            try
            {
                culture = File.ReadAllText(CULTURE_PATH);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return culture;
        }

        public void SaveCulture(string culture)
        {
            try
            {
                File.WriteAllText(CULTURE_PATH, culture);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}
