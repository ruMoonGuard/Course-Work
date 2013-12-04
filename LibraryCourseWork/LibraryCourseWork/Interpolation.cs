using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork
{
   /// <summary>
   /// Абстрактный класс, его должны унаследовать все класы интерполяции. Другие переменные находятся в самих классах. 
   /// Все сводится к функции calc.
   /// </summary>
    public abstract class Interpolation
    {
        protected double[] _x;
        protected double[] _y;
        //Хранит имя интерполяции, необходимо заполнять в конструкторе при создании. Не передавать параметров в конструктор.
        //Нужен для удобства вывода графиков, что в ручную имена не задавать.
        public string name;

        /// <summary>
        /// Метод, который считает значение в полученной точке для конкретного алгоритма интерполяции.
        /// </summary>
        /// <param name="arg">Наша точка. \n Примечание: Это не та точка, которая нам известна в начале задания!</param>
        /// <returns>Значение в точке</returns>
        public abstract double Calc(double arg);

       public double[] GetX()
       {
           return _x;
       }

       public double[] GetY()
       {
           return _y;
       }
        
    }
}
