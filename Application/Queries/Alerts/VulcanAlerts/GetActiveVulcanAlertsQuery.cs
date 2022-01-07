using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts.VulcanAlerts
{
    public class GetActiveVulcanAlertsQuery : IQuery<List<VulcanAlert>>
    {
        public GetActiveVulcanAlertsQuery() { }
        public GetActiveVulcanAlertsQuery(bool enabled)
        {
            Enabled = enabled;
        }

        public bool Enabled { get; protected internal set; }
    }
}
