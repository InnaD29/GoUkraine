using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ContactUsModel
    {
        public string SenderName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
