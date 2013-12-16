using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// thanks to http://dmpeli.math.mcmaster.ca/Matlab/Math1J03/LectureNotes/Lecture3_4.htm

namespace LibraryCourseWork 
{
	public class Trigonometric : Interpolation 
	{
		/// <summary>
		/// Все коэффициенты Фурье
		/// </summary>
		private double[] _coeff;

		/// <summary>
		/// Четные элементы таблицы коэффициентов Фурье с первым элементом равным _coeff[0]
		/// </summary>
		private double[] a;

		/// <summary>
		/// Нечентные элементы таблицы коэффициентов Фурье начиная с 3 с первым элементом равным 0
		/// </summary>
		private double[] b;

		/// <summary>
		/// Периодичность функции
		/// </summary>
		private double _L;

		/// <summary>
		/// Самый обычный конструктор
		/// </summary>
		/// <param name="x">Массив точек x</param>
		/// <param name="y">Массив точек y</param>
		/// <param name="L">Периодичность функции</param>
		public Trigonometric(double[] x, double[] y, double L) 
		{
			if (x.Length != y.Length)
				throw new System.ArgumentException(
					"Размер массива точек и размер массива значений в этих точках должны совпадать!");
			_x = new double[x.Length];
			_y = new double[y.Length];
			if ((_x.Length % 2) != 0) {//если кол-во точек четно - не делаем ничего
				for (int i = 0; i < x.Length; i++) {
					_x[i] = x[i];
					_y[i] = y[i];
				}
				name = "Тригонометрическая";
				_L = L;
				_coeff = FourierCoeffs();
				a = GetEvenCoefs();
				b = GetOddCoefs();
			}
		}

		private double[] GetOddCoefs() {
			double[] tmp = new double[_coeff.Count() / 2];
			tmp[0] = 0;
			for (int i = 1; i < _coeff.Count() / 2; i++) {
				tmp[i] = _coeff[i * 2];
			}
			return tmp;
		}

		private double[] GetEvenCoefs() {
			double[] tmp = new double[_coeff.Count() / 2 + 1];
			tmp[0] = _coeff[0];
			for (int i = 1; i < _coeff.Count() / 2 + 1; i++) 
			{
				tmp[i] = _coeff[i * 2 - 1];
			}
			return tmp;
		}

		public double[] FourierCoeffs() 
		{
			int n = _x.Length;
			int m = n / 2;
			double[] xx = new double[(n - (m + 1)) + m];
			double[] yy = new double[(n - (m + 1)) + m];
			double[,] A = new double[m*2, n];

			for (int i = 0; i < (n - m - 1); i++) 
			{
				xx[i] = _x[m + i];
				yy[i] = _y[m + i];
			}

			for (int i = 0; i < m; i++) 
			{
				xx[n - m -1 + i] = _x[i];
				yy[n - m -1 + i] = _y[i];
			}

			for (int i = 0; i < n-1; i++)
				A[i , 0] = 0.5;
			for (int i = 0; i < m-1; i++) 
			{
				for (int j = 0; j < n-1; j++) 
				{
					A[j, i * 2 + 1] = Math.Cos(2 * Math.PI * (i+1) * xx[j] / _L);
					A[j, i * 2 + 2] = Math.Sin(2 * Math.PI * (i+1) * xx[j] / _L);
				}
			}

			for (int j = 0; j < n - 1; j++) 
			{
				A[j, m * 2 - 1] = Math.Cos(2 * Math.PI * m * xx[j] / _L);
			}

			Matrix c = Matrix.LUSolve(new Matrix(A), new Matrix(yy));
			return c.GetColumn(0);
		}

		public override double Calc(double arg) 
		{
			if ((_x.Length % 2) != 0) {
				int n = _x.Length;
				int m = n / 2;
				double xInt = arg;
				double yInt = 0.5 * a[0];
				for (int i = 0; i < m - 1; i++) {
					yInt += a[i + 1] * Math.Cos(2 * Math.PI * (i + 1) * xInt / _L) + b[i + 1] * Math.Sin(2 * Math.PI * (i + 1) * xInt / _L);
				}
				yInt += a[m] * Math.Cos(2 * Math.PI * m * xInt / _L);
				return yInt;
			} else {
				return 0;
			}
		}
	}
}
