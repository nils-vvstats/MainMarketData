using Application.Commands;
using Application.Commands.Alerts;
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

        public async Task<Message> InterpretMessage(Telegram.Bot.Args.MessageEventArgs e, List<Telegram.Bot.Types.BotCommand> commands)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.EntityValues.Count() == 1 && e.Message.EntityValues.ElementAt(0).Contains(commands[0].Command) && e.Message.Text.Length > 1)
                {
                    var alertCriteria = e.Message.Text.Remove(0, commands[0].Command.Length + 2);
                    var alert = new Alert(alertCriteria, e.Message.Chat.Id, e.Message.From.Id);

                    var addAlert = new AddAlertCommand(alert.GetCoreAlert());
                    await _commandProcessor.Process(addAlert).ConfigureAwait(false);

                    return alert;
                }
            }

            return null;
        }
    }
}
