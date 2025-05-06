using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;

namespace PlanteJuicingREST.Repositories
{
    public class JordfugtighedRepository : IJordfugtighedRepository
    {
        private static int nextId = 4;

        private List<Jordfugtighed> _jordfugtighedList = new List<Jordfugtighed>()
        {
            new Jordfugtighed { Id = 1, JordfugtighedValue = 10 },
            new Jordfugtighed { Id = 2, JordfugtighedValue = 20 },
            new Jordfugtighed { Id = 3, JordfugtighedValue = 30 },



        };


        public List<Jordfugtighed> GetAllJordfugtighed()
        {
            return _jordfugtighedList;

        }
        public Jordfugtighed Add(Jordfugtighed jordfugtighed)
        {
            jordfugtighed.Id = nextId++;
            _jordfugtighedList.Add(jordfugtighed);
            //_context.SaveChanges();
            return jordfugtighed;
        }
    }
}
