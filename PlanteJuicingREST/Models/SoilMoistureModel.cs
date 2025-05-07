namespace PlanteJuicingREST.Models
{
    public class SoilMoistureModel
    {
        private int _id;
        private int _soilMoisture;
        
       
       

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("id must be higher than 0");
                _id = value;
            }
        }
        public int SoilMoistureValue
        {
            get => _soilMoisture;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("jordfugtighed must be higher than 0");

                _soilMoisture = value;
            }
        }

 

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
