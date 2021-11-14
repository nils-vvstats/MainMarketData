using Application.Interfaces;
using Core.Auctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateLiveAuctionCommand : ICommand
    {
        public ILiveAuction LiveAuction { get; set; }

        public CreateLiveAuctionCommand(ILiveAuction liveAuction)
        {
            LiveAuction = liveAuction;
        }
    }

    public class CreateLiveAuctionCommandHandler : ICommandHandler<CreateLiveAuctionCommand>
    {
        private readonly IRepository<ILiveAuction> _repository;

        public CreateLiveAuctionCommandHandler(IRepository<ILiveAuction> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLiveAuctionCommand command)
        {
            try
            {
                if (command == null)
                {
                    throw new ArgumentNullException(nameof(command), "Command not provided to CreateLiveAuctionCommandHandler");
                }
                _repository.Add(command.LiveAuction);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
