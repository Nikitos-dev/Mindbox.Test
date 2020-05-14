using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double SideA { get; set; }
        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SideB { get; set; }
        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double SideC { get; set; }
        /// <summary>
        /// Треугольник.
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("стороны не могут быть отрицательными");
            }
            SideA = a;
            SideB = b;
            SideC = c;
        }
        /// <summary>
        /// Определение, является ли труегольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double hypothenuse = new List<double> { SideA, SideB, SideC }.Max();
            double hypothenusesqrt = hypothenuse * hypothenuse;
            return hypothenusesqrt + hypothenusesqrt == SideA * SideA + SideB * SideB + SideC * SideC;
        }
        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.Sqrt((Perimeter() / 2 * (Perimeter() / 2 - SideA) * (Perimeter() / 2 - SideB) * (Perimeter() / 2 - SideC)));
        }
        /// <summary>
        /// Вычисление периметра треугольника.
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
