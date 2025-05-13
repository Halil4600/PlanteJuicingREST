using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.PDbContext;

namespace PlanteJuicingREST.Repositories
{
    public class TempRepository : ITempRepository
    {
        private static int nextId = 4;

        private readonly PlantDbContext _context;


        // tilføjelse her 
        public TempRepository(PlantDbContext context)
        {
            _context = context;

        }

        public TempModel Add(TempModel tempModel)
        {
            tempModel.Id = nextId++;
            _context.Temp.Add(tempModel);
            //  _soilMoistureList.Add(soilMoistureModel);
            _context.SaveChanges(); // gemmer ændringerne i databasen
            return tempModel;
        }



        //private List<TempModel> _tempList = new List<TempModel>()
        //{
        //    new TempModel { Id = 1, TempValue = 5 },
        //    new TempModel { Id = 2, TempValue = 10 },
        //    new TempModel { Id = 3, TempValue = 15 },
        //};
      
        public List<TempModel> GetAllTemp()
        {
            // måske skal der tilføjese noget her?? måske en liste 
            List<TempModel> _temp = new List<TempModel>();
            _temp = _context.Temp.ToList();


            return _temp;

        }



       
        //public TempModel Add(TempModel tempModel)
        //{
        //    tempModel.Id = nextId++;
        //    _tempList.Add(tempModel);
        //    _context.SaveChanges();
        //    return tempModel;
        //}
    }
}
