using Application.Commands;
using Application.Queries;
using System;

namespace Orchestrator
{
    public abstract class Orchestrator
    {
        public ICommandProcessor _commandProcessor { get; protected internal set; }
        public IQueryProcessor _queryProcessor { get; protected internal set; }
    }
}
