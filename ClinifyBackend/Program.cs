// Add services to the container.
using ClinifyBackend.Application.Interfaces;
using ClinifyBackend.Application.Services;
using ClinifyBackend.Infraestructure.Repositories;
using ClinifyBackend.Infrastructure.Adapters;
using ClinifyBackend.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin(); // Permite llamadas desde cualquier sitio
        });
});





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Adapter pattern
//builder.Services.AddScoped<IClienteRepository, ExternalClienteAdapter>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ClienteService>();

builder.Services.AddScoped<ICitaRepository, CitaRepository>();
builder.Services.AddScoped<CitaService>();

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<DoctorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.UseCors("AllowFrontend");

app.Run();
