using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanteJuicingREST.Models;

namespace PlanteJuicingREST.Repositories.Tests
{
    [TestClass()]
    public class JordfugtighedRepositoryTests
    {
        [TestMethod()]
        public void GetAllJordfugtighedTest()
        {
            // Arrange
            var repository = new JordfugtighedRepository();
            var jordfugtighed1 = new Jordfugtighed { Id = 1, JordfugtighedValue = 50 };
            var jordfugtighed2 = new Jordfugtighed { Id = 2, JordfugtighedValue = 60 };
            repository.Add(jordfugtighed1);
            repository.Add(jordfugtighed2);
            // Act
            var result = repository.GetAllJordfugtighed();
            // Assert
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(jordfugtighed1, result.First());

        }
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var repository = new JordfugtighedRepository();
            var jordfugtighed = new Jordfugtighed { Id = 1, JordfugtighedValue = 50 };
            // Act
            var result = repository.Add(jordfugtighed);
            // Assert
            Assert.AreEqual(jordfugtighed, result);
            Assert.AreEqual(1, repository.GetAllJordfugtighed().Count());
        }
    }
}