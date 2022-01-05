using Core.Users.VulcanUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Payments.VulcanPayment
{

    public class VulcanPayment : IPayment
    {
        public VulcanPayment()
        {
            ID = Guid.NewGuid();
        }

        public VulcanPayment(string transactionId, DateTime timestamp, string from, string to, double amount, VulcanUser user)
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

        public virtual VulcanUser User { get; set; }
        public Guid UserId { get; set; }
    }
}
