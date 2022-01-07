using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts.VulcanAlerts
{
    public class GetVulcanAuctionsQuery : IQuery<List<VulcanAuction>>
    {
        public GetVulcanAuctionsQuery() { }
        public GetVulcanAuctionsQuery(bool sendAlert)
        {
            SendAlert = sendAlert;
        }

        public bool SendAlert { get; protected internal set; }
    }
}
