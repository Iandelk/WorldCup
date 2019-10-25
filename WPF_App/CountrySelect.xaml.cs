using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using World_Cup_Data;
using World_Cup_Data.DAL;
using World_Cup_Data.Models;

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for CountrySelect.xaml
    /// </summary>
    public partial class CountrySelect : Window
    {
        private IRepoTeams TeamsRepo;
        private IRepoFile FileRepo;
        private IRepoMatches MatchRepo;
        private IList<Team> teamsList;
        private IList<Match> matches;
        private IList<TeamPerMatch> awayTeamsList;
        IList<string> countryDataHome;
        IList<string> countryDataAway;
        String fifaCode;
        Team Hometeam;
        TeamPerMatch AwayTeam;


        public CountrySelect()
        {
            InitializeComponent();
            MatchRepo = RepoFactory.GetMatchRepo();
            TeamsRepo = RepoFactory.GetTeamRepo();
            FileRepo = RepoFactory.GetFileRepo();
            countryDataHome = FileRepo.LoadFavoriteCountry();
            countryDataAway = FileRepo.LoadAwayCountry();
          

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoAsync();
        }

        private Task<IList<Team>> GetAsync()
        {

            return Task.Run(() => TeamsRepo.LoadTeams()
                );

        }


        private Task<IList<Match>> GetMatchesAsync(string fifaCode)
        {
            return Task.Run(() => MatchRepo.LoadMatches(fifaCode)
                );

        }

        private async void DoAsync()
        {
           
            teamsList = await GetAsync();
            foreach (var team in teamsList)
            {
                cb_HomeCountry.Items.Add(team);
            }
            if (countryDataHome.Count > 0)
            {
                Hometeam = teamsList.First(t => t.Country == countryDataHome[0]);
                cb_HomeCountry.SelectedItem = Hometeam;
            }
            else
            {
                cb_HomeCountry.SelectedIndex = 0;
            }

        }

        private async void GetMatchesAsync()
        {
            matches = await GetMatchesAsync(fifaCode);
            getAwayTeams();
        }

        private void getAwayTeams()
        {
            if (awayTeamsList != null)
            {
                awayTeamsList.Clear();
                cb_AwayCountry.Items.Clear();
            }
            awayTeamsList = MatchRepo.LoadAwayTeam(matches, fifaCode);
            awayTeamsList = awayTeamsList.OrderBy(x => x.Country).ToList();
            foreach (var awayTeam in awayTeamsList)
            {
                cb_AwayCountry.Items.Add(awayTeam);
              
            }
            if (countryDataAway.Count > 0 && cb_HomeCountry.SelectedItem == Hometeam)
            {
                AwayTeam = awayTeamsList.First(t => t.Country == countryDataAway[0]);
                cb_AwayCountry.SelectedItem = AwayTeam;
            }
            else
            {
                cb_AwayCountry.SelectedIndex = 0;
            }

        }

        private void cb_HomeCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            fifaCode = (cb_HomeCountry.SelectedItem as Team).FifaCode;
            GetMatchesAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FileRepo.SaveFavoriteCountry((cb_HomeCountry.SelectedItem as Team).Country, (cb_HomeCountry.SelectedItem as Team).FifaCode);
            FileRepo.SaveAwayCountry((cb_AwayCountry.SelectedItem as TeamPerMatch).Country, (cb_AwayCountry.SelectedItem as TeamPerMatch).Code, (cb_AwayCountry.SelectedItem as TeamPerMatch).FifaId);

            MainWindow window = new MainWindow();
            window.Show();
            this.Close();

        }

    }
}
