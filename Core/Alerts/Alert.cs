using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Alerts
{
    public abstract class Alert
    {
        public Guid AlertId { get; protected internal set; }
        public long UserId { get; protected internal set; }
        public long ChatId { get; protected internal set; }
        public bool Enabled { get; protected internal set; }
        public string StringExpression { get; protected internal set; }
        public abstract string GetMessage();
    }
}
