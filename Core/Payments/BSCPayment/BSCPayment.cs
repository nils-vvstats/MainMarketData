
using Core.Users;
using System;


namespace Core.Payments.BSCPayment
{
    public class BSCPayment :IPayment
    {
        public BSCPayment()
        {
            ID = Guid.NewGuid();
        }

        public BSCPayment(string transactionId, DateTime timestamp, string from, string to, double amount, YoHeroUser user)
        {
            ID = Guid.NewGuid();
            TransactionId = transactionId;
            Timestamp = timestamp;
            From = from;
            To = to;
            Amount = amount;
            User = user;
            UserId = user.ID;
        }

        public Guid ID { get; set; }
        public string TransactionId { get; set; }
        public DateTime Timestamp { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
        
        public virtual YoHeroUser User { get; set; }
        public Guid UserId { get; set; }
    }
}
