using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data;
using World_Cup_Data.DAL;

namespace Windows_Form_App
{
    public partial class TeamSelect : Form
    {
        private IRepoTeams TeamsRepo;
        private IRepoFile FileRepo;
        private IList<Team> teamsList;
        public TeamSelect()
        {
            InitializeComponent();
            TeamsRepo = RepoFactory.GetTeamRepo();
            FileRepo = RepoFactory.GetFileRepo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoAsync();
           
        }

        private void btnPickTeam_Click(object sender, EventArgs e)
        {
            var selectedTeam = cbTeams.SelectedItem as Team;
            FileRepo.SaveFavoriteCountry(selectedTeam.Country, selectedTeam.FifaCode);
            PlayerSelect playerSelectForm = new PlayerSelect(selectedTeam.FifaCode, selectedTeam.Country);
            playerSelectForm.Show();
            this.Hide();
        }

        private Task<IList<Team>> GetAsync()
        {

            return Task.Run(() => TeamsRepo.LoadTeams()
                );

        }

      private async void DoAsync()
        {
            teamsList = await GetAsync();
            teamsList = teamsList.OrderBy(x => x.Country).ToList();
            foreach (var team in teamsList)
            {
                cbTeams.Items.Add(team);
            }
            cbTeams.SelectedIndex = 0;
        }

        private void TeamSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
