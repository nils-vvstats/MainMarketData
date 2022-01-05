using Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.VulcanVerse;

namespace Orchestrator
{
    public class TelegramBotOrchestrator
    {
        private readonly ICommandProcessor _commandProcessor;
        public TelegramBotOrchestrator(ICommandProcessor commandProcessor) 
        {
            _commandProcessor = commandProcessor;
        }

        public bool StartVulcanTelegramBot()
        {
            var vulcanBot = new VulcanVerseBot("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY", _commandProcessor);
            return false;
        }
    }
}
