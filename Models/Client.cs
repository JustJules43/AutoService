using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Models
{
    public class Client
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [RegularExpression(@"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")]
        [StringLength(40)]
        public string Email { get; set; }
        [RegularExpression(@"^[0-9]+[0-9""'\s-]*$")]
        [StringLength(20)]
        [Required]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
    }
}
