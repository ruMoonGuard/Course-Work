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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonDataGrid = new System.Windows.Forms.Button();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.buttonCanon = new System.Windows.Forms.Button();
            this.buttonLagrange = new System.Windows.Forms.Button();
            this.buttonNewton = new System.Windows.Forms.Button();
            this.buttonSplain = new System.Windows.Forms.Button();
            this.buttonTrigonometrix = new System.Windows.Forms.Button();
            this.buttonRartional = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonChebyshev = new System.Windows.Forms.Button();
            this.buttonTwoVar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClear = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBoxLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(12, 47);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(573, 263);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(17, 30);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(137, 23);
            this.buttonLoadFile.TabIndex = 1;
            this.buttonLoadFile.Text = "Загрузить из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            // 
            // buttonDataGrid
            // 
            this.buttonDataGrid.Location = new System.Drawing.Point(18, 59);
            this.buttonDataGrid.Name = "buttonDataGrid";
            this.buttonDataGrid.Size = new System.Drawing.Size(136, 23);
            this.buttonDataGrid.TabIndex = 2;
            this.buttonDataGrid.Text = "Задать в таблице";
            this.buttonDataGrid.UseVisualStyleBackColor = true;
            this.buttonDataGrid.Click += new System.EventHandler(this.buttonDataGrid_Click);
            // 
            // groupBoxLoad
            // 
            this.groupBoxLoad.Controls.Add(this.buttonDataGrid);
            this.groupBoxLoad.Controls.Add(this.buttonLoadFile);
            this.groupBoxLoad.Location = new System.Drawing.Point(11, 316);
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.Size = new System.Drawing.Size(181, 100);
            this.groupBoxLoad.TabIndex = 3;
            this.groupBoxLoad.TabStop = false;
            this.groupBoxLoad.Text = "Загрузка значений";
            // 
            // buttonCanon
            // 
            this.buttonCanon.Location = new System.Drawing.Point(6, 19);
            this.buttonCanon.Name = "buttonCanon";
            this.buttonCanon.Size = new System.Drawing.Size(154, 23);
            this.buttonCanon.TabIndex = 4;
            this.buttonCanon.Text = "Каноническая";
            this.buttonCanon.UseVisualStyleBackColor = true;
            // 
            // buttonLagrange
            // 
            this.buttonLagrange.Location = new System.Drawing.Point(6, 48);
            this.buttonLagrange.Name = "buttonLagrange";
            this.buttonLagrange.Size = new System.Drawing.Size(154, 23);
            this.buttonLagrange.TabIndex = 5;
            this.buttonLagrange.Text = "Лагранжа";
            this.buttonLagrange.UseVisualStyleBackColor = true;
            // 
            // buttonNewton
            // 
            this.buttonNewton.Location = new System.Drawing.Point(6, 77);
            this.buttonNewton.Name = "buttonNewton";
            this.buttonNewton.Size = new System.Drawing.Size(154, 23);
            this.buttonNewton.TabIndex = 6;
            this.buttonNewton.Text = "Ньютона";
            this.buttonNewton.UseVisualStyleBackColor = true;
            // 
            // buttonSplain
            // 
            this.buttonSplain.Location = new System.Drawing.Point(165, 19);
            this.buttonSplain.Name = "buttonSplain";
            this.buttonSplain.Size = new System.Drawing.Size(154, 23);
            this.buttonSplain.TabIndex = 7;
            this.buttonSplain.Text = "Кубическим сплайном";
            this.buttonSplain.UseVisualStyleBackColor = true;
            // 
            // buttonTrigonometrix
            // 
            this.buttonTrigonometrix.Location = new System.Drawing.Point(166, 48);
            this.buttonTrigonometrix.Name = "buttonTrigonometrix";
            this.buttonTrigonometrix.Size = new System.Drawing.Size(153, 23);
            this.buttonTrigonometrix.TabIndex = 8;
            this.buttonTrigonometrix.Text = "Тригонометрическая";
            this.buttonTrigonometrix.UseVisualStyleBackColor = true;
            // 
            // buttonRartional
            // 
            this.buttonRartional.Location = new System.Drawing.Point(166, 77);
            this.buttonRartional.Name = "buttonRartional";
            this.buttonRartional.Size = new System.Drawing.Size(153, 23);
            this.buttonRartional.TabIndex = 9;
            this.buttonRartional.Text = "Рациональная";
            this.buttonRartional.UseVisualStyleBackColor = true;
            // 
            // buttonPow
            // 
            this.buttonPow.Location = new System.Drawing.Point(325, 19);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(153, 23);
            this.buttonPow.TabIndex = 10;
            this.buttonPow.Text = "Степенным рядом";
            this.buttonPow.UseVisualStyleBackColor = true;
            // 
            // buttonChebyshev
            // 
            this.buttonChebyshev.Location = new System.Drawing.Point(325, 48);
            this.buttonChebyshev.Name = "buttonChebyshev";
            this.buttonChebyshev.Size = new System.Drawing.Size(152, 23);
            this.buttonChebyshev.TabIndex = 11;
            this.buttonChebyshev.Text = "Чебышевом";
            this.buttonChebyshev.UseVisualStyleBackColor = true;
            // 
            // buttonTwoVar
            // 
            this.buttonTwoVar.Location = new System.Drawing.Point(325, 77);
            this.buttonTwoVar.Name = "buttonTwoVar";
            this.buttonTwoVar.Size = new System.Drawing.Size(152, 23);
            this.buttonTwoVar.TabIndex = 12;
            this.buttonTwoVar.Text = "Две переменные";
            this.buttonTwoVar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTwoVar);
            this.groupBox1.Controls.Add(this.buttonChebyshev);
            this.groupBox1.Controls.Add(this.buttonPow);
            this.groupBox1.Controls.Add(this.buttonRartional);
            this.groupBox1.Controls.Add(this.buttonTrigonometrix);
            this.groupBox1.Controls.Add(this.buttonSplain);
            this.groupBox1.Controls.Add(this.buttonNewton);
            this.groupBox1.Controls.Add(this.buttonLagrange);
            this.groupBox1.Controls.Add(this.buttonCanon);
            this.groupBox1.Location = new System.Drawing.Point(198, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интерполяция";
            // 
            // checkBoxClear
            // 
            this.checkBoxClear.AutoSize = true;
            this.checkBoxClear.Location = new System.Drawing.Point(596, 293);
            this.checkBoxClear.Name = "checkBoxClear";
            this.checkBoxClear.Size = new System.Drawing.Size(131, 17);
            this.checkBoxClear.TabIndex = 14;
            this.checkBoxClear.Text = "Совместный вывод?";
            this.checkBoxClear.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(596, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 23);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.интерполяцииToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
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
            this.лагранжToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.лагранжToolStripMenuItem.Text = "Лагранж";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 433);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLoad);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Курсовая работа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBoxLoad.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonDataGrid;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.Button buttonCanon;
        private System.Windows.Forms.Button buttonLagrange;
        private System.Windows.Forms.Button buttonNewton;
        private System.Windows.Forms.Button buttonSplain;
        private System.Windows.Forms.Button buttonTrigonometrix;
        private System.Windows.Forms.Button buttonRartional;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonChebyshev;
        private System.Windows.Forms.Button buttonTwoVar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxClear;
        private System.Windows.Forms.Button buttonClear;
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
    }
}

