using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ContactUsModel
    {
        public string SenderName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
