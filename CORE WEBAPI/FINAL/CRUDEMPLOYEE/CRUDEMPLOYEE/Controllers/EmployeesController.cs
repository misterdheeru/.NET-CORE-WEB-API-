using CRUDEMPLOYEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDEMPLOYEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees _employee;

        public EmployeesController(IEmployees employee)
        {
            _employee   = employee;
        }

        [HttpGet]
        public  IActionResult Get()
        {
             var Data =  _employee.DisplayEmployee();
          
            return Ok(Data);
        }

        
        [HttpPost]
        public  IActionResult Post(selectemp data)
        {
           _employee.InsertEmployeeRecord(data);
            return Ok("SUCCESSED");
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
             _employee.DeleteEmployee(id);
            return Ok("DELETED");
        }

        [HttpPut]
        public IActionResult Update (selectemp data)
        {
            _employee.UpdateEmployeeRecord(data);

            return Ok("UPDATED");
        }

        [HttpGet("{name}")]
        public ActionResult SearchEmployeesByName(string name)
        {
            var employees = _employee.SearchEmployeeByName(name);
            return Ok(employees);
        }
    }
}
