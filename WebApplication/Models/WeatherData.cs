using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class WeatherData
    {
        [JsonProperty("timezone")]
        public int timezone { get; set; }

        [JsonProperty("cod")]
        public string cod { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("cnt")]
        public string TimeStamp { get; set; }

        [JsonProperty("City")]
        public City City { get; set; }

        [JsonProperty("list")]
        public WeatherDataInfo[] WeatherDataInfo { get; set; }
    }
    public class WeatherDataInfo
    {
        [JsonProperty("dt")]
        public double dt { get; set; }
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("visibility")]
        public long visibility { get; set; }

        [JsonProperty("pop")]
        public long pop { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

    }
    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }


    public class Weather
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public string Visibility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public long Deg { get; set; }
    }
    public class Sys
    {
        
        [JsonProperty("pod")]
        public string pod { get; set; }

    }

    public class Main
    {
        [JsonProperty("temp")]
        public long Temperature { get; set; }

        [JsonProperty("feels_like")]

        public double feels_like { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        [JsonProperty("sea_level")]
        public long sea_level { get; set; }

        [JsonProperty("grnd_level")]
        public long grnd_level { get; set; }

        [JsonProperty("humidity")]

        public long Humidity { get; set; }

        [JsonProperty("temp_kf")]
        public double Percepita { get; set; }
    }
    public class City
    {
        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

