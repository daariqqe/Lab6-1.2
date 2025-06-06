using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public abstract class Solid
    {
        public abstract double GetVolume();
    }
    public class Cube : Solid
    {
        public double A { get; set; }
        public override double GetVolume() => A * A * A;
    }
    public class RectSolid : Solid
    {
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }
        public override double GetVolume() => C * D * H;
    }
}

