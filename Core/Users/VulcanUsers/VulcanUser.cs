using Core.Alerts.VulcanAlerts;
using Core.Payments.VulcanPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Users.VulcanUsers
{
    public class VulcanUser : IUser
    {
        public VulcanUser(int chatId)
        {
            ID = Guid.NewGuid();
            ChatId = chatId;
        }
        public Guid ID { get; set; }
        public int ChatId { get; set; }
        public virtual List<VulcanAlert> Alerts { get; set; }
        public virtual List<VulcanPayment> Payments { get; set; }
    }
}
