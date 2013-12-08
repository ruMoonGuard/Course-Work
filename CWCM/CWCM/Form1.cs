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
    public partial class FormMain : Form
    {
        /*
         *Объявляем переменные для классов 
         */
        /*---------------------------------------------*/
        Lagrange lg;
        Newton nw;
        CubicSpline cs;
        Trigonometric tr;
        Canonical can;
        /*---------------------------------------------*/
        int count;//Кол-во графиков
        
        /*Исходные точки*/
        double[] x = {1,2,3,4};
        double[] y = {1,2,3,4};

        public FormMain()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //При загрузки формы инициализируем наш счетчик и удаляем все дефолтные сериесы с чарта.
            count = 0;
            chartMain.Series.Clear();
        }
        /// <summary>
        /// Функция, которая рисует график
        /// </summary>
        /// <param name="x">Набор точек</param>
        /// <param name="cr">Указатель на компонент, на котором рисуем</param>
        /// <param name="obj">Объект определенной интерполяции</param>
        private void PaintGraph(double[] x, Chart cr, Interpolation obj)
        {
            if (!checkBoxClear.Checked)
            {
                cr.Series.Clear();
                count = 0;
            }
            
            //cr.Series.Add(new Series(""
            cr.Series[count].Name = obj.name;

        }

        private void buttonDataGrid_Click(object sender, EventArgs e)
        { 
            /*--------------------------------------------------------*/
            //Вот тут кароче будет загрузка всех данных в файл
            int n = 4;//Пока заглушка, в будущем будет содержать кол-во узлов(точек).
            ///x = {1,2,3,4};
            //y = new double[n];
            //x = 
            //y = {1,2,3,4};
            /*--------------------------------------------------------*/
            
            chartMain.Series.Add(new Series("Исходные точки"));
            chartMain.Series[0].ChartType = SeriesChartType.Point;
            chartMain.Series[0].Color = Color.Black;
            for (int i = 0; i < n; i++)
            {
                chartMain.Series[0].Points.AddXY(x[i], y[i]);
            }
        }
    }
}
