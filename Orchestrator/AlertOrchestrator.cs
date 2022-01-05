using Application.Commands;
using Application.Commands.Alerts;
using Core.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator
{
    public class AlertOrchestrator : Orchestrator
    {

        public AlertOrchestrator(ICommandProcessor commandProcessor) : base(commandProcessor)
        {

        }

        public async Task<bool> AddNewAlert(Alert alert)
        {
            var alertCommand = new AddAlertCommand(alert);
            await _commandProcessor.Process(alertCommand).ConfigureAwait(false);
            return true;
        }


    }
}
