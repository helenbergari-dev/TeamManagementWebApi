using Microsoft.AspNetCore.Mvc;
using TeamManagementWebApi.Models;

namespace TeamManagementWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvitationsController : ControllerBase
    {
        private static List<Invitation> invitations = new List<Invitation>
        {
            new Invitation
            {
                Id = 1,
                Email = "samantha@gmail.com",
                Status = "Pending"
            }
        };

        [HttpGet]
        public IActionResult GetInvitations()
        {
            return Ok(invitations);
        }

        [HttpPost]
        public IActionResult AddInvitation(Invitation newInvitation)
        {
            invitations.Add(newInvitation);

            return Ok(newInvitation);
        }
    }
}