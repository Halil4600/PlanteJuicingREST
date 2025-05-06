using System.Collections.Generic;
using PlanteJuicingREST.Models;
namespace PlanteJuicingREST.Interface
{
    public interface IJordfugtighedRepository
    {
        List<Jordfugtighed> GetAllJordfugtighed();
        Jordfugtighed Add(Jordfugtighed jordfugtighed);
    }
}
