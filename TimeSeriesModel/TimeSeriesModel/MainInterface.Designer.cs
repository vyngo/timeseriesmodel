namespace TimeSeriesModel
{
    partial class MainInterface
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPreprocessing = new System.Windows.Forms.TabPage();
            this.buttonTrainDataGet = new System.Windows.Forms.Button();
            this.txtTrainDataColumn = new System.Windows.Forms.TextBox();
            this.txtTrainDataToRow = new System.Windows.Forms.TextBox();
            this.txtTrainDataFromRow = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.labelTrainDataNumColumns = new System.Windows.Forms.Label();
            this.labelTrainDataNumRows = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCorrelogram = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.boxDeseasonality = new System.Windows.Forms.GroupBox();
            this.textBox_Cycle = new System.Windows.Forms.TextBox();
            this.label_cycle = new System.Windows.Forms.Label();
            this.radioNoneDeseasonality = new System.Windows.Forms.RadioButton();
            this.radioSeasonalAdjustment = new System.Windows.Forms.RadioButton();
            this.txtNumLagAtDeseasonality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioDifferenceSeasonality = new System.Windows.Forms.RadioButton();
            this.boxDetrend = new System.Windows.Forms.GroupBox();
            this.radioNoneDetrend = new System.Windows.Forms.RadioButton();
            this.radioLinearDetrend = new System.Windows.Forms.RadioButton();
            this.radioDifference = new System.Windows.Forms.RadioButton();
            this.boxScale = new System.Windows.Forms.GroupBox();
            this.checkBoxLnTransformation = new System.Windows.Forms.CheckBox();
            this.richTextProprocessData = new System.Windows.Forms.RichTextBox();
            this.btnPreprocessSaveData = new System.Windows.Forms.Button();
            this.btnPreprocessOpenData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNeuronNetwork = new System.Windows.Forms.TabPage();
            this.groupBoxValidate = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtAhead = new System.Windows.Forms.TextBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTestToRow = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTestFromRow = new System.Windows.Forms.TextBox();
            this.labelTestRow = new System.Windows.Forms.Label();
            this.txtValidateColumn = new System.Windows.Forms.TextBox();
            this.txtValidateToRow = new System.Windows.Forms.TextBox();
            this.txtValidateFromRow = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelValidateNumRows = new System.Windows.Forms.Label();
            this.labelValidateNumColumns = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtValidateFileName = new System.Windows.Forms.TextBox();
            this.btnValidateBrowse = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBoxAlgorithmConfig = new System.Windows.Forms.GroupBox();
            textBoxMinValue = new System.Windows.Forms.TextBox();
            textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.radioLoopTrain = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.radioLoopValidate = new System.Windows.Forms.RadioButton();
            this.txtConfigErrors = new System.Windows.Forms.TextBox();
            this.txtConfig2 = new System.Windows.Forms.TextBox();
            this.txtConfigEpoches = new System.Windows.Forms.TextBox();
            this.txtConfig1 = new System.Windows.Forms.TextBox();
            this.labelConfigResidual = new System.Windows.Forms.Label();
            this.labelConfigEpoches = new System.Windows.Forms.Label();
            this.labelConfig2 = new System.Windows.Forms.Label();
            this.labelConfig1 = new System.Windows.Forms.Label();
            this.groupBoxTraining = new System.Windows.Forms.GroupBox();
            this.txtTrainingToRow = new System.Windows.Forms.TextBox();
            this.txtTrainingFileName = new System.Windows.Forms.TextBox();
            this.labelTrainingNumColumns = new System.Windows.Forms.Label();
            this.labelTrainingNumRows = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.radioRPROP = new System.Windows.Forms.RadioButton();
            this.radioBackPropagation = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrainingFromRow = new System.Windows.Forms.TextBox();
            this.txtTrainingColumn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTrainingBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxNetworkConfig = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rtbPreProcess = new System.Windows.Forms.RichTextBox();
            this.tbLag = new System.Windows.Forms.TextBox();
            this.btnSadj = new System.Windows.Forms.Button();
            this.btnSDiff = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnDtrend = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnNetworkClear = new System.Windows.Forms.Button();
            this.btnNetworkSave = new System.Windows.Forms.Button();
            this.btnNetworkLoad = new System.Windows.Forms.Button();
            this.btnNetworkNew = new System.Windows.Forms.Button();
            this.txtNumLag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumOutput = new System.Windows.Forms.TextBox();
            this.txtNumHidden = new System.Windows.Forms.TextBox();
            this.txtNumInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            txtLogs = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPreprocessing.SuspendLayout();
            this.boxDeseasonality.SuspendLayout();
            this.boxDetrend.SuspendLayout();
            this.boxScale.SuspendLayout();
            this.tabNeuronNetwork.SuspendLayout();
            this.groupBoxValidate.SuspendLayout();
            this.groupBoxAlgorithmConfig.SuspendLayout();
            this.groupBoxTraining.SuspendLayout();
            this.groupBoxNetworkConfig.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPreprocessing);
            this.tabControl.Controls.Add(this.tabNeuronNetwork);
            this.tabControl.Controls.Add(this.tabLogs);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(951, 473);
            this.tabControl.TabIndex = 0;
            // 
            // tabPreprocessing
            // 
            this.tabPreprocessing.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPreprocessing.Controls.Add(this.buttonTrainDataGet);
            this.tabPreprocessing.Controls.Add(this.txtTrainDataColumn);
            this.tabPreprocessing.Controls.Add(this.txtTrainDataToRow);
            this.tabPreprocessing.Controls.Add(this.txtTrainDataFromRow);
            this.tabPreprocessing.Controls.Add(this.label18);
            this.tabPreprocessing.Controls.Add(this.labelTrainDataNumColumns);
            this.tabPreprocessing.Controls.Add(this.labelTrainDataNumRows);
            this.tabPreprocessing.Controls.Add(this.label15);
            this.tabPreprocessing.Controls.Add(this.label14);
            this.tabPreprocessing.Controls.Add(this.label13);
            this.tabPreprocessing.Controls.Add(this.label12);
            this.tabPreprocessing.Controls.Add(this.btnRestore);
            this.tabPreprocessing.Controls.Add(this.btnProcess);
            this.tabPreprocessing.Controls.Add(this.btnCorrelogram);
            this.tabPreprocessing.Controls.Add(this.btnPlot);
            this.tabPreprocessing.Controls.Add(this.boxDeseasonality);
            this.tabPreprocessing.Controls.Add(this.boxDetrend);
            this.tabPreprocessing.Controls.Add(this.boxScale);
            this.tabPreprocessing.Controls.Add(this.richTextProprocessData);
            this.tabPreprocessing.Controls.Add(this.btnPreprocessSaveData);
            this.tabPreprocessing.Controls.Add(this.btnPreprocessOpenData);
            this.tabPreprocessing.Controls.Add(this.label1);
            this.tabPreprocessing.Location = new System.Drawing.Point(4, 25);
            this.tabPreprocessing.Name = "tabPreprocessing";
            this.tabPreprocessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreprocessing.Size = new System.Drawing.Size(943, 444);
            this.tabPreprocessing.TabIndex = 0;
            this.tabPreprocessing.Text = "Time Series Preprocessing";
            // 
            // buttonTrainDataGet
            // 
            this.buttonTrainDataGet.Location = new System.Drawing.Point(211, 108);
            this.buttonTrainDataGet.Name = "buttonTrainDataGet";
            this.buttonTrainDataGet.Size = new System.Drawing.Size(66, 42);
            this.buttonTrainDataGet.TabIndex = 21;
            this.buttonTrainDataGet.Text = "Get";
            this.buttonTrainDataGet.UseVisualStyleBackColor = true;
            this.buttonTrainDataGet.Click += new System.EventHandler(this.buttonTrainDataGet_Click);
            // 
            // txtTrainDataColumn
            // 
            this.txtTrainDataColumn.Location = new System.Drawing.Point(83, 102);
            this.txtTrainDataColumn.Name = "txtTrainDataColumn";
            this.txtTrainDataColumn.Size = new System.Drawing.Size(80, 23);
            this.txtTrainDataColumn.TabIndex = 20;
            // 
            // txtTrainDataToRow
            // 
            this.txtTrainDataToRow.Location = new System.Drawing.Point(211, 79);
            this.txtTrainDataToRow.Name = "txtTrainDataToRow";
            this.txtTrainDataToRow.Size = new System.Drawing.Size(100, 23);
            this.txtTrainDataToRow.TabIndex = 19;
            // 
            // txtTrainDataFromRow
            // 
            this.txtTrainDataFromRow.Location = new System.Drawing.Point(83, 78);
            this.txtTrainDataFromRow.Name = "txtTrainDataFromRow";
            this.txtTrainDataFromRow.Size = new System.Drawing.Size(80, 23);
            this.txtTrainDataFromRow.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "to";
            // 
            // labelTrainDataNumColumns
            // 
            this.labelTrainDataNumColumns.AutoSize = true;
            this.labelTrainDataNumColumns.Location = new System.Drawing.Point(179, 56);
            this.labelTrainDataNumColumns.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelTrainDataNumColumns.Name = "labelTrainDataNumColumns";
            this.labelTrainDataNumColumns.Size = new System.Drawing.Size(60, 17);
            this.labelTrainDataNumColumns.TabIndex = 16;
            // 
            // labelTrainDataNumRows
            // 
            this.labelTrainDataNumRows.AutoSize = true;
            this.labelTrainDataNumRows.Location = new System.Drawing.Point(179, 34);
            this.labelTrainDataNumRows.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelTrainDataNumRows.Name = "labelTrainDataNumRows";
            this.labelTrainDataNumRows.Size = new System.Drawing.Size(60, 17);
            this.labelTrainDataNumRows.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Column";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Row";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Num Columns:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Num Rows:";
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(812, 389);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(98, 51);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(679, 389);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(98, 51);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCorrelogram
            // 
            this.btnCorrelogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrelogram.Location = new System.Drawing.Point(523, 389);
            this.btnCorrelogram.Name = "btnCorrelogram";
            this.btnCorrelogram.Size = new System.Drawing.Size(115, 51);
            this.btnCorrelogram.TabIndex = 8;
            this.btnCorrelogram.Text = "Correlogram";
            this.btnCorrelogram.UseVisualStyleBackColor = true;
            this.btnCorrelogram.Click += new System.EventHandler(this.btnCorrelogram_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.Location = new System.Drawing.Point(390, 389);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(98, 51);
            this.btnPlot.TabIndex = 7;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // boxDeseasonality
            // 
            this.boxDeseasonality.Controls.Add(this.textBox_Cycle);
            this.boxDeseasonality.Controls.Add(this.label_cycle);
            this.boxDeseasonality.Controls.Add(this.radioNoneDeseasonality);
            this.boxDeseasonality.Controls.Add(this.radioSeasonalAdjustment);
            this.boxDeseasonality.Controls.Add(this.txtNumLagAtDeseasonality);
            this.boxDeseasonality.Controls.Add(this.label2);
            this.boxDeseasonality.Controls.Add(this.radioDifferenceSeasonality);
            this.boxDeseasonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDeseasonality.Location = new System.Drawing.Point(373, 233);
            this.boxDeseasonality.Name = "boxDeseasonality";
            this.boxDeseasonality.Size = new System.Drawing.Size(558, 117);
            this.boxDeseasonality.TabIndex = 6;
            this.boxDeseasonality.TabStop = false;
            this.boxDeseasonality.Text = "Deseasonality";
            // 
            // textBox_Cycle
            // 
            this.textBox_Cycle.Enabled = false;
            this.textBox_Cycle.Location = new System.Drawing.Point(362, 52);
            this.textBox_Cycle.Name = "textBox_Cycle";
            this.textBox_Cycle.Size = new System.Drawing.Size(100, 23);
            this.textBox_Cycle.TabIndex = 7;
            this.textBox_Cycle.Visible = false;
            // 
            // label_cycle
            // 
            this.label_cycle.AutoSize = true;
            this.label_cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cycle.Location = new System.Drawing.Point(303, 57);
            this.label_cycle.Name = "label_cycle";
            this.label_cycle.Size = new System.Drawing.Size(42, 16);
            this.label_cycle.TabIndex = 6;
            this.label_cycle.Text = "Cycle";
            this.label_cycle.Visible = false;
            // 
            // radioNoneDeseasonality
            // 
            this.radioNoneDeseasonality.AutoSize = true;
            this.radioNoneDeseasonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNoneDeseasonality.Location = new System.Drawing.Point(71, 81);
            this.radioNoneDeseasonality.Name = "radioNoneDeseasonality";
            this.radioNoneDeseasonality.Size = new System.Drawing.Size(60, 21);
            this.radioNoneDeseasonality.TabIndex = 5;
            this.radioNoneDeseasonality.TabStop = true;
            this.radioNoneDeseasonality.Text = "None";
            this.radioNoneDeseasonality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNoneDeseasonality.UseVisualStyleBackColor = true;
            this.radioNoneDeseasonality.CheckedChanged += new System.EventHandler(this.radioNoneDeseasonality_CheckedChanged);
            // 
            // radioSeasonalAdjustment
            // 
            this.radioSeasonalAdjustment.AutoSize = true;
            this.radioSeasonalAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSeasonalAdjustment.Location = new System.Drawing.Point(71, 52);
            this.radioSeasonalAdjustment.Name = "radioSeasonalAdjustment";
            this.radioSeasonalAdjustment.Size = new System.Drawing.Size(159, 21);
            this.radioSeasonalAdjustment.TabIndex = 3;
            this.radioSeasonalAdjustment.TabStop = true;
            this.radioSeasonalAdjustment.Text = "Seasonal Adjustment";
            this.radioSeasonalAdjustment.UseVisualStyleBackColor = true;
            this.radioSeasonalAdjustment.CheckedChanged += new System.EventHandler(this.radioSeasonalAdjustment_CheckedChanged);
            // 
            // txtNumLagAtDeseasonality
            // 
            this.txtNumLagAtDeseasonality.Enabled = false;
            this.txtNumLagAtDeseasonality.Location = new System.Drawing.Point(362, 22);
            this.txtNumLagAtDeseasonality.Name = "txtNumLagAtDeseasonality";
            this.txtNumLagAtDeseasonality.Size = new System.Drawing.Size(100, 23);
            this.txtNumLagAtDeseasonality.TabIndex = 2;
            this.txtNumLagAtDeseasonality.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lag";
            this.label2.Visible = false;
            // 
            // radioDifferenceSeasonality
            // 
            this.radioDifferenceSeasonality.AutoSize = true;
            this.radioDifferenceSeasonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifferenceSeasonality.Location = new System.Drawing.Point(71, 24);
            this.radioDifferenceSeasonality.Name = "radioDifferenceSeasonality";
            this.radioDifferenceSeasonality.Size = new System.Drawing.Size(154, 21);
            this.radioDifferenceSeasonality.TabIndex = 0;
            this.radioDifferenceSeasonality.TabStop = true;
            this.radioDifferenceSeasonality.Text = "Seasonal Difference";
            this.radioDifferenceSeasonality.UseVisualStyleBackColor = true;
            this.radioDifferenceSeasonality.CheckedChanged += new System.EventHandler(this.radioDifferenceSeasonality_CheckedChanged);
            // 
            // boxDetrend
            // 
            this.boxDetrend.Controls.Add(this.radioNoneDetrend);
            this.boxDetrend.Controls.Add(this.radioLinearDetrend);
            this.boxDetrend.Controls.Add(this.radioDifference);
            this.boxDetrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDetrend.Location = new System.Drawing.Point(373, 115);
            this.boxDetrend.Name = "boxDetrend";
            this.boxDetrend.Size = new System.Drawing.Size(558, 96);
            this.boxDetrend.TabIndex = 5;
            this.boxDetrend.TabStop = false;
            this.boxDetrend.Text = "Detrend";
            // 
            // radioNoneDetrend
            // 
            this.radioNoneDetrend.AutoSize = true;
            this.radioNoneDetrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNoneDetrend.Location = new System.Drawing.Point(68, 56);
            this.radioNoneDetrend.Name = "radioNoneDetrend";
            this.radioNoneDetrend.Size = new System.Drawing.Size(60, 21);
            this.radioNoneDetrend.TabIndex = 3;
            this.radioNoneDetrend.TabStop = true;
            this.radioNoneDetrend.Text = "None";
            this.radioNoneDetrend.UseVisualStyleBackColor = true;
            // 
            // radioLinearDetrend
            // 
            this.radioLinearDetrend.AutoSize = true;
            this.radioLinearDetrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLinearDetrend.Location = new System.Drawing.Point(282, 22);
            this.radioLinearDetrend.Name = "radioLinearDetrend";
            this.radioLinearDetrend.Size = new System.Drawing.Size(121, 21);
            this.radioLinearDetrend.TabIndex = 1;
            this.radioLinearDetrend.TabStop = true;
            this.radioLinearDetrend.Text = "Linear Detrend";
            this.radioLinearDetrend.UseVisualStyleBackColor = true;
            // 
            // radioDifference
            // 
            this.radioDifference.AutoSize = true;
            this.radioDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDifference.Location = new System.Drawing.Point(69, 22);
            this.radioDifference.Name = "radioDifference";
            this.radioDifference.Size = new System.Drawing.Size(91, 21);
            this.radioDifference.TabIndex = 0;
            this.radioDifference.TabStop = true;
            this.radioDifference.Text = "Difference";
            this.radioDifference.UseVisualStyleBackColor = true;
            // 
            // boxScale
            // 
            this.boxScale.Controls.Add(this.checkBoxLnTransformation);
            this.boxScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxScale.Location = new System.Drawing.Point(373, 6);
            this.boxScale.Name = "boxScale";
            this.boxScale.Size = new System.Drawing.Size(559, 90);
            this.boxScale.TabIndex = 4;
            this.boxScale.TabStop = false;
            this.boxScale.Text = "Transformation";
            // 
            // checkBoxLnTransformation
            // 
            this.checkBoxLnTransformation.AutoSize = true;
            this.checkBoxLnTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLnTransformation.Location = new System.Drawing.Point(65, 30);
            this.checkBoxLnTransformation.Name = "checkBoxLnTransformation";
            this.checkBoxLnTransformation.Size = new System.Drawing.Size(143, 21);
            this.checkBoxLnTransformation.TabIndex = 5;
            this.checkBoxLnTransformation.Text = "Ln Transformation";
            this.checkBoxLnTransformation.UseVisualStyleBackColor = true;
            // 
            // richTextProprocessData
            // 
            this.richTextProprocessData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextProprocessData.Location = new System.Drawing.Point(8, 156);
            this.richTextProprocessData.Name = "richTextProprocessData";
            this.richTextProprocessData.ReadOnly = true;
            this.richTextProprocessData.Size = new System.Drawing.Size(347, 284);
            this.richTextProprocessData.TabIndex = 3;
            this.richTextProprocessData.Text = "";
            // 
            // btnPreprocessSaveData
            // 
            this.btnPreprocessSaveData.Location = new System.Drawing.Point(283, 108);
            this.btnPreprocessSaveData.Name = "btnPreprocessSaveData";
            this.btnPreprocessSaveData.Size = new System.Drawing.Size(66, 42);
            this.btnPreprocessSaveData.TabIndex = 2;
            this.btnPreprocessSaveData.Text = "Save";
            this.btnPreprocessSaveData.UseVisualStyleBackColor = true;
            this.btnPreprocessSaveData.Click += new System.EventHandler(this.btnPreprocessSaveData_Click);
            // 
            // btnPreprocessOpenData
            // 
            this.btnPreprocessOpenData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPreprocessOpenData.Location = new System.Drawing.Point(266, 6);
            this.btnPreprocessOpenData.Name = "btnPreprocessOpenData";
            this.btnPreprocessOpenData.Size = new System.Drawing.Size(75, 23);
            this.btnPreprocessOpenData.TabIndex = 1;
            this.btnPreprocessOpenData.Text = "Browse";
            this.btnPreprocessOpenData.UseVisualStyleBackColor = false;
            this.btnPreprocessOpenData.Click += new System.EventHandler(this.btnPreprocessOpenData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Series Data";
            // 
            // tabNeuronNetwork
            // 
            this.tabNeuronNetwork.BackColor = System.Drawing.Color.SeaGreen;
            this.tabNeuronNetwork.Controls.Add(this.groupBoxValidate);
            this.tabNeuronNetwork.Controls.Add(this.groupBoxAlgorithmConfig);
            this.tabNeuronNetwork.Controls.Add(this.groupBoxTraining);
            this.tabNeuronNetwork.Controls.Add(this.groupBoxNetworkConfig);
            this.tabNeuronNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNeuronNetwork.Location = new System.Drawing.Point(4, 25);
            this.tabNeuronNetwork.Name = "tabNeuronNetwork";
            this.tabNeuronNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNeuronNetwork.Size = new System.Drawing.Size(943, 444);
            this.tabNeuronNetwork.TabIndex = 1;
            this.tabNeuronNetwork.Text = "Neuron Network";
            // 
            // groupBoxValidate
            // 
            this.groupBoxValidate.Controls.Add(this.label26);
            this.groupBoxValidate.Controls.Add(this.txtAhead);
            this.groupBoxValidate.Controls.Add(this.btnForecast);
            this.groupBoxValidate.Controls.Add(this.btnTest);
            this.groupBoxValidate.Controls.Add(this.txtTestToRow);
            this.groupBoxValidate.Controls.Add(this.label17);
            this.groupBoxValidate.Controls.Add(this.txtTestFromRow);
            this.groupBoxValidate.Controls.Add(this.labelTestRow);
            this.groupBoxValidate.Controls.Add(this.txtValidateColumn);
            this.groupBoxValidate.Controls.Add(this.txtValidateToRow);
            this.groupBoxValidate.Controls.Add(this.txtValidateFromRow);
            this.groupBoxValidate.Controls.Add(this.label25);
            this.groupBoxValidate.Controls.Add(this.label24);
            this.groupBoxValidate.Controls.Add(this.label23);
            this.groupBoxValidate.Controls.Add(this.labelValidateNumRows);
            this.groupBoxValidate.Controls.Add(this.labelValidateNumColumns);
            this.groupBoxValidate.Controls.Add(this.label22);
            this.groupBoxValidate.Controls.Add(this.label21);
            this.groupBoxValidate.Controls.Add(this.txtValidateFileName);
            this.groupBoxValidate.Controls.Add(this.btnValidateBrowse);
            this.groupBoxValidate.Controls.Add(this.label20);
            this.groupBoxValidate.Enabled = false;
            this.groupBoxValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxValidate.Location = new System.Drawing.Point(320, 152);
            this.groupBoxValidate.Name = "groupBoxValidate";
            this.groupBoxValidate.Size = new System.Drawing.Size(314, 288);
            this.groupBoxValidate.TabIndex = 4;
            this.groupBoxValidate.TabStop = false;
            this.groupBoxValidate.Text = "Validate Test Config";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(124, 251);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 17);
            this.label26.TabIndex = 41;
            this.label26.Text = "A Head";
            // 
            // txtAhead
            // 
            this.txtAhead.Location = new System.Drawing.Point(191, 248);
            this.txtAhead.Name = "txtAhead";
            this.txtAhead.Size = new System.Drawing.Size(100, 23);
            this.txtAhead.TabIndex = 40;
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(23, 244);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(81, 31);
            this.btnForecast.TabIndex = 39;
            this.btnForecast.Text = "Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(219, 184);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 37);
            this.btnTest.TabIndex = 38;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTestToRow
            // 
            this.txtTestToRow.Location = new System.Drawing.Point(161, 198);
            this.txtTestToRow.Name = "txtTestToRow";
            this.txtTestToRow.Size = new System.Drawing.Size(47, 23);
            this.txtTestToRow.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(124, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "To";
            // 
            // txtTestFromRow
            // 
            this.txtTestFromRow.Location = new System.Drawing.Point(76, 198);
            this.txtTestFromRow.Name = "txtTestFromRow";
            this.txtTestFromRow.Size = new System.Drawing.Size(42, 23);
            this.txtTestFromRow.TabIndex = 35;
            // 
            // labelTestRow
            // 
            this.labelTestRow.AutoSize = true;
            this.labelTestRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestRow.Location = new System.Drawing.Point(17, 205);
            this.labelTestRow.Name = "labelTestRow";
            this.labelTestRow.Size = new System.Drawing.Size(44, 16);
            this.labelTestRow.TabIndex = 34;
            this.labelTestRow.Text = "TRow";
            // 
            // txtValidateColumn
            // 
            this.txtValidateColumn.Location = new System.Drawing.Point(65, 147);
            this.txtValidateColumn.Name = "txtValidateColumn";
            this.txtValidateColumn.Size = new System.Drawing.Size(100, 23);
            this.txtValidateColumn.TabIndex = 33;
            this.txtValidateColumn.Visible = false;
            // 
            // txtValidateToRow
            // 
            this.txtValidateToRow.Location = new System.Drawing.Point(171, 149);
            this.txtValidateToRow.Name = "txtValidateToRow";
            this.txtValidateToRow.Size = new System.Drawing.Size(119, 23);
            this.txtValidateToRow.TabIndex = 32;
            this.txtValidateToRow.Visible = false;
            // 
            // txtValidateFromRow
            // 
            this.txtValidateFromRow.Location = new System.Drawing.Point(57, 149);
            this.txtValidateFromRow.Name = "txtValidateFromRow";
            this.txtValidateFromRow.Size = new System.Drawing.Size(79, 23);
            this.txtValidateFromRow.TabIndex = 31;
            this.txtValidateFromRow.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 150);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 17);
            this.label25.TabIndex = 30;
            this.label25.Text = "Column";
            this.label25.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(140, 155);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 17);
            this.label24.TabIndex = 29;
            this.label24.Text = "To";
            this.label24.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 17);
            this.label23.TabIndex = 26;
            this.label23.Text = "Row";
            this.label23.Visible = false;
            // 
            // labelValidateNumRows
            // 
            this.labelValidateNumRows.AutoSize = true;
            this.labelValidateNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidateNumRows.Location = new System.Drawing.Point(132, 98);
            this.labelValidateNumRows.Name = "labelValidateNumRows";
            this.labelValidateNumRows.Size = new System.Drawing.Size(158, 17);
            this.labelValidateNumRows.TabIndex = 28;
            this.labelValidateNumRows.Text = "Choose Training File";
            // 
            // labelValidateNumColumns
            // 
            this.labelValidateNumColumns.AutoSize = true;
            this.labelValidateNumColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidateNumColumns.Location = new System.Drawing.Point(133, 124);
            this.labelValidateNumColumns.Name = "labelValidateNumColumns";
            this.labelValidateNumColumns.Size = new System.Drawing.Size(158, 17);
            this.labelValidateNumColumns.TabIndex = 27;
            this.labelValidateNumColumns.Text = "Choose Training File";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 17);
            this.label22.TabIndex = 25;
            this.label22.Text = "Num columns";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Num Rows";
            // 
            // txtValidateFileName
            // 
            this.txtValidateFileName.Location = new System.Drawing.Point(10, 64);
            this.txtValidateFileName.Name = "txtValidateFileName";
            this.txtValidateFileName.Size = new System.Drawing.Size(279, 23);
            this.txtValidateFileName.TabIndex = 23;
            // 
            // btnValidateBrowse
            // 
            this.btnValidateBrowse.Location = new System.Drawing.Point(185, 22);
            this.btnValidateBrowse.Name = "btnValidateBrowse";
            this.btnValidateBrowse.Size = new System.Drawing.Size(104, 39);
            this.btnValidateBrowse.TabIndex = 22;
            this.btnValidateBrowse.Text = "Browse";
            this.btnValidateBrowse.UseVisualStyleBackColor = true;
            this.btnValidateBrowse.Click += new System.EventHandler(this.btnValidateBrowse_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 17);
            this.label20.TabIndex = 21;
            this.label20.Text = "Choose Validate File";
            // 
            // groupBoxAlgorithmConfig
            // 
            this.groupBoxAlgorithmConfig.Controls.Add(textBoxMinValue);
            this.groupBoxAlgorithmConfig.Controls.Add(textBoxMaxValue);
            this.groupBoxAlgorithmConfig.Controls.Add(this.label28);
            this.groupBoxAlgorithmConfig.Controls.Add(this.label27);
            this.groupBoxAlgorithmConfig.Controls.Add(this.radioLoopTrain);
            this.groupBoxAlgorithmConfig.Controls.Add(this.label19);
            this.groupBoxAlgorithmConfig.Controls.Add(this.radioLoopValidate);
            this.groupBoxAlgorithmConfig.Controls.Add(this.txtConfigErrors);
            this.groupBoxAlgorithmConfig.Controls.Add(this.txtConfig2);
            this.groupBoxAlgorithmConfig.Controls.Add(this.txtConfigEpoches);
            this.groupBoxAlgorithmConfig.Controls.Add(this.txtConfig1);
            this.groupBoxAlgorithmConfig.Controls.Add(this.labelConfigResidual);
            this.groupBoxAlgorithmConfig.Controls.Add(this.labelConfigEpoches);
            this.groupBoxAlgorithmConfig.Controls.Add(this.labelConfig2);
            this.groupBoxAlgorithmConfig.Controls.Add(this.labelConfig1);
            this.groupBoxAlgorithmConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAlgorithmConfig.Location = new System.Drawing.Point(640, 152);
            this.groupBoxAlgorithmConfig.Name = "groupBoxAlgorithmConfig";
            this.groupBoxAlgorithmConfig.Size = new System.Drawing.Size(282, 284);
            this.groupBoxAlgorithmConfig.TabIndex = 3;
            this.groupBoxAlgorithmConfig.TabStop = false;
            this.groupBoxAlgorithmConfig.Text = "RPROP Config";
            // 
            // textBoxMinValue
            // 
            textBoxMinValue.Location = new System.Drawing.Point(126, 255);
            textBoxMinValue.Name = "textBoxMinValue";
            textBoxMinValue.Size = new System.Drawing.Size(100, 23);
            textBoxMinValue.TabIndex = 14;
            // 
            // textBoxMaxValue
            // 
            textBoxMaxValue.Location = new System.Drawing.Point(126, 219);
            textBoxMaxValue.Name = "textBoxMaxValue";
            textBoxMaxValue.Size = new System.Drawing.Size(100, 23);
            textBoxMaxValue.TabIndex = 13;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 251);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 17);
            this.label28.TabIndex = 12;
            this.label28.Text = "MinValue";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 225);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 17);
            this.label27.TabIndex = 11;
            this.label27.Text = "MaxValue";
            // 
            // radioLoopTrain
            // 
            this.radioLoopTrain.AutoSize = true;
            this.radioLoopTrain.Checked = true;
            this.radioLoopTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLoopTrain.Location = new System.Drawing.Point(6, 184);
            this.radioLoopTrain.Name = "radioLoopTrain";
            this.radioLoopTrain.Size = new System.Drawing.Size(121, 21);
            this.radioLoopTrain.TabIndex = 10;
            this.radioLoopTrain.TabStop = true;
            this.radioLoopTrain.Text = "Use Train MAE";
            this.radioLoopTrain.UseVisualStyleBackColor = true;
            this.radioLoopTrain.Visible = false;
            this.radioLoopTrain.CheckedChanged += new System.EventHandler(this.radioLoopTrain_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "Loop Condition";
            this.label19.Visible = false;
            // 
            // radioLoopValidate
            // 
            this.radioLoopValidate.AutoSize = true;
            this.radioLoopValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLoopValidate.Location = new System.Drawing.Point(32, 184);
            this.radioLoopValidate.Name = "radioLoopValidate";
            this.radioLoopValidate.Size = new System.Drawing.Size(139, 21);
            this.radioLoopValidate.TabIndex = 8;
            this.radioLoopValidate.Text = "Use Validate MAE";
            this.radioLoopValidate.UseVisualStyleBackColor = true;
            this.radioLoopValidate.Visible = false;
            this.radioLoopValidate.CheckedChanged += new System.EventHandler(this.radioLoopValidate_CheckedChanged);
            // 
            // txtConfigErrors
            // 
            this.txtConfigErrors.Location = new System.Drawing.Point(176, 155);
            this.txtConfigErrors.Name = "txtConfigErrors";
            this.txtConfigErrors.Size = new System.Drawing.Size(100, 23);
            this.txtConfigErrors.TabIndex = 7;
            // 
            // txtConfig2
            // 
            this.txtConfig2.Location = new System.Drawing.Point(174, 114);
            this.txtConfig2.Name = "txtConfig2";
            this.txtConfig2.Size = new System.Drawing.Size(100, 23);
            this.txtConfig2.TabIndex = 6;
            // 
            // txtConfigEpoches
            // 
            this.txtConfigEpoches.Location = new System.Drawing.Point(174, 71);
            this.txtConfigEpoches.Name = "txtConfigEpoches";
            this.txtConfigEpoches.Size = new System.Drawing.Size(100, 23);
            this.txtConfigEpoches.TabIndex = 5;
            // 
            // txtConfig1
            // 
            this.txtConfig1.Location = new System.Drawing.Point(174, 33);
            this.txtConfig1.Name = "txtConfig1";
            this.txtConfig1.Size = new System.Drawing.Size(100, 23);
            this.txtConfig1.TabIndex = 4;
            // 
            // labelConfigResidual
            // 
            this.labelConfigResidual.AutoSize = true;
            this.labelConfigResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigResidual.Location = new System.Drawing.Point(9, 155);
            this.labelConfigResidual.Name = "labelConfigResidual";
            this.labelConfigResidual.Size = new System.Drawing.Size(122, 17);
            this.labelConfigResidual.TabIndex = 3;
            this.labelConfigResidual.Text = "Residual of Errors";
            // 
            // labelConfigEpoches
            // 
            this.labelConfigEpoches.AutoSize = true;
            this.labelConfigEpoches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigEpoches.Location = new System.Drawing.Point(9, 74);
            this.labelConfigEpoches.Name = "labelConfigEpoches";
            this.labelConfigEpoches.Size = new System.Drawing.Size(162, 17);
            this.labelConfigEpoches.TabIndex = 2;
            this.labelConfigEpoches.Text = "Max Number of Epoches";
            // 
            // labelConfig2
            // 
            this.labelConfig2.AutoSize = true;
            this.labelConfig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig2.Location = new System.Drawing.Point(9, 119);
            this.labelConfig2.Name = "labelConfig2";
            this.labelConfig2.Size = new System.Drawing.Size(123, 17);
            this.labelConfig2.TabIndex = 1;
            this.labelConfig2.Text = "Max Update Value";
            // 
            // labelConfig1
            // 
            this.labelConfig1.AutoSize = true;
            this.labelConfig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig1.Location = new System.Drawing.Point(9, 36);
            this.labelConfig1.Name = "labelConfig1";
            this.labelConfig1.Size = new System.Drawing.Size(143, 17);
            this.labelConfig1.TabIndex = 0;
            this.labelConfig1.Text = "Default Update Value";
            // 
            // groupBoxTraining
            // 
            this.groupBoxTraining.Controls.Add(this.txtTrainingToRow);
            this.groupBoxTraining.Controls.Add(this.txtTrainingFileName);
            this.groupBoxTraining.Controls.Add(this.labelTrainingNumColumns);
            this.groupBoxTraining.Controls.Add(this.labelTrainingNumRows);
            this.groupBoxTraining.Controls.Add(this.btnTrain);
            this.groupBoxTraining.Controls.Add(this.radioRPROP);
            this.groupBoxTraining.Controls.Add(this.radioBackPropagation);
            this.groupBoxTraining.Controls.Add(this.label11);
            this.groupBoxTraining.Controls.Add(this.txtTrainingFromRow);
            this.groupBoxTraining.Controls.Add(this.txtTrainingColumn);
            this.groupBoxTraining.Controls.Add(this.label10);
            this.groupBoxTraining.Controls.Add(this.label9);
            this.groupBoxTraining.Controls.Add(this.label8);
            this.groupBoxTraining.Controls.Add(this.label7);
            this.groupBoxTraining.Controls.Add(this.label6);
            this.groupBoxTraining.Controls.Add(this.btnTrainingBrowse);
            this.groupBoxTraining.Controls.Add(this.label5);
            this.groupBoxTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTraining.Location = new System.Drawing.Point(8, 152);
            this.groupBoxTraining.Name = "groupBoxTraining";
            this.groupBoxTraining.Size = new System.Drawing.Size(305, 288);
            this.groupBoxTraining.TabIndex = 1;
            this.groupBoxTraining.TabStop = false;
            this.groupBoxTraining.Text = "Training";
            // 
            // txtTrainingToRow
            // 
            this.txtTrainingToRow.Location = new System.Drawing.Point(206, 161);
            this.txtTrainingToRow.Name = "txtTrainingToRow";
            this.txtTrainingToRow.Size = new System.Drawing.Size(90, 23);
            this.txtTrainingToRow.TabIndex = 19;
            // 
            // txtTrainingFileName
            // 
            this.txtTrainingFileName.Location = new System.Drawing.Point(10, 61);
            this.txtTrainingFileName.Name = "txtTrainingFileName";
            this.txtTrainingFileName.Size = new System.Drawing.Size(286, 23);
            this.txtTrainingFileName.TabIndex = 18;
            // 
            // labelTrainingNumColumns
            // 
            this.labelTrainingNumColumns.AutoSize = true;
            this.labelTrainingNumColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingNumColumns.Location = new System.Drawing.Point(177, 115);
            this.labelTrainingNumColumns.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelTrainingNumColumns.Name = "labelTrainingNumColumns";
            this.labelTrainingNumColumns.Size = new System.Drawing.Size(50, 17);
            this.labelTrainingNumColumns.TabIndex = 17;
            this.labelTrainingNumColumns.Text = "AAA";
            // 
            // labelTrainingNumRows
            // 
            this.labelTrainingNumRows.AutoSize = true;
            this.labelTrainingNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingNumRows.Location = new System.Drawing.Point(177, 91);
            this.labelTrainingNumRows.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelTrainingNumRows.Name = "labelTrainingNumRows";
            this.labelTrainingNumRows.Size = new System.Drawing.Size(50, 17);
            this.labelTrainingNumRows.TabIndex = 16;
            this.labelTrainingNumRows.Text = "AAA";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(223, 235);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 49);
            this.btnTrain.TabIndex = 15;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // radioRPROP
            // 
            this.radioRPROP.AutoSize = true;
            this.radioRPROP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRPROP.Location = new System.Drawing.Point(87, 259);
            this.radioRPROP.Name = "radioRPROP";
            this.radioRPROP.Size = new System.Drawing.Size(75, 21);
            this.radioRPROP.TabIndex = 14;
            this.radioRPROP.TabStop = true;
            this.radioRPROP.Text = "RPROP";
            this.radioRPROP.UseVisualStyleBackColor = true;
            this.radioRPROP.CheckedChanged += new System.EventHandler(this.radioRPROP_CheckedChanged);
            // 
            // radioBackPropagation
            // 
            this.radioBackPropagation.AutoSize = true;
            this.radioBackPropagation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBackPropagation.Location = new System.Drawing.Point(87, 235);
            this.radioBackPropagation.Name = "radioBackPropagation";
            this.radioBackPropagation.Size = new System.Drawing.Size(138, 21);
            this.radioBackPropagation.TabIndex = 13;
            this.radioBackPropagation.TabStop = true;
            this.radioBackPropagation.Text = "Back Propagation";
            this.radioBackPropagation.UseVisualStyleBackColor = true;
            this.radioBackPropagation.CheckedChanged += new System.EventHandler(this.radioBackPropagation_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Algorithm";
            // 
            // txtTrainingFromRow
            // 
            this.txtTrainingFromRow.Location = new System.Drawing.Point(59, 161);
            this.txtTrainingFromRow.Name = "txtTrainingFromRow";
            this.txtTrainingFromRow.Size = new System.Drawing.Size(90, 23);
            this.txtTrainingFromRow.TabIndex = 11;
            // 
            // txtTrainingColumn
            // 
            this.txtTrainingColumn.Location = new System.Drawing.Point(168, 201);
            this.txtTrainingColumn.Name = "txtTrainingColumn";
            this.txtTrainingColumn.Size = new System.Drawing.Size(128, 23);
            this.txtTrainingColumn.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Column";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Row";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Num Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Num Rows";
            // 
            // btnTrainingBrowse
            // 
            this.btnTrainingBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingBrowse.Location = new System.Drawing.Point(189, 19);
            this.btnTrainingBrowse.Name = "btnTrainingBrowse";
            this.btnTrainingBrowse.Size = new System.Drawing.Size(108, 39);
            this.btnTrainingBrowse.TabIndex = 1;
            this.btnTrainingBrowse.Text = "Browse";
            this.btnTrainingBrowse.UseVisualStyleBackColor = true;
            this.btnTrainingBrowse.Click += new System.EventHandler(this.btnTrainingBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose Training File";
            // 
            // groupBoxNetworkConfig
            // 
            this.groupBoxNetworkConfig.Controls.Add(this.label16);
            this.groupBoxNetworkConfig.Controls.Add(this.rtbPreProcess);
            this.groupBoxNetworkConfig.Controls.Add(this.tbLag);
            this.groupBoxNetworkConfig.Controls.Add(this.btnSadj);
            this.groupBoxNetworkConfig.Controls.Add(this.btnSDiff);
            this.groupBoxNetworkConfig.Controls.Add(this.btnLn);
            this.groupBoxNetworkConfig.Controls.Add(this.btnDtrend);
            this.groupBoxNetworkConfig.Controls.Add(this.btnDiff);
            this.groupBoxNetworkConfig.Controls.Add(this.btnNetworkClear);
            this.groupBoxNetworkConfig.Controls.Add(this.btnNetworkSave);
            this.groupBoxNetworkConfig.Controls.Add(this.btnNetworkLoad);
            this.groupBoxNetworkConfig.Controls.Add(this.btnNetworkNew);
            this.groupBoxNetworkConfig.Controls.Add(this.txtNumLag);
            this.groupBoxNetworkConfig.Controls.Add(this.label4);
            this.groupBoxNetworkConfig.Controls.Add(this.txtNumOutput);
            this.groupBoxNetworkConfig.Controls.Add(this.txtNumHidden);
            this.groupBoxNetworkConfig.Controls.Add(this.txtNumInput);
            this.groupBoxNetworkConfig.Controls.Add(this.label3);
            this.groupBoxNetworkConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNetworkConfig.Location = new System.Drawing.Point(8, 15);
            this.groupBoxNetworkConfig.Name = "groupBoxNetworkConfig";
            this.groupBoxNetworkConfig.Size = new System.Drawing.Size(915, 131);
            this.groupBoxNetworkConfig.TabIndex = 0;
            this.groupBoxNetworkConfig.TabStop = false;
            this.groupBoxNetworkConfig.Text = "Network Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Lag/Cycle";
            // 
            // rtbPreProcess
            // 
            this.rtbPreProcess.Location = new System.Drawing.Point(734, 19);
            this.rtbPreProcess.Name = "rtbPreProcess";
            this.rtbPreProcess.Size = new System.Drawing.Size(162, 100);
            this.rtbPreProcess.TabIndex = 17;
            this.rtbPreProcess.Text = "";
            // 
            // tbLag
            // 
            this.tbLag.Location = new System.Drawing.Point(607, 90);
            this.tbLag.Name = "tbLag";
            this.tbLag.Size = new System.Drawing.Size(100, 23);
            this.tbLag.TabIndex = 16;
            this.tbLag.Text = "12";
            // 
            // btnSadj
            // 
            this.btnSadj.Location = new System.Drawing.Point(394, 90);
            this.btnSadj.Name = "btnSadj";
            this.btnSadj.Size = new System.Drawing.Size(75, 23);
            this.btnSadj.TabIndex = 15;
            this.btnSadj.Text = "SADJ";
            this.btnSadj.UseVisualStyleBackColor = true;
            this.btnSadj.Click += new System.EventHandler(this.btnSadj_Click);
            // 
            // btnSDiff
            // 
            this.btnSDiff.Location = new System.Drawing.Point(311, 90);
            this.btnSDiff.Name = "btnSDiff";
            this.btnSDiff.Size = new System.Drawing.Size(75, 23);
            this.btnSDiff.TabIndex = 14;
            this.btnSDiff.Text = "SDIFF";
            this.btnSDiff.UseVisualStyleBackColor = true;
            this.btnSDiff.Click += new System.EventHandler(this.btnSDiff_Click);
            // 
            // btnLn
            // 
            this.btnLn.Enabled = false;
            this.btnLn.Location = new System.Drawing.Point(473, 61);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(75, 23);
            this.btnLn.TabIndex = 13;
            this.btnLn.Text = "LN";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Visible = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnDtrend
            // 
            this.btnDtrend.Location = new System.Drawing.Point(392, 61);
            this.btnDtrend.Name = "btnDtrend";
            this.btnDtrend.Size = new System.Drawing.Size(75, 23);
            this.btnDtrend.TabIndex = 12;
            this.btnDtrend.Text = "DTrend";
            this.btnDtrend.UseVisualStyleBackColor = true;
            this.btnDtrend.Click += new System.EventHandler(this.btnDtrend_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(311, 61);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(75, 23);
            this.btnDiff.TabIndex = 11;
            this.btnDiff.Text = "DIFF";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // btnNetworkClear
            // 
            this.btnNetworkClear.Enabled = false;
            this.btnNetworkClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetworkClear.Location = new System.Drawing.Point(524, 12);
            this.btnNetworkClear.Name = "btnNetworkClear";
            this.btnNetworkClear.Size = new System.Drawing.Size(54, 38);
            this.btnNetworkClear.TabIndex = 10;
            this.btnNetworkClear.Text = "Clear";
            this.btnNetworkClear.UseVisualStyleBackColor = true;
            this.btnNetworkClear.Click += new System.EventHandler(this.btnNetworkClear_Click);
            // 
            // btnNetworkSave
            // 
            this.btnNetworkSave.Enabled = false;
            this.btnNetworkSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetworkSave.Location = new System.Drawing.Point(453, 12);
            this.btnNetworkSave.Name = "btnNetworkSave";
            this.btnNetworkSave.Size = new System.Drawing.Size(54, 38);
            this.btnNetworkSave.TabIndex = 9;
            this.btnNetworkSave.Text = "Save";
            this.btnNetworkSave.UseVisualStyleBackColor = true;
            this.btnNetworkSave.Click += new System.EventHandler(this.btnNetworkSave_Click);
            // 
            // btnNetworkLoad
            // 
            this.btnNetworkLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetworkLoad.Location = new System.Drawing.Point(394, 11);
            this.btnNetworkLoad.Name = "btnNetworkLoad";
            this.btnNetworkLoad.Size = new System.Drawing.Size(54, 38);
            this.btnNetworkLoad.TabIndex = 8;
            this.btnNetworkLoad.Text = "Load";
            this.btnNetworkLoad.UseVisualStyleBackColor = true;
            this.btnNetworkLoad.Click += new System.EventHandler(this.btnNetworkLoad_Click);
            // 
            // btnNetworkNew
            // 
            this.btnNetworkNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetworkNew.Location = new System.Drawing.Point(326, 12);
            this.btnNetworkNew.Name = "btnNetworkNew";
            this.btnNetworkNew.Size = new System.Drawing.Size(52, 38);
            this.btnNetworkNew.TabIndex = 7;
            this.btnNetworkNew.Text = "New";
            this.btnNetworkNew.UseVisualStyleBackColor = true;
            this.btnNetworkNew.Click += new System.EventHandler(this.btnNetworkNew_Click);
            // 
            // txtNumLag
            // 
            this.txtNumLag.Location = new System.Drawing.Point(156, 49);
            this.txtNumLag.Name = "txtNumLag";
            this.txtNumLag.Size = new System.Drawing.Size(149, 23);
            this.txtNumLag.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "I-O lags";
            // 
            // txtNumOutput
            // 
            this.txtNumOutput.Enabled = false;
            this.txtNumOutput.Location = new System.Drawing.Point(262, 19);
            this.txtNumOutput.Name = "txtNumOutput";
            this.txtNumOutput.Size = new System.Drawing.Size(43, 23);
            this.txtNumOutput.TabIndex = 4;
            this.txtNumOutput.Text = "1";
            // 
            // txtNumHidden
            // 
            this.txtNumHidden.Location = new System.Drawing.Point(209, 19);
            this.txtNumHidden.Name = "txtNumHidden";
            this.txtNumHidden.Size = new System.Drawing.Size(43, 23);
            this.txtNumHidden.TabIndex = 3;
            // 
            // txtNumInput
            // 
            this.txtNumInput.Location = new System.Drawing.Point(156, 19);
            this.txtNumInput.Name = "txtNumInput";
            this.txtNumInput.Size = new System.Drawing.Size(43, 23);
            this.txtNumInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input-Hidden-Output";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(txtLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(943, 444);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            txtLogs.Location = new System.Drawing.Point(0, 0);
            txtLogs.Name = "txtLogs";
            txtLogs.Size = new System.Drawing.Size(940, 438);
            txtLogs.TabIndex = 0;
            txtLogs.Text = "";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 475);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(968, 513);
            this.MinimumSize = new System.Drawing.Size(968, 513);
            this.Name = "MainInterface";
            this.Text = "Neuron Network With Time Series Model";
            this.tabControl.ResumeLayout(false);
            this.tabPreprocessing.ResumeLayout(false);
            this.tabPreprocessing.PerformLayout();
            this.boxDeseasonality.ResumeLayout(false);
            this.boxDeseasonality.PerformLayout();
            this.boxDetrend.ResumeLayout(false);
            this.boxDetrend.PerformLayout();
            this.boxScale.ResumeLayout(false);
            this.boxScale.PerformLayout();
            this.tabNeuronNetwork.ResumeLayout(false);
            this.groupBoxValidate.ResumeLayout(false);
            this.groupBoxValidate.PerformLayout();
            this.groupBoxAlgorithmConfig.ResumeLayout(false);
            this.groupBoxAlgorithmConfig.PerformLayout();
            this.groupBoxTraining.ResumeLayout(false);
            this.groupBoxTraining.PerformLayout();
            this.groupBoxNetworkConfig.ResumeLayout(false);
            this.groupBoxNetworkConfig.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPreprocessing;
        private System.Windows.Forms.TabPage tabNeuronNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreprocessOpenData;
        private System.Windows.Forms.Button btnPreprocessSaveData;
        private System.Windows.Forms.RichTextBox richTextProprocessData;
        private System.Windows.Forms.GroupBox boxScale;
        private System.Windows.Forms.CheckBox checkBoxLnTransformation;
        private System.Windows.Forms.GroupBox boxDetrend;
        private System.Windows.Forms.GroupBox boxDeseasonality;
        private System.Windows.Forms.RadioButton radioNoneDetrend;
        private System.Windows.Forms.RadioButton radioLinearDetrend;
        private System.Windows.Forms.RadioButton radioDifference;
        private System.Windows.Forms.RadioButton radioDifferenceSeasonality;
        private System.Windows.Forms.TextBox txtNumLagAtDeseasonality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioSeasonalAdjustment;
        private System.Windows.Forms.RadioButton radioNoneDeseasonality;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCorrelogram;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.GroupBox groupBoxNetworkConfig;
        private System.Windows.Forms.TextBox txtNumOutput;
        private System.Windows.Forms.TextBox txtNumHidden;
        private System.Windows.Forms.TextBox txtNumInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumLag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNetworkSave;
        private System.Windows.Forms.Button btnNetworkLoad;
        private System.Windows.Forms.Button btnNetworkNew;
        private System.Windows.Forms.GroupBox groupBoxTraining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTrainingBrowse;
        private System.Windows.Forms.Button btnNetworkClear;
        private System.Windows.Forms.TextBox txtTrainingFromRow;
        private System.Windows.Forms.TextBox txtTrainingColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioRPROP;
        private System.Windows.Forms.RadioButton radioBackPropagation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxAlgorithmConfig;
        private System.Windows.Forms.Label labelConfig1;
        private System.Windows.Forms.Label labelConfig2;
        private System.Windows.Forms.TextBox txtConfigErrors;
        private System.Windows.Forms.TextBox txtConfig2;
        private System.Windows.Forms.TextBox txtConfigEpoches;
        private System.Windows.Forms.TextBox txtConfig1;
        private System.Windows.Forms.Label labelConfigResidual;
        private System.Windows.Forms.Label labelConfigEpoches;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label labelTrainingNumColumns;
        private System.Windows.Forms.Label labelTrainingNumRows;
        private System.Windows.Forms.TextBox textBox_Cycle;
        private System.Windows.Forms.Label label_cycle;
        private System.Windows.Forms.TextBox txtTrainingFileName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTrainDataNumColumns;
        private System.Windows.Forms.Label labelTrainDataNumRows;
        private System.Windows.Forms.TextBox txtTrainDataColumn;
        private System.Windows.Forms.TextBox txtTrainDataToRow;
        private System.Windows.Forms.TextBox txtTrainDataFromRow;
        private System.Windows.Forms.Button buttonTrainDataGet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtbPreProcess;
        private System.Windows.Forms.TextBox tbLag;
        private System.Windows.Forms.Button btnSadj;
        private System.Windows.Forms.Button btnSDiff;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnDtrend;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.GroupBox groupBoxValidate;
        private System.Windows.Forms.TextBox txtValidateColumn;
        private System.Windows.Forms.TextBox txtValidateToRow;
        private System.Windows.Forms.TextBox txtValidateFromRow;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelValidateNumRows;
        private System.Windows.Forms.Label labelValidateNumColumns;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtValidateFileName;
        private System.Windows.Forms.Button btnValidateBrowse;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTrainingToRow;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTestToRow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTestFromRow;
        private System.Windows.Forms.Label labelTestRow;
        private System.Windows.Forms.RadioButton radioLoopTrain;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioLoopValidate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtAhead;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        public static System.Windows.Forms.TextBox textBoxMinValue;
        public static System.Windows.Forms.TextBox textBoxMaxValue;
        public static System.Windows.Forms.RichTextBox txtLogs;

    }
}