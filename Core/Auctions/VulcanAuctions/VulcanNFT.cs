using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auctions.VulcanAuctions
{
    public class VulcanNFT
    {
        public VulcanNFT() { }
        public VulcanNFT(string title, string author, int dAppId, string image, string owner)
        {
            Title = title;
            Author = author;
            DAppId = dAppId;
            Image = image;
            Owner = owner;
        }

        public string Title { get; }
        public string Author { get; }
        public int DAppId { get; }
        public string Image { get; }
        public string Owner { get; }
    }
}
