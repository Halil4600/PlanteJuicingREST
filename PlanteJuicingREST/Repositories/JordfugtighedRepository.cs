using System.Collections.Generic;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;

namespace PlanteJuicingREST.Repositories
{
    public class JordfugtighedRepository : IJordfugtighedRepository
    {
        private readonly PlanteJucingDbContext _context;

        public JordfugtighedRepository(PlanteJucingDbContext context)
        {
            _context = context;
        }



        
        public IEnumerable<Jordfugtighed> GetAllJordfugtighed()
        {
            return _context.Jordfugtighed.ToList();
        }
        public Jordfugtighed Add(Jordfugtighed jordfugtighed)
        {
            _context.Jordfugtighed.Add(jordfugtighed);
            //_context.SaveChanges();
            return jordfugtighed;
        }
    }
}
