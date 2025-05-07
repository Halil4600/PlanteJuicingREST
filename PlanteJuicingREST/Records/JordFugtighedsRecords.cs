using System.Collections.Generic;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;



namespace PlanteJuicingREST.Records

{





    






    //tilføjelse af temp userstory 13
    public record JordFugtighedsRecord(int id, int jordfugtighedValue, int temp);

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
            if (record.temp == null)
            {
                throw new ArgumentNullException("exception" + record.temp);
            }

            //tilføjelse af temp userstory 13
            return new Jordfugtighed()
            {
                Id = (int)record.id,
                JordfugtighedValue = (int)record.jordfugtighedValue,
                Temp = (int)record.temp
            };

        }



    }


   



}

      


