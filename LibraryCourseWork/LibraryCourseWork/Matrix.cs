using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork 
{
	public class Matrix 
	{
		public double[,] data;
		public static int z_iters = 0;
		public static Matrix nev;
		public static Matrix XRes;

		public double this[int i, int j] 
		{
			get 
			{
				return data[i,j];
			}
			set 
			{
				data[i,j] = value;
			}
		}

		/// <summary>
		/// NxN matrix constructor
		/// </summary>
		/// <param name="n"></param>
		public Matrix(int n) 
		{
			data = new double[n,n];
			for (int i = 0; i < n; i++) 
			{
				for (int j = 0; j < n; j++) 
				{
					data[i, j] = 0;
				}
			}
		}
		/// <summary>
		/// IxJ matrix constructor
		/// </summary>
		/// <param name="i">lines count</param>
		/// <param name="j">rows count</param>
		public Matrix(int _i, int _j) 
		{
			data = new double[_i,_j];
			for (int i = 0; i < _i; i++) 
			{
				for (int j = 0; j < _j; j++) {
					data[i, j] = 0;
				}
			}
		}

		/// <summary>
		/// 0x0 Matrix constructor
		/// </summary>
		public Matrix() {
			data = new double[0,0];
		}

		/// <summary>
		/// Matrix from double[i,j] constructor
		/// </summary>
		/// <param name="_data"></param>
		public Matrix(double[,] _data)
		{
			data = _data;
		}

		/// <summary>
		/// One-column matrix from double[i] constructor
		/// </summary>
		/// <param name="_data"></param>
		public Matrix(double[] _data) 
		{
			data = new double[1, _data.Count()];
			for (int i = 0; i < _data.Count(); i++) 
				data[0,i] = _data[i];
		}

		/// <summary>
		/// Adds another column to matrix
		/// </summary>
		public void addColumn() 
		{
			double[,] tmp = new double[data.GetLength(0), data.GetLength(1) + 1];
			for (int i = 0; i < data.GetLength(0); i++) 
			{
				for (int j = 0; j < data.GetLength(1); j++)
					tmp[i, j] = data[i, j];
			}
			data = tmp;
		}

		/// <summary>
		/// Debug output the matrix
		/// </summary>
		/// <param name="prefix">prefix before matrix data</param>
		public void DebugOutput(string prefix) 
		{
			Console.Out.WriteLine(prefix);
			for (int i = 0; i < data.GetLength(0); i++) 
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Console.Out.Write(String.Format("{0,10}", data[i, j].ToString("F8")) + "  ");
				}
				Console.Out.WriteLine("");
			}
		}

		/// <summary>
		/// Debug output the matrix to string
		/// </summary>
		/// <returns>matrix</returns>
		public string DebugOutputStr() 
		{
			string res = "";
			for (int i = 0; i < data.GetLength(0); i++) 
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					res += (String.Format("{0,10}", data[i, j].ToString("F8")) + "  ");
				}
				res += Environment.NewLine;
			}
			return res;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>Lines count</returns>
		public int LinesCount() 
		{
			return data.GetLength(0);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>Columns count</returns>
		public int ColumnsCount() {
			return data.GetLength(1);
		}

		/// <summary>
		/// Get "i" line from matrix
		/// </summary>
		/// <param name="i">number of line</param>
		/// <returns>one line as double[]</returns>
		public double[] GetLine(int i) {
			double[] tmp = new double[ColumnsCount()];
			for(int j = 0; j<ColumnsCount(); j++)
			{
				tmp[j] = data[i, j];
			}
			return tmp;
		}

		/// <summary>
		/// Get "j" column from matrix
		/// </summary>
		/// <param name="j">number of column</param>
		/// <returns>one column as double[]</returns>
		public double[] GetColumn(int j) {
			double[] tmp = new double[LinesCount()];
			for (int i = 0; i < LinesCount(); i++) {
				tmp[i] = data[i, j];
			}
			return tmp;
		}

		public Matrix GetSquareMatrix() {
			return GetSquareMatrix(this);
		}

		public static Matrix GetSquareMatrix(Matrix m) {
			int linesCount = m.LinesCount();
			Matrix res = new Matrix(linesCount);
			for (int i = 0; i < linesCount; i++) {
				List<double> line = new List<double>(linesCount);
				for (int j = 0; j < m.GetLine(i).Count(); j++) {
					if (j < linesCount)
						res[i, j] = m[i, j];
				}
			}
			return res;
		}

		public Matrix GetLastRow() {
			return GetLastRow(this);
		}

		public static Matrix GetLastRow(Matrix m) {
			int linesCount = m.LinesCount();
			Matrix res = new Matrix(linesCount, 1);
			for (int i = 0; i < linesCount; i++) {
				List<double> line = new List<double>(1);
				for (int j = 0; j < m.GetLine(i).Count(); j++) {
					if (j >= linesCount) {
						res[i, 0] = m[i, j];
						break;
					}
				}
			}
			return res;
		}

		public static Matrix Multiply(Matrix A, Matrix B) {
			int n = A.LinesCount();
			Matrix res = new Matrix(n);
			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
					for (int k = 0; k < n; k++)
						res[i, j] += A[i, k] * B[k, j];
			return res;
		}

		public static Matrix CheckResult(Matrix A, Matrix B) {
			int n = A.LinesCount();
			Matrix res = new Matrix(n, 1);
			for (int i = 0; i < n; i++) {
				double r = 0;
				for (int j = 0; j < n; j++)
					r += A[i, j] * B[j, 0];
				res[i, 0] = r;
			}
			return res;
		}

		public static void LU(Matrix A, Matrix L, Matrix U, int n) {
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					if (i >= j) {
						double l = A[i, j];
						double sum = 0;
						for (int k = 0; k < j; k++) {
							sum += L[i, k] * U[k, j];
						}
						l -= sum;
						L[i, j] = l;
					}
					if (i <= j) {
						double u = 1.0 / L[i, i];
						double sum = 0;
						for (int k = 0; k < i; k++) {
							sum += L[i, k] * U[k, j];
						}
						u *= (A[i, j] - sum);
						U[i, j] = u;
					}
				}

			}
		}

		public static Matrix GaussDown(Matrix m1, Matrix m2) {
			int n = m1.LinesCount();
			Matrix res = new Matrix(n, 1);
			for (int i = 0; i < n; i++) {
				double sum = 0.0;
				for (int j = 0; j < i; j++) {
					sum += m1[i, j] * res[j, 0];
				}
				res[i, 0] = (m2[0, i] - sum) / m1[i, i];
			}
			return res;
		}

		public static Matrix GaussTop(Matrix m1, Matrix m2) {
			int n = m1.LinesCount();
			Matrix res = new Matrix(n, 1);
			for (int i = n - 1; i >= 0; i--) {
				double sum = 0.0;
				for (int j = i; j < n; j++) {
					sum += m1[i, j] * res[j, 0];
				}
				res[i, 0] = (m2[i, 0] - sum) / m1[i, i];
			}
			return res;
		}
		
		/// <summary>
		/// Linear equation solver
		/// </summary>
		/// <param name="A">coefficient matrix</param>
		/// <param name="B">one-column matrix of free members</param>
		/// <returns></returns>
		public static Matrix LUSolve(Matrix A, Matrix B) {
			Matrix L = new Matrix(A.LinesCount());
			Matrix U = new Matrix(A.LinesCount());
			Matrix.LU(A, L, U, A.LinesCount());
			Matrix GD = Matrix.GaussDown(L, B);
			Matrix result = Matrix.GaussTop(U, GD);
			return result;
		}

		public double[,] GetData()
		{
			return data;
		}
	}
}
