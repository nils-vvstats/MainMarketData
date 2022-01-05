using System;
using Telegram.Bot;
using TelegramBot;

namespace TelegramBot
{
    class Program
    {
        public static TelegramBotClient Bot = new TelegramBotClient("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY");
        static void Main(string[] args)
        {
            Bot.StartReceiving();

            Bot.OnMessage += Bot_OnMessage;

            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "Hello " + e.Message.Chat.Id);
            }
        }
    }
}
