using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Uyeler
    {
        [Key]
        public int UyeID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [Display(Name = "Gidilecek Sehir")]
        public string GidilecekSehir { get; set; }
        [Required]
        [Display(Name = "Gidilecek Üniversite")]
        public string GidilecekUniversite { get; set; }
        [Required]
        public string Bolum { get; set; }
        [Required]
        [Display(Name = "İs İmkani")]
        public string IsImkani { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string SifreTekrarı { get; set; }
        public bool Admin { get; set; }
    }
}