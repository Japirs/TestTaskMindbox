using FigureArea.Interfaces;
using System;

namespace FigureArea.Implementation
{

    public class Circle : IFigure 
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Invalid circle radius");
            Radius = radius;
        }
        /// <summary>
        /// Returns the area of a circle given its radius.
        /// ArgumentException if the input radius is less than or equal to zero.
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }

}

