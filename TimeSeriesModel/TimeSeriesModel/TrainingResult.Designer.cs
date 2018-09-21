namespace TimeSeriesModel
{
    partial class TrainingResult
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValidateMAE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMAE = new System.Windows.Forms.Label();
            this.labelProcessedEpoches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_AlgorithmName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValidateMAE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelMAE);
            this.groupBox1.Controls.Add(this.labelProcessedEpoches);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Epoches and Error";
            // 
            // labelValidateMAE
            // 
            this.labelValidateMAE.AutoSize = true;
            this.labelValidateMAE.Location = new System.Drawing.Point(330, 68);
            this.labelValidateMAE.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelValidateMAE.Name = "labelValidateMAE";
            this.labelValidateMAE.Size = new System.Drawing.Size(50, 13);
            this.labelValidateMAE.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Validate MAE: ";
            this.label4.Visible = false;
            // 
            // labelMAE
            // 
            this.labelMAE.AutoSize = true;
            this.labelMAE.Location = new System.Drawing.Point(330, 45);
            this.labelMAE.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelMAE.Name = "labelMAE";
            this.labelMAE.Size = new System.Drawing.Size(50, 13);
            this.labelMAE.TabIndex = 3;
            // 
            // labelProcessedEpoches
            // 
            this.labelProcessedEpoches.AutoSize = true;
            this.labelProcessedEpoches.Location = new System.Drawing.Point(318, 23);
            this.labelProcessedEpoches.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelProcessedEpoches.Name = "labelProcessedEpoches";
            this.labelProcessedEpoches.Size = new System.Drawing.Size(50, 13);
            this.labelProcessedEpoches.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAE: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processed Epoches:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "epoch";
            chartArea1.AxisY.Title = "MAE";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "MAE";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(493, 309);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label_AlgorithmName
            // 
            this.label_AlgorithmName.AutoSize = true;
            this.label_AlgorithmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlgorithmName.Location = new System.Drawing.Point(13, 9);
            this.label_AlgorithmName.Name = "label_AlgorithmName";
            this.label_AlgorithmName.Size = new System.Drawing.Size(52, 17);
            this.label_AlgorithmName.TabIndex = 2;
            this.label_AlgorithmName.Text = "label1";
            // 
            // TrainingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 443);
            this.Controls.Add(this.label_AlgorithmName);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrainingResult";
            this.Text = "Training Result";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label_AlgorithmName;
        private System.Windows.Forms.Label labelMAE;
        private System.Windows.Forms.Label labelProcessedEpoches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValidateMAE;
    }
}