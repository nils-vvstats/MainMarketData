using Application.Interfaces;
using Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.YoHero.YoHeroUsers
{
    public class GetYoHeroUserQueryHandler : IQueryHandler<GetYoHeroUserQuery, YoHeroUser>
    {
        private readonly IRepository<YoHeroUser> _repository;

        public GetYoHeroUserQueryHandler(IRepository<YoHeroUser> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Repository must be provided to execute GetLiveAuctionsQuery");
        }

        public async Task<YoHeroUser> Handle(GetYoHeroUserQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query), "Query must be provided to handle GetLiveAuctionsQuery");
            }
            var filter = new YoHeroUserFilter
            {
                UserId = query.UserId
            };

            var translatedFilter = FilterTranslation(filter);
            var liveAuctions = await _repository.Get(translatedFilter).ConfigureAwait(false);


            return liveAuctions.FirstOrDefault();
        }

        public static Expression<Func<YoHeroUser, bool>> FilterTranslation(YoHeroUserFilter filter)
        {
            Expression<Func<YoHeroUser, bool>> translatedFilter = ag => true;

            if (filter == null)
            {
                return null;
            }
            if (filter.UserId.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.ID == filter.UserId);
            }

            return translatedFilter;
        }
    }
}
