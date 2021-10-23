using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb1
{
    class Circle
    {

        float pi = 3.141f;
        double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void getArea()
        {
            Console.WriteLine("Cirkelns area är {0 :f2} cm^2", Radius * Radius * pi);
        }

        public void getCircumference()
        {
            Console.WriteLine("Cirkelns omkrets är {0:f2} cm", (2 * Radius) * pi);
        }

        public void getVolume()
        {
            Console.WriteLine("Sfärens volym är {0:f2} l.", ((4 * pi * Math.Pow(Radius, 3)) / 3)/1000);
        }
    }
}
