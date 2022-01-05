using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBot.YoHero
{
    public class YoHeroBot
    {
        public static TelegramBotClient Bot = new TelegramBotClient("2086056061:AAFcl1Fh7WfF3Cv_z3zA25AQVS-CFDxy_GY");

        public void sendMessage(string chatId,string message)
        {
            Bot.SendTextMessageAsync(chatId, message);
        }
    }
}
