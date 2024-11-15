using FirstAPiApp.Contexts;
using FirstAPiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPiApp.Repositories
{
    public class EmployeeRepository : Repository<int, Employee>
    {
        public EmployeeRepository(HRContext context):base(context)
        {
            
        }
        public async override Task<ICollection<Employee>> GetAllAsync()
        {
            var employees = _context.Employees;
            if (employees.Count() != 0)
                return employees.ToList();
            throw new Exception("No employees in collection");
        }

        public override async Task<Employee> GetAsync(int key)
        {
            var employee = await  _context.Employees.SingleOrDefaultAsync(e=>e.Id == key);
            if (employee == null) 
                throw new Exception("No such emplyee");
            return employee;
        }
    }
}
