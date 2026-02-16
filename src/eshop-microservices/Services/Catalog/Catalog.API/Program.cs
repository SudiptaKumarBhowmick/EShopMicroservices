var builder = WebApplication.CreateBuilder(args);

// Before building the application
// Add services to the container.

var app = builder.Build();

//After building the application
// Configure the HTTP request pipeline.

app.Run();
