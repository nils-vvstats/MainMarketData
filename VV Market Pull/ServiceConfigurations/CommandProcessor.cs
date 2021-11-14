using Application.Commands;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.ServiceConfigurations
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly IComponentContext _componentContext;

        public CommandProcessor(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public async Task Process(ICommand command)
        {
            var handlerType = typeof(ICommandHandler<>)
                .MakeGenericType(command.GetType());
            dynamic handler = _componentContext.Resolve(handlerType);
            await handler.Handle((dynamic)command);
        }
    }
}
