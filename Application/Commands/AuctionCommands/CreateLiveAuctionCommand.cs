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
        public LiveAuction LiveAuction { get; set; }

        public CreateLiveAuctionCommand(LiveAuction liveAuction)
        {
            LiveAuction = liveAuction;
        }
    }

    public class CreateLiveAuctionCommandHandler : ICommandHandler<CreateLiveAuctionCommand>
    {
        private readonly IRepository<LiveAuction> _repository;

        public CreateLiveAuctionCommandHandler(IRepository<LiveAuction> repository)
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
