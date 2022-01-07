using Application.Commands;
using Application.Commands.Alerts;
using Application.Commands.AuctionCommands;
using Application.Queries;
using Application.Queries.Alerts.VulcanAlerts;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.VulcanVerse;

namespace Orchestrator
{
    public class VulcanTelegramBotOrchestrator : Orchestrator
    {
        public static VulcanVerseBot VulcanVerseBot { get; set; }
        public VulcanTelegramBotOrchestrator(ICommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }

        public bool StartVulcanTelegramBot()
        {
            try
            {
                VulcanVerseBot = new VulcanVerseBot("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY", _commandProcessor);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public bool StartReceivingMessage()
        {
            VulcanVerseBot.StartReceivingMessage();

            return true;
        }

        public async Task<bool> SendVulcanAlerts()
        {
            var activeAlerts = await getActiveAlerts();
            var activeAuctions = await getActiveAuctions();

            //send alerts
            foreach (var alert in activeAlerts)
            {
                var matchedAuctions = alert.GetMatchedAuctions(activeAuctions, alert);
                SendVulcanAuctionAlerts(matchedAuctions, alert);
            }

            //set send alert to false as alerts have already been sent for new auctions
            foreach (var auction in activeAuctions)
            {
                auction.SendAlert = false;
            }

            var updateAuctions = new UpdateAuctionSendAlertCommand(activeAuctions);
            await _commandProcessor.Process(updateAuctions);

            return true;
        }

        public bool SendVulcanAuctionAlerts(List<VulcanAuction> auctions, Alert alert)
        {
            foreach (var auction in auctions)
            {
                VulcanVerseBot.SendAlert(alert, auction.GetMessage());
            }

            return true;
        }

        public async Task<List<VulcanAlert>> getActiveAlerts()
        {
            var getAlertsQuery = new GetActiveVulcanAlertsQuery(true);

            return await _queryProcessor.Process(getAlertsQuery).ConfigureAwait(false);
        }

        public async Task<List<VulcanAuction>> getActiveAuctions()
        {
            var getAuctionsQuery = new GetVulcanAuctionsQuery(true);

            return await _queryProcessor.Process(getAuctionsQuery).ConfigureAwait(false);
        }
    }
}
