using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Repositories;

namespace FirstAPiApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<int, Employee> _employeeRepository;
        private readonly ILogger<EmployeeService> _logger;

        public EmployeeService(IRepository<int,Employee> employeeRepository
                            ,ILogger<EmployeeService> logger) 
        {
            _employeeRepository  = employeeRepository;
            _logger = logger;
        }
        public async Task<ICollection<Employee>> GetAll(EmployeeGetPayloadDTO getPayloadDTO)
        {
            var employees = await _employeeRepository.GetAllAsync();
            if(employees.Count()>0)
            {
                employees = await filterEmployee(employees, getPayloadDTO.EmployeeFilter);
                employees = await sortEmployees(employees, getPayloadDTO.SortingOrder);
                employees = await paginateEmployees(employees, getPayloadDTO.Pagination);
                _logger.LogInformation(employees.Count() + " Filter result");
                return employees;
            }
            _logger.LogError("Tryingto retrive when no employees are present in collection");
            throw new Exception("No employees present");
            
        }

        private async Task<ICollection<Employee>> paginateEmployees(ICollection<Employee> employees, PaginationDTO pagination)
        {
            if(employees.Count()>5)
                return employees.Skip(pagination.PageNumber -1*pagination.TotalCount).Take(pagination.TotalCount).ToList();
            return employees;
        }

        private async Task<ICollection<Employee>> sortEmployees(ICollection<Employee> employees, int sortingOrder)
        {
            switch (sortingOrder)
            {
                case -3:
                    return employees.OrderByDescending(e => e.DepartmentId).ToList();
                case -2:
                    return employees.OrderByDescending(e => e.Email).ToList();
                case -1:
                    return employees.OrderByDescending(e => e.Name).ToList();
                case 1:
                    return employees.OrderBy(e => e.Name).ToList();
                case 2:
                    return employees.OrderBy(e => e.Email).ToList();
                case 3:
                    return employees.OrderBy(e => e.DepartmentId).ToList();
                default:
                    return employees.OrderBy(e=>e.Id).ToList();
            }
        }

        private async Task<ICollection<Employee>> filterEmployee(ICollection<Employee> employees, EmployeeFilterDTO employeeFilter)
        {
            if (employeeFilter == null) 
                return employees;
            if(employeeFilter.Name != null) 
                    employees = employees.Where(e=>e.Name.Contains(employeeFilter.Name)).ToList();
            if(employeeFilter.DepatmentID != -1)
                    employees = employees.Where(e=>e.DepartmentId == employeeFilter.DepatmentID).ToList();
            if(employeeFilter.Email != null)
                    employees = employees.Where(e=>e.Email ==  employeeFilter.Email).ToList();
            return employees;

        }
    }
}
