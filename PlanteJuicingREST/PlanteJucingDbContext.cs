using PlanteJuicingREST.Models;
using Microsoft.EntityFrameworkCore;

namespace PlanteJuicingREST
{
    public class PlanteJucingDbContext : DbContext
    {
        public PlanteJucingDbContext(
            DbContextOptions<PlanteJucingDbContext> options)
            : base(options) { }

        public DbSet<SoilMoistureModel> Jordfugtighed { get; set; }
        }
    }

