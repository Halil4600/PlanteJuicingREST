using System.Collections.Generic;
using PlanteJuicingREST.Models;
namespace PlanteJuicingREST.Interface
{
    public interface IJordfugtighedRepository
    {
        IEnumerable<Jordfugtighed> GetAllJordfugtighed();
        Jordfugtighed Add(Jordfugtighed jordfugtighed);
    }
}
