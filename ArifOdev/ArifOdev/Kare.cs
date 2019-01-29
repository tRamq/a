using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifOdev
{
    
    class Kare:Shape
    {
        
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if(value<0)
                {
                    value = 0;
                }
                else if(value>0&&value<100)
                {
                    value = width;
                }
            }
        }
        public Kare()
        {
            width = 0;
        }
        public override void BitisAta(int bx, int by)
        {
            width = bx - x;
        }
        public override bool Icindemi(int x, int y)
        {
            if (this.x+width >= x && this.y+width >=y && this.x <= x && this.y <= y)
            {
                return true;
            }
            return false;
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillRectangle(new SolidBrush(Sekilrengi), x, y, Width, Width);
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawRectangle(Pens.Blue, x, y, Width, Width);
        }
    }
}
