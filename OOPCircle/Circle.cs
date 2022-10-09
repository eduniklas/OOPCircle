using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Circle //Calculate area and volym of circle and orb.
    {
        const float pi = 3.141f;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
            if (_radius <= 0)
            {
                throw new Exception("Radien måste vara större än 0");
            }
        }
        public void getArea()
        {
            float area = _radius * _radius * pi;
            Console.WriteLine("Cirkelns area är: " + (float)Math.Round(area, 2) + " cm^2");
        }
        public void getVolym()
        {
            float volym = 4 * pi * (float)Math.Pow(_radius, 3) / 3; //read
            Console.WriteLine("Sfärens volym är: " + (float)Math.Round(volym, 3) + " cm^3");
        }
    }
}