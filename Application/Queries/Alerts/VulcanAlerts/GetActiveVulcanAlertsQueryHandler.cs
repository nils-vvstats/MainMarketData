using Application.Interfaces;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts.VulcanAlerts
{
    public class GetActiveVulcanAlertsQueryHandler : IQueryHandler<GetActiveVulcanAlertsQuery, List<VulcanAlert>>
    {
        private readonly IReadOnlyRepository<VulcanAlert> _repository;

        public GetActiveVulcanAlertsQueryHandler(IReadOnlyRepository<VulcanAlert> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository must be provided to execute GetLiveAuctionsQuery");
        }

        public async Task<List<VulcanAlert>> Handle(GetActiveVulcanAlertsQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query), "Query must be provided to handle GetLiveAuctionsQuery");
            }
            var filter = new VulcanAlertFilter
            {
                Enabled = query.Enabled
            };

            var translatedFilter = FilterTranslation(filter);
            var activeAlerts = await _repository.Get(translatedFilter).ConfigureAwait(false);

            return activeAlerts.ToList();
        }
        public static Expression<Func<VulcanAlert, bool>> FilterTranslation(VulcanAlertFilter filter)
        {
            Expression<Func<VulcanAlert, bool>> translatedFilter = ag => true;

            if (filter == null)
            {
                return null;
            }

            translatedFilter = translatedFilter.And(a => a.Enabled == filter.Enabled);


            return translatedFilter;
        }
    }
}
