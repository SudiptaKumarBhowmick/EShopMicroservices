var builder = WebApplication.CreateBuilder(args);

// Before building the application
// Add services to the container.

builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// After building the application
// Configure the HTTP request pipeline.

app.MapCarter();

app.Run();
