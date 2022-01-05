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

        private Expression<Func<VulcanAuction, bool>> getListOfCriteria(string newCriterias)
        {
            Expression<Func<VulcanAuction, bool>> translatedFilter = a => true;

            if (newCriterias == null || newCriterias.Length == 0)
            {
                return null;
            }

            var criterias = newCriterias.Split(",");

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
                            translatedFilter = translatedFilter.And(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<Int32>() < value);
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
                            translatedFilter = translatedFilter.And(Va => JObject.Parse(Va.AuctionDetails)[parts[0]].ToObject<Int32>() > value);
                        }

                    }
                }
                else if (criteria.Contains("="))
                {
                    var parts = criteria.Split("=");

                    if (parts.Length == 2)
                    {
                        translatedFilter = translatedFilter.And(Va => JObject.Parse(Va.AuctionDetails)[parts[0]] == (JObject)parts[1]);
                    }
                }
            }

            return translatedFilter;
        }
    }
}
