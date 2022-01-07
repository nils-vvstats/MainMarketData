using Application.Commands;
using Application.Commands.Alerts;
using Application.Queries;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator
{
    public class AlertOrchestrator : Orchestrator
    {

        public AlertOrchestrator(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }

        public async Task<bool> AddNewAlert(VulcanAlert alert)
        {
            var alertCommand = new AddVulcanAlertCommand(alert);
            await _commandProcessor.Process(alertCommand).ConfigureAwait(false);
            return true;
        }


    }
}
