﻿namespace MapTrackingAPI.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime AccessedAt { get; set; }
    }
}
