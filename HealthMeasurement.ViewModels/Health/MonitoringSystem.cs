using System;

namespace HealthMeasurement.Api.Models
{
    public class MonitoringSystem
    {
        public string MarchineName { get; set; }
        public string IpAddress { get; set; }
        public int CPUInfo { get; set; }
        public int CPUOver { get; set; }
        public int MemoryInfo { get; set; }
        public int MemoryOver { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime ResponseTime { get; set; }
        public int StorageInfo { get; set; }
        public int StorageOver { get; set; }
        public string AppName { get; set; }
        public int NumberOfTransactionFail { get; set; }
        public int TransactionFailOver { get; set; }
        public string ContentData { get; set; }
    }
}
