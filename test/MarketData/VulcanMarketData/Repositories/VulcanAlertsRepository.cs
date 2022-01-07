using Application.Interfaces;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
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
    public class VulcanAlertsRepository : IReadOnlyRepository<VulcanAlert>
    {
        protected VulcanMarketDataDbContext _context;

        public VulcanAlertsRepository(VulcanMarketDataDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VulcanAlert>> Get(Expression<Func<VulcanAlert, bool>> filter)
        {
            var auctions = await _context.VulcanAlerts
                .Where(filter)
                .ToListAsync()
                .ConfigureAwait(false);
            return auctions;
        }

        public Task<IEnumerable<VulcanAlert>> Get()
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<VulcanAlert>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<VulcanAlert> GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
