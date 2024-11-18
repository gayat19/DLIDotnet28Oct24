using AutoMapper;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;

namespace FirstAPiApp.Mapper
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentEmployessResponseDTO>();

            CreateMap<DepartmentEmployessResponseDTO,Department>();
        }
    }
}
