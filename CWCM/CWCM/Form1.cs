using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryCourseWork;
using System.Windows.Forms.DataVisualization.Charting;

namespace CWCM
{
	public partial class FormMain : Form, IMatrixDataObserver
    {
		Interpolation[] interpolations;
        
		/*Исходные точки*/
		Matrix sourceData = new Matrix(new double[,]{{1,1}, {2,2}, {3,2}, {4,4}, {5,1}});
		

		int[] widthArr = new int[]{738, 970};
		string[] widthAddArr = new string[] { ">", "<" };
		bool expandedWindow = false;

        public FormMain()
        { 
            InitializeComponent();
			sourceData.Observer = this;
			onSourceDataChanged();
			RefreshInterpolation();
			AddInterpolatorsToChart();
			AddInterpolatorsToList();
			chartMain.Update();
        }

		public void RefreshInterpolation() 
		{
			double[] x = sourceData.GetColumn(0);
			double[] y = sourceData.GetColumn(1);
			interpolations = new Interpolation[6];
			interpolations[0] = new Canonical(x, y);
			interpolations[1] = new Lagrange(x, y);
			interpolations[2] = new Newton(x, y);
			interpolations[3] = new CubicSpline(x, y);
			interpolations[4] = new Trigonometric(x, y, sourceData.LinesCount()-1);
            interpolations[5] = new Rational(x, y, 7);
		}

		public void AddInterpolatorsToChart() 
		{
			chartMain.Series.Clear();
			chartMain.Series.Add(new Series("Исходные точки"));
			chartMain.Series[0].ChartType = SeriesChartType.Point;
			for (int i = 0; i < sourceData.LinesCount(); i++) 
			{
				chartMain.Series[0].Points.AddXY(sourceData[i, 0], sourceData[i, 1]);
			}

			for (int i = 0; i < interpolations.Count(); i++) 
			{
				string name = interpolations[i].name;
				Series s = new Series(name);
				s.ChartType = SeriesChartType.Line;
				s.Enabled = true;
				double minX = sourceData[0,0];
				double maxX = sourceData[sourceData.LinesCount()-1,0];
				double delta = (maxX - minX) / 100.0;
				for (double x = minX; x <= maxX; x += delta) 
				{
					double y = interpolations[i].Calc(x);
					s.Points.AddXY(x, y);
				}

				chartMain.Series.Add(s);
			}
		}

		public void AddInterpolatorsToList() 
		{
			clbInterpolators.Items.Clear();
			for (int i = 0; i < interpolations.Count(); i++) 
			{
				clbInterpolators.Items.Add(interpolations[i].name,true);
			}
		}

		public void onDataChanged() 
		{
			onSourceDataChanged();
			//RefreshInterpolation();
			//AddInterpolatorsToChart();
		}

		private void onSourceDataChanged() 
		{
			dgvSourceData.DataSource = sourceData.GetAsPointsArray();
		}

		private void buttonLoadSourceFromFile_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.ShowDialog();
			sourceData.LoadFromFile(dialog.FileName);
			RefreshInterpolation();
			AddInterpolatorsToChart();
		}

		private void clbInterpolators_ItemCheck(object sender, ItemCheckEventArgs e) {
			chartMain.Series[e.Index + 1].Enabled = (e.NewValue == CheckState.Checked);
		}

		private void buttonUpdateChart_Click(object sender, EventArgs e) {
			RefreshInterpolation();
			AddInterpolatorsToChart();
		}

		private void dgvSourceData_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
			sourceData[e.RowIndex, e.ColumnIndex] = (double) dgvSourceData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			RefreshInterpolation();
			AddInterpolatorsToChart();
		}

		private void buttonShowTable_Click(object sender, EventArgs e) {
			expandedWindow = !expandedWindow;
			this.Width = (widthArr[Convert.ToInt32(expandedWindow)]);
			this.buttonShowTable.Text = "Таблица значений " + widthAddArr[Convert.ToInt32(expandedWindow)];
		}

		private void dgvSourceData_KeyDown(object sender, KeyEventArgs e) {

			int rowIndex = 0;
			if (dgvSourceData.CurrentRow != null)
				rowIndex = dgvSourceData.CurrentRow.Index;

			if (e.KeyCode == Keys.Delete) 
			{
				if (dgvSourceData.CurrentRow != null) {
					sourceData.LineRemove(dgvSourceData.CurrentRow.Index);
				}
			}

			if (e.KeyCode == Keys.Enter) {
				if (dgvSourceData.CurrentRow != null) {
					if (e.Modifiers == Keys.Control && dgvSourceData.CurrentRow.Index > 0)
						sourceData.LineInsert(dgvSourceData.CurrentRow.Index - 1);
					else {
						sourceData.LineInsert(dgvSourceData.CurrentRow.Index);
					}
					dgvSourceData.CurrentCell = dgvSourceData.Rows[rowIndex].Cells[0];
				} else {
					sourceData.LineInsert();
				}

			}
		}

		
    }
}
