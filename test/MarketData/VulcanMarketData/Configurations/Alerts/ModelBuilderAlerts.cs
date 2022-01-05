using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.VulcanMarketData.Configurations.Alerts
{
    public static class ModelBuilderAlerts
    {
        public static void ConfigureAlerts(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlertsConfiguration());
            modelBuilder.ApplyConfiguration(new VulcanAlertsConfiguration());

        }
    }
}
