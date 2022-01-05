using Application.Interfaces;
using Core.Alerts;
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
    public class VulcanAlertsRepository : IRepository<Alert>
    {
        protected VulcanMarketDataDbContext _context;

        public VulcanAlertsRepository(VulcanMarketDataDbContext context)
        {
            _context = context;
        }
        public void Add(Alert entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Alert> entities)
        {
            _context.AddRange(entities);
        }

        public async Task<List<Alert>> Get(Expression<Func<Alert, bool>> filter)
        {
            var auctions = await _context.Alerts
                .Where(filter)
                .ToListAsync()
                .ConfigureAwait(false);
            return auctions;
        }

        public Task<Alert> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Alert entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Alert> entities)
        {
            _context.Set<Alert>().RemoveRange(entities);
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Alert entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<Alert> entities)
        {
            this._context.Alerts.AttachRange(entities);
            foreach (var auction in entities)
            {
                _context.Entry(auction).State = EntityState.Modified;
            }


        }
    }
}
