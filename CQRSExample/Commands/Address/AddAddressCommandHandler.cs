namespace CQRSExample.Commands.Address
{
    public class AddAddressCommandHandler : CommandHandler<AddAddressCommand, AddAddressCommandResult>, CommandHandler<AddAddressCommand>
    {
        public AddAddressCommandResult Execute(AddAddressCommand command)
        {
            return new AddAddressCommandResult(Guid.NewGuid());
        }

        void CommandHandler<AddAddressCommand>.Execute(AddAddressCommand command)
        {
            Execute(command);
        }
    }
}
