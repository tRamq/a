using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifOdev
{
    class Altigen:Shape
    {
        Point[] altigen = new Point[6];
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public Point p4 { get; set; }
        public Point p5 { get; set; }
        public Point p6 { get; set; }
        public override void BitisAta(int bx, int by)
        {
            int dx = Math.Abs(bx/4);
            int dy = Math.Abs(by /3);
            p1 = new Point(x +(2*dx) ,y);
            p2 = new Point(x + dx, y - dy);
            p3 = new Point(x - dx, y - dy);
            p4 = new Point(x -(2 * dx), y );
            p5 = new Point(x - dx, y + dy);
            p6 = new Point(x + dx, y + dy);
            altigen[0] = p1;
            altigen[1] = p2;
            altigen[2] = p3;
            altigen[3] = p4;
            altigen[4] = p5;
            altigen[5] = p6;
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
            ciz.DrawPolygon(Pens.Blue, altigen);
        }
        public override void Ciz(Graphics ciz)
        {
            ciz.FillPolygon(new SolidBrush(Sekilrengi), altigen);
        }
    }
}
