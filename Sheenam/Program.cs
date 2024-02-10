using Sheenam.Brokers.Files;
using Sheenam.Brokers.Storages;
using Sheenam.Brokers.Tokens;
using Sheenam.Services.Foundations.Files;
using Sheenam.Services.Foundations.Homes;
using Sheenam.Services.Foundations.ImageMetadatas;
using Sheenam.Services.Foundations.Users;
using Sheenam.Services.Orchestrations.Homes;
using Sheenam.Services.Orchestrations.Images;
using Sheenam.Services.Orchestrations.Users;
using Sheenam.Services.Processings.File;
using Sheenam.Services.Processings.Homes;
using Sheenam.Services.Processings.ImageMetadatas;
using Sheenam.Services.Processings.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StorageBroker>();
AddBrokers(builder);
AddFoundationServices(builder);
AddProccessingServices(builder);
AddOrchestrationServices(builder);

static void AddOrchestrationServices(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserOrchestrationService, UserOrchestrationService>();
    builder.Services.AddTransient<IHomeOrchestrationService, HomeOrchestrationService>();
    builder.Services.AddTransient<IImageOrchestrationService, ImageOrchestrationService>();
}

static void AddProccessingServices(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserProcessingService, UserProcessingService>();
    builder.Services.AddTransient<IHomeProcessingService, HomeProcessingService>();
    builder.Services.AddTransient<IFileProcessingService, FileProcessingService>();
    builder.Services.AddTransient<IImageMetadataProcessingService, ImageMetadataProcessingService>();
}

static void AddFoundationServices(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<IHomeService, HomeService>();
    builder.Services.AddTransient<IImageMetadataService, ImageMetadataService>();
    builder.Services.AddTransient<IFileService, FileService>();
}

static void AddBrokers(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IStorageBroker, StorageBroker>();
    builder.Services.AddTransient<ITokenBroker, TokenBroker>();
    builder.Services.AddTransient<IFileBroker, FileBroker>();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();

app.Run();