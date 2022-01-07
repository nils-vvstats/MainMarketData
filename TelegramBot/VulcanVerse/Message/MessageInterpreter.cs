using Application.Commands;
using Application.Commands.Alerts;
using Core.Alerts.VulcanAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.VulcanVerse.Message
{
    public class MessageInterpreter
    {
        private readonly ICommandProcessor _commandProcessor;

        public MessageInterpreter(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }

        public async Task<VulcanAlert> InterpretMessage(Telegram.Bot.Args.MessageEventArgs e, List<Telegram.Bot.Types.BotCommand> commands)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && e != null && e.Message != null && e.Message.EntityValues != null)
            {
                if (e.Message.EntityValues.Count() == 1 && e.Message.EntityValues.ElementAt(0).Contains(commands[0].Command) && e.Message.Text.Length > 1)
                {
                    var alertCriteria = e.Message.Text.Remove(0, commands[0].Command.Length + 2);
                    var alert = new VulcanAlert(e.Message.Chat.Id, e.Message.From.Id, alertCriteria);

                    var addAlert = new AddVulcanAlertCommand(alert);
                    try
                    {
                        await _commandProcessor.Process(addAlert);
                    } catch (Exception ex)
                    {
                        ex = new Exception();
                    }
                    

                    return alert;
                }
            }

            return new VulcanAlert();
        }
    }
}
