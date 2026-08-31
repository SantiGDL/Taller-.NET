using Actividad_2.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Actividad 2 v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Esta línea es muy importante: conecta las rutas de tus controladores con la aplicación.
// Por ejemplo, conecta: [Route("api/tareas")] con /api/tareas
app.MapControllers();

app.Run();