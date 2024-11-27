using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Repositories;
using FirstAPiApp.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FirstAPiApp.Misc
{
    public class UsernameValidator :ValidationAttribute
    {
        private readonly IRepository<int, Employee> _employeeRepository;

        public UsernameValidator() 
        {
            var opts = new DbContextOptionsBuilder().UseSqlServer("Server=DESKTOP-KVHT2L3\\SQLEXPRESS;Database=dbHRApp;TrustServerCertificate=True;Integrated security=true").Options;
               
            HRContext hRContext = new HRContext(opts);
            _employeeRepository = new EmployeeRepository(hRContext);
        }
        
        protected  override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Inavlid value");
            string username = value as string ?? "";
            if (username == "")
                return new ValidationResult("Inavlid value");
            var result = Task<ICollection<Employee>>.Run(() => _employeeRepository.GetAllAsync());

            var employees = result.GetAwaiter().GetResult();
            var employee =employees.FirstOrDefault(e=>e.Email == username);
            if (employee !=null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Employee email not present");
        }
    }
}
