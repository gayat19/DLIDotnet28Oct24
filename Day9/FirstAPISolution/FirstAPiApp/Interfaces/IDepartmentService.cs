using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;

namespace FirstAPiApp.Interfaces
{
    public interface IDepartmentService
    {
        public Task<Department> Add(string name);

        public Task<Department> Remove(string name);
        public Task<ICollection<Employee>> GetEmployees(string name);
        public Task<ICollection<DepartmentEmployessResponseDTO>> GetDepartmnetsWithEmployees();

    }
}
