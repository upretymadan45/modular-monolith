using CustomerApi;
using UserApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCustomerServices()
    .AddUserServices();

builder.Services.AddSwaggerGen(options =>
{
    options.AddCustomerSwaggerGen()
    .AddUserSwaggerGen();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.UseCustomerSwaggerEndpoints()
    .UseUserSwaggerEndpoints();
});

app.UseHttpsRedirection();

app.MapCustomerControllers()
    .MapUserControllers();

app.Run();

