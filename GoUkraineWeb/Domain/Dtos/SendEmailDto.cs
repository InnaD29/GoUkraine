using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class SendEmailDto
    {
        [DisplayName("Sender name")]
        public string SenderName { get; set; }
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}
