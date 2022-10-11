namespace HealthMeasurement.Api.Models
{
    public class MonitoringSystem
    {
        public string MarchineName { get; set; }
        public string IpAddress { get; set; }
        public int CPU { get; set; }
        public int Memory { get; set; }
        public int Storage { get; set; }
    }
}
