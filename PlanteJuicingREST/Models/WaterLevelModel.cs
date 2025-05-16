using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlanteJuicingREST.Models
{
    public class WaterLevelModel
    {
        private int _id;
        private int _waterLevel;



        public int Id
        {
            get => _id;
            set
            {
                //if (value < 0)
                //    throw new ArgumentOutOfRangeException("id must be higher than 0");
                _id = value;
            }
        }


       
        public int WaterLevelValue
        {
            get => _waterLevel;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("waterlevel must be higher than 0");
                _waterLevel = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}



