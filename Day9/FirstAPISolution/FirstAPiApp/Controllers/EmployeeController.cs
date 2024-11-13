using FirstAPiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>();
            //{
            //    new Employee() { Id = 1,Name="Ramu",Email="ramu@gmail.com" },
            //    new Employee() { Id = 2,Name="Somu",Email="somu@gmail.com" }
            //};
        public EmployeeController() {
            
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Employee>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorObject),StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            if (employees == null || employees.Count == 0)
                return NotFound(new ErrorObject { ErrorCode=404,Message=nameof(ErrorResponses.ObjectNotFound)});
            return Ok(employees);
        }
        [HttpPost]
        public ActionResult<Employee> Post(Employee employee)
        {
            int id = employees.Count + 1;
            employee.Id = id;
            employees.Add(employee);
            return Created("", employee);
        }
        [HttpGet]
        [Route("EmployeeSearch")]
        public ActionResult<Employee> GetEmployee([FromQuery] string email)
        {
            var employee = employees.FirstOrDefault(e => e.Email == email);
            if (employee == null)
                return NotFound($"No Employee with email {email} is present");
            return Ok(employee);
        }
    }
}
