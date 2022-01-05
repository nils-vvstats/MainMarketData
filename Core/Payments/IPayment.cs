using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Payments
{
    public interface IPayment
    {
        public Guid ID { get; set; }
        public string TransactionId { get; set; }
        public DateTime Timestamp { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }

        public Guid UserId { get; set; }
    }
}
