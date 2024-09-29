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

        [HttpGet("getAllMembers")]
        public IActionResult GetAllMembers()
        {
            return Ok(_memberServices.GetAllMembers());
        }

        [HttpGet("getMemberById")]
        public IActionResult GetMemberById(int id)
        {
            return Ok(_memberServices.GetMemberById(id));
        }
        [HttpPost("addMember")]
        public IActionResult AddMember(Domain.Member member)
        {
            return Ok(_memberServices.AddMembers(member));
        }
        [HttpDelete("deleteMember")]
        public IActionResult DeleteMember(int id)
        {
            _memberServices.RemoveMembers(id);
            return Ok("Member Deleted Successfully");
        }
        [HttpPut("updateMember")]
        public IActionResult EditMember(int oldId, Domain.Member member)
        {
            return Ok(_memberServices.EditMembers(oldId, member));
        }
    }
}
