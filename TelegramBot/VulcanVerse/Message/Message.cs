using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.VulcanVerse.Message
{
    public abstract class Message
    {
        
        public Message(long chatId, long userId)
        {
            ChatId = chatId;
            UserId = userId;
        }

        public long ChatId { get; }

        public long UserId { get; }


        public abstract string GetMessage();
    }
}
