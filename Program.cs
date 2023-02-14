using Timer.CustomMiddleware;
using Timer.Helpers;
using Timer.Interfaces;
using Timer.Services;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddTransient<IStopWatch, StopWatch>();
// builder.Services.AddTransient<StopWatchService>();

// builder.Services.AddSingleton<IStopWatch, StopWatch>();
// builder.Services.AddSingleton<StopWatchService>();

builder.Services.AddScoped<IStopWatch, StopWatch>();
builder.Services.AddScoped<StopWatchService>();


var app = builder.Build();

app.UseMiddleware<StopWatchMiddleware>();

app.Run();
