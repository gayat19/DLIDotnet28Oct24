using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Repositories;
using FirstAPiApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ICollection<DepartmentEmployessResponseDTO>>> Get()
        {
            //try
            //{
                var departments = await _departmentService.GetDepartmnetsWithEmployees();
                return Ok(departments);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(new ErrorObject { ErrorCode=400,Message=ex.Message});
            //}
        }
    }
}
