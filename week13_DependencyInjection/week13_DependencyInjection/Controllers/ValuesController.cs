using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week13_DependencyInjection.Services;

namespace week13_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ValuesController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
       public IActionResult Get()
        {
            string teacherInfo = _teacher.GetInfo();
            return Ok(teacherInfo);
        }
    }
}
