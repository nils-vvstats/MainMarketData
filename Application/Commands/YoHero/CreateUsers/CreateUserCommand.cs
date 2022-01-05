using Application.Interfaces;
using Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.AuctionCommands
{

public class CreateUserCommand : ICommand
{
    public List<YoHeroUser> Users { get; }
    public CreateUserCommand(List<YoHeroUser> users)
    {
            Users = users;
    }
}

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly IRepository<YoHeroUser> _repository;

    public CreateUserCommandHandler(IRepository<YoHeroUser> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateUserCommand command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        if (command.Users == null)
        {
            throw new ArgumentException("YoHeroLiveAuctions not provided to SaveLiveAuctionsCommandHandler");
        }


        try
        {
            _repository.AddRange(command.Users);
            await _repository.Save();
        }
        catch (Exception ex)
        {
            throw new Exception("Repository was unable to save: " + ex.Message);
        }
    }
}
}