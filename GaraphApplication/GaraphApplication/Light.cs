using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraphApplication
{
    internal class Light
    {
        public double xs;
        public double ys;
        public double zs;
        public Color color;

        public Light(double xs, double ys, double zs, Color color)
        {
            this.xs = xs;
            this.ys = ys;
            this.zs = zs;
            this.color = color;
        }
    }
}
