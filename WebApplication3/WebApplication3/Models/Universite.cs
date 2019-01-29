using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Universite
    {
        public int UniversiteID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage ="Boş Kalamaz")]
        public string Ad { get; set; }
        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Boş Kalamaz")]
        public string Sehirler { get; set; }
        [StringLength(25, MinimumLength = 3)]
        public string Bolum { get; set; } 
        public virtual ICollection<Uye> uye { get; set; }

    }
}