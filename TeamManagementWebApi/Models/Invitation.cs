namespace TeamManagementWebApi.Models
{
    public class Invitation
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string Status { get; set; } = null!;
    }
}