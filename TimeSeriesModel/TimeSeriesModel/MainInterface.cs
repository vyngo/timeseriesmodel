using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TimeSeriesModel
{
    public partial class MainInterface : Form
    {
        private string m_DemoFile;
        private string m_ValidateTestFile;
        private string m_TrainingFile;
        private TimeSeries m_DemoDataSeries;
        private TimeSeries m_TrainingDataSeries;
        private TimeSeries m_ValidateDataSeries;
        private NeuronNetwork m_NeuronNetwork;
        private TrainingResult m_TrainingResult;

        private List<string> lstPreprocess = new List<string>();
        const string DIFFERENCE = "Difference";
        const string DETREND = "Detrend";
        const string LN = "LnTranform";
        const string SDIFFERNCE = "Seasonal Difference";
        const string SADJUSTMENT = "Seasonal Adjustment";

        private bool useValidate = false;

        private List<ProcessType> Mapping()
        {
            List<ProcessType> ret = new List<ProcessType>();
            foreach(string method in this.lstPreprocess){
                if(method.Equals(DIFFERENCE)){
                    ProcessType typ = new ProcessType(enum_PreprocessType.DIFFERENCE,1);
                    ret.Add(typ);
                }
                else if (method.Equals(DETREND)) {
                    ProcessType typ = new ProcessType(enum_PreprocessType.LINEAR_DETREND);
                    ret.Add(typ);
                }
                else if (method.Equals(LN))
                {
                    ProcessType typ = new ProcessType(enum_PreprocessType.LN_TRANSFORM);
                    ret.Add(typ);
                }
                else
                {
                    string[] med = method.Split('_');
                    ProcessType typ = null;
                    if (med[0].Equals(SDIFFERNCE))
                    {
                        typ = new ProcessType(enum_PreprocessType.SEASONAL_DIFF, Int32.Parse(med[1]));
                    }
                    else {
                        typ = new ProcessType(enum_PreprocessType.SEASONAL_ADJ, Int32.Parse(med[1]));
                    }
                    ret.Add(typ);
                }
            }
            return ret;
        }
        public MainInterface()
        {
            m_DemoDataSeries = new TimeSeries();
            m_TrainingDataSeries = new TimeSeries();
            m_ValidateDataSeries = new TimeSeries();
            InitializeComponent();
            InitializeNetworkTab();
        }

        public void InitializeNetworkTab()
        {
            groupBoxNetworkConfig.Enabled = true;
            groupBoxTraining.Enabled = false;
            groupBoxAlgorithmConfig.Enabled = false;
        }

        private void btnPreprocessOpenData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_DemoFile = openDialog.FileName;
            }
            else
                return;
            if (m_DemoFile == null || m_DemoFile.Equals(""))
            {
                MessageBox.Show("Please choose validate test data file before training", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.IO.StreamReader fPointer = null;
                string line = null;
                int numRows = 0;
                int numColumns = 0;
                try
                {
                    fPointer = new System.IO.StreamReader(m_DemoFile);
                    while ((line = fPointer.ReadLine()) != null)
                    {
                        if (numRows == 0)
                        {
                            char[] delimiterChars = { ' ', ',' };
                            string[] words = line.Split(delimiterChars);
                            numColumns = words.Length;
                        }
                        numRows++;
                    }
                    this.labelTrainDataNumColumns.Text = Convert.ToString(numColumns);
                    this.labelTrainDataNumRows.Text = Convert.ToString(numRows);

                    this.txtTrainDataColumn.Text = "1";
                    this.txtTrainDataFromRow.Text = "1";
                    this.txtTrainDataToRow.Text = Convert.ToString(numRows);

                    if (numColumns == 1)
                    {
                        this.txtTrainDataColumn.Enabled = false;
                    }
                    else
                        this.txtTrainDataColumn.Enabled = true;
                }
                catch (System.OutOfMemoryException outOfMemory)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.IOException io)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fPointer != null)
                        fPointer.Close();
                }
            }
        }

        private void showing()
        {
            this.richTextProprocessData.Clear();
            List<double> data = this.m_DemoDataSeries.getProcessedSeries();
            this.richTextProprocessData.AppendText("Time Series\n");
            this.richTextProprocessData.AppendText("Start = " + this.m_DemoDataSeries.getStart() + "\n");
            this.richTextProprocessData.AppendText("End = " + this.m_DemoDataSeries.getEnd() + "\n\n");
            this.richTextProprocessData.AppendText(String.Format("{0,10}", "TIME"));
            this.richTextProprocessData.AppendText(String.Format("{0,20}", "VALUE\n\n"));
            for (int t = 0; t < data.Count; t++)
            {
                this.richTextProprocessData.AppendText(String.Format("{0,10}", "[" + (t + 1) + "]"));
                this.richTextProprocessData.AppendText(String.Format("{0,20}", data.ElementAt(t)) + "\n");
            }
        }

        private void btnPreprocessSaveData_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog file = new SaveFileDialog();
            file.Title = "Save Data";
            DialogResult result = file.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                filePath = file.FileName;
                this.m_DemoDataSeries.saveData(filePath);
            }
            else
                return;
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            try
            {
                Plot_Form form = new Plot_Form();
                List<double> data = this.m_DemoDataSeries.getProcessedSeries();
                if (data == null || data.Count == 0)
                {
                    return;
                }
                form.chart1.Series["Data"].Color = System.Drawing.Color.Blue;
                for (int i = 0; i < data.Count; i++)
                {
                    form.chart1.Series["Data"].Points.AddXY(i + 1, data.ElementAt(i));
                }
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in plot the Time Series: " + exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.m_DemoDataSeries.getProcessedSeries() == null || this.m_DemoDataSeries.getProcessedSeries().Count == 0)
            {
                return;
            }
            this.m_DemoDataSeries.restore();
            this.m_DemoDataSeries.preProcessList.Clear();
            TimeSeries.isSeasonalAdjust = false;
            TimeSeries.isDetrend = false;
            this.showing();
        }

        private void btnCorrelogram_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_DemoDataSeries.getProcessedSeries() == null || this.m_DemoDataSeries.getProcessedSeries().Count == 0)
                {
                    return;
                }
                Plot_Form form = new Plot_Form();
                form.chart1.Titles["Title1"].Text = "Autocorrelation Function";
                form.chart1.ChartAreas["ChartArea1"].Axes[0].Title = "Lag";
                form.chart1.ChartAreas["ChartArea1"].Axes[1].Title = "ACF";
                form.chart1.Series[0].Name = "ACF";
                form.chart1.Series[0].Color = System.Drawing.Color.Blue;
                form.chart1.Series[0].Points.AddXY(0.0, 0.0);
                form.chart1.Series[0].Points.AddXY(0.0, 1.0);


                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series1.Color = System.Drawing.Color.Red;
                series1.Points.AddXY(0.0, 1.96 / Math.Sqrt(this.m_DemoDataSeries.getSize()));
                series1.IsVisibleInLegend = false;

                System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series2.ChartArea = "ChartArea1";
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series2.Color = System.Drawing.Color.Red;
                series2.Points.AddXY(0.0, -1.96 / Math.Sqrt(this.m_DemoDataSeries.getSize()));
                series2.IsVisibleInLegend = false;

                for (int i = 1; i <= 50; i++)
                {
                    System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                    series.ChartArea = "ChartArea1";
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    series.Color = System.Drawing.Color.Blue;
                    series.Points.AddXY(i, 0.0);
                    series.Points.AddXY(i, this.m_DemoDataSeries.getAutocorrelation(i));
                    series.IsVisibleInLegend = false;
                    form.chart1.Series.Add(series);

                    series1.Points.AddXY(i, 1.96 / Math.Sqrt(this.m_DemoDataSeries.getSize()));

                    series2.Points.AddXY(i, -1.96 / Math.Sqrt(this.m_DemoDataSeries.getSize()));


                }

                form.chart1.Series.Add(series1);
                form.chart1.Series.Add(series2);
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in plot Autocorrelation of the Time Series: " + exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (this.checkBoxLnTransformation.Checked)
            {
                this.m_DemoDataSeries.lnTranformation();
               
            }
            if (this.radioDifference.Checked)
            {
                
                this.m_DemoDataSeries.difference(1);
                
            }
            if (this.radioLinearDetrend.Checked)
            {
               
                this.m_DemoDataSeries.linearDetrend();
                
            }
            if (this.radioDifferenceSeasonality.Checked)
            {
                try
                {
                    int lag = Int32.Parse(this.txtNumLagAtDeseasonality.Text);
                    this.m_DemoDataSeries.difference(lag);
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (this.radioSeasonalAdjustment.Checked) {
                try {
                    int cycle = Int32.Parse(this.textBox_Cycle.Text.ToString());
                    this.m_DemoDataSeries.seasonalAdjust(cycle);
                   
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.showing();
        }

        private void radioDifferenceSeasonality_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            this.txtNumLagAtDeseasonality.Visible = true;
            this.txtNumLagAtDeseasonality.Enabled = true;
            this.label_cycle.Visible = false;
            this.textBox_Cycle.Visible = false;
            this.textBox_Cycle.Enabled = false;
        }

        private void radioSeasonalAdjustment_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            this.txtNumLagAtDeseasonality.Visible = false;
            this.txtNumLagAtDeseasonality.Enabled = false;
            this.label_cycle.Visible = true;
            this.textBox_Cycle.Visible = true;
            this.textBox_Cycle.Enabled = true;
           
        }

        private void radioNoneDeseasonality_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            this.txtNumLagAtDeseasonality.Visible = false;
            this.txtNumLagAtDeseasonality.Enabled = false;
            this.label_cycle.Visible = false;
            this.textBox_Cycle.Visible = false;
            this.textBox_Cycle.Enabled = false;
            
        }

        private void btnNetworkNew_Click(object sender, EventArgs e)
        {
            string numInputs = this.txtNumInput.Text;
            string numHiddens = this.txtNumHidden.Text;
            string numOutputs = this.txtNumOutput.Text;
            string lags = this.txtNumLag.Text;
            if (numInputs == "" || numHiddens == "" || numOutputs == "")
            {
                System.Windows.Forms.MessageBox.Show("Please insert the number of Input Nodes, Hidden Nodes, Output Nodes", null, System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }
            try
            {
                m_NeuronNetwork = new NeuronNetwork(Int32.Parse(numInputs),Int32.Parse(numHiddens),Int32.Parse(numOutputs), lags);
                System.Windows.Forms.MessageBox.Show("NetWork configuration successfull, You can train it");
                
                this.txtNumOutput.Enabled = false;
                this.txtNumHidden.Enabled = false;
                this.txtNumInput.Enabled = false;
                this.txtNumLag.Enabled = false;
                this.groupBoxTraining.Enabled = true;
                this.groupBoxValidate.Enabled = true;
                this.btnNetworkNew.Enabled = false;
                this.btnNetworkLoad.Enabled = false;
                this.btnNetworkSave.Enabled = true;
                this.btnNetworkClear.Enabled = true;
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
            
        }

        private void btnNetworkClear_Click(object sender, EventArgs e)
        {
            m_NeuronNetwork = null;
            this.txtNumLag.Text = "";
            this.txtNumInput.Text = "";
            this.txtNumHidden.Text = "";
            this.txtNumOutput.Text = "";
            this.txtTrainingFileName.Text = "";
            this.txtTrainingColumn.Text = "";
            this.txtTrainingFromRow.Text = "";
            this.txtConfig1.Text = "";
            this.txtConfig2.Text = "";
            this.txtConfigEpoches.Text = "";
            this.txtConfigErrors.Text = "";

            this.groupBoxTraining.Enabled = false;
            this.groupBoxAlgorithmConfig.Enabled = false;
            this.groupBoxAlgorithmConfig.Enabled = false;
            this.groupBoxValidate.Enabled = false;
            this.btnNetworkNew.Enabled = true;
            this.btnNetworkLoad.Enabled = true;
            this.btnNetworkSave.Enabled = false;
            this.btnNetworkClear.Enabled = false;
            this.txtNumLag.Enabled = true;
            this.txtNumHidden.Enabled = true;
            this.txtNumInput.Enabled = true;
            this.txtNumOutput.Enabled = true;
            this.rtbPreProcess.Text = "";
            this.lstPreprocess = new List<string>();
            this.radioBackPropagation.Checked = false;
            this.radioRPROP.Checked = false;
        }

        private void btnNetworkLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Load Network Config File";
            fileDialog.DefaultExt = "xml";
            DialogResult result = fileDialog.ShowDialog();
            string dataFile = "";
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                dataFile = fileDialog.FileName;
                NeuronNetwork temp = NeuronNetwork.Import(dataFile);
                if (temp == null)
                {
                    System.Windows.Forms.MessageBox.Show("The Input file is not correct format !!!", null, System.Windows.Forms.MessageBoxButtons.OK);
                }
                else
                {
                    m_NeuronNetwork = temp;
                    this.txtNumInput.Text = Convert.ToString(m_NeuronNetwork.m_iNumInputNodes);
                    this.txtNumHidden.Text = Convert.ToString(m_NeuronNetwork.m_iNumHiddenNodes);
                    this.txtNumOutput.Text = Convert.ToString(m_NeuronNetwork.m_iNumOutputNodes);
                    this.txtNumLag.Text = m_NeuronNetwork.GetStringLags();
                    this.txtNumInput.Enabled = false;
                    this.txtNumHidden.Enabled = false;
                    this.txtNumOutput.Enabled = false;
                    this.txtNumLag.Enabled = false;
                    this.btnNetworkNew.Enabled = false;
                    this.btnNetworkLoad.Enabled = false;
                    this.btnNetworkClear.Enabled = true;
                    this.btnNetworkSave.Enabled = true;
                    this.groupBoxTraining.Enabled = true;
                }
            }
            else
                return;
        }

        private void btnNetworkSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Network Config File";
            saveDialog.DefaultExt = "xml";
            DialogResult result = saveDialog.ShowDialog();
            string dataFile = "";
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                dataFile = saveDialog.FileName;
                NeuronNetwork.Export(m_NeuronNetwork, dataFile);
            }
            else
                return;
        }

        private void radioBackPropagation_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAlgorithmConfig.Enabled = true;
            groupBoxAlgorithmConfig.Text = "Back Propagation Config";
            labelConfig1.Text = "Learning Rate";
            labelConfig2.Text = "Momemtum";
        }

        private void radioRPROP_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAlgorithmConfig.Enabled = true;
            groupBoxAlgorithmConfig.Text = "Resilient Propagation Config";
            labelConfig1.Text = "Default Update Value";
            labelConfig2.Text = "Max Update Value";
        }

        private void btnTrainingBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_TrainingFile = openDialog.FileName;
                //this.txtValidateFileName.Text = m_TrainingFile;
                m_ValidateTestFile = m_TrainingFile;
            }
            else
                return;
            if (m_TrainingFile == null || m_TrainingFile.Equals(""))
            {
                MessageBox.Show("Please choose validate test data file before training", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //this.txtValidateFileName.Text = m_TrainingFile;
                m_ValidateTestFile = m_TrainingFile;
                System.IO.StreamReader fPointer = null;
                string line = null;
                int numRows = 0;
                int numColumns = 0;
                try
                {
                    fPointer = new System.IO.StreamReader(m_TrainingFile);
                    while ((line = fPointer.ReadLine()) != null)
                    {
                        if (numRows == 0)
                        {
                            char[] delimiterChars = { ' ', ',' };
                            string[] words = line.Split(delimiterChars);
                            numColumns = words.Length;
                        }
                        numRows++;
                    }
                    this.txtTrainingFileName.Text = m_TrainingFile;
                    this.labelTrainingNumColumns.Text = Convert.ToString(numColumns);
                    this.labelTrainingNumRows.Text = Convert.ToString(numRows);

                    this.txtTrainingColumn.Text = "1";
                    this.txtTrainingFromRow.Text = "1";
                    this.txtTrainDataToRow.Text = Convert.ToString(numRows);
               
                    if (numColumns == 1)
                    {
                        this.txtTrainingColumn.Enabled = false;
                    }
                    else
                        this.txtTrainingColumn.Enabled = true;
                }
                catch (System.OutOfMemoryException outOfMemory)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.IOException io)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fPointer != null)
                        fPointer.Close();
                }
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            //if (!m_TrainingFile.Equals(m_ValidateTestFile)) {
            //    MessageBox.Show("Training file must be the same with validate File", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (radioBackPropagation.Checked)
            {
                //Back Propagation Training
                double epoch, learningRate, momemtum, residual;
                try
                {
                    epoch = Double.Parse(txtConfigEpoches.Text);
                    learningRate = Double.Parse(txtConfig1.Text);
                    momemtum = Double.Parse(txtConfig2.Text);
                    residual = Double.Parse(txtConfigErrors.Text);

                    List<double> sampleForTrain = new List<double>();
                    List<double> sampleForValidate = new List<double>();

                    //load train input
                    System.IO.StreamReader file = null;
                    string line = null;
                    int counter = 0;
                    bool isFormatFileRight = true;
                    int beginRow = Convert.ToInt32(this.txtTrainingFromRow.Text);
                    int endRow = Convert.ToInt32(this.txtTrainingToRow.Text);

                    int columnSelected = Convert.ToInt32(this.txtTrainingColumn.Text);
                    int idxRow = 0;
                    try
                    {
                        file = new System.IO.StreamReader(m_TrainingFile);
                        while ((line = file.ReadLine()) != null)
                        {
                            idxRow++;
                            char[] delimiterChars = { ' ', ',' };
                            string[] words = line.Split(delimiterChars);
                            if (columnSelected <= words.Length)
                            {
                                if (idxRow < beginRow || idxRow > endRow)
                                {
                                    continue;
                                }
                                else
                                {
                                    sampleForTrain.Add(Double.Parse(words[columnSelected - 1]));
                                }
                            }
                            else
                            {
                                isFormatFileRight = false;
                                break;
                            }
                        }
                        if (!isFormatFileRight)
                        {
                            MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sampleForTrain = null;
                        }
                    }
                    catch (System.OutOfMemoryException outOfMemory)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.IO.IOException io)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.Exception excp)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }

                    ////load validate input
                    //file = null;
                    //line = null;
                    //counter = 0;
                    //isFormatFileRight = true;
                    //if (!this.useValidate) {
                    //    this.txtValidateFromRow.Text = "-1";
                    //    this.txtValidateToRow.Text = "-1";
                    //}
                    //beginRow = Convert.ToInt32(this.txtValidateFromRow.Text);
                    //endRow = Convert.ToInt32(this.txtValidateToRow.Text);

                    //columnSelected = Convert.ToInt32(this.txtValidateColumn.Text);
                   
                    //idxRow = 0;
                    //try
                    //{
                    //    file = new System.IO.StreamReader(m_ValidateTestFile);
                    //    while ((line = file.ReadLine()) != null)
                    //    {
                    //        idxRow++;
                    //        char[] delimiterChars = { ' ', ',' };
                    //        string[] words = line.Split(delimiterChars);
                    //        if (columnSelected <= words.Length)
                    //        {
                    //            if (idxRow < beginRow || idxRow > endRow)
                    //            {
                    //                continue;
                    //            }
                    //            else
                    //            {
                    //                sampleForValidate.Add(Double.Parse(words[columnSelected - 1]));
                    //            }
                    //        }
                    //        else
                    //        {
                    //            isFormatFileRight = false;
                    //            break;
                    //        }
                    //    }
                    //    if (!isFormatFileRight)
                    //    {
                    //        MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        sampleForValidate = null;
                    //    }
                    //}
                    //catch (System.OutOfMemoryException outOfMemory)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //catch (System.IO.IOException io)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //catch (System.Exception excp)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //finally
                    //{
                    //    if (file != null)
                    //        file.Close();
                    //}

                    if (sampleForTrain != null && sampleForValidate != null)
                    {
                        m_ValidateDataSeries.loadData(sampleForValidate);
                        m_TrainingDataSeries.loadData(sampleForTrain);
                        List<ProcessType> preProcessList = this.Mapping();
                        m_TrainingResult = new TrainingResult(AlgorithmType.BackPropagation);
                        AlgorithmLoop loopType = (this.useValidate) ? AlgorithmLoop.LoopValidateMAE : AlgorithmLoop.LoopTrainMAE;
                        txtLogs.Enabled = true;
                        txtLogs.Text = "";
                        txtLogs.AppendText("Begin training....\n");
                        tabControl.SelectedTab = tabLogs;
                        Algorithm.BPropTraining(loopType, preProcessList, m_TrainingResult, m_NeuronNetwork, m_TrainingDataSeries, m_ValidateDataSeries, learningRate, momemtum, epoch, residual);
                        if (loopType == AlgorithmLoop.LoopValidateMAE)
                        {
                            m_TrainingResult.ShowDialog();
                        }
                        else
                        {
                            m_TrainingResult.ShowDialog2();
                        }
                    }
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input for Back Propagation Training is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Resilient Propagation Training
                double defaultValue, maxValue, epoch, residual;
                try
                {
                    epoch = Double.Parse(txtConfigEpoches.Text);
                    defaultValue = Double.Parse(txtConfig1.Text);
                    maxValue = Double.Parse(txtConfig2.Text);
                    residual = Double.Parse(txtConfigErrors.Text);
                  
                    List<double> sampleForTrain = new List<double>();
                    List<double> sampleForValidate = new List<double>();

                    //load train input
                    System.IO.StreamReader file = null;
                    string line = null;
                    int counter = 0;
                    bool isFormatFileRight = true;
                    int beginRow = Convert.ToInt32(this.txtTrainingFromRow.Text);
                    int endRow = Convert.ToInt32(this.txtTrainingToRow.Text);

                    int columnSelected = Convert.ToInt32(this.txtTrainingColumn.Text);
                    int idxRow = 0;
                    try
                    {
                        file = new System.IO.StreamReader(m_TrainingFile);
                        while ((line = file.ReadLine()) != null)
                        {
                            idxRow++;
                            char[] delimiterChars = { ' ', ',' };
                            string[] words = line.Split(delimiterChars);
                            if (columnSelected <= words.Length)
                            {
                                if (idxRow < beginRow || idxRow > endRow)
                                {
                                    continue;
                                }
                                else
                                {
                                    sampleForTrain.Add(Double.Parse(words[columnSelected - 1]));
                                }
                            }
                            else
                            {
                                isFormatFileRight = false;
                                break;
                            }
                        }
                        if (!isFormatFileRight)
                        {
                            MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sampleForTrain = null;
                        }
                    }
                    catch (System.OutOfMemoryException outOfMemory)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.IO.IOException io)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.Exception excp)
                    {
                        sampleForTrain = null;
                        MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }

                    //load validate input
                    //file = null;
                    //line = null;
                    //counter = 0;
                    //isFormatFileRight = true;
                    //if (!this.useValidate)
                    //{
                    //    this.txtValidateFromRow.Text = "-1";
                    //    this.txtValidateToRow.Text = "-1";
                    //}
                    //beginRow = Convert.ToInt32(this.txtValidateFromRow.Text);
                    //endRow = Convert.ToInt32(this.txtValidateToRow.Text);

                    //columnSelected = Convert.ToInt32(this.txtValidateColumn.Text);
                    
                    //idxRow = 0;
                    //try
                    //{
                    //    file = new System.IO.StreamReader(m_ValidateTestFile);
                    //    while ((line = file.ReadLine()) != null)
                    //    {
                    //        idxRow++;
                    //        char[] delimiterChars = { ' ', ',' };
                    //        string[] words = line.Split(delimiterChars);
                    //        if (columnSelected <= words.Length)
                    //        {
                    //            if (idxRow < beginRow || idxRow > endRow)
                    //            {
                    //                continue;
                    //            }
                    //            else
                    //            {
                    //                sampleForValidate.Add(Double.Parse(words[columnSelected - 1]));
                    //            }
                    //        }
                    //        else
                    //        {
                    //            isFormatFileRight = false;
                    //            break;
                    //        }
                    //    }
                    //    if (!isFormatFileRight)
                    //    {
                    //        MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        sampleForValidate = null;
                    //    }
                    //}
                    //catch (System.OutOfMemoryException outOfMemory)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //catch (System.IO.IOException io)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //catch (System.Exception excp)
                    //{
                    //    sampleForValidate = null;
                    //    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //finally
                    //{
                    //    if (file != null)
                    //        file.Close();
                    //}
                    if (sampleForTrain != null && sampleForValidate != null)
                    {
                        m_ValidateDataSeries = new TimeSeries();
                        m_ValidateDataSeries.loadData(sampleForValidate);
                        m_TrainingDataSeries.loadData(sampleForTrain);
                        List<ProcessType> preProcessList = this.Mapping();
                        m_TrainingResult = new TrainingResult(AlgorithmType.ResilientPropagation);
                        AlgorithmLoop loopType = (this.useValidate) ? AlgorithmLoop.LoopValidateMAE : AlgorithmLoop.LoopTrainMAE;
                        txtLogs.Enabled = true;
                        txtLogs.Text = "";
                        txtLogs.AppendText("Begin training....\n");
                        tabControl.SelectedTab = tabLogs;
                        Algorithm.RPropTraining(loopType, preProcessList, m_TrainingResult, m_NeuronNetwork, m_TrainingDataSeries, m_ValidateDataSeries, defaultValue, maxValue, epoch, residual);
                        if (loopType == AlgorithmLoop.LoopValidateMAE)
                        {
                            m_TrainingResult.ShowDialog();
                        }
                        else {
                            m_TrainingResult.ShowDialog2();
                        }
                    }
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input for Back Propagation Training is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTrainDataGet_Click(object sender, EventArgs e)
        {
            List<double> sample = new List<double>();
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtTrainDataFromRow.Text);
            int endRow = Convert.ToInt32(this.txtTrainDataToRow.Text);
            int columnSelected = Convert.ToInt32(this.txtTrainDataColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_DemoFile);
                while ((line = file.ReadLine()) != null)
                {
                    idxRow++;
                    if (idxRow < beginRow || idxRow > endRow)
                        continue;

                    char[] delimiterChars = { ' ', ',' };
                    string[] words = line.Split(delimiterChars);
                    if (columnSelected <= words.Length)
                    {
                        sample.Add(Double.Parse(words[columnSelected - 1]));
                    }
                    else
                    {
                        isFormatFileRight = false;
                        break;
                    }
                }
                if (!isFormatFileRight)
                {
                    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sample = null;
                }
            }
            catch (System.OutOfMemoryException outOfMemory)
            {
                sample = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException io)
            {
                sample = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception excp)
            {
                sample = null;
                MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            if (sample != null)
            {
                m_DemoDataSeries.loadData(sample);
                TimeSeries.isSeasonalAdjust = false;
                TimeSeries.isDetrend = false;
                showing();
                this.m_DemoDataSeries.preProcessList.Clear(); //clear for new data
            }
            else
            {
                MessageBox.Show("Load data fail", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            this.rtbPreProcess.AppendText("-" + DIFFERENCE + "\n");
            this.lstPreprocess.Add(DIFFERENCE);
        }

        private void btnDtrend_Click(object sender, EventArgs e)
        {
            this.rtbPreProcess.AppendText("-" + DETREND + "\n");
            this.lstPreprocess.Add(DETREND);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            this.rtbPreProcess.AppendText("-" + LN + "\n");
            this.lstPreprocess.Add(LN);
        }

        private void btnSDiff_Click(object sender, EventArgs e)
        {
            string lag = this.tbLag.Text;
            this.rtbPreProcess.AppendText("-" + SDIFFERNCE + "_" + lag + "\n");
            this.lstPreprocess.Add(SDIFFERNCE + "_" + lag);
        }

        private void btnSadj_Click(object sender, EventArgs e)
        {
            string lag = this.tbLag.Text;
            this.rtbPreProcess.AppendText("-" + SADJUSTMENT + "_" + lag + "\n");
            this.lstPreprocess.Add(SADJUSTMENT + "_" + lag);
        }

        private void btnValidateBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_ValidateTestFile = openDialog.FileName;
            }
            else
                return;
            if (m_ValidateTestFile == null || m_ValidateTestFile.Equals(""))
            {
                MessageBox.Show("Please choose validate test data file before training", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.IO.StreamReader fPointer = null;
                string line = null;
                int numRows = 0;
                int numColumns = 0;
                try
                {
                    fPointer = new System.IO.StreamReader(m_ValidateTestFile);
                    while ((line = fPointer.ReadLine()) != null)
                    {
                        if (numRows == 0)
                        {
                            char[] delimiterChars = { ' ', ',' };
                            string[] words = line.Split(delimiterChars);
                            numColumns = words.Length;
                        }
                        numRows++;
                    }
                    this.txtValidateFileName.Text = m_ValidateTestFile;
                    this.labelValidateNumColumns.Text = Convert.ToString(numColumns);
                    this.labelValidateNumRows.Text = Convert.ToString(numRows);

                    this.txtValidateFromRow.Text = "1";
                    this.txtValidateColumn.Text = "1";
                    this.txtValidateToRow.Text = Convert.ToString(numRows);

                    if (numColumns == 1)
                    {
                        this.txtValidateColumn.Enabled = false;
                    }
                    else
                        this.txtValidateColumn.Enabled = true;
                }
                catch (System.OutOfMemoryException outOfMemory)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.IOException io)
                {
                    MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (fPointer != null)
                        fPointer.Close();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<double> sampleForTest = new List<double>();
            List<double> testPartion = new List<double>();

            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtTestFromRow.Text);
            int endRow = Convert.ToInt32(this.txtTestToRow.Text);

            int columnSelected = Convert.ToInt32(this.txtValidateColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_ValidateTestFile);
                while ((line = file.ReadLine()) != null)
                {
                    idxRow++;
                    char[] delimiterChars = { ' ', ',' };
                    string[] words = line.Split(delimiterChars);
                    if (columnSelected <= words.Length)
                    {
                        if (idxRow < beginRow || idxRow > endRow)
                        {
                            sampleForTest.Add(Double.Parse(words[columnSelected - 1]));
                        }
                        else
                        {
                            testPartion.Add(Double.Parse(words[columnSelected - 1]));
                            //sampleForTest.Add(Double.Parse(words[columnSelected - 1]));
                        }
                    }
                    else
                    {
                        isFormatFileRight = false;
                        break;
                    }
                }
                if (!isFormatFileRight)
                {
                    MessageBox.Show("Input is wrong format in Test", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (System.OutOfMemoryException outOfMemory)
            {
                
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.IO.IOException io)
            {
               
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.Exception excp)
            {
                
                MessageBox.Show("Input is wrong format in Test", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
            if (sampleForTest.Count() != 0 && testPartion.Count() != 0) { 
                TimeSeries testSample = new TimeSeries();
                testSample.loadData(sampleForTest);
                List<ProcessType> preProcessList = this.Mapping();
                Algorithm.doTest(preProcessList, testSample, testPartion);
            }
        }

        private void radioLoopValidate_CheckedChanged(object sender, EventArgs e)
        {
            //this.radioLoopTrain.Enabled = false;
            //this.radioLoopValidate.Enabled = true;
            this.useValidate = true;
        }

        private void radioLoopTrain_CheckedChanged(object sender, EventArgs e)
        {
            //this.radioLoopTrain.Enabled = true;
            //this.radioLoopValidate.Enabled = false;
            this.useValidate = false;
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            int ahead = 0;
            try
            {
                ahead = Int32.Parse(this.txtAhead.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Input is wrong format in ForeCast", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<double> sample = new List<double>();
            int beginRow = Convert.ToInt32(this.txtTrainingFromRow.Text);
            int endRow = Convert.ToInt32(this.txtTrainingToRow.Text);
            System.IO.StreamReader file = null;
            string line = null;
            bool isFormatFileRight = true;

            int columnSelected = Convert.ToInt32(this.txtTrainingColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_TrainingFile);
                while ((line = file.ReadLine()) != null)
                {
                    idxRow++;
                    char[] delimiterChars = { ' ', ',' };
                    string[] words = line.Split(delimiterChars);
                    if (columnSelected <= words.Length)
                    {
                        if (idxRow < beginRow || idxRow > endRow)
                        {
                            continue;
                        }
                        else
                        {
                            sample.Add(Double.Parse(words[columnSelected - 1]));
                        }
                    }
                    else
                    {
                        isFormatFileRight = false;
                        break;
                    }
                }
                if (!isFormatFileRight)
                {
                    MessageBox.Show("Input is wrong format in Test", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (System.OutOfMemoryException outOfMemory)
            {

                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.IO.IOException io)
            {

                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.Exception excp)
            {

                MessageBox.Show("Input is wrong format in Forecast", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
            if (sample.Count() != 0)
            {
                TimeSeries forecastSample = new TimeSeries();
                forecastSample.loadData(sample);
                List<ProcessType> preProcessList = this.Mapping();
                Algorithm.doForecast(preProcessList, forecastSample, ahead);
            }
        }
    }
}
