﻿using Application.Interfaces;
using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Alerts
{
    public class VulcanAuctionFilter : IFilter
    {
        public Expression<Func<VulcanAuction, bool>> AlertExpression { get; protected internal set; }
    }
}
