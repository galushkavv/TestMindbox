using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindbox
{
    public class Circle : IAreaCalculatable
    {
        private double r;

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius
        {
            get => r;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Радиус круга должен быть больше 0");
                }
                r = value;
            }
        }

        /// <summary>
        /// Создаёт новый круг с заданным радиусом
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius) =>
            this.Radius = radius;


        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Значение площади</returns>
        public double CalculateArea() =>
            Math.PI * Math.Pow(Radius, 2);
    }
}
