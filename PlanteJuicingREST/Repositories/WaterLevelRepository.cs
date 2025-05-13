using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.PDbContext;

namespace PlanteJuicingREST.Repositories
{
    public class WaterLevelRepository : IWaterLevelRepository
    {
        private static int nextId = 4;

        private readonly PlantDbContext _context;


        // tilføjelse her 
        public WaterLevelRepository(PlantDbContext context)
        {
            _context = context;
        }

        public WaterLevelModel Add(WaterLevelModel waterLevelModel)
        {
            waterLevelModel.Id = nextId++;
            _context.WaterLevel.Add(waterLevelModel);
            _context.SaveChanges();
            return waterLevelModel;
        }
        //private List<WaterLevelModel> _waterLevelList = new List<WaterLevelModel>()
        //{
        //    new WaterLevelModel { Id = 1, WaterLevelValue = 10 },
        //    new WaterLevelModel { Id = 2, WaterLevelValue = 20 },
        //    new WaterLevelModel { Id = 3, WaterLevelValue = 30 },
        //};

        public List<WaterLevelModel> GetAllWaterLevel()
        {
            List<WaterLevelModel> _waterLevelList = new List<WaterLevelModel>();
            _waterLevelList = _context.WaterLevel.ToList();
            return _waterLevelList;
        }
    }
 
}
