using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Models
{
    public class Car
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Marka")]
        public string Brand { get; set; }
        [StringLength(60)]
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data produkcji")]
        public DateTime ProductionDate { get; set; }
        [StringLength(20)]
        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "ID klienta")]
        public int ClientId { get; set; }
    }
}
