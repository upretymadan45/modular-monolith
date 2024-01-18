using CustomerApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddCustomerServices();

builder.Services.AddSwaggerGen(options =>
{
    options.AddCustomerSwaggerGen();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.UseCustomerSwaggerEndpoints();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapCustomerControllers();

app.Run();
