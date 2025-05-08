using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Models;
using System.Linq;

namespace PlanteJuicingREST.Tests.Repositories
{
    [TestClass]
    public class SoilMoistureRepositoryTests
    {
        private SoilMoistureRepository _repository;

        [TestInitialize]
        public void Init()
        {
            _repository = new SoilMoistureRepository();
        }

        [TestMethod]
        public void Add_ShouldAddSoilMoistureToList()
        {
            // Arrange
            var soilMoisture = new SoilMoistureModel { Id = 1, SoilMoistureValue = 50 };

            // Act
            var result = _repository.Add(soilMoisture);

            // Assert
            Assert.AreEqual(soilMoisture, result);
            Assert.AreEqual(4, _repository.GetAllSoilMoisture().Count());
        }

        [TestMethod]
        public void GetAllSoulMoisture_ShouldReturnAllItems()
        {
            // Arrange
            var soilMoisture1 = new SoilMoistureModel { Id = 1, SoilMoistureValue = 50 };
            var soilMoisture2 = new SoilMoistureModel { Id = 2, SoilMoistureValue = 60 };
            _repository.Add(soilMoisture1);
            _repository.Add(soilMoisture2);

            // Act
            var result = _repository.GetAllSoilMoisture();

            // Assert
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual(10, result.First().SoilMoistureValue);
        }
    }
}