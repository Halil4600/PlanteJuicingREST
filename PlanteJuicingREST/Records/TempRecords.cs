using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;

namespace PlanteJuicingREST.Records
{
    public record TempRecords(int id, int tempValue);
    
    public static class RecordHelperTemp
    {
        public static TempModel ConvertTempRecords(TempRecords record)
        {
            if (record.id == null)
            {
                throw new ArgumentNullException("exception" + record.id);
            }
            if (record.tempValue == null)
            {
                throw new ArgumentNullException("exception" + record.tempValue);
            }
        
            //tilføjelse af temp userstory 13
            return new TempModel()
            {
                Id = (int)record.id,
                TempValue = (int)record.tempValue
            };
        }
    }
}