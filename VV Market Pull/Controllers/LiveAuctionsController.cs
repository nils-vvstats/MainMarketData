using Core.Auctions;
using DataAccess.MarketData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiveAuctionsController : ControllerBase
    {
        private readonly ILogger<LiveAuctionsController> _logger;

        public LiveAuctionsController(ILogger<LiveAuctionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LiveAuction> Get()
        {
            var newAuction = new LiveAuction();
            var auctions = new List<LiveAuction>() { newAuction };

            return auctions.ToArray();
        }
    }
}
