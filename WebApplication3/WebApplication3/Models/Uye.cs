using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Uye
    {
       
        public int UyeID { get; set; }
        public int UniversiteID { get; set; }
        public int KonaklamaID { get; set; }
        public int IsImkanlariID { get; set; }
        public int YetkiKisiID { get; set; }
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
        //seed bolumunu kontrol et yanlısın orda
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string SifreTekrarı { get; set; }

        public virtual Universite Universite { get; set; }
        public virtual Konaklama Konaklama { get; set; }
        public virtual IsImkanlari Imkanlari { get; set; }
        public virtual YetkiKisi YetkiKisi { get; set; }
    }
}