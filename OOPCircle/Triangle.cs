using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Triangle //Calculate area of triangle.
    {
        int _widht;
        int _hight;
        public Triangle(int widht, int hight)
        {
            this._widht = widht;
            this._hight = hight;
            if (widht <= 0)
            {
                throw new Exception("Basen måste vara sörre än 0");
            }
            else if (hight <= 0)
            {
                throw new Exception("Höjden måste vara större än 0");
            }
        }

        public void getTriangleInfo()
        {
            float area = _widht * _hight / 2f;
            Console.WriteLine("Triangeln area är: " + area + " cm^2");
            float volym = (_widht * _widht) * _hight / 3f;
            Console.WriteLine("Pyramidens volym är: " + volym + " cm^3");
        }
    }
}