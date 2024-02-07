using Sheenam.Brokers.Storages;
using Sheenam.Services.Foundations.Users;
using Sheenam.Services.Orchestrations.Users;
using Sheenam.Services.Processings.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StorageBroker>();
builder.Services.AddTransient<IStorageBroker, StorageBroker>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserProcessingService, UserProcessingService>();
builder.Services.AddTransient<IUserOrchestrationService, UserOrchestrationService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
