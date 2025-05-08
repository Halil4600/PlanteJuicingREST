using System.Collections.Generic;
using PlanteJuicingREST.Models;

namespace PlanteJuicingREST.Interface
{
    public interface IWaterLevelRepository
    {
        List<WaterLevelModel> GetAllWaterLevel();

        WaterLevelModel Add(WaterLevelModel waterLevelModel);
    }
}
