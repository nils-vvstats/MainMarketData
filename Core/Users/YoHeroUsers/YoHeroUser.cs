using Core.Alerts;

using Core.Payments.BSCPayment;
using System;
using System.Collections.Generic;

namespace Core.Users
{
    public class YoHeroUser : IUser
    {
        public YoHeroUser(int chatId)
        {
            ID = Guid.NewGuid();
            ChatId = chatId;
        }
        public Guid ID { get; set; }
        public int ChatId { get; set; }
        //public virtual List<YoHeroAlert> Alerts { get; set; }
        public virtual List<BSCPayment> Payments { get; set; }
    }
}
