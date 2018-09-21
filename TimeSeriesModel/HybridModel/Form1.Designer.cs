namespace HybridModel
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNeuronNetwork = new System.Windows.Forms.TabPage();
            this.groupNeuronAlgorithmConfig = new System.Windows.Forms.GroupBox();
            this.txtNeuronDeltaErrors = new System.Windows.Forms.TextBox();
            this.txtNeuronMaxEpoches = new System.Windows.Forms.TextBox();
            this.txtNeuronConfig2 = new System.Windows.Forms.TextBox();
            this.txtNeuronConfig1 = new System.Windows.Forms.TextBox();
            this.labelNeuronConfig4 = new System.Windows.Forms.Label();
            this.labelNeuronConfig3 = new System.Windows.Forms.Label();
            this.labelNeuronConfig2 = new System.Windows.Forms.Label();
            this.labelNeuronConfig1 = new System.Windows.Forms.Label();
            this.groupNeuronTraining = new System.Windows.Forms.GroupBox();
            this.buttonPlot = new System.Windows.Forms.Button();
            txtMinValue = new System.Windows.Forms.TextBox();
            txtMaxValue = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtNeuronColumnSelected = new System.Windows.Forms.TextBox();
            this.txtNeuronToRow = new System.Windows.Forms.TextBox();
            this.txtNeuronFromRow = new System.Windows.Forms.TextBox();
            this.buttonNeuronTrain = new System.Windows.Forms.Button();
            this.radioNeuronRProp = new System.Windows.Forms.RadioButton();
            this.radioNeuronBackPropagation = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNeuronNumColumns = new System.Windows.Forms.Label();
            this.labelNeuronNumRows = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNeuronTrainingFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupNeuronInit = new System.Windows.Forms.GroupBox();
            this.txtNeuronLags = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNeuronClear = new System.Windows.Forms.Button();
            this.btnNeuronSave = new System.Windows.Forms.Button();
            this.btnNeuronLoad = new System.Windows.Forms.Button();
            this.btnNeuronNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNeuronNumOutputs = new System.Windows.Forms.TextBox();
            this.txtNeuronNumHiddens = new System.Windows.Forms.TextBox();
            this.txtNeuronNumInputs = new System.Windows.Forms.TextBox();
            this.tabSmoothing = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSmoothResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdditive = new System.Windows.Forms.CheckBox();
            this.txtSmoothRPath = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.radioUseR = new System.Windows.Forms.RadioButton();
            this.txtSmoothStep = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtSmoothCycle = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.radioSmoothSimulated = new System.Windows.Forms.RadioButton();
            this.txtSmoothColumn = new System.Windows.Forms.TextBox();
            this.txtSmoothToRow = new System.Windows.Forms.TextBox();
            this.txtSmoothFromRow = new System.Windows.Forms.TextBox();
            this.btnSmoothTrain = new System.Windows.Forms.Button();
            this.radioSmoothSteepestAscent = new System.Windows.Forms.RadioButton();
            this.radioSmoothBruteForce = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSmoothNumColumns = new System.Windows.Forms.Label();
            this.labelSmoothNumRows = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSmoothTrainingFile = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabHybrid = new System.Windows.Forms.TabPage();
            this.groupHybirdTest = new System.Windows.Forms.GroupBox();
            this.btnHybridFocast = new System.Windows.Forms.Button();
            this.txtHybridAHead = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnHybridTest = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtHybridTestToRow = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtHybridTestFromRow = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupHybridTraining = new System.Windows.Forms.GroupBox();
            this.txtHybridAlpha = new System.Windows.Forms.TextBox();
            this.radioHybridSetAlpha = new System.Windows.Forms.RadioButton();
            this.radioHybridEstimateAlpha = new System.Windows.Forms.RadioButton();
            this.txtHybridResult = new System.Windows.Forms.RichTextBox();
            this.txtHybridColumn = new System.Windows.Forms.TextBox();
            this.txtHybridToRow = new System.Windows.Forms.TextBox();
            this.txtHybridFromRow = new System.Windows.Forms.TextBox();
            this.btnHybridTrain = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelHybridNumColumns = new System.Windows.Forms.Label();
            this.labelHybridNumRows = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtHybridTrainingFile = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            txtLogs = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabNeuronNetwork.SuspendLayout();
            this.groupNeuronAlgorithmConfig.SuspendLayout();
            this.groupNeuronTraining.SuspendLayout();
            this.groupNeuronInit.SuspendLayout();
            this.tabSmoothing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHybrid.SuspendLayout();
            this.groupHybirdTest.SuspendLayout();
            this.groupHybridTraining.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNeuronNetwork);
            this.tabControl.Controls.Add(this.tabSmoothing);
            this.tabControl.Controls.Add(this.tabHybrid);
            this.tabControl.Controls.Add(this.tabLogs);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(588, 528);
            this.tabControl.TabIndex = 0;
            // 
            // tabNeuronNetwork
            // 
            this.tabNeuronNetwork.Controls.Add(this.groupNeuronAlgorithmConfig);
            this.tabNeuronNetwork.Controls.Add(this.groupNeuronTraining);
            this.tabNeuronNetwork.Controls.Add(this.groupNeuronInit);
            this.tabNeuronNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNeuronNetwork.Name = "tabNeuronNetwork";
            this.tabNeuronNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNeuronNetwork.Size = new System.Drawing.Size(580, 502);
            this.tabNeuronNetwork.TabIndex = 0;
            this.tabNeuronNetwork.Text = "Neuron Network";
            this.tabNeuronNetwork.UseVisualStyleBackColor = true;
            // 
            // groupNeuronAlgorithmConfig
            // 
            this.groupNeuronAlgorithmConfig.Controls.Add(this.txtNeuronDeltaErrors);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.txtNeuronMaxEpoches);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.txtNeuronConfig2);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.txtNeuronConfig1);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.labelNeuronConfig4);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.labelNeuronConfig3);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.labelNeuronConfig2);
            this.groupNeuronAlgorithmConfig.Controls.Add(this.labelNeuronConfig1);
            this.groupNeuronAlgorithmConfig.Enabled = false;
            this.groupNeuronAlgorithmConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNeuronAlgorithmConfig.Location = new System.Drawing.Point(303, 7);
            this.groupNeuronAlgorithmConfig.Name = "groupNeuronAlgorithmConfig";
            this.groupNeuronAlgorithmConfig.Size = new System.Drawing.Size(277, 196);
            this.groupNeuronAlgorithmConfig.TabIndex = 2;
            this.groupNeuronAlgorithmConfig.TabStop = false;
            this.groupNeuronAlgorithmConfig.Text = "Algorithm Config";
            // 
            // txtNeuronDeltaErrors
            // 
            this.txtNeuronDeltaErrors.Location = new System.Drawing.Point(171, 145);
            this.txtNeuronDeltaErrors.Name = "txtNeuronDeltaErrors";
            this.txtNeuronDeltaErrors.Size = new System.Drawing.Size(80, 23);
            this.txtNeuronDeltaErrors.TabIndex = 7;
            this.txtNeuronDeltaErrors.Text = "0.001";
            // 
            // txtNeuronMaxEpoches
            // 
            this.txtNeuronMaxEpoches.Location = new System.Drawing.Point(171, 104);
            this.txtNeuronMaxEpoches.Name = "txtNeuronMaxEpoches";
            this.txtNeuronMaxEpoches.Size = new System.Drawing.Size(80, 23);
            this.txtNeuronMaxEpoches.TabIndex = 6;
            this.txtNeuronMaxEpoches.Text = "1000";
            // 
            // txtNeuronConfig2
            // 
            this.txtNeuronConfig2.Location = new System.Drawing.Point(171, 61);
            this.txtNeuronConfig2.Name = "txtNeuronConfig2";
            this.txtNeuronConfig2.Size = new System.Drawing.Size(80, 23);
            this.txtNeuronConfig2.TabIndex = 5;
            this.txtNeuronConfig2.Text = "1";
            // 
            // txtNeuronConfig1
            // 
            this.txtNeuronConfig1.Location = new System.Drawing.Point(171, 25);
            this.txtNeuronConfig1.Name = "txtNeuronConfig1";
            this.txtNeuronConfig1.Size = new System.Drawing.Size(80, 23);
            this.txtNeuronConfig1.TabIndex = 4;
            this.txtNeuronConfig1.Text = "0.1";
            // 
            // labelNeuronConfig4
            // 
            this.labelNeuronConfig4.AutoSize = true;
            this.labelNeuronConfig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuronConfig4.Location = new System.Drawing.Point(20, 151);
            this.labelNeuronConfig4.Name = "labelNeuronConfig4";
            this.labelNeuronConfig4.Size = new System.Drawing.Size(84, 17);
            this.labelNeuronConfig4.TabIndex = 3;
            this.labelNeuronConfig4.Text = "Delta Errors";
            // 
            // labelNeuronConfig3
            // 
            this.labelNeuronConfig3.AutoSize = true;
            this.labelNeuronConfig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuronConfig3.Location = new System.Drawing.Point(19, 110);
            this.labelNeuronConfig3.Name = "labelNeuronConfig3";
            this.labelNeuronConfig3.Size = new System.Drawing.Size(92, 17);
            this.labelNeuronConfig3.TabIndex = 2;
            this.labelNeuronConfig3.Text = "Max Epoches";
            // 
            // labelNeuronConfig2
            // 
            this.labelNeuronConfig2.AutoSize = true;
            this.labelNeuronConfig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuronConfig2.Location = new System.Drawing.Point(19, 66);
            this.labelNeuronConfig2.Name = "labelNeuronConfig2";
            this.labelNeuronConfig2.Size = new System.Drawing.Size(54, 17);
            this.labelNeuronConfig2.TabIndex = 1;
            this.labelNeuronConfig2.Text = "label14";
            // 
            // labelNeuronConfig1
            // 
            this.labelNeuronConfig1.AutoSize = true;
            this.labelNeuronConfig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuronConfig1.Location = new System.Drawing.Point(19, 30);
            this.labelNeuronConfig1.Name = "labelNeuronConfig1";
            this.labelNeuronConfig1.Size = new System.Drawing.Size(54, 17);
            this.labelNeuronConfig1.TabIndex = 0;
            this.labelNeuronConfig1.Text = "label13";
            // 
            // groupNeuronTraining
            // 
            this.groupNeuronTraining.Controls.Add(this.buttonPlot);
            this.groupNeuronTraining.Controls.Add(txtMinValue);
            this.groupNeuronTraining.Controls.Add(txtMaxValue);
            this.groupNeuronTraining.Controls.Add(this.label33);
            this.groupNeuronTraining.Controls.Add(this.label32);
            this.groupNeuronTraining.Controls.Add(this.txtNeuronColumnSelected);
            this.groupNeuronTraining.Controls.Add(this.txtNeuronToRow);
            this.groupNeuronTraining.Controls.Add(this.txtNeuronFromRow);
            this.groupNeuronTraining.Controls.Add(this.buttonNeuronTrain);
            this.groupNeuronTraining.Controls.Add(this.radioNeuronRProp);
            this.groupNeuronTraining.Controls.Add(this.radioNeuronBackPropagation);
            this.groupNeuronTraining.Controls.Add(this.label12);
            this.groupNeuronTraining.Controls.Add(this.label11);
            this.groupNeuronTraining.Controls.Add(this.label10);
            this.groupNeuronTraining.Controls.Add(this.label9);
            this.groupNeuronTraining.Controls.Add(this.labelNeuronNumColumns);
            this.groupNeuronTraining.Controls.Add(this.labelNeuronNumRows);
            this.groupNeuronTraining.Controls.Add(this.label6);
            this.groupNeuronTraining.Controls.Add(this.label5);
            this.groupNeuronTraining.Controls.Add(this.txtNeuronTrainingFile);
            this.groupNeuronTraining.Controls.Add(this.label4);
            this.groupNeuronTraining.Enabled = false;
            this.groupNeuronTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNeuronTraining.Location = new System.Drawing.Point(3, 209);
            this.groupNeuronTraining.Name = "groupNeuronTraining";
            this.groupNeuronTraining.Size = new System.Drawing.Size(577, 290);
            this.groupNeuronTraining.TabIndex = 1;
            this.groupNeuronTraining.TabStop = false;
            this.groupNeuronTraining.Text = "Training";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(429, 208);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(88, 63);
            this.buttonPlot.TabIndex = 20;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // txtMinValue
            // 
            txtMinValue.Location = new System.Drawing.Point(442, 98);
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new System.Drawing.Size(100, 23);
            txtMinValue.TabIndex = 19;
            // 
            // txtMaxValue
            // 
            txtMaxValue.Location = new System.Drawing.Point(442, 69);
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Size = new System.Drawing.Size(100, 23);
            txtMaxValue.TabIndex = 18;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(320, 103);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 17);
            this.label33.TabIndex = 17;
            this.label33.Text = "Min Value";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(319, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 17);
            this.label32.TabIndex = 16;
            this.label32.Text = "Max Value";
            // 
            // txtNeuronColumnSelected
            // 
            this.txtNeuronColumnSelected.Location = new System.Drawing.Point(164, 172);
            this.txtNeuronColumnSelected.Name = "txtNeuronColumnSelected";
            this.txtNeuronColumnSelected.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronColumnSelected.TabIndex = 15;
            // 
            // txtNeuronToRow
            // 
            this.txtNeuronToRow.Location = new System.Drawing.Point(372, 141);
            this.txtNeuronToRow.Name = "txtNeuronToRow";
            this.txtNeuronToRow.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronToRow.TabIndex = 14;
            // 
            // txtNeuronFromRow
            // 
            this.txtNeuronFromRow.Location = new System.Drawing.Point(164, 141);
            this.txtNeuronFromRow.Name = "txtNeuronFromRow";
            this.txtNeuronFromRow.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronFromRow.TabIndex = 13;
            // 
            // buttonNeuronTrain
            // 
            this.buttonNeuronTrain.Location = new System.Drawing.Point(302, 208);
            this.buttonNeuronTrain.Name = "buttonNeuronTrain";
            this.buttonNeuronTrain.Size = new System.Drawing.Size(90, 63);
            this.buttonNeuronTrain.TabIndex = 12;
            this.buttonNeuronTrain.Text = "Train";
            this.buttonNeuronTrain.UseVisualStyleBackColor = true;
            this.buttonNeuronTrain.Click += new System.EventHandler(this.buttonNeuronTrain_Click);
            // 
            // radioNeuronRProp
            // 
            this.radioNeuronRProp.AutoSize = true;
            this.radioNeuronRProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNeuronRProp.Location = new System.Drawing.Point(110, 250);
            this.radioNeuronRProp.Name = "radioNeuronRProp";
            this.radioNeuronRProp.Size = new System.Drawing.Size(75, 21);
            this.radioNeuronRProp.TabIndex = 11;
            this.radioNeuronRProp.TabStop = true;
            this.radioNeuronRProp.Text = "RPROP";
            this.radioNeuronRProp.UseVisualStyleBackColor = true;
            this.radioNeuronRProp.CheckedChanged += new System.EventHandler(this.radioNeuronRProp_CheckedChanged);
            // 
            // radioNeuronBackPropagation
            // 
            this.radioNeuronBackPropagation.AutoSize = true;
            this.radioNeuronBackPropagation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNeuronBackPropagation.Location = new System.Drawing.Point(110, 212);
            this.radioNeuronBackPropagation.Name = "radioNeuronBackPropagation";
            this.radioNeuronBackPropagation.Size = new System.Drawing.Size(138, 21);
            this.radioNeuronBackPropagation.TabIndex = 10;
            this.radioNeuronBackPropagation.TabStop = true;
            this.radioNeuronBackPropagation.Text = "Back Propagation";
            this.radioNeuronBackPropagation.UseVisualStyleBackColor = true;
            this.radioNeuronBackPropagation.CheckedChanged += new System.EventHandler(this.radioNeuronBackPropagation_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Algorithms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Column";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Row";
            // 
            // labelNeuronNumColumns
            // 
            this.labelNeuronNumColumns.AutoSize = true;
            this.labelNeuronNumColumns.Location = new System.Drawing.Point(161, 106);
            this.labelNeuronNumColumns.Name = "labelNeuronNumColumns";
            this.labelNeuronNumColumns.Size = new System.Drawing.Size(52, 17);
            this.labelNeuronNumColumns.TabIndex = 5;
            this.labelNeuronNumColumns.Text = "label8";
            // 
            // labelNeuronNumRows
            // 
            this.labelNeuronNumRows.AutoSize = true;
            this.labelNeuronNumRows.Location = new System.Drawing.Point(161, 75);
            this.labelNeuronNumRows.Name = "labelNeuronNumRows";
            this.labelNeuronNumRows.Size = new System.Drawing.Size(52, 17);
            this.labelNeuronNumRows.TabIndex = 4;
            this.labelNeuronNumRows.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Num Columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Num Rows";
            // 
            // txtNeuronTrainingFile
            // 
            this.txtNeuronTrainingFile.Location = new System.Drawing.Point(161, 34);
            this.txtNeuronTrainingFile.Name = "txtNeuronTrainingFile";
            this.txtNeuronTrainingFile.Size = new System.Drawing.Size(410, 23);
            this.txtNeuronTrainingFile.TabIndex = 1;
            this.txtNeuronTrainingFile.Click += new System.EventHandler(this.txtTrainingInputFile_MouseClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose Training File";
            // 
            // groupNeuronInit
            // 
            this.groupNeuronInit.Controls.Add(this.txtNeuronLags);
            this.groupNeuronInit.Controls.Add(this.label15);
            this.groupNeuronInit.Controls.Add(this.btnNeuronClear);
            this.groupNeuronInit.Controls.Add(this.btnNeuronSave);
            this.groupNeuronInit.Controls.Add(this.btnNeuronLoad);
            this.groupNeuronInit.Controls.Add(this.btnNeuronNew);
            this.groupNeuronInit.Controls.Add(this.label3);
            this.groupNeuronInit.Controls.Add(this.label2);
            this.groupNeuronInit.Controls.Add(this.label1);
            this.groupNeuronInit.Controls.Add(this.txtNeuronNumOutputs);
            this.groupNeuronInit.Controls.Add(this.txtNeuronNumHiddens);
            this.groupNeuronInit.Controls.Add(this.txtNeuronNumInputs);
            this.groupNeuronInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNeuronInit.Location = new System.Drawing.Point(3, 7);
            this.groupNeuronInit.Name = "groupNeuronInit";
            this.groupNeuronInit.Size = new System.Drawing.Size(266, 196);
            this.groupNeuronInit.TabIndex = 0;
            this.groupNeuronInit.TabStop = false;
            this.groupNeuronInit.Text = "Init Neuron Network";
            // 
            // txtNeuronLags
            // 
            this.txtNeuronLags.Location = new System.Drawing.Point(94, 123);
            this.txtNeuronLags.Name = "txtNeuronLags";
            this.txtNeuronLags.Size = new System.Drawing.Size(149, 23);
            this.txtNeuronLags.TabIndex = 11;
            this.txtNeuronLags.Text = "1,2,3,4,5,6,7,8,9,10,11,12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "I-O lags";
            // 
            // btnNeuronClear
            // 
            this.btnNeuronClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuronClear.Location = new System.Drawing.Point(204, 161);
            this.btnNeuronClear.Name = "btnNeuronClear";
            this.btnNeuronClear.Size = new System.Drawing.Size(55, 23);
            this.btnNeuronClear.TabIndex = 9;
            this.btnNeuronClear.Text = "Clear";
            this.btnNeuronClear.UseVisualStyleBackColor = true;
            this.btnNeuronClear.Click += new System.EventHandler(this.btnNeuronClear_Click);
            // 
            // btnNeuronSave
            // 
            this.btnNeuronSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuronSave.Location = new System.Drawing.Point(144, 161);
            this.btnNeuronSave.Name = "btnNeuronSave";
            this.btnNeuronSave.Size = new System.Drawing.Size(52, 23);
            this.btnNeuronSave.TabIndex = 8;
            this.btnNeuronSave.Text = "Save";
            this.btnNeuronSave.UseVisualStyleBackColor = true;
            this.btnNeuronSave.Click += new System.EventHandler(this.btnNeuronSave_Click);
            // 
            // btnNeuronLoad
            // 
            this.btnNeuronLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuronLoad.Location = new System.Drawing.Point(72, 161);
            this.btnNeuronLoad.Name = "btnNeuronLoad";
            this.btnNeuronLoad.Size = new System.Drawing.Size(62, 23);
            this.btnNeuronLoad.TabIndex = 7;
            this.btnNeuronLoad.Text = "Load";
            this.btnNeuronLoad.UseVisualStyleBackColor = true;
            this.btnNeuronLoad.Click += new System.EventHandler(this.btnNeuronLoad_Click);
            // 
            // btnNeuronNew
            // 
            this.btnNeuronNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuronNew.Location = new System.Drawing.Point(6, 161);
            this.btnNeuronNew.Name = "btnNeuronNew";
            this.btnNeuronNew.Size = new System.Drawing.Size(60, 23);
            this.btnNeuronNew.TabIndex = 6;
            this.btnNeuronNew.Text = "New";
            this.btnNeuronNew.UseVisualStyleBackColor = true;
            this.btnNeuronNew.Click += new System.EventHandler(this.btnNeuronNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num Output Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num Hidden Nodes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num Input  Nodes";
            // 
            // txtNeuronNumOutputs
            // 
            this.txtNeuronNumOutputs.Location = new System.Drawing.Point(143, 93);
            this.txtNeuronNumOutputs.Name = "txtNeuronNumOutputs";
            this.txtNeuronNumOutputs.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronNumOutputs.TabIndex = 2;
            this.txtNeuronNumOutputs.Text = "1";
            // 
            // txtNeuronNumHiddens
            // 
            this.txtNeuronNumHiddens.Location = new System.Drawing.Point(143, 60);
            this.txtNeuronNumHiddens.Name = "txtNeuronNumHiddens";
            this.txtNeuronNumHiddens.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronNumHiddens.TabIndex = 1;
            this.txtNeuronNumHiddens.Text = "12";
            // 
            // txtNeuronNumInputs
            // 
            this.txtNeuronNumInputs.Location = new System.Drawing.Point(141, 25);
            this.txtNeuronNumInputs.Name = "txtNeuronNumInputs";
            this.txtNeuronNumInputs.Size = new System.Drawing.Size(100, 23);
            this.txtNeuronNumInputs.TabIndex = 0;
            this.txtNeuronNumInputs.Text = "12";
            this.txtNeuronNumInputs.TextChanged += new System.EventHandler(this.txtNeuronNumInputs_TextChanged);
            // 
            // tabSmoothing
            // 
            this.tabSmoothing.Controls.Add(this.label21);
            this.tabSmoothing.Controls.Add(this.txtSmoothResult);
            this.tabSmoothing.Controls.Add(this.groupBox1);
            this.tabSmoothing.Location = new System.Drawing.Point(4, 22);
            this.tabSmoothing.Name = "tabSmoothing";
            this.tabSmoothing.Padding = new System.Windows.Forms.Padding(3);
            this.tabSmoothing.Size = new System.Drawing.Size(580, 502);
            this.tabSmoothing.TabIndex = 1;
            this.tabSmoothing.Text = "Smoothing Model";
            this.tabSmoothing.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 395);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "Result";
            // 
            // txtSmoothResult
            // 
            this.txtSmoothResult.Location = new System.Drawing.Point(15, 418);
            this.txtSmoothResult.Name = "txtSmoothResult";
            this.txtSmoothResult.Size = new System.Drawing.Size(556, 65);
            this.txtSmoothResult.TabIndex = 3;
            this.txtSmoothResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdditive);
            this.groupBox1.Controls.Add(this.txtSmoothRPath);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.radioSmoothSteepestAscent);
            this.groupBox1.Controls.Add(this.radioUseR);
            this.groupBox1.Controls.Add(this.txtSmoothStep);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtSmoothCycle);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.radioSmoothSimulated);
            this.groupBox1.Controls.Add(this.txtSmoothColumn);
            this.groupBox1.Controls.Add(this.txtSmoothToRow);
            this.groupBox1.Controls.Add(this.txtSmoothFromRow);
            this.groupBox1.Controls.Add(this.btnSmoothTrain);
            this.groupBox1.Controls.Add(this.radioSmoothBruteForce);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelSmoothNumColumns);
            this.groupBox1.Controls.Add(this.labelSmoothNumRows);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtSmoothTrainingFile);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 386);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // checkBoxAdditive
            // 
            this.checkBoxAdditive.AutoSize = true;
            this.checkBoxAdditive.Location = new System.Drawing.Point(109, 251);
            this.checkBoxAdditive.Name = "checkBoxAdditive";
            this.checkBoxAdditive.Size = new System.Drawing.Size(133, 21);
            this.checkBoxAdditive.TabIndex = 24;
            this.checkBoxAdditive.Text = "Additive Model";
            this.checkBoxAdditive.UseVisualStyleBackColor = true;
            this.checkBoxAdditive.CheckedChanged += new System.EventHandler(this.checkBoxAdditive_CheckedChanged);
            // 
            // txtSmoothRPath
            // 
            this.txtSmoothRPath.Location = new System.Drawing.Point(161, 209);
            this.txtSmoothRPath.Name = "txtSmoothRPath";
            this.txtSmoothRPath.Size = new System.Drawing.Size(410, 23);
            this.txtSmoothRPath.TabIndex = 23;
            this.txtSmoothRPath.Text = "C:\\Program Files\\R\\R-2.15.2\\bin\\i386";
            this.txtSmoothRPath.Visible = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(18, 212);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(102, 17);
            this.label35.TabIndex = 22;
            this.label35.Text = "Set R directory";
            this.label35.Visible = false;
            // 
            // radioUseR
            // 
            this.radioUseR.AutoSize = true;
            this.radioUseR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUseR.Location = new System.Drawing.Point(109, 278);
            this.radioUseR.Name = "radioUseR";
            this.radioUseR.Size = new System.Drawing.Size(65, 21);
            this.radioUseR.TabIndex = 21;
            this.radioUseR.TabStop = true;
            this.radioUseR.Text = "Use R";
            this.radioUseR.UseVisualStyleBackColor = true;
            this.radioUseR.CheckedChanged += new System.EventHandler(this.radioUseR_CheckedChanged);
            // 
            // txtSmoothStep
            // 
            this.txtSmoothStep.Location = new System.Drawing.Point(372, 172);
            this.txtSmoothStep.Name = "txtSmoothStep";
            this.txtSmoothStep.Size = new System.Drawing.Size(100, 23);
            this.txtSmoothStep.TabIndex = 20;
            this.txtSmoothStep.Text = "0.1";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(296, 176);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 17);
            this.label34.TabIndex = 19;
            this.label34.Text = "Step";
            // 
            // txtSmoothCycle
            // 
            this.txtSmoothCycle.Location = new System.Drawing.Point(372, 72);
            this.txtSmoothCycle.Name = "txtSmoothCycle";
            this.txtSmoothCycle.Size = new System.Drawing.Size(100, 23);
            this.txtSmoothCycle.TabIndex = 18;
            this.txtSmoothCycle.Text = "12";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(301, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Cycle";
            // 
            // radioSmoothSimulated
            // 
            this.radioSmoothSimulated.AutoSize = true;
            this.radioSmoothSimulated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmoothSimulated.Location = new System.Drawing.Point(109, 332);
            this.radioSmoothSimulated.Name = "radioSmoothSimulated";
            this.radioSmoothSimulated.Size = new System.Drawing.Size(155, 21);
            this.radioSmoothSimulated.TabIndex = 16;
            this.radioSmoothSimulated.TabStop = true;
            this.radioSmoothSimulated.Text = "Simulated Annealing";
            this.radioSmoothSimulated.UseVisualStyleBackColor = true;
            this.radioSmoothSimulated.CheckedChanged += new System.EventHandler(this.radioSmoothSimulated_CheckedChanged);
            // 
            // txtSmoothColumn
            // 
            this.txtSmoothColumn.Location = new System.Drawing.Point(164, 172);
            this.txtSmoothColumn.Name = "txtSmoothColumn";
            this.txtSmoothColumn.Size = new System.Drawing.Size(100, 23);
            this.txtSmoothColumn.TabIndex = 15;
            // 
            // txtSmoothToRow
            // 
            this.txtSmoothToRow.Location = new System.Drawing.Point(372, 141);
            this.txtSmoothToRow.Name = "txtSmoothToRow";
            this.txtSmoothToRow.Size = new System.Drawing.Size(100, 23);
            this.txtSmoothToRow.TabIndex = 14;
            // 
            // txtSmoothFromRow
            // 
            this.txtSmoothFromRow.Location = new System.Drawing.Point(164, 141);
            this.txtSmoothFromRow.Name = "txtSmoothFromRow";
            this.txtSmoothFromRow.Size = new System.Drawing.Size(100, 23);
            this.txtSmoothFromRow.TabIndex = 13;
            // 
            // btnSmoothTrain
            // 
            this.btnSmoothTrain.Location = new System.Drawing.Point(372, 288);
            this.btnSmoothTrain.Name = "btnSmoothTrain";
            this.btnSmoothTrain.Size = new System.Drawing.Size(188, 92);
            this.btnSmoothTrain.TabIndex = 12;
            this.btnSmoothTrain.Text = "Train";
            this.btnSmoothTrain.UseVisualStyleBackColor = true;
            this.btnSmoothTrain.Click += new System.EventHandler(this.btnSmoothTrain_Click);
            // 
            // radioSmoothSteepestAscent
            // 
            this.radioSmoothSteepestAscent.AutoSize = true;
            this.radioSmoothSteepestAscent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmoothSteepestAscent.Location = new System.Drawing.Point(109, 359);
            this.radioSmoothSteepestAscent.Name = "radioSmoothSteepestAscent";
            this.radioSmoothSteepestAscent.Size = new System.Drawing.Size(129, 21);
            this.radioSmoothSteepestAscent.TabIndex = 11;
            this.radioSmoothSteepestAscent.TabStop = true;
            this.radioSmoothSteepestAscent.Text = "Steepest Ascent";
            this.radioSmoothSteepestAscent.UseVisualStyleBackColor = true;
            this.radioSmoothSteepestAscent.CheckedChanged += new System.EventHandler(this.radioSmoothSteepestAscent_CheckedChanged);
            // 
            // radioSmoothBruteForce
            // 
            this.radioSmoothBruteForce.AutoSize = true;
            this.radioSmoothBruteForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmoothBruteForce.Location = new System.Drawing.Point(109, 305);
            this.radioSmoothBruteForce.Name = "radioSmoothBruteForce";
            this.radioSmoothBruteForce.Size = new System.Drawing.Size(100, 21);
            this.radioSmoothBruteForce.TabIndex = 10;
            this.radioSmoothBruteForce.TabStop = true;
            this.radioSmoothBruteForce.Text = "Brute Force";
            this.radioSmoothBruteForce.UseVisualStyleBackColor = true;
            this.radioSmoothBruteForce.CheckedChanged += new System.EventHandler(this.radioSmoothBruteForce_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Algorithms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Column";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(297, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "to";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Row";
            // 
            // labelSmoothNumColumns
            // 
            this.labelSmoothNumColumns.AutoSize = true;
            this.labelSmoothNumColumns.Location = new System.Drawing.Point(161, 106);
            this.labelSmoothNumColumns.Name = "labelSmoothNumColumns";
            this.labelSmoothNumColumns.Size = new System.Drawing.Size(52, 17);
            this.labelSmoothNumColumns.TabIndex = 5;
            this.labelSmoothNumColumns.Text = "label8";
            // 
            // labelSmoothNumRows
            // 
            this.labelSmoothNumRows.AutoSize = true;
            this.labelSmoothNumRows.Location = new System.Drawing.Point(161, 75);
            this.labelSmoothNumRows.Name = "labelSmoothNumRows";
            this.labelSmoothNumRows.Size = new System.Drawing.Size(52, 17);
            this.labelSmoothNumRows.TabIndex = 4;
            this.labelSmoothNumRows.Text = "label7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Num Columns";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Num Rows";
            // 
            // txtSmoothTrainingFile
            // 
            this.txtSmoothTrainingFile.Location = new System.Drawing.Point(161, 34);
            this.txtSmoothTrainingFile.Name = "txtSmoothTrainingFile";
            this.txtSmoothTrainingFile.Size = new System.Drawing.Size(410, 23);
            this.txtSmoothTrainingFile.TabIndex = 1;
            this.txtSmoothTrainingFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSmoothTrainingFile_MouseClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Choose Training File";
            // 
            // tabHybrid
            // 
            this.tabHybrid.Controls.Add(this.groupHybirdTest);
            this.tabHybrid.Controls.Add(this.groupHybridTraining);
            this.tabHybrid.Location = new System.Drawing.Point(4, 22);
            this.tabHybrid.Name = "tabHybrid";
            this.tabHybrid.Size = new System.Drawing.Size(580, 502);
            this.tabHybrid.TabIndex = 2;
            this.tabHybrid.Text = "Hybrid Model";
            this.tabHybrid.UseVisualStyleBackColor = true;
            // 
            // groupHybirdTest
            // 
            this.groupHybirdTest.Controls.Add(this.btnHybridFocast);
            this.groupHybirdTest.Controls.Add(this.txtHybridAHead);
            this.groupHybirdTest.Controls.Add(this.label28);
            this.groupHybirdTest.Controls.Add(this.label27);
            this.groupHybirdTest.Controls.Add(this.btnHybridTest);
            this.groupHybirdTest.Controls.Add(this.label23);
            this.groupHybirdTest.Controls.Add(this.txtHybridTestToRow);
            this.groupHybirdTest.Controls.Add(this.label22);
            this.groupHybirdTest.Controls.Add(this.txtHybridTestFromRow);
            this.groupHybirdTest.Controls.Add(this.label16);
            this.groupHybirdTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHybirdTest.Location = new System.Drawing.Point(3, 314);
            this.groupHybirdTest.Name = "groupHybirdTest";
            this.groupHybirdTest.Size = new System.Drawing.Size(574, 185);
            this.groupHybirdTest.TabIndex = 4;
            this.groupHybirdTest.TabStop = false;
            this.groupHybirdTest.Text = "Test And Focast";
            // 
            // btnHybridFocast
            // 
            this.btnHybridFocast.Location = new System.Drawing.Point(417, 140);
            this.btnHybridFocast.Name = "btnHybridFocast";
            this.btnHybridFocast.Size = new System.Drawing.Size(109, 35);
            this.btnHybridFocast.TabIndex = 22;
            this.btnHybridFocast.Text = "Focast";
            this.btnHybridFocast.UseVisualStyleBackColor = true;
            this.btnHybridFocast.Click += new System.EventHandler(this.btnHybridFocast_Click);
            // 
            // txtHybridAHead
            // 
            this.txtHybridAHead.Location = new System.Drawing.Point(164, 146);
            this.txtHybridAHead.Name = "txtHybridAHead";
            this.txtHybridAHead.Size = new System.Drawing.Size(100, 23);
            this.txtHybridAHead.TabIndex = 21;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(18, 118);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 17);
            this.label28.TabIndex = 20;
            this.label28.Text = "Focast";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(39, 152);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 17);
            this.label27.TabIndex = 19;
            this.label27.Text = "A Head";
            // 
            // btnHybridTest
            // 
            this.btnHybridTest.Location = new System.Drawing.Point(417, 54);
            this.btnHybridTest.Name = "btnHybridTest";
            this.btnHybridTest.Size = new System.Drawing.Size(109, 35);
            this.btnHybridTest.TabIndex = 18;
            this.btnHybridTest.Text = "Test";
            this.btnHybridTest.UseVisualStyleBackColor = true;
            this.btnHybridTest.Click += new System.EventHandler(this.btnHybridTest_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "Test";
            // 
            // txtHybridTestToRow
            // 
            this.txtHybridTestToRow.Location = new System.Drawing.Point(246, 60);
            this.txtHybridTestToRow.Name = "txtHybridTestToRow";
            this.txtHybridTestToRow.Size = new System.Drawing.Size(100, 23);
            this.txtHybridTestToRow.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(211, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 17);
            this.label22.TabIndex = 15;
            this.label22.Text = "to";
            // 
            // txtHybridTestFromRow
            // 
            this.txtHybridTestFromRow.Location = new System.Drawing.Point(88, 60);
            this.txtHybridTestFromRow.Name = "txtHybridTestFromRow";
            this.txtHybridTestFromRow.Size = new System.Drawing.Size(100, 23);
            this.txtHybridTestFromRow.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Row";
            // 
            // groupHybridTraining
            // 
            this.groupHybridTraining.Controls.Add(this.txtHybridAlpha);
            this.groupHybridTraining.Controls.Add(this.radioHybridSetAlpha);
            this.groupHybridTraining.Controls.Add(this.radioHybridEstimateAlpha);
            this.groupHybridTraining.Controls.Add(this.txtHybridResult);
            this.groupHybridTraining.Controls.Add(this.txtHybridColumn);
            this.groupHybridTraining.Controls.Add(this.txtHybridToRow);
            this.groupHybridTraining.Controls.Add(this.txtHybridFromRow);
            this.groupHybridTraining.Controls.Add(this.btnHybridTrain);
            this.groupHybridTraining.Controls.Add(this.label24);
            this.groupHybridTraining.Controls.Add(this.label25);
            this.groupHybridTraining.Controls.Add(this.label26);
            this.groupHybridTraining.Controls.Add(this.labelHybridNumColumns);
            this.groupHybridTraining.Controls.Add(this.labelHybridNumRows);
            this.groupHybridTraining.Controls.Add(this.label29);
            this.groupHybridTraining.Controls.Add(this.label30);
            this.groupHybridTraining.Controls.Add(this.txtHybridTrainingFile);
            this.groupHybridTraining.Controls.Add(this.label31);
            this.groupHybridTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHybridTraining.Location = new System.Drawing.Point(3, 3);
            this.groupHybridTraining.Name = "groupHybridTraining";
            this.groupHybridTraining.Size = new System.Drawing.Size(577, 305);
            this.groupHybridTraining.TabIndex = 3;
            this.groupHybridTraining.TabStop = false;
            this.groupHybridTraining.Text = "Training";
            // 
            // txtHybridAlpha
            // 
            this.txtHybridAlpha.Location = new System.Drawing.Point(426, 179);
            this.txtHybridAlpha.Name = "txtHybridAlpha";
            this.txtHybridAlpha.Size = new System.Drawing.Size(100, 23);
            this.txtHybridAlpha.TabIndex = 19;
            // 
            // radioHybridSetAlpha
            // 
            this.radioHybridSetAlpha.AutoSize = true;
            this.radioHybridSetAlpha.Location = new System.Drawing.Point(265, 183);
            this.radioHybridSetAlpha.Name = "radioHybridSetAlpha";
            this.radioHybridSetAlpha.Size = new System.Drawing.Size(105, 21);
            this.radioHybridSetAlpha.TabIndex = 18;
            this.radioHybridSetAlpha.Text = "Set Weight";
            this.radioHybridSetAlpha.UseVisualStyleBackColor = true;
            // 
            // radioHybridEstimateAlpha
            // 
            this.radioHybridEstimateAlpha.AutoSize = true;
            this.radioHybridEstimateAlpha.Checked = true;
            this.radioHybridEstimateAlpha.Location = new System.Drawing.Point(265, 206);
            this.radioHybridEstimateAlpha.Name = "radioHybridEstimateAlpha";
            this.radioHybridEstimateAlpha.Size = new System.Drawing.Size(176, 21);
            this.radioHybridEstimateAlpha.TabIndex = 17;
            this.radioHybridEstimateAlpha.TabStop = true;
            this.radioHybridEstimateAlpha.Text = "Use Estimate Weight";
            this.radioHybridEstimateAlpha.UseVisualStyleBackColor = true;
            // 
            // txtHybridResult
            // 
            this.txtHybridResult.Location = new System.Drawing.Point(265, 233);
            this.txtHybridResult.Name = "txtHybridResult";
            this.txtHybridResult.Size = new System.Drawing.Size(271, 57);
            this.txtHybridResult.TabIndex = 16;
            this.txtHybridResult.Text = "";
            // 
            // txtHybridColumn
            // 
            this.txtHybridColumn.Location = new System.Drawing.Point(164, 146);
            this.txtHybridColumn.Name = "txtHybridColumn";
            this.txtHybridColumn.Size = new System.Drawing.Size(100, 23);
            this.txtHybridColumn.TabIndex = 15;
            // 
            // txtHybridToRow
            // 
            this.txtHybridToRow.Location = new System.Drawing.Point(372, 115);
            this.txtHybridToRow.Name = "txtHybridToRow";
            this.txtHybridToRow.Size = new System.Drawing.Size(100, 23);
            this.txtHybridToRow.TabIndex = 14;
            // 
            // txtHybridFromRow
            // 
            this.txtHybridFromRow.Location = new System.Drawing.Point(164, 115);
            this.txtHybridFromRow.Name = "txtHybridFromRow";
            this.txtHybridFromRow.Size = new System.Drawing.Size(100, 23);
            this.txtHybridFromRow.TabIndex = 13;
            // 
            // btnHybridTrain
            // 
            this.btnHybridTrain.Location = new System.Drawing.Point(18, 233);
            this.btnHybridTrain.Name = "btnHybridTrain";
            this.btnHybridTrain.Size = new System.Drawing.Size(188, 57);
            this.btnHybridTrain.TabIndex = 12;
            this.btnHybridTrain.Text = "Train";
            this.btnHybridTrain.UseVisualStyleBackColor = true;
            this.btnHybridTrain.Click += new System.EventHandler(this.btnHybridTrain_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(18, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 17);
            this.label24.TabIndex = 8;
            this.label24.Text = "Column";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(297, 118);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 17);
            this.label25.TabIndex = 7;
            this.label25.Text = "to";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(18, 118);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 17);
            this.label26.TabIndex = 6;
            this.label26.Text = "Row";
            // 
            // labelHybridNumColumns
            // 
            this.labelHybridNumColumns.AutoSize = true;
            this.labelHybridNumColumns.Location = new System.Drawing.Point(161, 88);
            this.labelHybridNumColumns.Name = "labelHybridNumColumns";
            this.labelHybridNumColumns.Size = new System.Drawing.Size(52, 17);
            this.labelHybridNumColumns.TabIndex = 5;
            this.labelHybridNumColumns.Text = "label8";
            // 
            // labelHybridNumRows
            // 
            this.labelHybridNumRows.AutoSize = true;
            this.labelHybridNumRows.Location = new System.Drawing.Point(161, 57);
            this.labelHybridNumRows.Name = "labelHybridNumRows";
            this.labelHybridNumRows.Size = new System.Drawing.Size(52, 17);
            this.labelHybridNumRows.TabIndex = 4;
            this.labelHybridNumRows.Text = "label7";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(15, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 17);
            this.label29.TabIndex = 3;
            this.label29.Text = "Num Columns";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(15, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Num Rows";
            // 
            // txtHybridTrainingFile
            // 
            this.txtHybridTrainingFile.Location = new System.Drawing.Point(161, 23);
            this.txtHybridTrainingFile.Name = "txtHybridTrainingFile";
            this.txtHybridTrainingFile.Size = new System.Drawing.Size(410, 23);
            this.txtHybridTrainingFile.TabIndex = 1;
            this.txtHybridTrainingFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHybridTrainingFile_MouseClicked);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(15, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(138, 17);
            this.label31.TabIndex = 0;
            this.label31.Text = "Choose Training File";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(txtLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(580, 502);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            txtLogs.Location = new System.Drawing.Point(0, 0);
            txtLogs.Name = "txtLogs";
            txtLogs.Size = new System.Drawing.Size(584, 506);
            txtLogs.TabIndex = 0;
            txtLogs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 526);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hybrid Model";
            this.tabControl.ResumeLayout(false);
            this.tabNeuronNetwork.ResumeLayout(false);
            this.groupNeuronAlgorithmConfig.ResumeLayout(false);
            this.groupNeuronAlgorithmConfig.PerformLayout();
            this.groupNeuronTraining.ResumeLayout(false);
            this.groupNeuronTraining.PerformLayout();
            this.groupNeuronInit.ResumeLayout(false);
            this.groupNeuronInit.PerformLayout();
            this.tabSmoothing.ResumeLayout(false);
            this.tabSmoothing.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHybrid.ResumeLayout(false);
            this.groupHybirdTest.ResumeLayout(false);
            this.groupHybirdTest.PerformLayout();
            this.groupHybridTraining.ResumeLayout(false);
            this.groupHybridTraining.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNeuronNetwork;
        private System.Windows.Forms.GroupBox groupNeuronInit;
        private System.Windows.Forms.TabPage tabSmoothing;
        private System.Windows.Forms.TabPage tabHybrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNeuronNumOutputs;
        private System.Windows.Forms.TextBox txtNeuronNumHiddens;
        private System.Windows.Forms.TextBox txtNeuronNumInputs;
        private System.Windows.Forms.Button btnNeuronClear;
        private System.Windows.Forms.Button btnNeuronSave;
        private System.Windows.Forms.Button btnNeuronLoad;
        private System.Windows.Forms.Button btnNeuronNew;
        private System.Windows.Forms.GroupBox groupNeuronTraining;
        private System.Windows.Forms.TextBox txtNeuronTrainingFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNeuronNumColumns;
        private System.Windows.Forms.Label labelNeuronNumRows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonNeuronTrain;
        private System.Windows.Forms.RadioButton radioNeuronRProp;
        private System.Windows.Forms.RadioButton radioNeuronBackPropagation;
        private System.Windows.Forms.TextBox txtNeuronColumnSelected;
        private System.Windows.Forms.TextBox txtNeuronToRow;
        private System.Windows.Forms.TextBox txtNeuronFromRow;
        private System.Windows.Forms.GroupBox groupNeuronAlgorithmConfig;
        private System.Windows.Forms.TextBox txtNeuronDeltaErrors;
        private System.Windows.Forms.TextBox txtNeuronMaxEpoches;
        private System.Windows.Forms.TextBox txtNeuronConfig2;
        private System.Windows.Forms.TextBox txtNeuronConfig1;
        private System.Windows.Forms.Label labelNeuronConfig4;
        private System.Windows.Forms.Label labelNeuronConfig3;
        private System.Windows.Forms.Label labelNeuronConfig2;
        private System.Windows.Forms.Label labelNeuronConfig1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSmoothColumn;
        private System.Windows.Forms.TextBox txtSmoothToRow;
        private System.Windows.Forms.TextBox txtSmoothFromRow;
        private System.Windows.Forms.Button btnSmoothTrain;
        private System.Windows.Forms.RadioButton radioSmoothSteepestAscent;
        private System.Windows.Forms.RadioButton radioSmoothBruteForce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelSmoothNumColumns;
        private System.Windows.Forms.Label labelSmoothNumRows;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSmoothTrainingFile;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioSmoothSimulated;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSmoothCycle;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox txtSmoothResult;
        private System.Windows.Forms.GroupBox groupHybridTraining;
        private System.Windows.Forms.TextBox txtHybridColumn;
        private System.Windows.Forms.TextBox txtHybridToRow;
        private System.Windows.Forms.TextBox txtHybridFromRow;
        private System.Windows.Forms.Button btnHybridTrain;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelHybridNumColumns;
        private System.Windows.Forms.Label labelHybridNumRows;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtHybridTrainingFile;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNeuronLags;
        private System.Windows.Forms.RichTextBox txtHybridResult;
        private System.Windows.Forms.GroupBox groupHybirdTest;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtHybridTestToRow;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHybridTestFromRow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnHybridTest;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnHybridFocast;
        private System.Windows.Forms.TextBox txtHybridAHead;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.TextBox txtHybridAlpha;
        private System.Windows.Forms.RadioButton radioHybridSetAlpha;
        private System.Windows.Forms.RadioButton radioHybridEstimateAlpha;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSmoothStep;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.RadioButton radioUseR;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtSmoothRPath;
        private System.Windows.Forms.Button buttonPlot;
        public static System.Windows.Forms.TextBox txtMinValue;
        public static System.Windows.Forms.TextBox txtMaxValue;
        public static System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.CheckBox checkBoxAdditive;
    }
}

