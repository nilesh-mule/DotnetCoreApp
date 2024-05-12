using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
            
        public string PhoneNumber { get; set; }
            public string EmailConfirmed { get; set; }
    }
}
