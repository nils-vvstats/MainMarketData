using Application.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orchestrator;
using TelegramBot.VulcanVerse;


namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StartTelegramBotController : ControllerBase
    {

        private readonly ILogger<StartTelegramBotController> _logger;
        private readonly ICommandProcessor _commandProcessor;

        public StartTelegramBotController(ILogger<StartTelegramBotController> logger,
            ICommandProcessor commandProcessor)
        {
            _logger = logger;
            _commandProcessor = commandProcessor;
        }


        [HttpGet]
        public bool Get()
        {
            var orchestrator = new TelegramBotOrchestrator(_commandProcessor);
            orchestrator.StartVulcanTelegramBot();
            //var bot = new VulcanVerseBot("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY", _commandProcessor);

            return true;
        }
    }
}
