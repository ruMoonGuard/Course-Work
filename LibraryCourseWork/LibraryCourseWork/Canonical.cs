using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    public class Canonical : Interpolation
    {
        private int n;
        public Canonical(double[] x, double[] y)
        {

            if (x.Length != y.Length)
                throw new System.ArgumentException(
                    "Размер массива точек и размер массива значений в этих точках должны совпадать!");
            _x = new double[x.Length];
            _y = new double[y.Length];
            n = x.Length;
            for (int i = 0; i < x.Length; i++)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }
        }

        public override double Calc(double arg)
        {
            double[,] a = new double[n, n];
            double[,] l = new double[n, n];
            double[,] u = new double[n, n];
            double[] b = new double[n];
            double[] d = new double[n];
            double[] p = new double[n];

            for (int i = 0; i < n; ++i)
                p[i] = _x[i];

            // заполняем матрицу для поиска членов полинома
            for (int i = 0; i < n; ++i)
            {
                a[i, 0] = 1;
                for (int j = 1; j < n; ++j)
                {
                    a[i, j] = Math.Pow(_x[i], j);
                }
            }
            // ищем члены полинома с помощью метода LU-разложения
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    l[i, j] = u[i, j] = 0;
            for (int i = 0; i < n; ++i)
                u[i, i] = 1;

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    u[i, j] = a[i, j];
            for (int i = 0; i < n; ++i)
                for (int j = i; j < n; ++j)
                    l[j, i] = u[j, i] / u[i, i];

            for (int k = 1; k < n; ++k)
            {
                for (int i = k - 1; i < n; ++i)
                    for (int j = i; j < n; ++j)
                        l[j, i] = u[j, i] / u[i, i];
                for (int i = k; i < n; ++i)
                    for (int j = k - 1; j < n; ++j)
                        u[i, j] = u[i, j] - l[i, k - 1] * u[k - 1, j];
            }
            double sum = 0;
            for (int k = 0; k < n; ++k)
            {
                sum = 0;
                for (int j = 0; j < k; ++j)
                    sum += d[j] * l[k, j];
                d[k] = (_y[k] - sum) / l[k, k];
            }

            sum = 0;
            for (int k = 0; k < n; ++k)
            {
                sum = 0;
                for (int j = 0; j < k; ++j)
                    sum += p[n - j - 1] * u[n - k - 1, n - j - 1];
                p[n - k - 1] = (d[n - k - 1] - sum) / u[n - k - 1, n - k - 1];
            }
            //закончили поиск
            //считаем полином
            double sm = 0;
            for (int i = 0; i < n; ++i)
                sm = sm + p[i] * Math.Pow(arg, i);
            return sm;

        }
    }
}
