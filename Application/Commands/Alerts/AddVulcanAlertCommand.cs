using Application.Interfaces;
using Core.Alerts;
using Core.Alerts.VulcanAlerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Alerts
{
    public class AddVulcanAlertCommand : ICommand
    {
        public VulcanAlert Alert { get; }

        public AddVulcanAlertCommand(VulcanAlert alert)
        {
            Alert = alert;
        }
    }

    public class AddVulcanAlertCommandHandler : ICommandHandler<AddVulcanAlertCommand>
    {
        private readonly IRepository<Alert> _repository;

        public AddVulcanAlertCommandHandler(IRepository<Alert> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddVulcanAlertCommand command)
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
