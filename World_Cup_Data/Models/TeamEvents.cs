using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data.Models
{
    public class TeamEvents
    {
 
        [JsonProperty("type_of_event")]
        public string TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

    }
}
