using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;



namespace PlanteJuicingREST.Records

{





    







    public record JordFugtighedsRecord(int id, int jordfugtighedValue);

    public static class RecordHelper
    {
        public static Jordfugtighed ConvertJordFugtighedRecord(JordFugtighedsRecord record)
        {
            if (record.id == null)
            {
                throw new ArgumentNullException("exception" + record.id);
            }
            if (record.jordfugtighedValue == null)
            {
                throw new ArgumentNullException("exception" + record.jordfugtighedValue);
            }
            return new Jordfugtighed()
            {
                Id = (int)record.id,
                JordfugtighedValue = (int)record.jordfugtighedValue
            };

        }



    }


   



}

      


