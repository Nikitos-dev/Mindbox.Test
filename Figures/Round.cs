using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Round : Figure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// Круг.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Round(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException(nameof(radius), "Радиус не может быть отрицательным");
            }
            Radius = radius;
        }
        /// <summary>
        /// Вычисление площади круга.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Perimeter() * Perimeter() / (4 * Math.PI);
        }
        /// <summary>
        /// Вычисление периметра (длины окружности).
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return (Radius * 2 * Math.PI);
        }
    }
}
