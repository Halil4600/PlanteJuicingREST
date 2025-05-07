using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Models;
using System;

namespace PlanteJuicingREST.Models.Tests
{
    [TestClass]
    public class SoilMoistureModelTests
    {
        [TestMethod]
        public void IdTest()
        {
            // Arrange
            SoilMoistureModel soilMoistureModel = new SoilMoistureModel();

            // Act & Assert
            soilMoistureModel.Id = 1;
            Assert.AreEqual(1, soilMoistureModel.Id);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => soilMoistureModel.Id = -1);
        }

        [TestMethod]
        public void JordfugtighedValueTest()
        {
            // Arrange
            SoilMoistureModel soilMoistureModel = new SoilMoistureModel();

            // Act & Assert
            soilMoistureModel.SoilMoistureValue = 50;
            Assert.AreEqual(50, soilMoistureModel.SoilMoistureValue);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => soilMoistureModel.SoilMoistureValue = -10);
        }

    }
}