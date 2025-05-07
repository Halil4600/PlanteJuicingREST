namespace PlanteJuicingREST.Models
{
    public class Jordfugtighed
    {
        private int _id;
        private int _jordfugtighed;

        //add temperatur
        private int _temp; 

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
        public int JordfugtighedValue
        {
            get => _jordfugtighed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("jordfugtighed must be higher than 0");

                _jordfugtighed = value;
            }
        }

        public int Temp
        {
            get => _temp;
            set 
            {
                if (_temp < 0)
                    throw new ArgumentOutOfRangeException("temperatur must be higer than 0");

                _temp = value;
            
            }
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
