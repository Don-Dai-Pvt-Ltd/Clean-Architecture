using Member.Application;
using Microsoft.AspNetCore.Mvc;

namespace Member.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMemberServices _memberServices;

        public MembersController(IMemberServices memberServices)
        {
            _memberServices = memberServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_memberServices.GetAllMembers());
        }
    }
}
