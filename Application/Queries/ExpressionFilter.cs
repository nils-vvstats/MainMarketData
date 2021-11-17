using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class ExpressionFilter<T> : IFilter
    {
        public Expression<Func<T, bool>> QueryFilterExpression { get; set; }

        public ExpressionFilter(Expression<Func<T, bool>> queryFilterExpression)
        {
            QueryFilterExpression = queryFilterExpression;
        }
    }
}
