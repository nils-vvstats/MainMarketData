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
    public class GetVulcanAuctionsQuery : IQuery<VulcanAlert>
    {
        public GetVulcanAuctionsQuery(Expression<Func<VulcanAuction, bool>> expression)
        {
            Expression = expression;
        }

        public Expression<Func<VulcanAuction, bool>> Expression { get; }
    }
}
