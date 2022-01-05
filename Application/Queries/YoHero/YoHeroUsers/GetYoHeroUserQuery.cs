using Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.YoHero.YoHeroUsers
{
    public class GetYoHeroUserQuery : IQuery<YoHeroUser>
    {
        public GetYoHeroUserQuery(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; }
    }
}
