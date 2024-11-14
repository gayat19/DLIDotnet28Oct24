using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ShoppingAppTest
{
    public class DepartmentTests
    {
        IRepository<int, Department> _departmnetRepository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HRContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;
            HRContext context = new HRContext(options);
            _departmnetRepository = new DepartmentRepository(context);
        }

        [Test]
        public async Task AddDepartmetSuccessTest()
        {
            //Arrage - Prep
            Department department = new Department { DepartmentName = "TestDepartment" };

            //Action - Call for the method
            var result = await _departmnetRepository.AddAsync(department);

            //Assert
            //Assert.That(result, Is.Not.Null);
            Assert.That(result.DepartmentId, Is.EqualTo(1));
                
        }
        [Test]
        public async Task AddDepartmetNullTest()
        {
            //Arrage - Prep
            Department department = new Department { DepartmentName = null };

            //Action - Call for the method
            //var result = await _departmnetRepository.AddAsync(department);

            //Assert
            //Assert.That(result, Is.Not.Null);
            Assert.ThrowsAsync<Exception>(async () => await _departmnetRepository.AddAsync(department));

        }
    }
}