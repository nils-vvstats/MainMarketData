using Application.Interfaces;
using Core.Auctions;
using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.LiveAuctions
{
    public class GetYoHeroLiveAuctionsQueryHandler : IQueryHandler<GetYoHeroLiveAuctionsQuery, List<YoHeroLiveAuction>>
    {
        private readonly IRepository<YoHeroLiveAuction> _repository;

        public GetYoHeroLiveAuctionsQueryHandler(IRepository<YoHeroLiveAuction> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository must be provided to execute GetLiveAuctionsQuery");
        }

        public async Task<List<YoHeroLiveAuction>> Handle(GetYoHeroLiveAuctionsQuery query)
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
