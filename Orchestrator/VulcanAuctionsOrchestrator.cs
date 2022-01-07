using Application.Commands;
using Application.Queries;
using Application.Queries.Alerts.VulcanAlerts;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrator
{
    public class VulcanAuctionsOrchestrator : Orchestrator
    {
        public VulcanAuctionsOrchestrator(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }






    }
}
