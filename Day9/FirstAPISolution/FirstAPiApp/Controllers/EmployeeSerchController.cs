using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class EmployeeSerchController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeSerchController> _logger;

        public EmployeeSerchController(IEmployeeService employeeService,ILogger<EmployeeSerchController> logger) 
        {
            _employeeService = employeeService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<ActionResult<ICollection<Employee>>> GetEmployees(EmployeeGetPayloadDTO employeeGetPayload)
        {
            var employees = await _employeeService.GetAll(employeeGetPayload);
            _logger.LogInformation("Result of search - "+employees.Count);
            return Ok(employees);
        }
    }
}
