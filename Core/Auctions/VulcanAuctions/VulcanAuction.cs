using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auctions.VulcanAuctions
{
    public class VulcanAuction : Auction
    {
        public VulcanAuction() { }

        public VulcanAuction(int auctionId, string auctionDetails)
        {
            AuctionId = auctionId;
            AuctionDetails = AuctionDetails;
            LastUpdated = DateTime.UtcNow;
            Enabled = true;
        }

        //public VulcanAuction(int vulcanAuctionId, int ownerId, string ownerUsername, List<VulcanNFT> vulcanNFTs,
        //                     double buyNowPrice, double maxBidPrice, double minimumBidRaise, DateTime createdDate, DateTime closedDate, double purchasedPrice, int purchasedBy)
        //{
        //    VulcanAuctionId = vulcanAuctionId;
        //    OwnerId = ownerId;
        //    OwnerUsername = ownerUsername;
        //    VulcanNFTs = vulcanNFTs;
        //    BuyNowPrice = buyNowPrice;
        //    MaxBidPrice = maxBidPrice;
        //    MinimumBidRaise = minimumBidRaise;
        //    CreatedDate = createdDate;
        //    ClosedDate = closedDate;
        //    PurchasedPrice = purchasedPrice;
        //    PurchasedBy = purchasedBy;
        //}

        //public int VulcanAuctionId { get; }
        //public int OwnerId { get; }
        //public string OwnerUsername { get; }
        //public List<VulcanNFT> VulcanNFTs { get; }
        //public double BuyNowPrice { get; }
        //public double MaxBidPrice { get; }
        //public double MinimumBidRaise { get; }
        //public DateTime CreatedDate { get; }
        //public DateTime ClosedDate { get; }
        //public double PurchasedPrice { get; }
        //public int PurchasedBy { get; }
    }
}
