using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Cup_Data
{
    public class Player
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public String Position { get; set; }

        public String ImagePath { get; set; }

        public int GoalsScored { get; set; }

        public int YellowCards { get; set; }

        public override string ToString() => $"{Name}";
    }
}
