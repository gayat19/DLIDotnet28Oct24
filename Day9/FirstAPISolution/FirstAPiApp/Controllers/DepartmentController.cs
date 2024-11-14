using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IRepository<int, Department> _departmentRepository;

        public DepartmentController(IRepository<int, Department> repository)
        {
            _departmentRepository = repository;
        }
        //public DepartmentController()
        //{
        //    _departmentRepository = new DepartmentRepository();
        //}
        [HttpGet]
        public async Task<ActionResult<ICollection<Department>>> Get()
        {
            try
            {
                var departments = await _departmentRepository.GetAllAsync();
                return Ok(departments);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
