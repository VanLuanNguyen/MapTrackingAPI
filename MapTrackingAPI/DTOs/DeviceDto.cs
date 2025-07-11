namespace MapTrackingAPI.DTOs
{
    public class DeviceDto
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime AccessedAt { get; set; }
    }
}
