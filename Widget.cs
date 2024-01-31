﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    public class Widget(string name,int width,int heigth,int depth) : NamedItem(name)
    {

        public int WidthInCM => width;
        public int HeightInCM => heigth;
        public int DepthInCM => depth;

        public Widget() : this("N/A", 1, 1, 1) { } //unnamed unit cube

        public int Volume => width * heigth * depth;


    }
}
