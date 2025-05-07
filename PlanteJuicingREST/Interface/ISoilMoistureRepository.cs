using System.Collections.Generic;
using PlanteJuicingREST.Models;
namespace PlanteJuicingREST.Interface
{
    public interface ISoilMoistureRepository
    {
        List<SoilMoistureModel> GetAllSoilMoisture();
        SoilMoistureModel Add(SoilMoistureModel soilMoistureModel);
    }
}
