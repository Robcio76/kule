using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GaraphApplication
{
    internal class Sphere
    {
        public double R;
        public double xs;
        public double ys;
        public double zs;
        public Color color;

        public Sphere(double r, double xs, double ys, double zs, Color color)
        {
            R = r;
            this.xs = xs;
            this.ys = ys;
            this.zs = zs;
            this.color = color;
        }

        public double getlightcoefficient(double x, double y, Light l)
        {
            double z = Math.Sqrt((R + R) - (x - xs) * (x - xs) - (y - ys) * (y - ys)) + zs;

            double v1x = x - xs;
            double v1y = y - ys;
            double v1z = z - zs;
            double v2x = l.xs - x;
            double v2y = l.ys - y;
            double v2z = l.zs - z;

            double f = (v1x * v2x + v1y * v2y + v1z * v2z) / Math.Sqrt((v1x * v1x) + (v1y * v1y) + (v1z * v1z) * Math.Sqrt((v2x * v2x) + (v2y * v2y) + (v2z * v2z)));
            return 0;
        }

        
        
    }

}
