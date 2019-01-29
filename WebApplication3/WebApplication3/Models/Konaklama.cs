using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Konaklama
    {
        public int KonaklamaID { get; set; }
        [Required(ErrorMessage = "Boş Kalamaz")]
        [StringLength(50, MinimumLength = 3)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Boş Kalamaz")]
        [StringLength(15, MinimumLength = 3)]
        public string Sehirler { get; set; }
        public double Fiyat { get; set; }
        [Display(Name = "Yurt / Ev")]
        public string YurtmuEvmi { get; set; }
        [Display(Name = "Yakın / Uzak")]
        public double? YakinlikUzaklik { get; set; }
        [Display(Name = "Kız / Erkek")]
        public string KızmıErkek { get; set; }
        [Display(Name = "Kisi Sayısı")]
        public int? KisiSayısı { get; set; }
        [Display(Name = "Kaç Odalı")]
        public int? Kaçoda  { get; set; }
        public virtual ICollection<Uye> uye { get; set; }
    }
}