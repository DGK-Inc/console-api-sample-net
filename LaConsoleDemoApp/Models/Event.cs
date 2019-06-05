using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaConsoleDemoApp.Models
{
    public class Event
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "location_name")]
        public string LocationName { get; set; }

        [JsonProperty(PropertyName = "location_address")]
        public string LocationAddress { get; set; }

        [JsonProperty(PropertyName = "location_city")]
        public string LocationCity { get; set; }

        [JsonProperty(PropertyName = "location_province")]
        public string LocationProvince { get; set; }
    }
}