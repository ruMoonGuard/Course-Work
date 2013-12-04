using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
    public class CubicSpline : Interpolation
    {
        //Число отрезков, их значение будет на 1 меньше, чем число узлов.
        private int n;
        //Переменные при функции
        //a = y;
        private double[] a, b, c, d;
        //Для хранения предыдущего и следующего шага
        private double[] h, l;

        public CubicSpline(double[] x, double[] y)
        {
            n = x.Length-1;
            _x = new double[n+1];
            _y = new double[n+1];
            for (int i = 0; i < n+1; i++)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }
            a = new double[n + 1];
            b = new double[n + 1];
            c = new double[n + 1];
            d = new double[n + 1];

            h = new double[n + 1];
            l = new double[n + 1];

            name = "Кубический сплайн";
            //Построение сплайна (определение коэф-ов на каждом интервале)
            BuldingSpline();
        }

        private void BuldingSpline()
        {
            double[] delta = new double[n+1];
            double[] lambda = new double[n+1];
            for (int i = 1; i < n+1; i++)
            {
                h[i] = _x[i] - _x[i - 1];
                if (h[i] == 0)
                {
                    throw new Exception("Ошибка: шаг не должен быть равен 0, т.е. совпадает значение х");
                }
                l[i] = (_y[i] - _y[i - 1])/h[i];
            }
            //Прямой метод прогонки - вычисляем коэф. прогонки
            delta[1] = -h[2] / (2 * (h[1] + h[2]));
            lambda[1] = 1.5 * (l[2] - l[1]) / (h[1] + h[2]);

            for (int k = 3; k <= n; k++)
            {
                delta[k - 1] = -h[k] / (2 * h[k - 1] + 2 * h[k] + h[k - 1] * delta[k - 2]);
                lambda[k - 1] = (3 * l[k] - 3 * l[k - 1] - h[k - 1] * lambda[k - 2]) /
                      (2 * h[k - 1] + 2 * h[k] + h[k - 1] * delta[k - 2]);
            }

            c[0] = 0;
            c[n] = 0;
            //Обратных ход прогонки(вычисляем с)
            for (int k = n; k >= 2; k--)
            {
                c[k - 1] = delta[k - 1] * c[k] + lambda[k - 1];
            }
            //вычисляем другие коэф.
            for (int k = 1; k <= n; k++)
            {
                d[k] = (c[k] - c[k - 1]) / (3 * h[k]);
                b[k] = l[k] + (2 * c[k] * h[k] + h[k] * c[k - 1]) / 3;
            }
        }

        public override double Calc(double arg)
        {
            double start = _x[0];
            double end = _x[n];
            int k = 0;

            //Ищем какому интервалу принадлежит наша точка
            for (k = 1; k < n+1; k++)
            {
                if (arg >= _x[k - 1] && arg <= _x[k])
                {
                    break;
                }
            }
            double F = _y[k] + b[k] * (arg - _x[k]) + c[k] * Math.Pow(arg - _x[k], 2) + d[k] * Math.Pow(arg - _x[k], 3);
            return F;
        }

        //Получение коэф. а,б,ц,д
        public double[] getValues(int i)
        {
            double[] values = new double[4];
            values[0] = _y[i];
            values[1] = b[i];
            values[2] = c[i];
            values[3] = d[i];
            return values;
        }
        #region

        /*
        int n;
        //Коэфициенты сетки в каждом узле
        double[,] Coef;
        double[] b;

        public CubicSpline(double[] x, double[] y)
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
            name = "Кубический сплайн";
        }

        public override double Calc(double arg)
        {
            if (Coef == null)
                BuildSpline();
            double start = _x[0];
            double end = _x[_x.Length-1];
            double step = (end - start) / 20;
            int i = 0;
            
            /*
            while (_x[i] < arg)
                i++;
            i--;
            double[] s = new double[4];
            if (arg < _x[0])// Если x меньше точки сетки x[0] - пользуемся первым эл-тов массива
                for (int j = 0; j < 4; j++)
                {
                    s[j] = Coef[0, j];
                    i = 0;
                }
            else if (arg > _x[_x.Length - 1])
                for (int j = 0; j < 4; j++)
                {
                    s[j] = Coef[n - 1, j];
                    i = n - 1;
                }
            else // Иначе x лежит между граничными точками сетки - производим бинарный поиск нужного эл-та массива
            {
                
                while (_x[i] < arg)
                    i++;
                i--;
                for (int j = 0; j < 4; j++)
                {
                    s[j] = Coef[i, j];
                }
            }
            double F = s[0] + s[1] * (arg - _x[i]) + s[2] * Math.Pow((arg - _x[i]), 2) + s[3] * Math.Pow((arg - _x[i]), 3);
            return F; 
        }

        // Решение СЛАУ относительно коэффициентов сплайнов c[i] методом прогонки для трехдиагональных матриц
        private void SolveTriDiag(double[,] TDM, double[] F)
        {
            double[] alph = new double[n - 1];
            double[] beta = new double[n - 1];

            int i;

            alph[0] = -TDM[0,2] / TDM[0,1];
            beta[0] = F[0] / TDM[0,1];

            for (i = 1; i < n - 1; i++)
            {
                alph[i] = -TDM[2,i] / (TDM[i,1] + TDM[i,0] * alph[i - 1]);
                beta[i] = (F[i] - TDM[i,0] * beta[i - 1]) / (TDM[i,1] + TDM[i,0] * alph[i - 1]);
            }
            b[n - 1] = (F[n - 1] - TDM[n-1,0] * beta[n - 2]) / (TDM[n-1,1] + TDM[n-1,0] * alph[n - 2]);

            for (i = n - 2; i > -1; i--)
            {
                b[i] = b[i + 1] * alph[i] + beta[i];
            }
        }

        //Построение таблицы коэффициентов кубического сплайна
        private void BuildSpline()
        {
            n = _x.Length;
            double[] a = new double[n - 1];
            double[] c = new double[n - 1];
            double[] d = new double[n - 1];
            double[] delta = new double[n - 1];
            double[] h = new double[n - 1];
            double[,] TriDiagMatrix = new double[n,3];

            b = new double[n];
            double[] f = new double[n];
            double x3, xn;
            int i;
            if (n < 3)
                throw new Exception("Нужно больше золота(кол-во элементов)");

            x3 = _x[2] - _x[0];
            xn = _x[n - 1] - _x[n - 3];
            for (i = 0; i < n - 1; i++)
            {
                a[i] = _y[i];
                h[i] = _x[i + 1] - _x[i];
                delta[i] = (_y[i + 1] - _y[i])/h[i];
                TriDiagMatrix[i,0] = i > 0 ? h[i] : x3;
                f[i] = i > 0 ? 3 * (h[i] * delta[i - 1] + h[i - 1] * delta[i]) : 0;
            }

            TriDiagMatrix[0,1] = h[0];
            TriDiagMatrix[0,2] = h[0];
            for (i = 1; i < n - 1; i++)
            {
                TriDiagMatrix[i,1] = 2 * (h[i] + h[i - 1]);
                TriDiagMatrix[i,2] = h[i];
            }
            TriDiagMatrix[n-1,1] = h[n - 2];
            TriDiagMatrix[n-1,2] = xn;
            TriDiagMatrix[n-1,0] = h[n - 2];

            i = n - 1;
            f[0] = ((h[0] + 2 * x3) * h[1] * delta[0] + Math.Pow(h[0], 2) * delta[1]) / x3;
            f[n - 1] = (Math.Pow(h[i - 1], 2) * delta[i - 2] + (2 * xn + h[i - 1]) * h[i - 2] * delta[i - 1]) / xn;

            SolveTriDiag(TriDiagMatrix, f);

            Coef = new double[n-1,4];
            int j;
            for (j = 0; j < n - 1; j++)
            {
                d[j] = (b[j + 1] + b[j] - 2 * delta[j]) / (h[j] * h[j]);
                c[j] = 2 * (delta[j] - b[j]) / h[j] - (b[j + 1] - delta[j]) / h[j];

                Coef[j,0] = a[j];
                Coef[j,1] = b[j];
                Coef[j,2] = c[j];
                Coef[j,3] = d[j];
            }
        }
        //Получение коэф. на конкретном отрезке сплайна
        public double[] getValues(int i)
        {
            double[] values = new double[4];
            for (int j = 0; j < 4; ++j)
                values[j] = Coef[i, j];
            return values;
        }*/

        #endregion
    }
}
