using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherModel
    {
        [JsonPropertyName("current_condition")]
        public List<CurrentCondition> CurrentCondition { get; set; }
    }
}