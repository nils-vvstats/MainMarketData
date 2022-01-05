using Application.Commands;
using Application.Queries;
using Application.Queries.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orchestrator;
using System.Threading.Tasks;
using TelegramBot.VulcanVerse;


namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VulcanAuctionsController : ControllerBase
    {

        private readonly ILogger<StartTelegramBotController> _logger;
        private readonly ICommandProcessor _commandProcessor;
        private readonly IQueryProcessor _queryProcessor;

        public VulcanAuctionsController(ILogger<StartTelegramBotController> logger,
            IQueryProcessor queryProcessor,
            ICommandProcessor commandProcessor)
        {
            _logger = logger;
            _queryProcessor = queryProcessor;
            _commandProcessor = commandProcessor;
        }


        [HttpGet]
        public async Task<VulcanAuction> Get()
        {
            var getAlertsQuery = new GetActiveVulcanAlertsQuery(true);

            var activeAlerts = await _queryProcessor.Process(getAlertsQuery).ConfigureAwait(false);

            var test = "";

            return new VulcanAuction();
        }
    }
}
