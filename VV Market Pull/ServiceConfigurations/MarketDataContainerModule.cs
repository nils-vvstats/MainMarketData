using Application.Commands;
using Application.Queries;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.ServiceConfigurations
{
    public class MarketDataContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ICommandHandler<>).Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>));
            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>));
            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQuery<>));

            builder.RegisterType<QueryProcessor>().As<IQueryProcessor>();
            builder.RegisterType<CommandProcessor>().As<ICommandProcessor>();
        }
    }
}
