using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiproject.Model;
using webapiproject.Services;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
       
            private readonly ICourseServices _courservice;
            public CourseController(ICourseServices courservice)
            {
                _courservice = courservice;
            }
            [HttpGet]

            [Route("GetCourses")]
            public IActionResult GetCourses()
            {
                return new ObjectResult(_courservice.GetAllCourses());
                // test code
            }
            [HttpPost]
            [Route("AddCourse")]
            public IActionResult AddCourse(Course cour)
            {
                return new ObjectResult(_courservice.AddCourse(cour));
            }
            [HttpPost]
            [Route("ModifyCourse")]
            public IActionResult ModifyCourse(Course cour)
            {
                return new ObjectResult(_courservice.ModifyCourse(cour));
            }

            [HttpGet]
            [Route("DeleteCourse/{id}")]
            public IActionResult DeleteCourse(int id)
            {
                return new ObjectResult(_courservice.DeleteCourse(id));
            }
        }

    }

