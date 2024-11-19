using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;

namespace FirstAPiApp.Interfaces
{
    public interface IEmployeeService
    {
        public Task<ICollection<Employee>> GetAll(EmployeeGetPayloadDTO getPayloadDTO);
    }
}
