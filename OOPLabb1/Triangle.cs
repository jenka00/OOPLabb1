using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb1
{
    class Triangle
    {
        public double triangleHeight;

        public double triangleLenght;

        public Triangle(double TriangleHeight, double TriangleLeght)
        {
            this.triangleHeight = TriangleHeight;
            this.triangleLenght = TriangleLeght;
        }

        public void GetTriangleArea()
        {
           
            Console.WriteLine("Triangelns area är {0:f2} cm^2", (this.triangleLenght * this.triangleHeight) / 2);
        }
    }
}
