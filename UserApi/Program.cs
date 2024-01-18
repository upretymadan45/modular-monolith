using UserApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUserServices();
builder.Services.AddSwaggerGen(options =>
{
    options.AddUserSwaggerGen();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.UseUserSwaggerEndpoints();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapUserControllers();

app.Run();
