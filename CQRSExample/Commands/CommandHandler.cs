namespace CQRSExample.Commands
{
    public interface CommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }

    public interface CommandHandler<TCommand, TCommandResult> 
            where TCommand : Command 
            where TCommandResult : CommandResult
    {
        TCommandResult Execute(TCommand command);
    }
}
