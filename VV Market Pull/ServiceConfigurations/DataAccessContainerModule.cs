using Application.Interfaces;
using Autofac;
using DataAccess;
using DataAccess.MarketData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.ServiceConfigurations
{
    public class DataAccessContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var dataAccessAssembly = typeof(MarketDataDbContext).Assembly;

            builder.RegisterAssemblyTypes(dataAccessAssembly)
                .AsClosedTypesOf(typeof(IReadOnlyRepository<>));

            builder.RegisterAssemblyTypes(dataAccessAssembly)
                .AsClosedTypesOf(typeof(IRepository<>));

            builder.RegisterGeneric(typeof(MarketDataRepository<>))
                .AsSelf()
                .AsImplementedInterfaces();
        }
    }
}
