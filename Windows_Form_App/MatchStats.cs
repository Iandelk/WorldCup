using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Cup_Data.Models;

namespace Windows_Form_App
{
    public partial class MatchStats : UserControl
    {
        Match Match;

        public MatchStats(Match match)
        {
            InitializeComponent();
            SetMatchStats(match);
            this.Match = match;
        }




        private void SetMatchStats(Match match)
        {

           
            lblLocation.Text = match.Location;
            lblAttendance.Text = $"{Resources.Resources.AttendanceString} {match.Attendance.ToString()}";
            lblHomeTeam.Text = match.HomeTeamCountry;
            lblAwayTeam.Text = match.AwayTeamCountry;

        }

    }

}

