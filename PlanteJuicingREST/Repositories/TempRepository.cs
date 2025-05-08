using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;

namespace PlanteJuicingREST.Repositories
{
    public class TempRepository : ITempRepository
    {
        private static int nextId = 4;

        private List<TempModel> _tempList = new List<TempModel>()
        {
            new TempModel { Id = 1, TempValue = 5 },
            new TempModel { Id = 2, TempValue = 10 },
            new TempModel { Id = 3, TempValue = 15 },
        };

        public List<TempModel> GetAllTemp()
        {
            return _tempList;

        }
        public TempModel Add(TempModel tempModel)
        {
            tempModel.Id = nextId++;
            _tempList.Add(tempModel);
            //_context.SaveChanges();
            return tempModel;
        }
    }
}
