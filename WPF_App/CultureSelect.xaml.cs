using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
  
    public partial class CultureSelect : Window
    {
    
        private IRepoFile FileRepo;
        private const string LANGUAGE_ENGLISH = "English";
        private const string LANGUAGE_ENGLISH_SHORT = "en";
        private const string LANGUAGE_CROATIAN = "Hrvatski";
        private const string LANGUAGE_CROATIAN_SHORT = "hr-HR";
        private const string MAXIMIZED = "Maximized";
        private const string WINDOWED = "Windowed";



        public CultureSelect()
        {
            InitializeComponent();

            FileRepo = RepoFactory.GetFileRepo();

            setUpComboBoxes();
        }

        private void setUpComboBoxes()
        {
            cb_Language.Items.Add(LANGUAGE_ENGLISH);
            cb_Language.Items.Add(LANGUAGE_CROATIAN);
            cb_Language.SelectedIndex = 0;

            cb_size.Items.Add(WINDOWED);
            cb_size.Items.Add(MAXIMIZED);
            cb_size.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedLanguage = cb_Language.SelectedItem.ToString();
            string selectedSize = cb_size.SelectedItem.ToString();
            if (selectedLanguage == LANGUAGE_CROATIAN)
            {
                FileRepo.SaveCulture(LANGUAGE_CROATIAN_SHORT);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(LANGUAGE_CROATIAN_SHORT);
            }
            else
            {
                FileRepo.SaveCulture(LANGUAGE_ENGLISH_SHORT);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(LANGUAGE_ENGLISH_SHORT);
            }

            FileRepo.SaveWindowSize(selectedSize);


            CountrySelect cs = new CountrySelect();
            cs.Show();
            this.Close();
        }

     
    }
    
}
