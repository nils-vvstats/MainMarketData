

using Application.Interfaces;
using Application.Queries.YoHero;
using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

            var filter = new YoHeroLiveAuctionsFilter
            {
                Enabled = query.Enabled,
                GenesisHero = query.GenesisHero,
                Head = query.Head,
                Face = query.Face,
                Body = query.Body,
                Eyes = query.Eyes,
                Ears = query.Ears,
                Legs = query.Legs,
                Hp = query.Hp,
                Att = query.Att,
                Spo = query.Spo,
                Dex = query.Dex,
                Crit = query.Crit
            };

            var translatedFilter = FilterTranslation(filter);
            var liveAuctions = await _repository.Get(translatedFilter).ConfigureAwait(false);


            return liveAuctions;
        }

        public static Expression<Func<YoHeroLiveAuction, bool>> FilterTranslation(YoHeroLiveAuctionsFilter filter)
        {
            Expression<Func<YoHeroLiveAuction, bool>> translatedFilter = ag => true;

            if (filter == null)
            {
                return null;
            }
            if (filter.Enabled.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Enabled == filter.Enabled);
            }
            if (filter.GenesisHero.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.GenesisHero == filter.GenesisHero);
            }

            if (filter.Head.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Head == filter.Head);
            }

            if (filter.Face.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Face == filter.Face);
            }

            if (filter.Body.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Body == filter.Body);
            }

            if (filter.Eyes.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Eyes == filter.Eyes);
            }

            if (filter.Ears.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Ears == filter.Ears);
            }

            if (filter.Legs.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroComposition.Legs == filter.Legs);
            }

            if (filter.Att.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroAttributes.ATT == filter.Att);
            }
            if (filter.Hp.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroAttributes.HP == filter.Hp);
            }
            if (filter.Spo.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroAttributes.SPO == filter.Spo);
            }
            if (filter.Dex.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroAttributes.DEX == filter.Dex);
            }
            if (filter.Crit.HasValue)
            {
                translatedFilter = translatedFilter.And(la => la.Hero.HeroProperties.HeroAttributes.CRIT == filter.Crit);
            }

            return translatedFilter;
        }
    }
}
