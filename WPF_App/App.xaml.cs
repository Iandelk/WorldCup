using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using World_Cup_Data.DAL;

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

   

    public partial class App : Application
    {
        private IRepoFile fileRepo;
        String culture;
        String windowSize;
        IList<String> homeTeam;
        IList<String> awayTeam;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            fileRepo = RepoFactory.GetFileRepo();

          culture =  fileRepo.LoadCulture();
          windowSize = fileRepo.LoadWindowSize();
          homeTeam = fileRepo.LoadFavoriteCountry();
          awayTeam = fileRepo.LoadAwayCountry();

        if(culture.Length == 0 || windowSize.Length == 0)
            {
                CultureSelect cultureSelect = new CultureSelect();
                cultureSelect.Show();

            }else if (homeTeam.Count == 0 || awayTeam.Count == 0)
            {
                CountrySelect countrySelect = new CountrySelect();
                countrySelect.Show();
            }
            else
            {
                MainWindow mw = new MainWindow();
                mw.Show();
            }

        }
    }
}
