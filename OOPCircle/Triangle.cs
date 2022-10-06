using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCircle
{
    class Triangle //Calculate area of triangle.
    {
        int _widht;
        int _hight;

        public void getTriangleInfo()
        {
            float area = _widht * _hight / 2f;
            Console.WriteLine("Arean på triangeln är: " + area + " cm^2");
            float volym = (_widht * _widht) * _hight / 3f;
            Console.WriteLine("Volymen på pyramid är: " + volym + " cm^3");
        }
        public int SetWidht(int widht)
        {
            this._widht = widht;
            return _widht;
        }
        public int SetHight(int hight)
        {
            this._hight = hight;
            return _hight;
        }
    }
}