using Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using TelegramBot.VulcanVerse.Message;

namespace TelegramBot.VulcanVerse
{
    public class VulcanVerseBot : TelegramBot
    {
        public VulcanVerseBot(string token, ICommandProcessor commandProcessor) : base(token, commandProcessor)
        {
            AddAlert.Command = "addalert";
            AddAlert.Description = "Add criteria so that you get notified whenever an auction is listed with the matching criteria";

            AddPayment.Command = "addpayment";
            AddPayment.Description = "Add a transaction ID for your payment";

            comm.Add(AddAlert);
            comm.Add(AddPayment);

            
            StartTelegramBot(Bot_OnMessage, comm);
        }

        private async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var messageInterpreter = new MessageInterpreter(_commandProcessor);
            var message = await messageInterpreter.InterpretMessage(e, comm);

            if (message != null)
            {
                SendMessage(message.ChatId, message.GetMessage());
            }
            else
            {
                SendMessage(e.Message.Chat.Id, "There was an error processing your request. Please try again.");
            }
            
        }

        private List<Telegram.Bot.Types.BotCommand> comm = new List<Telegram.Bot.Types.BotCommand>() {};
        private Telegram.Bot.Types.BotCommand AddAlert = new Telegram.Bot.Types.BotCommand();
        private Telegram.Bot.Types.BotCommand AddPayment = new Telegram.Bot.Types.BotCommand();
    }
}
