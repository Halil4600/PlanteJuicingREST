using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;

namespace PlanteJuicingREST.Repositories
{
    public class WaterLevelRepository : IWaterLevelRepository
    {
        private static int nextId = 4;

        private List<WaterLevelModel> _waterLevelList = new List<WaterLevelModel>()
        {
            new WaterLevelModel { Id = 1, WaterLevelValue = 10 },
            new WaterLevelModel { Id = 2, WaterLevelValue = 20 },
            new WaterLevelModel { Id = 3, WaterLevelValue = 30 },
        };

        public List<WaterLevelModel> GetAllWaterLevel()
        {
            return _waterLevelList;

        }

        public WaterLevelModel Add(WaterLevelModel waterLevelModel)
        {
            waterLevelModel.Id = nextId++;
            _waterLevelList.Add(waterLevelModel);
            //_context.SaveChanges();
            return waterLevelModel;
        }
    }
 
}
