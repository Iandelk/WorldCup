using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data.DAL;

namespace Windows_Form_App
{
    public partial class Culture : Form
    {
        private const string LANGUAGE_ENGLISH = "English";
        private const string LANGUAGE_ENGLISH_SHORT = "en";
        private const string LANGUAGE_CROATIAN = "Hrvatski";
        private const string LANGUAGE_CROATIAN_SHORT = "hr-HR";
        private IRepoFile FileRepo;

        public Culture()
        {
            InitializeComponent();
            FileRepo = RepoFactory.GetFileRepo();
        }

        private void btnPickLanguage_Click(object sender, EventArgs e)
        {
            string selectedLanguage = cbLanguage.SelectedItem.ToString();
            if(selectedLanguage == LANGUAGE_CROATIAN)
            {
                FileRepo.SaveCulture(LANGUAGE_CROATIAN_SHORT);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(LANGUAGE_CROATIAN_SHORT);
            }
            else
            {
                FileRepo.SaveCulture(LANGUAGE_ENGLISH_SHORT);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(LANGUAGE_ENGLISH_SHORT);
            }

            
            TeamSelect teamSelectForm = new TeamSelect();
            teamSelectForm.Show();
            this.Hide();
        }

        private void Culture_Load(object sender, EventArgs e)
        {
            cbLanguage.Items.Add(LANGUAGE_ENGLISH);
            cbLanguage.Items.Add(LANGUAGE_CROATIAN);
            cbLanguage.SelectedIndex = 0;
        }

        private void Culture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
