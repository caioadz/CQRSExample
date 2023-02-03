﻿using CQRSExample.Commands;

namespace CQRSExample
{
    public class CommandBuilder
    {
        private IServiceProvider serviceProvider;

        public CommandBuilder(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Execute<TCommand>(TCommand command) where TCommand : Command
        {
            serviceProvider.GetService<CommandHandler<TCommand>>().Execute(command);
        }

        public TCommandResult Execute<TCommand, TCommandResult>(TCommand command) 
                where TCommand : Command
                where TCommandResult : CommandResult
        {
            return serviceProvider.GetService<CommandHandler<TCommand, TCommandResult>>().Execute(command);
        }
    }
}
