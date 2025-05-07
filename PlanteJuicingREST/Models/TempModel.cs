namespace PlanteJuicingREST.Models
{
    public class TempModel
    {
        private int _id;
       
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
       
        public int TempValue
        {
            get => _temp;
            set
            {
                if (value < 0)
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
