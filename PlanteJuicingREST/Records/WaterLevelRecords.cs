using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;

namespace PlanteJuicingREST.Records
{
        public record WaterLevelRecord(int id, int waterLevelValue);

        public static class RecordHelperWaterLevel
        {
            public static WaterLevelModel ConvertWaterLevelRecords(WaterLevelRecord record)
            {
                if (record.id == null)
                {
                    throw new ArgumentNullException("exception" + record.id);
                }
                if (record.waterLevelValue == null)
                {
                    throw new ArgumentNullException("exception" + record.waterLevelValue);
                }

                
                return new WaterLevelModel()
                {
                    Id = (int)record.id,
                    WaterLevelValue = (int)record.waterLevelValue
                };
            }

        }
}
