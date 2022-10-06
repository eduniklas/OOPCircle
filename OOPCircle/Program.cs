using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Program
    {
        static void Main(string[] args)
        {                               //NET22 Niklas Hagelin
            //Set radius for circle and get respons.
            Circle C1 = new Circle();
            C1.radius = 5;
            C1.getArea();
            C1.getVolym();

            Circle C2 = new Circle();
            C2.radius = 6;
            C2.getArea();
            C2.getVolym();

            //Set parameters for triangle and get respons.
            Triangle T1 = new Triangle();
            T1.widht = 3;
            T1.hight = 5;
            T1.getTriangleInfo();
        }
    }
}