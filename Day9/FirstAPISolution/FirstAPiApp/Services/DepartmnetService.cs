using AutoMapper;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Repositories;

namespace FirstAPiApp.Services
{
    public class DepartmnetService : IDepartmentService
    {
        private readonly IRepository<int, Department> _departmentRepository;
        private readonly IRepository<int, Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public DepartmnetService(IRepository<int,Department> departmentRepository,
                                IRepository<int,Employee> employeeRepository,
                                IMapper mapper) 
        {
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<Department> Add(string name)
        {
            var departments = await _departmentRepository.GetAllAsync();
            var department = departments.FirstOrDefault(d => d.DepartmentName.ToUpper() == name.ToUpper());
            if (department == null) 
            {
                department = new Department { DepartmentName = name };
                await _departmentRepository.AddAsync(department);
                return department;
            }
            throw new Exception("Could not create another department with same name");
        }

        public async Task<ICollection<DepartmentEmployessResponseDTO>> GetDepartmnetsWithEmployees()
        {
            List<DepartmentEmployessResponseDTO> empDepDto = new List<DepartmentEmployessResponseDTO>();
            var departments = await _departmentRepository.GetAllAsync();
            foreach (var department in departments) 
            {
                var depatmentDto = _mapper.Map<DepartmentEmployessResponseDTO>(department);
                depatmentDto.Employees = await GetEmployeesFromDepartmnet(department.DepartmentName);
                empDepDto.Add(depatmentDto);
            }
            return empDepDto;
        }
        async Task<List<EmployeeDTO>> GetEmployeesFromDepartmnet(string name)
        {
            var employees = _employeeRepository.GetAllAsync();
            List<EmployeeDTO> depEmployees = new List<EmployeeDTO>();
            var result = await GetEmployees(name);
            foreach (var employee in result)
            {
                depEmployees.Add(_mapper.Map<EmployeeDTO>(employee));
            }
            return depEmployees;
        }
        public async Task<ICollection<Employee>> GetEmployees(string name)
        {
            var id = (await _departmentRepository.GetAllAsync()).Where(d=>d.DepartmentName==name).FirstOrDefault().DepartmentId;
            var employees = (await _employeeRepository.GetAllAsync()).Where(e => e.DepartmentId == id);
            return employees.ToList();
        }

        public Task<Department> Remove(string name)
        {
            throw new NotImplementedException();
        }
    }
}
