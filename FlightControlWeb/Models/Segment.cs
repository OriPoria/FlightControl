﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class Segment
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [JsonPropertyName("timespan_seconds")]
        public double TimespanSeconds { get; set; }
    }
}