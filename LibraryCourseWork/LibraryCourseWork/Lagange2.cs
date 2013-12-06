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
        /// Тут теперь все хитрее, нам нужно не просто трехмерное про-во
        /// А мы задаем области, т.е. прямоугольную сетку значений NxM
        /// </summary>
        private double[,] x;
        private double[,] y;
        public Lagange2(double[,] X,double[,] Y)
        {
            x = new double[X.GetLength(0), X.GetLength(1)];
            y = new double[X.GetLength(0), X.GetLength(1)];
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    x[i,j]= X[i,j];
                    y[i, j] = Y[i, j];
                }
            }
            //name = "Лагранж от двух переменных";
        }

        public double Calc(double x0,double y0)
        {
            int n = x.GetLength(0);
            int m = x.GetLength(1);
            //Сюда мы будем заносить одну строку массива
            double[] str = new double[m];
            //Сюда мы будем записывать значение для каждого узла в строчке
            double[] str2 = new double[m];
            //Массив для интерполяции по У
            double[] tmp = new double[n];
            /*Интерполяция по X*/
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    str[j] = x[i, j];
                    str2[j] = y[i,j];
                }
                Lagrange lg = new Lagrange(str, str2);
                tmp[i] = lg.Calc(x0);
            }
            /*Интерполяция по Y*/
            Lagrange lg2 = new Lagrange(str, tmp);
            return lg2.Calc(y0);
        }
    }
}
