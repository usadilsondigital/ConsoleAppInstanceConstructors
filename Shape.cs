﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    abstract  class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Shape (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }
}
