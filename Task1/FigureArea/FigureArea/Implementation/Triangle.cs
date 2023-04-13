using FigureArea.Interfaces;
using System;

namespace FigureArea.Implementation
{

    public class Triangle : ITriangle 
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <=0 || sideC <= 0)
                throw new ArgumentException("The side of the triangle cannot be less than/equal to zero");
            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
                throw new ArgumentException("The triangle with such sides does not exist.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        /// <summary>
        /// Returns the area of a triangle given three sides.
        /// ArgumentException if one of the sides is less than or equal to zero or a triangle with such sides does not exist.
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return square;
        }
        /// <summary>
        /// Returns true if triangle is right triangle.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (Math.Pow(SideA, 2) == (Math.Pow(SideB, 2) + Math.Pow(SideC, 2)))
                return true;
            if (Math.Pow(SideB, 2) == (Math.Pow(SideA, 2) + Math.Pow(SideC, 2)))
                return true;
            if (Math.Pow(SideC, 2) == (Math.Pow(SideA, 2) + Math.Pow(SideB, 2)))
                return true;
            return false;
        }
    }

}

