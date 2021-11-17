﻿using Application.Interfaces;
using Application.Queries;
using Application.Queries.YoHero;
using Core.Auctions.YoHeroLiveAuctions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.Repository
{
    public class YoHeroLiveAuctionsRepository : IRepository<YoHeroLiveAuction>
    {
        protected MarketDataDbContext _context;

        public YoHeroLiveAuctionsRepository(MarketDataDbContext context)
        {
            _context = context;
        }
        public void Add(YoHeroLiveAuction entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<YoHeroLiveAuction> entities)
        {
            _context.AddRange(entities);
        }

        public async Task<List<YoHeroLiveAuction>> Get(Expression<Func<YoHeroLiveAuction, bool>> filter)
        {
            var auctions = await _context.YoHeroLiveAuctions
                .Where(filter)
                .Include(la => la.Hero)
                .ToListAsync()
                .ConfigureAwait(false);
            return auctions;
        }

        public Task<YoHeroLiveAuction> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Remove(YoHeroLiveAuction entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<YoHeroLiveAuction> entities)
        {
            _context.Set<YoHeroLiveAuction>().RemoveRange(entities);
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(YoHeroLiveAuction entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<YoHeroLiveAuction> entities)
        {
            throw new NotImplementedException();
        }
    }
}
