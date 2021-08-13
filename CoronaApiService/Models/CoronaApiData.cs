using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoronaApiService.Models
{
    //root obj used by json
    public class CoronaApiData
    {
        [JsonProperty("latest")]
        public Latest Latest { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }
    }
}