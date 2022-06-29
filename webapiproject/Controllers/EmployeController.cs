using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiproject.Model;
using webapiproject.Services;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
       

            private readonly IEmployeServices _empservice;
            public EmployeController(IEmployeServices empservice)
            {
                _empservice = empservice;
            }
            [HttpGet]

            [Route("GetEmployes")]
            public IActionResult GetEmployes()
            {
                return new ObjectResult(_empservice.GetAllEmployes());
                // test code
            }
            [HttpPost]
            [Route("Addemploye")]
            public IActionResult AddEmploye(Employe emp)
            {
                return new ObjectResult(_empservice.AddEmploye(emp));
            }
            [HttpPost]
            [Route("ModifyEmploye")]
            public IActionResult ModifyEmploye(Employe emp)
            {
                return new ObjectResult(_empservice.ModifyEmploye(emp));
            }

            [HttpGet]
            [Route("DeleteEmploye/{id}")]
            public IActionResult DeleteEmploye(int id)
            {
                return new ObjectResult(_empservice.DeleteEmploye(id));
            }
        }
    }

