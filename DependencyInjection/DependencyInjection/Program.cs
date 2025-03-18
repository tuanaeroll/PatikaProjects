using DependencyInjection.Models;
using DependencyInjection.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IOgretmen, Teacher>();
builder.Services.AddScoped<ClassRoom>();

var app = builder.Build();

app.MapGet("/teacher", (ClassRoom classRoom) =>
{
    return Results.Ok(classRoom.GetTeacherInfo());
});

app.Run();