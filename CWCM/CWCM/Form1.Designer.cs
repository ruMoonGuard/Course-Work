namespace CWCM
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.интерполяцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.однойПеременнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.каноническаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.лагранжToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ньютонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.кубическимСплайномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.тригонометрическаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.рациональнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.степеннымРядомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.чебышевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.двухПеременныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.лагранжToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonUpdateChart = new System.Windows.Forms.Button();
			this.clbInterpolators = new System.Windows.Forms.CheckedListBox();
			this.buttonShowTable = new System.Windows.Forms.Button();
			this.dgvSourceData = new System.Windows.Forms.DataGridView();
			this.buttonLoadSourceFromFile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSourceData)).BeginInit();
			this.SuspendLayout();
			// 
			// chartMain
			// 
			chartArea1.Name = "ChartArea1";
			this.chartMain.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartMain.Legends.Add(legend1);
			this.chartMain.Location = new System.Drawing.Point(12, 43);
			this.chartMain.Name = "chartMain";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartMain.Series.Add(series1);
			this.chartMain.Size = new System.Drawing.Size(574, 288);
			this.chartMain.TabIndex = 0;
			this.chartMain.Text = "chart1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.интерполяцииToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(724, 24);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// интерполяцииToolStripMenuItem
			// 
			this.интерполяцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.однойПеременнойToolStripMenuItem,
            this.двухПеременныхToolStripMenuItem});
			this.интерполяцииToolStripMenuItem.Name = "интерполяцииToolStripMenuItem";
			this.интерполяцииToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.интерполяцииToolStripMenuItem.Text = "Интерполяции";
			// 
			// однойПеременнойToolStripMenuItem
			// 
			this.однойПеременнойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каноническаяToolStripMenuItem,
            this.лагранжToolStripMenuItem1,
            this.ньютонToolStripMenuItem,
            this.кубическимСплайномToolStripMenuItem,
            this.тригонометрическаяToolStripMenuItem,
            this.рациональнаяToolStripMenuItem,
            this.степеннымРядомToolStripMenuItem,
            this.чебышевToolStripMenuItem});
			this.однойПеременнойToolStripMenuItem.Name = "однойПеременнойToolStripMenuItem";
			this.однойПеременнойToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.однойПеременнойToolStripMenuItem.Text = "Одной переменной";
			// 
			// каноническаяToolStripMenuItem
			// 
			this.каноническаяToolStripMenuItem.Name = "каноническаяToolStripMenuItem";
			this.каноническаяToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.каноническаяToolStripMenuItem.Text = "Каноническая";
			// 
			// лагранжToolStripMenuItem1
			// 
			this.лагранжToolStripMenuItem1.Name = "лагранжToolStripMenuItem1";
			this.лагранжToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
			this.лагранжToolStripMenuItem1.Text = "Лагранж";
			// 
			// ньютонToolStripMenuItem
			// 
			this.ньютонToolStripMenuItem.Name = "ньютонToolStripMenuItem";
			this.ньютонToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.ньютонToolStripMenuItem.Text = "Ньютон";
			// 
			// кубическимСплайномToolStripMenuItem
			// 
			this.кубическимСплайномToolStripMenuItem.Name = "кубическимСплайномToolStripMenuItem";
			this.кубическимСплайномToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.кубическимСплайномToolStripMenuItem.Text = "Кубическим сплайном";
			// 
			// тригонометрическаяToolStripMenuItem
			// 
			this.тригонометрическаяToolStripMenuItem.Name = "тригонометрическаяToolStripMenuItem";
			this.тригонометрическаяToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.тригонометрическаяToolStripMenuItem.Text = "Тригонометрическая";
			// 
			// рациональнаяToolStripMenuItem
			// 
			this.рациональнаяToolStripMenuItem.Name = "рациональнаяToolStripMenuItem";
			this.рациональнаяToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.рациональнаяToolStripMenuItem.Text = "Рациональная";
			// 
			// степеннымРядомToolStripMenuItem
			// 
			this.степеннымРядомToolStripMenuItem.Name = "степеннымРядомToolStripMenuItem";
			this.степеннымРядомToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.степеннымРядомToolStripMenuItem.Text = "Степенным рядом";
			// 
			// чебышевToolStripMenuItem
			// 
			this.чебышевToolStripMenuItem.Name = "чебышевToolStripMenuItem";
			this.чебышевToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.чебышевToolStripMenuItem.Text = "Чебышев";
			// 
			// двухПеременныхToolStripMenuItem
			// 
			this.двухПеременныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лагранжToolStripMenuItem});
			this.двухПеременныхToolStripMenuItem.Name = "двухПеременныхToolStripMenuItem";
			this.двухПеременныхToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.двухПеременныхToolStripMenuItem.Text = "Двух переменных";
			// 
			// лагранжToolStripMenuItem
			// 
			this.лагранжToolStripMenuItem.Name = "лагранжToolStripMenuItem";
			this.лагранжToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.лагранжToolStripMenuItem.Text = "Лагранж";
			this.лагранжToolStripMenuItem.Click += new System.EventHandler(this.лагранжToolStripMenuItem_Click);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(591, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Интерполяторы";
			// 
			// buttonUpdateChart
			// 
			this.buttonUpdateChart.Location = new System.Drawing.Point(591, 283);
			this.buttonUpdateChart.Name = "buttonUpdateChart";
			this.buttonUpdateChart.Size = new System.Drawing.Size(126, 23);
			this.buttonUpdateChart.TabIndex = 19;
			this.buttonUpdateChart.Text = "Обновить график";
			this.buttonUpdateChart.UseVisualStyleBackColor = true;
			this.buttonUpdateChart.Click += new System.EventHandler(this.buttonUpdateChart_Click);
			// 
			// clbInterpolators
			// 
			this.clbInterpolators.CheckOnClick = true;
			this.clbInterpolators.FormattingEnabled = true;
			this.clbInterpolators.Location = new System.Drawing.Point(592, 62);
			this.clbInterpolators.Name = "clbInterpolators";
			this.clbInterpolators.Size = new System.Drawing.Size(125, 214);
			this.clbInterpolators.TabIndex = 17;
			this.clbInterpolators.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbInterpolators_ItemCheck);
			// 
			// buttonShowTable
			// 
			this.buttonShowTable.Location = new System.Drawing.Point(592, 312);
			this.buttonShowTable.Name = "buttonShowTable";
			this.buttonShowTable.Size = new System.Drawing.Size(126, 23);
			this.buttonShowTable.TabIndex = 20;
			this.buttonShowTable.Text = "Таблица значений >";
			this.buttonShowTable.UseVisualStyleBackColor = true;
			this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
			// 
			// dgvSourceData
			// 
			this.dgvSourceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSourceData.Location = new System.Drawing.Point(724, 62);
			this.dgvSourceData.Name = "dgvSourceData";
			this.dgvSourceData.RowHeadersVisible = false;
			this.dgvSourceData.Size = new System.Drawing.Size(216, 244);
			this.dgvSourceData.TabIndex = 21;
			this.dgvSourceData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSourceData_CellEndEdit);
			this.dgvSourceData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSourceData_KeyDown);
			// 
			// buttonLoadSourceFromFile
			// 
			this.buttonLoadSourceFromFile.Location = new System.Drawing.Point(724, 312);
			this.buttonLoadSourceFromFile.Name = "buttonLoadSourceFromFile";
			this.buttonLoadSourceFromFile.Size = new System.Drawing.Size(139, 23);
			this.buttonLoadSourceFromFile.TabIndex = 22;
			this.buttonLoadSourceFromFile.Text = "Загрузить из файла";
			this.buttonLoadSourceFromFile.UseVisualStyleBackColor = true;
			this.buttonLoadSourceFromFile.Click += new System.EventHandler(this.buttonLoadSourceFromFile_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 343);
			this.Controls.Add(this.buttonLoadSourceFromFile);
			this.Controls.Add(this.dgvSourceData);
			this.Controls.Add(this.buttonShowTable);
			this.Controls.Add(this.buttonUpdateChart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clbInterpolators);
			this.Controls.Add(this.chartMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Курсовая работа";
			((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSourceData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерполяцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однойПеременнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каноническаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лагранжToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ньютонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кубическимСплайномToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тригонометрическаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рациональнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem степеннымРядомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чебышевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двухПеременныхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem лагранжToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonUpdateChart;
		private System.Windows.Forms.CheckedListBox clbInterpolators;
		private System.Windows.Forms.Button buttonShowTable;
		private System.Windows.Forms.DataGridView dgvSourceData;
		private System.Windows.Forms.Button buttonLoadSourceFromFile;
    }
}

