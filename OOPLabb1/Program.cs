using System;

namespace OOPLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);

            Circle secondCircle = new Circle(6);

            Console.WriteLine($"Första cirkelns area är {firstCircle.getArea():f2} cm^2");

            Console.WriteLine($"Första cirkelns omkrets är {firstCircle.getCircumference():f2} cm");

            Console.WriteLine($"Första sfärens volym är {firstCircle.getVolume():f2} l");

            Console.WriteLine($"Andra cirkelns area är {secondCircle.getArea():f2} cm^2");

            Console.WriteLine($"Andra cirkelns omkrets är {secondCircle.getCircumference():f2} cm");

            Console.WriteLine($"Andra sfärens volym är {secondCircle.getVolume():f2} l");

            Triangle firstTriangle = new Triangle(5, 10);

            Console.WriteLine($"Triangelns area är {firstTriangle.GetTriangleArea():f2} cm^2");
        }

    }
}
