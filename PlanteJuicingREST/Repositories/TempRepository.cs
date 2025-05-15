using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.PDbContext;

namespace PlanteJuicingREST.Repositories
{
    public class TempRepository : ITempRepository
    {
        private static int nextId = 1;

        private readonly PlantDbContext _context;


        // tilføjelse her 
        public TempRepository(PlantDbContext context)
        {
            _context = context;

        }

        public TempModel Add(TempModel tempModel)
        {
           tempModel.Id = nextId++;
            _context.Temp.Add(tempModel);
            //  _soilMoistureList.Add(soilMoistureModel);
            _context.SaveChanges(); // gemmer ændringerne i databasen
            return tempModel;
        }

        public List<TempModel> GetAllTemp()
        {
            // måske skal der tilføjese noget her?? måske en liste 
            List<TempModel> _temp = new List<TempModel>();
            _temp = _context.Temp.ToList();
            return _temp;
        }
    }
}
