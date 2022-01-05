using Application.Commands;
using System;

namespace Orchestrator
{
    public class Orchestrator
    {
        public ICommandProcessor _commandProcessor { get; protected internal set; }
        public Orchestrator(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }
    }
}
