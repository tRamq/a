using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
  public enum Bolumler
    {
        BilgisayarMühendisliği,SiberGüvenlik,ElektrikElektronikMühendisliği, EndüstriMühendisliği, İnşaatMühendisliği, MakinaMühendisliği,TıpFakültesi,İşletme,iktisat
    }
    public class IsImkanlari
    {
        public int IsImkanlariID { get; set; }
        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Boş Kalamaz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Boş Kalamaz")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Sirket İsmi")]
        public string SirketIsmi { get; set; }
        public Bolumler? Bolum { get; set; }
        public virtual ICollection<Uye> uye { get; set; }
        

    }
}