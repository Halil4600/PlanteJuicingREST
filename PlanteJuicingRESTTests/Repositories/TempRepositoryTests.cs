using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Models;
using System.Collections.Generic;

namespace PlanteJuicingREST.Repositories.Tests
{
    [TestClass]
    public class TempRepositoryTests
    {
        private TempRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            //denne metode kører før hver test
            _repository = new TempRepository();
        }

        [TestMethod]
        public void GetAllTemp_ShouldReturnInitialList()
        {
            // Act
            List<TempModel> result = _repository.GetAllTemp();

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(5, result[0].TempValue);
        }

        [TestMethod]
        public void Add_ShouldAssignNewIdAndAddToList()
        {
            // Arrange
            var newTemp = new TempModel { TempValue = 25 };

            // Act
            TempModel result = _repository.Add(newTemp);
            List<TempModel> allTemps = _repository.GetAllTemp();

            // Assert
            Assert.AreEqual(4, result.Id); // nextId starter på 4
            Assert.AreEqual(25, result.TempValue);
            Assert.AreEqual(4, allTemps.Count); // 3 oprindelige + 1 ny
            Assert.AreEqual(result, allTemps[3]);
        }
    }
}

