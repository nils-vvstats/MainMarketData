using Application.Interfaces;
using Core.Auctions;
using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class DeleteLiveAuctionCommand : ICommand
    {
        public List<YoHeroLiveAuction> YoHeroLiveAuctions { get; }

        public DeleteLiveAuctionCommand(List<YoHeroLiveAuction> yoHeroLiveAuctions)
        {
            YoHeroLiveAuctions = yoHeroLiveAuctions;
        }
    }

    public class DeleteLiveAuctionCommandHandler : ICommandHandler<DeleteLiveAuctionCommand>
    {
        private readonly IRepository<YoHeroLiveAuction> _repository;

        public DeleteLiveAuctionCommandHandler(IRepository<YoHeroLiveAuction> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteLiveAuctionCommand command)
        {
            try
            {
                if (command == null)
                {
                    throw new ArgumentNullException(nameof(command), "Command not provided to CreateLiveAuctionCommandHandler");
                }
                _repository.RemoveRange(command.YoHeroLiveAuctions);
                await _repository.Save();
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
