using Application.Commands;
using Application.Queries;
using Core.Auctions;
using Core.Auctions.YoHeroLiveAuctions;
using DataAccess.MarketData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoHeroMarketData.Requests.LiveAuctionsRequest;

namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YoHeroLiveAuctionsController : ControllerBase
    {
        private readonly ILogger<YoHeroLiveAuctionsController> _logger;
        private readonly IQueryProcessor _queryProcessor;
        private readonly ICommandProcessor _commandProcessor;

        public YoHeroLiveAuctionsController(ILogger<YoHeroLiveAuctionsController> logger,
            IQueryProcessor queryProcessor,
            ICommandProcessor commandProcessor)
        {
            _logger = logger;
            _queryProcessor = queryProcessor;
            _commandProcessor = commandProcessor;
        }

        [HttpGet]
        public async Task<bool> Get()
        {
            var marketDataRequest = new YoHeroMarketDataRequest(_commandProcessor, _queryProcessor);
            var LiveAuctions = await marketDataRequest.getLatestMarketData();
            var test = LiveAuctions;
            return true;
        }
    }
}
