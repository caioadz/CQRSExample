using CQRSExample.Commands;
using CQRSExample.Commands.Address;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CommandHandler<AddAddressCommand, AddAddressCommandResult>, AddAddressCommandHandler>();
builder.Services.AddScoped<CommandHandler<AddAddressCommand>, AddAddressCommandHandler>();
builder.Services.AddScoped<CommandHandler<RemoveAddressCommand>, RemoveAddressCommandHandler>();
builder.Services.AddScoped<CommandHandler<UpdateAddressCommand>, UpdateAddressCommandHandler>();
builder.Services.AddScoped<CommandResolver>();

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
