var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.WebHost.UseKestrel(serverOptions =>
// {
//     serverOptions.ListenAnyIP(5000);
// });

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
