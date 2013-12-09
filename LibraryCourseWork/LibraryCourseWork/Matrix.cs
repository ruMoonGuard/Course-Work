using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseWork 
{
	public class Point 
	{
		public Point(double x, double y) {
			X = x;
			Y = y;
		}

		public double X {
			get;
			set;
		}

		public double Y {
			get;
			set;
		}
	}

	public interface IMatrixDataObserver {

		void onDataChanged();

	}

	public class Matrix 
	{
		public double[,] data;
		public static int z_iters = 0;
		public static Matrix nev;
		public static Matrix XRes;

		private IMatrixDataObserver observer;
		public IMatrixDataObserver Observer {
			get {
				return observer;
			}
			set {
				observer = value;
			}
		}

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
		public void ColumnInsert() 
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
		/// Add another line to matrix
		/// </summary>
		public void LineInsert() 
		{
			double[,] tmp = new double[data.GetLength(0)+1, data.GetLength(1)];
			for (int i = 0; i < data.GetLength(0); i++) {
				for (int j = 0; j < data.GetLength(1); j++)
					tmp[i, j] = data[i, j];
			}
			data = tmp;

			if (observer != null) {
				observer.onDataChanged();
			}
		}

		/// <summary>
		/// Add another line to matrix after index
		/// </summary>
		/// <param name="index"></param>
		public void LineInsert(int index) 
		{
			double[,] tmp = new double[data.GetLength(0) + 1, data.GetLength(1)];
			int add = 0;
			for (int i = 0; i < data.GetLength(0); i++) {
				for (int j = 0; j < data.GetLength(1); j++)
					tmp[i+add, j] = data[i, j];
				if (i == index) {
					add = 1;
				}
			}
			data = tmp;

			if (observer != null) {
				observer.onDataChanged();
			}
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
			if (data.GetLength(1) < j)
				return tmp;
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

		public Point[] GetAsPointsArray() 
		{
			List<Point> res = new List<Point>();
			if (data.GetLength(1) >= 2)
				for (int i = 0; i < data.GetLength(0); i++)
				{
					res.Add(new Point(data[i, 0], data[i, 1]));
				}
			return res.ToArray<Point>();
		}

		public void LoadFromFile(string fileName) {
			//TODO: implement method
			DebugOutput("pref");
			data = new double[0, 0];
			var reader = new StreamReader(File.OpenRead(fileName));
			var RowCount = 0;
			int currIndex = 0;
			while (!reader.EndOfStream) {
				var line = reader.ReadLine();
				var values = line.Split(';');
				if (0 == RowCount) 
				{
					RowCount = values.Count();
					for (int i = 0; i < RowCount; i++)
						ColumnInsert();
				}
				if (values.Count() == RowCount) {
					LineInsert();
					for (int j = 0; j < RowCount; j++) {
						data[currIndex, j] = Convert.ToDouble(values[j]);
					}
					currIndex++;
				}
			}
			DebugOutput("pref");

			if (observer != null) {
				observer.onDataChanged();
			}
		}

		public void LineRemove(int index) 
		{
			if (LinesCount() <= 0)
				return;
			double[,] tmp = new double[data.GetLength(0)-1,data.GetLength(1)];
			int add = 0;
			for (int i = 0; i < data.GetLength(0); i++) 
			{
				if (i == index) 
				{
					add = 1;
					continue;
				}
				for (int j = 0; j < data.GetLength(1); j++) 
				{
					tmp[i - add, j] = data[i, j];
				}
			}
			data = tmp;

			if (observer != null) {
				observer.onDataChanged();
			}
		}
	}
}
