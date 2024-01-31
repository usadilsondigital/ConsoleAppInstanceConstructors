using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    internal class Circle : Shape
    {
        public Circle(double radius) : base(radius, 0)
        {
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
