using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindbox
{
    public class Triangle : IAreaCalculatable
    {
        private double a, b, c; // длины сторон треугольника

        /// <summary>
        /// Длина первой стороны треугольника
        /// </summary>
        public double A
        {
            get => a;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(A), "Длина стороны треугольника должна быть больше 0");

                a = value;
            }
        }

        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(B), "Длина стороны треугольника должна быть больше 0");

                b = value;
            }
        }

        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(C), "Длина стороны треугольника должна быть больше 0");

                c = value;
            }
        }

        /// <summary>
        /// Создаёт новый треугольник по заданным сторонам
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            if (!(this.CalculateArea() > 0))
                throw new ArgumentException("Неправильные значения сторон треугольника");
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double p = (a + b + c) / 2; // полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Обозначает, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle
        {
            get
            {
                List<double> sides = new List<double>() { a, b, c };
                sides.Sort(); // поиск гипотенузы (самой длинной стороны)
                double hypotenuse = sides[2];
                double katet1 = sides[1];
                double katet2 = sides[0];

                return Math.Abs(Math.Pow(hypotenuse, 2) - Math.Pow(katet1, 2) - Math.Pow(katet2, 2)) < double.Epsilon;
            }
        }
    }
}
