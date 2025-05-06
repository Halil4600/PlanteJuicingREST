using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Interface;
using Microsoft.EntityFrameworkCore;

using System.Linq;


namespace PlanteJuicingREST.Tests
{
    [TestClass]
    public class JordfugtighedRepositoryTests
    {
        private IJordfugtighedRepository _repository;
        private PlanteJucingDbContext _context;
        [TestInitialize]
       
public void Init()
{
    var options = new DbContextOptionsBuilder<PlanteJucingDbContext>()
        .UseSqlServer("Data Source=mssql17.unoeuro.com;User ID=professionaleducationnetwor_dk;Password=yEA9Hna25RtmGxpkfgdB;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        .Options;

    _context = new PlanteJucingDbContext(options);
    _repository = new JordfugtighedRepository(_context);
}




        [TestMethod]
        public void GetAllJordfugtighedTest()
        {
            // Arrange
            var jordfugtighed1 = new Jordfugtighed { Id = 1, JordfugtighedValue = 50 };
            var jordfugtighed2 = new Jordfugtighed { Id = 2, JordfugtighedValue = 60 };
            _repository.Add(jordfugtighed1);
            _repository.Add(jordfugtighed2);

            // Act
            var result = _repository.GetAllJordfugtighed();

            // Assert
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(50, result.First().JordfugtighedValue);
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var jordfugtighed = new Jordfugtighed { Id = 1, JordfugtighedValue = 50 };

            // Act
            var result = _repository.Add(jordfugtighed);

            // Assert
            Assert.AreEqual(jordfugtighed, result);
            Assert.AreEqual(1, _repository.GetAllJordfugtighed().Count());
        }
    }
}
