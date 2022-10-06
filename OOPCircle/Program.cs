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
            C1.SetRadius(5);
            C1.getArea();
            C1.getVolym();

            Circle C2 = new Circle();
            C2.SetRadius(6);
            C2.getArea();
            C2.getVolym();

            //Set parameters for triangle and get respons.
            Triangle T1 = new Triangle();
            T1.SetWidht(3);
            T1.SetHight(5);
            T1.getTriangleInfo();
        }
    }
}