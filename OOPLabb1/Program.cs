using System;

namespace OOPLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);

            Circle secondCircle = new Circle(6);

            firstCircle.getArea();

            secondCircle.getArea();
        }
    }
}
