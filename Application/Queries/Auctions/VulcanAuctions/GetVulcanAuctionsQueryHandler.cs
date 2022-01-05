using Application.Interfaces;
using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts.VulcanAlerts
{
    public class GetVulcanAuctionsQueryHandler : IQueryHandler<GetVulcanAuctionsQuery, List<VulcanAuction>>
    {
        private readonly IRepository<VulcanAuction> _repository;

        public GetVulcanAuctionsQueryHandler(IRepository<VulcanAuction> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository must be provided to execute GetLiveAuctionsQuery");
        }

        public async Task<List<VulcanAuction>> Handle(GetVulcanAuctionsQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query), "Query must be provided to handle GetLiveAuctionsQuery");
            }
            var filter = new VulcanAuctionFilter
            {
                AlertExpression = query.Expression
            };

            var liveAuctions = await _repository.Get(filter.AlertExpression).ConfigureAwait(false);


            return liveAuctions.ToList();
        }

    }
}
