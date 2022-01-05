using Application.Queries;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using Core.Auctions.VulcanAuctions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.VulcanVerse.Message
{
    public class Alert : Message
    {
        public Expression<Func<Auction, bool>> AlertExpression { get; protected internal set; }
        public string AlertCriteria { get; protected internal set; }
        public Alert(string alertCriteria, long chatId, long userId) : base(chatId, userId)
        {
            AlertCriteria = alertCriteria;
        }



        public Core.Alerts.Alert GetCoreAlert()
        {
            return new VulcanAlert(UserId, ChatId, AlertCriteria);
        }

        public override string GetMessage()
        {
            var message = "An alert with the following Criteria has been added: \n\n";

            foreach(var criteria in AlertCriteria.Split(","))
            {
                message += criteria + "\n";
            }

            return message;
        }
    }
}
