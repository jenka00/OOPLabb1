using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb1
{
    class Circle
    {

        float pi = 3.141f;
        int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void getArea()
        {
            Console.WriteLine(Radius * Radius * pi);
        }
    }
}
