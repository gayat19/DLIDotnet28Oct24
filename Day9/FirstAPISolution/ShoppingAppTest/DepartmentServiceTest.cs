using AutoMapper;
using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Repositories;
using FirstAPiApp.Services;
using Microsoft.EntityFrameworkCore;
using Moq;


namespace ShoppingAppTest
{
    public class DepartmentServiceTest
    {
        
        IDepartmentService _departmentService;
        IRepository<int, Department> _departmentRepository;
        IRepository<int, Employee> _employeeRepository;
        Mock<IMapper> _mapper = new Mock<IMapper>();
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<HRContext>()
                .UseInMemoryDatabase("TestDB")
                .Options;
            HRContext context = new HRContext(options);
            _departmentRepository = new DepartmentRepository(context);
            _employeeRepository = new EmployeeRepository(context);
            
        }

        [Test]
        public async Task TestGetDepartmentWithEmployees()
        {
            var department = new Department { DepartmentName = "Admin" };
            var employee = new Employee
            {
                Name = "Ramu",
                DepartmentId = 1,
                Email = "ramu@abc.com"
            };
            department = await _departmentRepository.AddAsync(department);
            await _employeeRepository.AddAsync(employee);
            
            var departmentDTO = new DepartmentEmployessResponseDTO
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName
            };
            var employeeDTO = new EmployeeDTO();
            _mapper.Setup(d=>d.Map<DepartmentEmployessResponseDTO>(department)).Returns(departmentDTO);    
            _mapper.Setup(e=>e.Map<EmployeeDTO>(employee)).Returns(employeeDTO);
            _departmentService = new DepartmnetService(_departmentRepository, _employeeRepository, _mapper.Object);

            var result = await _departmentService.GetDepartmnetsWithEmployees();


            Assert.That(result, Is.Not.Null);
        }

    }
}
