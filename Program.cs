using DotNet9WithMemDB.DB;
using DotNet9WithMemDB.web.api;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ToDoDb>(options => options.UseInMemoryDatabase("todos"));
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "ToDo API",
        Version = "v1",
        Description = "A simple ToDo Web API with In-Memory Database"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDo API V1");
    });
}

app.MapGet("/", () => "Hello World!");
app.MapToDoEndpoints();

app.Run();
