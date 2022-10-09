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
            Circle C1 = new Circle(5);
            Circle C2 = new Circle(6);

            C1.getArea();
            C1.getVolym();

            C2.getArea();
            C2.getVolym();

            //Set parameters for triangle and get respons.
            Triangle T1 = new Triangle(15,25);
            T1.getTriangleInfo();
        }
    }
}