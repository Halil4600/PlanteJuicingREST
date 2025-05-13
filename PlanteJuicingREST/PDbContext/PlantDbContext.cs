using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;


namespace PlanteJuicingREST.PDbContext
{
    public class PlantDbContext : DbContext
    {
        // hele denne fil er vores DBcontext 

        public PlantDbContext(DbContextOptions<PlantDbContext> options) : base(options)
        { }
        // public dbset of all vores repositories 

        public DbSet<SoilMoistureModel> SoilMoisture { get; set; }
        public DbSet<TempModel> Temp { get; set; }
        public DbSet<WaterLevelModel> WaterLevel { get; set; }


    }
}
