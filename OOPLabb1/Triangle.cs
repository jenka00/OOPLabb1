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

        public double GetTriangleArea()
        {
           
           double triangleArea = (this.triangleLenght * this.triangleHeight) / 2;
           return triangleArea;
        }
    }
}
