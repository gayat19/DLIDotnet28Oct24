using AutoMapper;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;

namespace FirstAPiApp.Mapper
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeDTO, Employee>();
        }
    }
}
