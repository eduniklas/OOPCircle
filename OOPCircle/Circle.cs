﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Circle //Calculate area and volym of circle and orb.
    {
        float pi = 3.141f;
        public int radius;

        public void getArea() 
        {
            float area = radius * radius * pi;
            Console.WriteLine("Arean av cirkeln är: " + Math.Round(area, 3) + " cm^2");
        }
        public void getVolym()
        {
            double volym = 4 * pi * Math.Pow(radius, 3) / 3;
            Console.WriteLine("Volymen på sfären är: " + Math.Round(volym, 3) + " cm^3");
        }
    }
}