namespace Unadesk
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public sealed class Triangle
    {
        /// <summary>
        /// Параметризированный конструктор.
        /// </summary>
        /// <param name="a">Длина стороны a.</param>
        /// <param name="b">Длина стороны b.</param>
        /// <param name="c">Длина стороны c.</param>
        public Triangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c)
            {
                A = a; B = b; C = c;
            }
            else throw new InvalidOperationException();
        }



        /// <summary>
        /// Длина стороны a.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Длина стороны b.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Длина стороны c.
        /// </summary>
        public double C { get; }


        /// <summary>
        /// Тип треугольника.
        /// </summary>
        public TriangleType Type
        {
            get
            {
                var angles = CountAngles();

                if (angles.Any(angle => angle == 90))
                    return TriangleType.Right;
                else if (angles.Any(angle => angle > 90))
                    return TriangleType.Obtuse;
                else
                    return TriangleType.Acute;
            }
        }



        /// <summary>
        /// Рассчитывает величину углов по длинам сторон.
        /// </summary>
        /// <returns>Массив: величины трех углов треугольника.</returns>
        private double[] CountAngles()
        {
            double alpha = CountAngle(A, B, C);
            double beta = CountAngle(B, A, C);
            double gamma = CountAngle(C, A, B);

            return new double[] { alpha, beta, gamma };
        }


        /// <summary>
        /// Рассчитывает величину угла по длинам сторон.
        /// </summary>
        /// <param name="y">Длина стороны противоположной углу.</param>
        /// <param name="x1">Длина первой смежной с углом стороны.</param>
        /// <param name="x2">Длина второй смежной с углом стороны.</param>
        /// <returns>Величина угла.</returns>
        private static double CountAngle(double y, double x1, double x2) =>
            Math.Acos((Math.Pow(x1, 2) + Math.Pow(x2, 2) - Math.Pow(y, 2)) / (2 * x1 * x2)) * 180 / Math.PI;
    }
}