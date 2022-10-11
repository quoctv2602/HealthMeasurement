using HealthMeasurement.Api.Models;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace HealthMeasurement.Application.Health
{
    public class HealthMeasurementService : IHealthMeasurementService
    {
        public async Task<MonitoringSystem> GetDataMonitor()
        {
            try
            {
                string hostName = Dns.GetHostName();
                MonitoringSystem monitoringSystem = new MonitoringSystem();
                monitoringSystem.MarchineName = hostName;
                monitoringSystem.IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                monitoringSystem.CPUInfo = getCPUCounter();
                monitoringSystem.MemoryInfo = getRAMCounter();
                monitoringSystem.StorageInfo = getDiskCounter();
                monitoringSystem.ResponseTime = DateTime.Now;
                return monitoringSystem;
            }
            catch
            {
                return null;
            }
          
        }
        public int getCPUCounter()
        {
            PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            int cpuCounter = (int)Math.Ceiling(theCPUCounter.NextValue());
            if (cpuCounter == 0)
            {
                Thread.Sleep(1000);
                cpuCounter = (int)Math.Ceiling(theCPUCounter.NextValue());
            }
            return cpuCounter;
        }
        public int getRAMCounter()
        {
            PerformanceCounter ramCounter = new PerformanceCounter();
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            dynamic value = (int)Math.Ceiling(ramCounter.NextValue());
            return value;
        }
        public int getDiskCounter()
        {
            PerformanceCounter diskCounter = new PerformanceCounter();
            diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            var firstValue = (int)Math.Ceiling(diskCounter.NextValue());
            Thread.Sleep(500);
            var secondValue = (int)Math.Ceiling(diskCounter.NextValue());
            return secondValue;
        }
    }
}
