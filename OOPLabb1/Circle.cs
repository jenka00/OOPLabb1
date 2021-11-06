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

        public double getArea()
        {
            double circleArea = Radius * Radius * pi;
            return circleArea;
        }

        public double getCircumference()
        {
            double circleCircum = (2 * Radius) * pi;
            return circleCircum;
        }

        public double getVolume()
        {
            double circleVol = ((4 * pi * Math.Pow(Radius, 3)) / 3) / 1000;
            return circleVol;
            
        }
    }
}
