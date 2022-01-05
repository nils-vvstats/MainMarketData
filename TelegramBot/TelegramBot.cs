using Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot
{
    public class TelegramBot
    {
        public TelegramBotClient Bot { get; protected internal set; }
        public ICommandProcessor _commandProcessor { get; protected internal set; }
        public TelegramBot(string token, ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
            Bot = new TelegramBotClient(token);
        }

        public void StartTelegramBot(EventHandler<Telegram.Bot.Args.MessageEventArgs> Bot_OnMessage, IEnumerable<Telegram.Bot.Types.BotCommand> commands)
        {
            Bot.SetMyCommandsAsync(commands);
            Bot.StartReceiving();
            Bot.OnMessage += Bot_OnMessage;

            Console.ReadLine();
        }

        public void SendMessage(long chatId, string message)
        {
            Bot.SendTextMessageAsync(chatId, message);
        }

    }
}
