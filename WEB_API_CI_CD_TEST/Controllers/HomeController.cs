using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API_CI_CD_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("/getUserName")]
        public String UserName()
        {


           

            return "Muhammad Abu Yousof";

        }
    }
}
