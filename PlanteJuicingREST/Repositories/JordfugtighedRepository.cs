using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;

namespace PlanteJuicingREST.Repositories
{
    public class JordfugtighedRepository : IJordfugtighedRepository
    {
       

        private List<Jordfugtighed> _jordfugtighedList = new List<Jordfugtighed>();


        public IEnumerable<Jordfugtighed> GetAllJordfugtighed()
        {
            return _jordfugtighedList;
        }
        public Jordfugtighed Add(Jordfugtighed jordfugtighed)
        {
            _jordfugtighedList.Add(jordfugtighed);
            //_context.SaveChanges();
            return jordfugtighed;
        }
    }
}
