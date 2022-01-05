using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.VulcanMarketData.Configurations.Alerts
{
    public class VulcanAlertsConfiguration : IEntityTypeConfiguration<VulcanAlert>
    {
        public void Configure(EntityTypeBuilder<VulcanAlert> builder)
        {
            builder.HasBaseType<Alert>();
            builder.Property(a => a.AlertId);
        }
    }
}
