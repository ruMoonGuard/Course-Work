using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    /// <summary>
    /// Интерполяция полиномом ньютона
    /// </summary>
    public class Newton : Interpolation
    {
        private double[] _coef;

        public Newton(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                throw new System.ArgumentException(
                    "Размер массива точек и размер массива значений в этих точках должны совпадать!");
            _x = new double[x.Length];
            _y = new double[y.Length];
            _coef = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }
            _coef = coeffs();
            name = "Ньютон";
        }

        /**
         * Я не знаю, кем надо быть, чтобы суметь объяснить работу
         * Ньютоновского полинома вот так вот, текстом.
         * Короче, надо создать такой вот массив коэффициентов, чтобы потом
         * юзать его в методе calc - см. ниже
         * По умному такая штука называется - разделенные разности
         **/
        private double[] coeffs()
        {
            double[] k = new double[_x.Length];
            k[0] = _y[0];
            for (int j = 1; j < k.Length; j++)
            {
                for (int i = 0; i < k.Length - j; i++)
                {
                    _y[i] = (_y[i + 1] - _y[i]) / (_x[i + j] - _x[i]);
                    k[j] = _y[0];
                }
            }
            return k;
        }

        public override double Calc(double argx)
        {
            double[] k = new double[_x.Length];
            k = _coef;//Верю, что он побайтово копирует весь массив без всяких магических проблем. Необходим, что бы занова каждый раз не считать коэф.
            /**
	         * argx  - это та точка, в которой мы хотим
	         * посчитать значение "загаданной функции"
             **/
            double S = k[0];
            double p = 1;
            for (int i = 1; i < _x.Length; i++)
            {
                p *= (argx - _x[i - 1]);
                S += k[i] * p;
            }
            return S;
        }
    }
}
