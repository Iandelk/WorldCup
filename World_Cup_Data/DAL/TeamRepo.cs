using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Cup_Data.DAL
{
    class TeamRepo : IRepoTeams
    {
        private const string API_URL = "https://world-cup-json-2018.herokuapp.com/teams/results";
        static HttpClient client = new HttpClient();
        private const string ErrorMessageTitle = "Error!";


        public IList<Team> LoadTeams()
        {
            IList<Team> teamList = new List<Team>();

            try
            {
                var webRequest = WebRequest.Create(API_URL) as HttpWebRequest;


                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

               

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var teamsAsJson = sr.ReadToEnd();
                        var teams = JsonConvert.DeserializeObject<List<Team>>(teamsAsJson);
                        foreach (var team in teams)
                        {
                            teamList.Add(team);
                        }
                    }
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return teamList;
        }

       
    }
}
