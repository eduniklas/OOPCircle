using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Triangle //Calculate area of triangle.
    {
        public int widht;
        public int hight;

        public void getTriangleInfo()
        {
            float area = widht * hight / 2f;
            Console.WriteLine("Arean på triangeln är: " + area + " cm^2");
            float volym = (widht * widht) * hight / 3f;
            Console.WriteLine("Volymen på pyramid är: " + volym + " cm^3");
        }
    }
}