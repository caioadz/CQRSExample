using CQRSExample.Commands;
using CQRSExample.Commands.Address;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<CommandHandler<AddAddressCommand, AddAddressCommandResult>, AddAddressCommandHandler>();
builder.Services.AddSingleton<CommandHandler<AddAddressCommand>, AddAddressCommandHandler>();
builder.Services.AddSingleton<CommandHandler<RemoveAddressCommand>, RemoveAddressCommandHandler>();
builder.Services.AddSingleton<CommandHandler<UpdateAddressCommand>, UpdateAddressCommandHandler>();

builder.Services.AddSingleton<CommandResolver>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
