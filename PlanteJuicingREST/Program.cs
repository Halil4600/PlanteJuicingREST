using Microsoft.EntityFrameworkCore;
using PlanteJuicingREST;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<PlanteJucingDbContext>(options =>
    options.UseSqlServer("Data Source=mssql17.unoeuro.com,1433;Initial Catalog=professionaleducationnetworkforinnovativesolutions_dk_db_jord;User ID=professionaleducationnetwor_dk;Password=yEA9Hna25RtmGxpkfgdB;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite; MultiSubnetFailover=False"));
builder.Services.AddTransient<IJordfugtighedRepository, JordfugtighedRepository>();


builder.Services.AddControllers();


// dbContext med connection string 

// tilføj transient med med vores jordfugtighedsrepository for at forbind dbcontext med database 
// public dbset <jordFugtighed> jordfugtigheds { get; set; }
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
