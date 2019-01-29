using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifOdev
{
    class Ucgen:Shape
    {
        Point[] ucgen = new Point[3];
        
       public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public override void  BitisAta(int bx, int by)
        {
            int dx = Math.Abs(bx - x);
            int dy = Math.Abs(by - y);
            p1 = new Point(x, y);
            p2 = new Point(bx, by);
            p3 = new Point(x - dx, y + dy);
            ucgen[0] = p1;
            ucgen[1] = p2;
            ucgen[2] = p3;
        }
       
        public override bool Icindemi(int x, int y)
        {

            if (this.x < x && this.y < y && this.x < x && this.y < y)
            {
                return true;
            }
            return false;
        }
        public override void SinirCiz(Graphics ciz)
        {
            ciz.DrawPolygon(Pens.Blue, ucgen);
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillPolygon(new SolidBrush(Sekilrengi),ucgen);
        }
    }
}
