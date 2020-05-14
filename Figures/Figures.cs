using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        /// <summary>
        /// Вычисление периметра.
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();
        /// <summary>
        /// Вычисление площади.
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
    }
}
