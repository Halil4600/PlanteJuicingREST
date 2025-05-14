using Microsoft.EntityFrameworkCore;
using PlanteJuicingREST;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.PDbContext;
using PlanteJuicingREST.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the repositories
builder.Services.AddScoped<ISoilMoistureRepository, SoilMoistureRepository>();
builder.Services.AddScoped<ITempRepository, TempRepository>();
builder.Services.AddScoped<IWaterLevelRepository, WaterLevelRepository>();

// Register the DbContext with connection string
builder.Services.AddDbContext<PlantDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PlantDatabaseConnection")));

// Register controllers
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
