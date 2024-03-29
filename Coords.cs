﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    internal class Coords
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Coords(int x , int y)
        {
            X = x;
            Y = y;
        }


        public Coords() : this(0, 0) { }

        //override ToString to show coordinates
        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
