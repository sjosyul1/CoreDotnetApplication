using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Edgenuity.Models
{
    public class EmployeeUser
    {
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string EmailID { get; set; }
        public string UserID { get; set; }
    }
}
