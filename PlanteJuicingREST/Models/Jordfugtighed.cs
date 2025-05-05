namespace PlanteJuicingREST.Models
{
    public class Jordfugtighed
    {
        private int _id;
        private int _jordfugtighed;


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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
