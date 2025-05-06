using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Models;
using System.Linq;

namespace PlanteJuicingREST.Tests.Repositories
{
    [TestClass]
    public class JordfugtighedRepositoryTests
    {
        private JordfugtighedRepository _repository;

        [TestInitialize]
        public void Init()
        {
            _repository = new JordfugtighedRepository();
        }

        [TestMethod]
        public void Add_ShouldAddJordfugtighedToList()
        {
            // Arrange
            var jordfugtighed = new Jordfugtighed { Id = 1, JordfugtighedValue = 50 };

            // Act
            var result = _repository.Add(jordfugtighed);

            // Assert
            Assert.AreEqual(jordfugtighed, result);
            Assert.AreEqual(1, _repository.GetAllJordfugtighed().Count());
        }

        [TestMethod]
        public void GetAllJordfugtighed_ShouldReturnAllItems()
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
    }
}