using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;

namespace PlanteJuicingREST.Records
{
    public record SoilMoistureRecord(int id, int soilMoistureValue);
    
    public static class RecordHelperSoilMoisterValue
    {
        public static SoilMoistureModel ConvertSoilMoistureRecord(SoilMoistureRecord record)
        {
            if (record.id == null)
            {
                throw new ArgumentNullException("exception" + record.id);
            }
            if (record.soilMoistureValue == null)
            {
                throw new ArgumentNullException("exception" + record.soilMoistureValue);
            }
        
            //tilføjelse af temp userstory 13
            return new SoilMoistureModel()
            {
                Id = (int)record.id,
                SoilMoistureValue = (int)record.soilMoistureValue
            };
        }
    }
}