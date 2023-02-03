namespace CQRSExample.Commands.Address
{
    public class AddAddressCommandResult : CommandResult
    {
        public Guid Id { get; }

        public AddAddressCommandResult(Guid id)
        {
            Id = id;
        }
    }
}
