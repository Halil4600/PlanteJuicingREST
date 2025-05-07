using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;

namespace PlanteJuicingREST.Repositories
{
    public class SoilMoistureRepository : ISoilMoistureRepository
    {
        private static int nextId = 4;

        private List<SoilMoistureModel> _soilMoistureList = new List<SoilMoistureModel>()
        {
            new SoilMoistureModel { Id = 1, SoilMoistureValue = 10 },
            new SoilMoistureModel { Id = 2, SoilMoistureValue = 20 },
            new SoilMoistureModel { Id = 3, SoilMoistureValue = 30 },
        };
        
        public List<SoilMoistureModel> GetAllSoilMoisture()
        {
            return _soilMoistureList;

        }
        public SoilMoistureModel Add(SoilMoistureModel soilMoistureModel)
        {
            soilMoistureModel.Id = nextId++;
            _soilMoistureList.Add(soilMoistureModel);
            //_context.SaveChanges();
            return soilMoistureModel;
        }
    }
}
