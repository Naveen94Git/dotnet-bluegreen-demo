var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/", () => "Product API Running");

app.MapHealthChecks("/health");

app.Run();
