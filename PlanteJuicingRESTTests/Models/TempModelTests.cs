using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Models;
using System;






    namespace PlanteJuicingREST.Tests.Models
    {

        //[TestClass]
        //public class TempModelTests
        //{
        //    [TestMethod]
        //    public void IdTest()
        //    {
        //        // Arrange
        //        TempModel tempModel = new TempModel();

        //        // Act & Assert
        //        tempModel.Id = 1;
        //        Assert.AreEqual(1, tempModel.Id);
        //        Assert.ThrowsException<ArgumentOutOfRangeException>(() => tempModel.Id = -1);
        //    }

        //    [TestMethod]
        //    public void TempValueTest()
        //    {
        //        // Arrange
        //         TempModel tempModel = new TempModel();

        //        // Act & Assert
        //        tempModel.TempValue = 15;
        //        Assert.AreEqual(50, tempModel.TempValue);
        //        Assert.ThrowsException<ArgumentOutOfRangeException>(() => tempModel.TempValue = -1);
        //    }

        //}
        [TestClass]
        public class TempModelTests
        {
            [TestMethod]
            public void Set_Valid_Id_Should_Assign_Value()
            {
                // Arrange
                var model = new TempModel();

                // Act
                model.Id = 1;

                // Assert
                Assert.AreEqual(1, model.Id);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Set_Invalid_Id_Should_Throw_Exception()
            {
                // Arrange
                var model = new TempModel();

                // Act
                model.Id = -5;
            }

            [TestMethod]
            public void Set_Valid_TempValue_Should_Assign_Value()
            {
                // Arrange
                var model = new TempModel();

                // Act
                model.TempValue = 20;

                // Assert
                Assert.AreEqual(20, model.TempValue);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Set_Invalid_TempValue_Should_Throw_Exception()
            {
                // Arrange
                var model = new TempModel();

                // Act
                model.TempValue = -10;
            }

            [TestMethod]
            public void ToString_Should_Return_Default_String()
            {
                // Arrange
                var model = new TempModel();

                // Act
                var result = model.ToString();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Contains("TempModel")); // eller tilpas efter dit behov
            }
        }
    }





