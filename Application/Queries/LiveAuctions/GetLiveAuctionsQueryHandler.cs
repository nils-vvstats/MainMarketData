using Application.Interfaces;
using Core.Auctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.LiveAuctions
{
    public class GetLiveAuctionsQueryHandler : IQueryHandler<GetLiveAuctionsQuery, List<ILiveAuction>>
    {
        private readonly IReadOnlyRepository<ILiveAuction> _repository;

        public GetLiveAuctionsQueryHandler(IReadOnlyRepository<ILiveAuction> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository must be provided to execute GetLiveAuctionsQuery");
        }

        public async Task<List<ILiveAuction>> Handle(GetLiveAuctionsQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query), "Query must be provided to handle GetLiveAuctionsQuery");
            }

            var liveAuctions = await _repository.GetAll().ConfigureAwait(false);

            return liveAuctions.ToList();
        }
    }
}
