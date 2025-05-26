
namespace laba3.Lavreshin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbRoomCount = new System.Windows.Forms.ComboBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.nudPeriod = new System.Windows.Forms.NumericUpDown();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(268, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(523, 130);
            this.dataGridView.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(6, 24);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(130, 50);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Загрузить данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // cmbRoomCount
            // 
            this.cmbRoomCount.FormattingEnabled = true;
            this.cmbRoomCount.Location = new System.Drawing.Point(115, 36);
            this.cmbRoomCount.Name = "cmbRoomCount";
            this.cmbRoomCount.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomCount.TabIndex = 2;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(6, 80);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(130, 50);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Анализ данных";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // nudPeriod
            // 
            this.nudPeriod.Location = new System.Drawing.Point(115, 63);
            this.nudPeriod.Name = "nudPeriod";
            this.nudPeriod.Size = new System.Drawing.Size(120, 20);
            this.nudPeriod.TabIndex = 4;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(6, 136);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(130, 50);
            this.btnPredict.TabIndex = 5;
            this.btnPredict.Text = "Прогнозировать";
            this.btnPredict.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 324);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(151, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Вывод результатов анализа";
            // 
            // priceChart
            // 
            chartArea1.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.priceChart.Legends.Add(legend1);
            this.priceChart.Location = new System.Drawing.Point(268, 148);
            this.priceChart.Name = "priceChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.priceChart.Series.Add(series1);
            this.priceChart.Size = new System.Drawing.Size(523, 198);
            this.priceChart.TabIndex = 7;
            this.priceChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRoomCount);
            this.groupBox1.Controls.Add(this.nudPeriod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры анализа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество комнат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Период средней:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadData);
            this.groupBox2.Controls.Add(this.btnAnalyze);
            this.groupBox2.Controls.Add(this.btnPredict);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.priceChart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Цены на жильё";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbRoomCount;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.NumericUpDown nudPeriod;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}