using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifOdev
{
    class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public Color Sekilrengi { get; set; }
        public virtual void BitisAta(int bx, int by) { }
        public virtual void Ciz(Graphics ciz) { }
        public virtual bool Icindemi(int x, int y)
        {
            return false;
        }
        public virtual void SinirCiz(Graphics ciz) { }
    }
}
