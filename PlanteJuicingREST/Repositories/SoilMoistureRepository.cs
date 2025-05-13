using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.PDbContext;


namespace PlanteJuicingREST.Repositories
{
    public class SoilMoistureRepository : ISoilMoistureRepository
    {
        private static int nextId = 4;

        private readonly PlantDbContext _context;


        // tilføjelse her 
        public SoilMoistureRepository(PlantDbContext context)
        {
            _context = context;
            
        }

       
        public SoilMoistureModel Add(SoilMoistureModel soilMoistureModel)
        {
            soilMoistureModel.Id = nextId++;
            _context.SoilMoisture.Add(soilMoistureModel);
          //  _soilMoistureList.Add(soilMoistureModel);
            _context.SaveChanges(); // gemmer ændringerne i databasen
            return soilMoistureModel;
        }

        //private List<SoilMoistureModel> _soilMoistureList = new List<SoilMoistureModel>()
        //{
        //    new SoilMoistureModel { Id = 1, SoilMoistureValue = 10 },
        //    new SoilMoistureModel { Id = 2, SoilMoistureValue = 20 },
        //    new SoilMoistureModel { Id = 3, SoilMoistureValue = 30 },

        //    //udskift liste med connection af database 
        //    //lav noget db cotext her 
        //    //lav dbContext mappe 

        //};
        
        public List<SoilMoistureModel> GetAllSoilMoisture()
        {
            // måske skal der tilføjese noget her?? måske en liste 
            List<SoilMoistureModel> _soilMoisture = new List<SoilMoistureModel>();
            _soilMoisture = _context.SoilMoisture.ToList();


            return _soilMoisture;

        }
      
    }
}
