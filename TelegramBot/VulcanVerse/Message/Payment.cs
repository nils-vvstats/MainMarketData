using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.VulcanVerse.Message
{
    public class Payment : Message
    {
        private string PaymentCriteria { get; set; }
        public Payment(string paymentCriteria, long chatId, long userId) : base(chatId, userId)
        {
            PaymentCriteria = paymentCriteria;
        }

        public override string GetMessage()
        {
            var message = "An alert with the following Criteria has been added: \n\n" + PaymentCriteria;
            return message;
        }
    }
}
