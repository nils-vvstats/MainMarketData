using Core.Auctions.YoHeroLiveAuctions;
using Core.NFTs.YoHeroNFTs;
using DataAccess.MarketData.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoHeroMarketData.Translators
{
    public static class YoHeroLiveAuctionTranslator
    {
        public static async Task<List<YoHeroLiveAuction>> ToYoHeroLiveAuctions(JObject data)
        {

            var liveAuctions = getTranslatedLiveAuction(data);

            return liveAuctions;
        }

        private static List<YoHeroLiveAuction> getTranslatedLiveAuction(JObject data)
        {

            var listOfLiveAuctions = data["list"].ToList();

            var liveAuctions = new List<YoHeroLiveAuction>();

            for (int i = 0; i < listOfLiveAuctions.Count; i++)
            {
                var hero = getHero(listOfLiveAuctions[i].ToObject<JObject>());
                var price = listOfLiveAuctions[i].ToObject<JObject>()["price"].ToObject<double>();
                var decimalPrice = price / Math.Pow(10, 18);
                var liveAuction = new YoHeroLiveAuction(hero, decimalPrice);

                liveAuctions.Add(liveAuction);
            }

            return liveAuctions;
        }

        private static Hero getHero(JObject hero)
        {
            var heroProperties = getHeroProperties(hero);
            var id = hero["id"].ToObject<int>(); //itemId

            var convertedHero = new Hero(id, heroProperties);

            return convertedHero;
        }

        private static HeroProperties getHeroProperties(JObject hero)
        {
            var partsToken = hero.GetValue("parts");
            var listOfParts = partsToken.Values<int>().ToList();

            if (listOfParts.Count == 6)
            {
                var heroComposition = getHeroComposition(listOfParts);
                var race = (Race)listOfParts[0];


                //TODO Calculate health, dmg attributes based off of races
                var heroAttributes = getHeroAttributes();


                var numOfSummons = hero.GetValue("callNum").Value<int>();
                var genesisHero = hero.GetValue("genesis").Value<bool>();

                var heroProperties = new HeroProperties(race, numOfSummons, heroAttributes, heroComposition, genesisHero);

                return heroProperties;
            }
            else
            {
                return null;
            }

        }

        private static HeroAttributes getHeroAttributes()
        {
            var heroAttributes = new HeroAttributes(1,1,1,1,1);
            return heroAttributes;
        }
        private static HeroComposition getHeroComposition(List<int> parts)
        {
            
            var Head = (Race)parts[0];
            var Face = (Race)parts[1];
            var Body = (Race)parts[2];
            var Eyes = (Race)parts[3];
            var Ears = (Race)parts[4];
            var Legs = (Race)parts[5];

            var heroComposition = new HeroComposition(Head, Face, Body, Eyes, Ears, Legs);

            return heroComposition;
        }
      

        
    }
}
