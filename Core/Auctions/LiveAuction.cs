using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auctions
{
    public class LiveAuction
    {
        public LiveAuction(int auctionID)
        {
            AuctionId = auctionID;
        }
        public int AuctionId { get; protected internal set; }
    }
}
