using Newtonsoft.Json;

namespace CoronaApiService.Models
{
    public class Coordinates
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
         
        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}