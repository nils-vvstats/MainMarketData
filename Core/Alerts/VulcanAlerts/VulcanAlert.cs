using Core.Auctions.VulcanAuctions;
using Core.Users.VulcanUsers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Alerts.VulcanAlerts
{
    public class VulcanAlert : Alert
    {
        public VulcanAlert() { }
        public VulcanAlert(long userId, long chatId, string stringExpression)
        {
            AlertId = Guid.NewGuid();
            UserId = userId;
            ChatId = chatId;
            Enabled = true;
            StringExpression = stringExpression;
        }

        public Expression<Func<VulcanAuction, bool>> getExpression()
        {
            Expression<Func<VulcanAuction, bool>> translatedFilter = a => true;

            if (StringExpression == null || StringExpression.Length == 0)
            {
                return null;
            }

            var criterias = StringExpression.Split(",");

            foreach (var criteria in criterias)
            {
                
                if (criteria.Contains("<"))
                {
                    var parts = criteria.Split("<");

                    if (parts.Length == 2)
                    {
                        int value;

                        if (int.TryParse(parts[1], out value))
                        {
                            translatedFilter = translatedFilter.And(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<decimal>() < value);
                        }

                    }
                }
                else if (criteria.Contains(">"))
                {
                    var parts = criteria.Split(">");

                    if (parts.Length == 2)
                    {
                        int value;

                        if (int.TryParse(parts[1], out value))
                        {
                            translatedFilter = translatedFilter.And(Va => JValue.Parse(Va.AuctionDetails)[parts[0]].ToObject<decimal>() > value);
                        }

                    }
                }
                else if (criteria.Contains("="))
                {
                    var parts = criteria.Split("=");

                    if (parts.Length == 2)
                    {
                        translatedFilter = translatedFilter.And(Va => 

                             JObject.Parse(Va.AuctionDetails)[parts[0]].Value<string>().Equals(parts[1])


                            );
                    }
                }
            }

            return translatedFilter;
        }

        public List<VulcanAuction> GetMatchedAuctions(List<VulcanAuction> auctions, Alert alert)
        {
            var criterias = alert.StringExpression.Split(",");

            List<VulcanAuction> matchedAuctions = auctions;

            foreach (var criteria in criterias)
            {

                if (criteria.Contains("<"))
                {
                    var parts = criteria.Split("<");

                    if (parts.Length == 2)
                    {
                        decimal value;

                        if (decimal.TryParse(parts[1], out value))
                        {
                            matchedAuctions = matchedAuctions.Where(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<decimal>() < value).ToList();
                        }

                    }
                }
                else if (criteria.Contains(">"))
                {
                    var parts = criteria.Split(">");

                    if (parts.Length == 2)
                    {
                        decimal value;

                        if (decimal.TryParse(parts[1], out value))
                        {
                            matchedAuctions = matchedAuctions.Where(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<decimal>() > value).ToList();
                        }

                    }
                }
                else if (criteria.Contains("="))
                {
                    var parts = criteria.Split("=");

                    if (parts.Length == 2)
                    {
                        matchedAuctions = matchedAuctions.Where(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<string>().Equals(parts[1])).ToList();
                    }
                }
            }

            return matchedAuctions;
        }
    
    
        public override string GetMessage()
        {
            var message = "An alert with the following Criteria has been added: \n\n";

            foreach (var criteria in StringExpression.Split(","))
            {
                message += criteria + "\n";
            }

            return message;
        }
    }
}
