namespace CQRSExample.Commands.Address
{
    public class UpdateAddressCommand : Command
    {
        public Guid Id { get; set; }
        public String NewAddress { get; set; }
    }
}
