using HealthMeasurement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMeasurement.Application.Health
{
    public interface IHealthMeasurementService
    {
        Task<MonitoringSystem> GetDataMonitor();
    }
}
