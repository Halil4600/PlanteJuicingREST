using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Models;
using System.Linq;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.PDbContext;
using Microsoft.EntityFrameworkCore;

namespace PlanteJuicingREST.Tests.Repositories
{
    [TestClass]
    public class SoilMoistureRepositoryTests
    {
        //private ISoilMoistureRepository _soilMoistureRepository;
        //private PlantDbContext _context;

        //[TestInitialize]

        //public void init()
        //{
        //    var options = new DbContextOptionsBuilder<PlantDbContext>()
        //        .UseSqlServer
        //        ("Server=tcp:plantserver.database.windows.net,1433;Initial Catalog=PlantDatabase;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";")
        //        .Options;

        //    _context = new PlantDbContext (options);

        //    _soilMoistureRepository = new SoilMoistureRepository(_context);
        //}

        //[TestMethod]
        //public void AddSoilMoisture()
        //{
        //    var Soilmoisture = new SoilMoistureModel { Id = 1, SoilMoistureValue = 60 };

        //    _soilMoistureRepository.Add(Soilmoisture);

        //    Assert.AreEqual(1, _soilMoistureRepository.GetAllSoilMoisture().Count());


        //}




























        //public void Init()
        //{
        //    _repository = new SoilMoistureRepository();
        //}

        //[TestMethod]
        //public void Add_ShouldAddSoilMoistureToList()
        //{
        //    // Arrange
        //    var soilMoisture = new SoilMoistureModel { Id = 1, SoilMoistureValue = 50 };

        //    // Act
        //    var result = _repository.Add(soilMoisture);

        //    // Assert
        //    Assert.AreEqual(soilMoisture, result);
        //    Assert.AreEqual(4, _repository.GetAllSoilMoisture().Count());
        //}

        //[TestMethod]
        //public void GetAllSoulMoisture_ShouldReturnAllItems()
        //{
        //    // Arrange
        //    var soilMoisture1 = new SoilMoistureModel { Id = 1, SoilMoistureValue = 50 };
        //    var soilMoisture2 = new SoilMoistureModel { Id = 2, SoilMoistureValue = 60 };
        //    _repository.Add(soilMoisture1);
        //    _repository.Add(soilMoisture2);

        //    // Act
        //    var result = _repository.GetAllSoilMoisture();

        //    // Assert
        //    Assert.AreEqual(5, result.Count());
        //    Assert.AreEqual(10, result.First().SoilMoistureValue);
        //}



    
    
        
        
            private ISoilMoistureRepository _soilMoistureRepository;
            private PlantDbContext _context;

            [TestInitialize]
            public void Init()
            {
                var options = new DbContextOptionsBuilder<PlantDbContext>()
                    .UseInMemoryDatabase(databaseName: "Test_PlantDb") // <-- Use InMemory DB
                    .Options;

                _context = new PlantDbContext(options);
                _soilMoistureRepository = new SoilMoistureRepository(_context);
            }

            [TestMethod]
            public void AddSoilMoisture()
            {
                var soilMoisture = new SoilMoistureModel { Id = 1, SoilMoistureValue = 60 };

                _soilMoistureRepository.Add(soilMoisture);

                var allMoisture = _soilMoistureRepository.GetAllSoilMoisture();

                Assert.AreEqual(1, allMoisture.Count());
            }
        
    }

}
