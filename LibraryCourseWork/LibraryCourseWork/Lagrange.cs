using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    public class Lagrange : Interpolation
    {
        public Lagrange(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                throw new System.ArgumentException(
                    "Размер массива точек и размер массива значений в этих точках должны совпадать!");
            _x = new double[x.Length];
            _y = new double[y.Length];
            for (int i = 0; i < x.Length; i++)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }
            name = "Лагранж";
        }

        public override double Calc(double argx)
        {
            //L[i](x) = sum(y[i]*l[i]), i=(0:n), l[i] - базисный полином, n - степень полинома, где на вход n+1 точек.
            double lagrange = 0;
            double basicPolynomial = 1;
            for (int i = 0; i < _x.Length; i++)
            {
                basicPolynomial = 1;
                for (int j = 0; j < _x.Length; j++)
                {
                    //В противном случаи у нас получится деление на 0, что матушка математика делать запрещает.
                    if (i != j)
                        basicPolynomial *= (argx - _x[j]) / (_x[i] - _x[j]);
                }
                lagrange += basicPolynomial * _y[i];
            }
            return lagrange;
        }
    }
}
