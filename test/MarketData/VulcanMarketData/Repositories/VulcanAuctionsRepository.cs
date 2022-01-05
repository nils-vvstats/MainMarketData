using Application.Interfaces;
using Core.Auctions.VulcanAuctions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MarketData.VulcanMarketData.Repositories
{
    public class VulcanAuctionsRepository : IRepository<VulcanAuction>
    {
        protected VulcanMarketDataDbContext _context;

        public VulcanAuctionsRepository(VulcanMarketDataDbContext context)
        {
            _context = context;
        }
        public void Add(VulcanAuction entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<VulcanAuction> entities)
        {
            _context.AddRange(entities);
        }

        public async Task<List<VulcanAuction>> Get(Expression<Func<VulcanAuction, bool>> filter)
        {
            var auctions = await _context.VulcanAuctions
                .Where(filter)
                .ToListAsync()
                .ConfigureAwait(false);
            return auctions;
        }

        public Task<VulcanAuction> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Remove(VulcanAuction entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<VulcanAuction> entities)
        {
            _context.Set<VulcanAuction>().RemoveRange(entities);
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(VulcanAuction entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<VulcanAuction> entities)
        {
            this._context.VulcanAuctions.AttachRange(entities);
            foreach (var auction in entities)
            {
                _context.Entry(auction).State = EntityState.Modified;
            }


        }
    }
}
