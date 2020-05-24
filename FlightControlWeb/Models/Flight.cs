﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class Flight
    {
        [JsonProperty("flight_id")]
        [JsonPropertyName("flight_id")]
        public string FlightId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Passengers { get; set; }

        [JsonProperty("company_name")]
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("date_time")]
        [JsonPropertyName("date_time")]
        public DateTime DateTime { get; set; }

        [JsonProperty("is_external")]
        [JsonPropertyName("is_external")]
        public bool IsExternal { get; set; }
    }
}