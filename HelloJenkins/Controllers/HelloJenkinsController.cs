using HelloJenkins.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloJenkins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HelloJenkinsController : ControllerBase
    {
        private readonly IBusinessLogic businessLogic;

        public HelloJenkinsController(IBusinessLogic logic)
        {
            businessLogic = logic;
        }

        [HttpGet, Route("{name}")]
        public string getHello([FromRoute] string name)
        {
            businessLogic.Name = name;
            return businessLogic.SayHello();
        }
    }
}
