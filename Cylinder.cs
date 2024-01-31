using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    internal class Cylinder : Circle
    {
        public Cylinder(double radius,double height) : base(radius)
        {
            y = height;
        }

        public override double Area()
        {
            return (2*base.Area())+(2*pi*x*y);
        }
    }
}
