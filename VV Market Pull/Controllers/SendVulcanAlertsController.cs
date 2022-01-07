using Application.Commands;
using Application.Commands.Alerts;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orchestrator;
using System.Threading.Tasks;
using TelegramBot.VulcanVerse;


namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendVulcanAlertsController : ControllerBase
    {

        private readonly ILogger<StartTelegramBotController> _logger;
        private readonly ICommandProcessor _commandProcessor;
        private readonly IQueryProcessor _queryProcessor;

        public SendVulcanAlertsController(ILogger<StartTelegramBotController> logger,
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
            var orchestrator = new VulcanTelegramBotOrchestrator(_commandProcessor, _queryProcessor);
            
            orchestrator.StartVulcanTelegramBot();
            await orchestrator.SendVulcanAlerts();

            //await orchestrator.trySave();
            //var bot = new VulcanVerseBot("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY", _commandProcessor);

            return true;
        }
    }
}
