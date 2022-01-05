using Core.Auctions.VulcanAuctions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulcanMarketDataPull.Models
{
    public static class LiveAuctionsTranslator
    {
        //    public static List<VulcanAuction> ConvertToVulcanAuctions(List<JToken> auctions)
        //    {
        //        List<VulcanAuction> convertedVulcanAuctions = new List<VulcanAuction>();
        //        foreach (JObject auction in auctions)
        //        {
        //            convertedVulcanAuctions.Add(ToVulcanAuction(auction));
        //        }
        //        return convertedVulcanAuctions;
        //    }

        //    private static VulcanAuction ToVulcanAuction(JObject auction)
        //    {
        //        var auctionId = auction["auctionID"].ToObject<int>();
        //        var auctionOwner = auction["userID"].ToObject<int>();
        //        var auctionOwnerName = auction["userName"].ToObject<string>();
        //        var createdDate = auction["createdDate"].ToObject<DateTime>();
        //        //var lastUpdatedDate = auction["updatedDate"].ToObject<DateTime>();
        //        var purchasedBy = auction["purchasedBy"].ToObject<int>();
        //        var purchasedPrice = auction["purchasedPrice"].ToObject<double>();
        //        var closedDate = auction["closedDate"].ToObject<DateTime>();
        //        var buyNowPrice = auction["buyNowPrice"].ToObject<double>();
        //        var maxBidPrice = auction["maxBidPrice"].ToObject<double>();
        //        var minimumBidRaise = auction["minimumBidRise"].ToObject<double>();


        //        var nft = auction["completeObjects"].ToString().Replace("\\", "").Split("|||");

        //        var vulcanNFTs = GetVulcanNFTs(nft);

        //        return new VulcanAuction(auctionId, auctionOwner, auctionOwnerName, vulcanNFTs, buyNowPrice, maxBidPrice, minimumBidRaise, createdDate, closedDate, purchasedPrice, purchasedBy);
        //    }

        //    private static List<VulcanNFT> GetVulcanNFTs(String[] nfts)
        //    {
        //        var VulcanNFTs = new List<VulcanNFT>();

        //        foreach(var nft in nfts)
        //        {
        //            VulcanNFTs.Add(getVulcanNFT(JObject.Parse(nft)));
        //        }

        //        return VulcanNFTs;
        //    }

        //    private static VulcanNFT getVulcanNFT(JObject nft)
        //    {
        //        string title = String.Empty;
        //        string author = String.Empty;
        //        int dAppId = 0;
        //        string image = String.Empty;
        //        string owner = String.Empty;

        //        if (nft["Title"] != null)
        //        {
        //            title = nft["Title"].ToObject<string>();
        //        }

        //        if (nft["author"] != null)
        //        {
        //            author = nft["author"].ToObject<string>();
        //        }

        //        if (nft["dappid"] != null)
        //        {
        //            dAppId = nft["dappid"].ToObject<int>();
        //        }

        //        if (nft["image"] != null)
        //        {
        //            image = nft["image"].ToObject<string>();
        //        }

        //        if (nft["owner"] != null)
        //        {
        //            owner = nft["owner"].ToObject<string>();
        //        }

        //        return new VulcanNFT(title, author, dAppId, image, owner);
        //    }
    }
}
