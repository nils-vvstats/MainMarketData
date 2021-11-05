using Application.Commands;
using Application.Queries;
using Application.Queries.LiveAuctions;
using Core.Auctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("AuctionLiveController")]
    public class AuctionLiveController : ControllerBase
    {


        private readonly ILogger<AuctionLiveController> _logger;
        //private readonly IQueryProcessor _queryProcessor;

        public AuctionLiveController(ILogger<AuctionLiveController> logger)//, IQueryProcessor queryProcessor)
        {
            _logger = logger;
            //_queryProcessor = queryProcessor;
        }

        [HttpGet]
        public async Task<IEnumerable<LiveAuction>> Get()
        {
            var liveAuction = new LiveAuction(1);

            var db = new CreateLiveAuctionCommand(liveAuction);

            var liveAuctionsQuery = new GetLiveAuctionsQuery();
            // var liveAuctions = await _queryProcessor.Process(liveAuctionsQuery).ConfigureAwait(false);

            //return liveAuctions.ToList();
            return null;



        }
    }
}
