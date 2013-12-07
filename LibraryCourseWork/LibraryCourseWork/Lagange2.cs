using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    /// <summary>
    /// Класс, который интерполирует полиномом лагранжа для функции двух переменных
    /// </summary>
    public class Lagange2
    {
        /// <summary>
        /// мы задаем области, т.е. прямоугольную сетку значений NxM
        /// </summary>
        private double[] _x;
        private double[] _y;
        //Наши значения в точке f(x[i],y[j]);
        private double[,] _f;
        //n - size(x), m - size(y)
        int n, m;
        public Lagange2(double[] x,double[] y, double[,] f)
        {
            n = x.Length;
            m = y.Length;
            _x = new double[n];
            _y = new double[m];
            _f = new double[n,m];
            if (f.GetLength(0) != n || f.GetLength(1) != m)
                throw new Exception("Не хватает кол-ва значений для узлов, метод Лагранжа не применим");
            for (int i = 0; i < n; ++i)
            {
                _x[i] = x[i];
            }
            for (int i = 0; i < m; ++i)
            {
                _y[i] = y[i];
            }
            for(int i = 0; i<n;++i)
                for (int j = 0; j < m; ++j)
                {
                    _f[i, j] = f[i, j];
                }
            //name = "Лагранж от двух переменных";
        }

        public double Calc(double x0, double y0)
        {
            double lagrange = 0;
            //Для учета первого произведения
            double basicPolynomial = 1;
            for(int i=0;i<n;++i)
                for (int j = 0; j < m; ++j)
                {
                    basicPolynomial = 1;
                    for (int k = 0; k < n; ++k)
                    {
                        for (int t = 0; t < m; ++t)
                        {
                            if ((t == j) || (k == i)) continue;
                            basicPolynomial *= (((x0 - _x[k]) * (y0 - _y[t])) / ((_x[i] - _x[k]) * (_y[j] - _y[t])));
                        }
                    }
                    lagrange += basicPolynomial * _f[i,j];
                }
            return lagrange;
        }
    }
}
