using Application.Interfaces;
using Autofac;
using DataAccess;
using DataAccess.MarketData.Repository;
using DataAccess.MarketData.VulcanMarketData.Repositories;
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
            //ar dataAccessAssembly = typeof(MarketDataDbContext).Assembly;
            var vulcanDataAccessAssembly = typeof(VulcanMarketDataDbContext).Assembly;

            builder.RegisterAssemblyTypes(vulcanDataAccessAssembly)
                .AsClosedTypesOf(typeof(IReadOnlyRepository<>));

            builder.RegisterAssemblyTypes(vulcanDataAccessAssembly)
                .AsClosedTypesOf(typeof(IRepository<>));

            builder.RegisterGeneric(typeof(VulcanMarketDataRepository<>))
                .AsSelf()
                .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(vulcanDataAccessAssembly)
            //    .AsClosedTypesOf(typeof(IReadOnlyRepository<>));

            //builder.RegisterAssemblyTypes(vulcanDataAccessAssembly)
            //    .AsClosedTypesOf(typeof(IRepository<>));

            //builder.RegisterGeneric(typeof(VulcanMarketDataRepository<>))
            //    .AsSelf()
            //    .AsImplementedInterfaces();
        }
    }
}
