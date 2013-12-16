using LibraryCourseWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWCM {
	public partial class Form2 : Form {
		/*double[] x = { 0, 1 };
		double[] y = { 0, 1 };
		double[,] f = {
					  {2,1.732},
					  {1.732,1.414}
					  };*/
		double[] x = { 0, 1, 2};
		double[] y = { 0, 1, 2};
		double[,] f = {
					  {2, 1.732, 1.5},
					  {1.732, 2, 1.6},
					  {1, 1.2, 2}
					  };
		Lagange2 l2;
		Matrix res;

		public Form2() {
			InitializeComponent();
			res = new Matrix(0,1);
			Lagange2 l2 = new Lagange2(x, y, f);
			int currI = 0;
			int currJ = 0;
			for (double i = 0; i < (x.Length-1)+0.1; i += 0.1) {
				currJ = 0;
				res.LineInsert();
				for (double j = 0; j <= (y.Length-1)+0.1; j += 0.1) {
					if (currJ >= res.ColumnsCount())
						res.ColumnInsert();
					res[currI, currJ] = l2.Calc(i, j);
					currJ++;
				}
				//res.DebugOutput("\n\nNNN");
				currI++;
			}

			for (int i = 0; i < res.ColumnsCount(); i++) {
				DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
				col.Width = 20;
				dgvResult.Columns.Add(col);
			}
			for (int i = 0; i < res.LinesCount(); i++) {
				DataGridViewRow col = new DataGridViewRow();
				col.Height = 20;
				dgvResult.Rows.Add(col);
			}

			for (int i = 0; i < res.LinesCount(); i++) {
				for (int j = 0; j < res.ColumnsCount(); j++) {
					dgvResult.Rows[i].Cells[j].Value = res[i,j].ToString();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			double min = res.min;
			double max = res.max;
			double delta = max - min;
			for (int i = 0; i < res.LinesCount(); i++) {
				for (int j = 0; j < res.ColumnsCount(); j++) {
					//int c = Convert.ToInt32((Convert.ToDouble(dgvResult.Rows[i].Cells[j].Value) - min) / delta * 255);
					int c = Convert.ToInt32((Convert.ToDouble(dgvResult.Rows[i].Cells[j].Value) - min) / delta * 255);
					dgvResult.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(c,0,0);
				}
			}
		}

	}
}
