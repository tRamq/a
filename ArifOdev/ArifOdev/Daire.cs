using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifOdev
{
    class Daire:Shape
    {
        private int yari_cap;
        public override void BitisAta(int bx, int by)
        {
            yari_cap = bx - x;
        } 
        public override void Ciz(Graphics ciz)
        {
            ciz.FillEllipse(new SolidBrush(Sekilrengi), x, y, yari_cap, yari_cap);
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawRectangle(Pens.Blue, x, y, yari_cap, yari_cap);
        }
        public override bool Icindemi(int x, int y)
        {
            int dx = Math.Abs(yari_cap + x);
            int dy = Math.Abs(yari_cap + y);
            int b = Math.Abs(dx - yari_cap);
            double a = Math.Abs(Math.Sqrt((dx * dx) + (dy * dy) - yari_cap));
            if (this.yari_cap + a >= yari_cap && this.yari_cap + b >= yari_cap && this.x <= x && this.y <= y)
            {
                return true;
            }
            return false;
        }
    }
}