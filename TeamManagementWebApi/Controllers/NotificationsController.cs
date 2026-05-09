using Microsoft.AspNetCore.Mvc;
using TeamManagementWebApi.Models;

namespace TeamManagementWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private static List<Notification> notifications = new List<Notification>
        {
            new Notification
            {
                Id = 1,
                Title = "Invitation sent",
                Message = "Your invitation was sent successfully.",
                IsRead = false
            },
            new Notification
            {
                Id = 2,
                Title = "New team member",
                Message = "Adam Smith joined the team.",
                IsRead = false
            }
        };

        [HttpGet]
        public IActionResult GetNotifications()
        {
            return Ok(notifications);
        }

        [HttpPut("{id}/read")]
        public IActionResult MarkAsRead(int id)
        {
            var notification = notifications.FirstOrDefault(x => x.Id == id);

            if (notification == null)
            {
                return NotFound();
            }

            notification.IsRead = true;

            return Ok(notification);
        }
    }
}