using Common; // Required library with implementation.

// Builder that is using to build the web application.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adding controllers.
builder.Services.AddControllers();
// Adding Swagger/OpenAPI for documentation.
builder.Services.AddSwaggerGen();

// Make sure Common.dll is present in bin/Debug/net6.0 folder.
// Registering our TaskHelper from Common library as Singleton.
// Singleton = the same object instance will be used.
builder.Services.AddSingleton(new TaskHelper());

// Getting build result.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Using Swagger along with SwaggerUI.
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Using authorization (none by default).
app.UseAuthorization();

// Mapping controllers to actual routes.
app.MapControllers();

// Running the WEB App.
app.Run();
