using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Circle //Calculate area and volym of circle and orb.
    {
        const float pi = 3.141f;
        private int _radius;

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
            Console.WriteLine("Cirkelns area är: " + (float)Math.Round(area,2) + " cm^2");
        }
        public void getVolym()
        {
            float volym = 4 * pi * (float)Math.Pow(_radius, 3) / 3; //read
            Console.WriteLine("Sfärens volym är: " + (float)Math.Round(volym,3) + " cm^3");
        }
    }



















    //public Circle(int radius)
    //{
    //    this._radius = radius;
    //    Console.WriteLine("Arean av cirkeln är: " + getArea(_area) + " cm^2");
    //}
    //public float getArea(float radius) 
    //{
    //    float area = _radius * _radius * pi;
    //    this._area = (float)Math.Round(area, 3);
    //    return _area;
    //}
    //public void getVolym()
    //{
    //    double volym = 4 * pi * Math.Pow(_radius, 3) / 3;
    //    Console.WriteLine("Volymen på sfären är: " + Math.Round(volym, 3) + " cm^3");
    //}
}