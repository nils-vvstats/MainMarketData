using Application.Interfaces;
using Core.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Alerts
{
    public class AddAlertCommand : ICommand
    {
        public Alert Alert { get; set; }

        public AddAlertCommand(Alert alert)
        {
            Alert = alert;
        }
    }

    public class AddAlertCommandHandler : ICommandHandler<AddAlertCommand>
    {
        private readonly IRepository<Alert> _repository;

        public AddAlertCommandHandler(IRepository<Alert> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddAlertCommand command)
        {
            try
            {
                if (command == null)
                {
                    throw new ArgumentNullException(nameof(command), "Command not provided to AddVulcanAlertCommandHandler");
                }
                _repository.Add(command.Alert);
                await _repository.Save();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
