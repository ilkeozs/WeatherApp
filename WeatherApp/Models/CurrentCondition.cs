using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class CurrentCondition
    {
        public List<WeatherDesc> WeatherDesc { get; set; }

        [JsonPropertyName("temp_C")]
        public string TempC { get; set; }

        [JsonPropertyName("temp_F")]
        public string TempF { get; set; }

        [JsonPropertyName("FeelsLikeC")]
        public string FeelsLikeC { get; set; }

        [JsonPropertyName("FeelsLikeF")]
        public string FeelsLikeF { get; set; }

        [JsonPropertyName("humidity")]
        public string Humidity { get; set; }

        [JsonPropertyName("uvIndex")]
        public string UvIndex { get; set; }

        [JsonPropertyName("windspeedKmph")]
        public string WindspeedKmph { get; set; }

        [JsonPropertyName("pressure")]
        public string Pressure { get; set; }

        [JsonPropertyName("cloudcover")]
        public string Cloudcover { get; set; }

        [JsonPropertyName("observation_time")]
        public string ObservationTime { get; set; }

        [JsonPropertyName("localObsDateTime")]
        public string LocalObsDateTime { get; set; }
    }
}