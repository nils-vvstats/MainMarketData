using Application.Interfaces;
using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.YoHero.DisableOldAuctions
{
    public class DisableOldAuctionsCommand : ICommand
    {
        public List<YoHeroLiveAuction> YoHeroLiveAuctions { get; }
        public DisableOldAuctionsCommand(List<YoHeroLiveAuction> yoHeroLiveAuctions)
        {
            YoHeroLiveAuctions = yoHeroLiveAuctions;
        }
    }

    public class DisableOldAuctionsCommandHandler : ICommandHandler<DisableOldAuctionsCommand>
    {
        private readonly IRepository<YoHeroLiveAuction> _repository;

        public DisableOldAuctionsCommandHandler(IRepository<YoHeroLiveAuction> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DisableOldAuctionsCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            if (command.YoHeroLiveAuctions == null)
            {
                throw new ArgumentException("YoHeroLiveAuctions not provided to SaveLiveAuctionsCommandHandler");
            }

            var updatedAuctions = command.YoHeroLiveAuctions.Select(la => { la.Enabled = false; return la; }).ToList();

            try
            {
                _repository.UpdateRange(updatedAuctions);
                await _repository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Repository was unable to save: " + ex.Message);
            }
        }
    }
}
