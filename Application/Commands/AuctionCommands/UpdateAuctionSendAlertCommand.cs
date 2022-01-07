using Application.Interfaces;
using Core.Auctions.VulcanAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.AuctionCommands
{

    public class UpdateAuctionSendAlertCommand : ICommand
    {
        public List<VulcanAuction> Auctions { get; set; }

        public UpdateAuctionSendAlertCommand(List<VulcanAuction> auctions)
        {
            Auctions = auctions;
        }
    }

    public class UpdateAuctionSendAlertCommandHandler : ICommandHandler<UpdateAuctionSendAlertCommand>
    {
        private readonly IRepository<VulcanAuction> _repository;

        public UpdateAuctionSendAlertCommandHandler(IRepository<VulcanAuction> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuctionSendAlertCommand command)
        {
            try
            {
                if (command == null)
                {
                    throw new ArgumentNullException(nameof(command), "Command not provided to CreateLiveAuctionCommandHandler");
                }
                _repository.UpdateRange(command.Auctions);
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
