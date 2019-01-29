
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class YetkiKisi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YetkiKisiID { get; set; }
        public string YetkiAd { get; set; }
        public virtual ICollection<Uye> Uye { get; set; }
    }
}