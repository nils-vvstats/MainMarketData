using Application.Queries;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.ServiceConfigurations
{
    public class QueryProcessor : IQueryProcessor
    {
        private readonly IComponentContext _componentContext;

        public QueryProcessor(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public async Task<TResult> Process<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));
            //try
            //{
            //    dynamic handler2 = _componentContext.Resolve(handlerType);
            //    return await handler2.Handle((dynamic)query);
            //}
            //catch (Exception ex)
            //{
            //    var test = ex;
            //}
            dynamic handler = _componentContext.Resolve(handlerType);
            return await handler.Handle((dynamic)query);
        }
    }
}
