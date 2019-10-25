using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data.DAL;

namespace Windows_Form_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IRepoFile FileRepo;
            IList<string> countryData;
            string culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileRepo = RepoFactory.GetFileRepo();
            countryData = FileRepo.LoadFavoriteCountry();
            culture = FileRepo.LoadCulture();
            if (culture.Length == 0)
            {
                Application.Run(new Culture());
            }      
            else if (countryData.Count == 0)
            {
                Application.Run(new TeamSelect());

            }
            else
            {
                Application.Run(new PlayerSelect(countryData[1], countryData[0]));
            }
        }
    }
}
