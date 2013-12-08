using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    public class Rational : Interpolation
    {
        //Кол-во узлов
        int n;
        //Веса, используемые в барицентрической модели
        double[] _w;

        double sy;

        /// <summary>
        /// Конструктор (с) К.О.
        /// </summary>
        /// <param name="x">Узлы</param>
        /// <param name="y">Значение в конкретном узле</param>
        /// <param name="d">Параметр d задает порядок используемой интерполяционной схемы и, как следствие, её точность.</param>
        public Rational(double[] x, double[] y, int d)
        {

            n = x.Length;
            double s0;
            //Сумма, которая используется в формуле для вычисления весов
            double s;
            //Произведение, которое используется в формуле для вычисления весов
            double v;


            if (d > n - 1)
                d = n - 1;

            /*-------------------*/
            if (n == 1)
            {
                _x = new double[n];
                _y = new double[n];
                _w = new double[n];
                _x[0] = x[0];
                _y[0] = y[0];
                _w[0] = 1;
                //barycentricnormalize(b); WTF?
                return;
            }

            //Заполняем наши узлы и значения, подразумивается, что они расположены по возрастанию.
            _x = new double[n];
            _y = new double[n];
            _w = new double[n];
            for (int i = 0; i < n; ++i)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }

            //Считаем наши веса w по формуле Флоатера-Хорманна
            s0 = 1;
            for (int i = 0; i <= d; ++i)
                s0 = -s0;

            for (int k = 0; k <= n - 1; ++k)
            {
                //
                //Wk
                //
                s = 0;
                for (int i = Math.Max(k - d, 0); i <= Math.Min(k, n - d - 1); ++i)
                {
                    v = 1;
                    for (int j = i; j < i + d; ++j)
                    {
                        if (j != k)
                        {
                            v = v / Math.Abs((_x[k] - x[j]));
                        }
                    }
                    s = s + v;
                }
                _w[k] = s0 * s;

                //Следующий элемент ряда (-1)^i;
                s0 = -s0;
            }

            //
            // Normalize
            //
            //barycentricnormalize(b); wtf? Oo

        }

        public override double Calc(double arg)
        {
            double result = 0;
            double s1 = 0;
            double s2 = 0;
            double v = 0;

            //
            // special case: NaN
            //
            if (Double.IsNaN(arg))
            {
                result = Double.NaN;
                return result;
            }

            //
            // special case: N=1
            //
            if (n == 1)
            {
                result = _y[0];
                return result;
            }
            for (int i = 0; i <n; i++)
            {
                v = _x[i];
                if ((double)(v) == (double)(arg))
                {
                    result = _y[i];
                    return result;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                v = _w[i] / (arg - _x[i]);
                s1 += v * _y[i];
                s2 += v;
            }
            return s1 / s2;
        }
    }
}
