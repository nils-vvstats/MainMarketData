using Application.Interfaces;
using Core.Auctions.YoHeroLiveAuctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.YoHero.SaveAuctions
{
    public class SaveLiveAuctionsCommand :ICommand
    {
        public List<YoHeroLiveAuction> YoHeroLiveAuctions { get; }
        public SaveLiveAuctionsCommand(List<YoHeroLiveAuction> yoHeroLiveAuctions)
        {
            YoHeroLiveAuctions = yoHeroLiveAuctions;
        }
    }

    public class SaveLiveAuctionsCommandHandler: ICommandHandler<SaveLiveAuctionsCommand>
    {
        private readonly IRepository<YoHeroLiveAuction> _repository;

        public SaveLiveAuctionsCommandHandler(IRepository<YoHeroLiveAuction> repository)
        {
            _repository = repository;
        }

        public async Task Handle(SaveLiveAuctionsCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            if (command.YoHeroLiveAuctions == null)
            {
                throw new ArgumentException("YoHeroLiveAuctions not provided to SaveLiveAuctionsCommandHandler");
            }


            try
            {
                _repository.AddRange(command.YoHeroLiveAuctions);
                await _repository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Repository was unable to save: " + ex.Message);
            }
        }
    }
}
