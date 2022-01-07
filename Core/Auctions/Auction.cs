using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auctions.VulcanAuctions
{
    public abstract class Auction
    {
        public int AuctionId { get; protected internal set; }
        public string AuctionDetails { get; protected internal set; }
        public bool Enabled { get; protected internal set; }
        public DateTime LastUpdated { get; protected internal set; }
        public bool SendAlert { get; set; }
        public abstract string GetMessage();
    }
}
