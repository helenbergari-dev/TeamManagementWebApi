using Microsoft.AspNetCore.Mvc;
using TeamManagementWebApi.Models;

namespace TeamManagementWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamMembersController : ControllerBase
    {
        private static List<TeamMember> teamMembers = new List<TeamMember>
        {
            new TeamMember
            {
                Id = 1,
                Name = "Samantha William",
                Email = "samantha@gmail.com",
                Role = "Student"
            },
            new TeamMember
            {
                Id = 2,
                Name = "Adam Smith",
                Email = "adamsmith@gmail.com",
                Role = "Student"
            }
        };

        [HttpGet]
        public IActionResult GetTeamMembers()
        {
            return Ok(teamMembers);
        }

        [HttpPost]
        public IActionResult AddTeamMember(TeamMember newMember)
        {
            teamMembers.Add(newMember);

            return Ok(newMember);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            var member = teamMembers.FirstOrDefault(x => x.Id == id);

            if (member == null)
            {
                return NotFound();
            }

            teamMembers.Remove(member);

            return Ok(member);
        }
    }
}