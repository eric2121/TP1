using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TP_1.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage="Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@".*@.*", ErrorMessage="Must be a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Comments { get; set; }
    }
}