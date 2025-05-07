using System.Collections.Generic;
using PlanteJuicingREST.Models;

namespace PlanteJuicingREST.Interface
{
    public interface ITempRepository
    {
        List<TempModel> GetAllTemp();

        TempModel Add(TempModel tempModel);
    }
}
