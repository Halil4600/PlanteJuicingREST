using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Models;
using System;

namespace PlanteJuicingREST.Models.Tests
{
    [TestClass]
    public class JordfugtighedTests
    {
        [TestMethod]
        public void IdTest()
        {
            // Arrange
            Jordfugtighed jordfugtighed = new Jordfugtighed();

            // Act & Assert
            jordfugtighed.Id = 1;
            Assert.AreEqual(1, jordfugtighed.Id);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => jordfugtighed.Id = -1);
        }

        [TestMethod]
        public void JordfugtighedValueTest()
        {
            // Arrange
            Jordfugtighed jordfugtighed = new Jordfugtighed();

            // Act & Assert
            jordfugtighed.JordfugtighedValue = 50;
            Assert.AreEqual(50, jordfugtighed.JordfugtighedValue);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => jordfugtighed.JordfugtighedValue = -10);
        }

    }
}