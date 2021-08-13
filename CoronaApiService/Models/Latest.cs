using Newtonsoft.Json;

namespace CoronaApiService.Models
{
    public class Latest
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set;}
        [JsonProperty("deaths")]
        public int Deaths { get; set;}
        [JsonProperty("recovered")]

        public int Recovered { get; set;}
    }
}
