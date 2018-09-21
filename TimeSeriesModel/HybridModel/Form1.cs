using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HybridModel
{
    public partial class Form1 : Form
    {
        private NeuronNetwork m_NeuronNetwork;

        private string m_NeuronTrainingFile;
        public TrainingResult m_NeuronTrainingResult;

        private string m_SmoothTrainingFile;
        Smoothing m_Smooth;
        Param m_Param;

        private string m_HybridTrainingFile;
        Hybrid m_Hybrid;
        double m_estimateAlpha;

        public Form1()
        {
            InitializeComponent();
            this.groupNeuronAlgorithmConfig.Enabled = false;
            this.groupNeuronTraining.Enabled = false;
            this.btnNeuronSave.Enabled = false;
            this.btnNeuronClear.Enabled = false;
        }

        private void btnNeuronNew_Click(object sender, EventArgs e)
        {
            string numInputs = txtNeuronNumInputs.Text;
            string numHiddens = txtNeuronNumHiddens.Text;
            string numOutputs = txtNeuronNumOutputs.Text;
            string lags = this.txtNeuronLags.Text;
            if (numInputs == "" || numHiddens == "" || numOutputs == "")
            {
                System.Windows.Forms.MessageBox.Show("Please insert the number of Input Nodes, Hidden Nodes, Output Nodes", null, System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }
            try
            {
                m_NeuronNetwork = new NeuronNetwork(Int32.Parse(numInputs), Int32.Parse(numHiddens), Int32.Parse(numOutputs), lags);
                System.Windows.Forms.MessageBox.Show("NetWork configuration successfull, You can train it");

                this.txtNeuronNumInputs.Enabled = false;
                this.txtNeuronNumHiddens.Enabled = false;
                this.txtNeuronNumOutputs.Enabled = false;
                this.txtNeuronLags.Enabled = false;
                this.groupNeuronAlgorithmConfig.Enabled = true;
                this.groupNeuronTraining.Enabled = true;
                this.btnNeuronNew.Enabled = false;
                this.btnNeuronLoad.Enabled = false;
                this.btnNeuronSave.Enabled = true;
                this.btnNeuronClear.Enabled = true;
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
            }
        }

        private void btnNeuronLoad_Click(object sender, EventArgs e)
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
                    this.txtNeuronNumInputs.Text = Convert.ToString(m_NeuronNetwork.m_iNumInputNodes);
                    this.txtNeuronNumHiddens.Text = Convert.ToString(m_NeuronNetwork.m_iNumHiddenNodes);
                    this.txtNeuronNumOutputs.Text = Convert.ToString(m_NeuronNetwork.m_iNumOutputNodes);
                    this.txtNeuronLags.Text = m_NeuronNetwork.GetStringLags();
                    this.txtNeuronNumInputs.Enabled = false;
                    this.txtNeuronNumHiddens.Enabled = false;
                    this.txtNeuronNumOutputs.Enabled = false;
                    this.txtNeuronLags.Enabled = false;
                    this.btnNeuronNew.Enabled = false;
                    this.btnNeuronLoad.Enabled = false;
                    this.btnNeuronClear.Enabled = true;
                    this.btnNeuronSave.Enabled = true;
                    this.groupNeuronTraining.Enabled = true;
                }
            }
            else
                return;
        }

        private void btnNeuronSave_Click(object sender, EventArgs e)
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

        private void btnNeuronClear_Click(object sender, EventArgs e)
        {
            m_NeuronNetwork = null;
            this.txtNeuronLags.Text = "";
            this.txtNeuronNumInputs.Text = "";
            this.txtNeuronNumHiddens.Text = "";
            this.txtNeuronNumOutputs.Text = "";
            this.groupNeuronTraining.Enabled = false;
            this.groupNeuronAlgorithmConfig.Enabled = false;
            this.txtNeuronNumInputs.Enabled = true;
            this.txtNeuronNumHiddens.Enabled = true;
            this.txtNeuronNumOutputs.Enabled = true;
            this.txtNeuronLags.Enabled = true;

            this.btnNeuronNew.Enabled = true;
            this.btnNeuronLoad.Enabled = true;
        }

        private void radioNeuronBackPropagation_CheckedChanged(object sender, EventArgs e)
        {
            groupNeuronAlgorithmConfig.Enabled = true;
            groupNeuronAlgorithmConfig.Text = "Back Propagation Config";
            labelNeuronConfig1.Text = "Learning Rate";
            labelNeuronConfig2.Text = "Momemtum";
        }

        private void radioNeuronRProp_CheckedChanged(object sender, EventArgs e)
        {
            groupNeuronAlgorithmConfig.Enabled = true;
            groupNeuronAlgorithmConfig.Text = "Resilient Propagation Config";
            labelNeuronConfig1.Text = "Default Update Value";
            labelNeuronConfig2.Text = "Max Update Value";
        }

        private void txtTrainingInputFile_MouseClicked(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_NeuronTrainingFile = openDialog.FileName;
                m_SmoothTrainingFile = m_NeuronTrainingFile;
                m_HybridTrainingFile = m_NeuronTrainingFile;
            }
            else
                return;
            if (m_NeuronTrainingFile == null || m_NeuronTrainingFile.Equals(""))
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
                    fPointer = new System.IO.StreamReader(m_NeuronTrainingFile);
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
                    this.txtNeuronTrainingFile.Text = m_NeuronTrainingFile;
                    this.txtSmoothTrainingFile.Text = m_NeuronTrainingFile;
                    this.txtHybridTrainingFile.Text = m_HybridTrainingFile;

                    this.labelNeuronNumColumns.Text = Convert.ToString(numColumns);
                    this.labelSmoothNumColumns.Text = this.labelNeuronNumColumns.Text;
                    this.labelHybridNumColumns.Text = this.labelNeuronNumColumns.Text;

                    this.labelNeuronNumRows.Text = Convert.ToString(numRows);
                    this.labelSmoothNumRows.Text = this.labelNeuronNumRows.Text;
                    this.labelHybridNumRows.Text = this.labelNeuronNumRows.Text;

                    this.txtNeuronColumnSelected.Text = "1";
                    this.txtSmoothColumn.Text = this.txtNeuronColumnSelected.Text;
                    this.txtHybridColumn.Text = this.txtNeuronColumnSelected.Text;

                    this.txtNeuronFromRow.Text = "1";
                    this.txtSmoothFromRow.Text = "1";
                    this.txtHybridFromRow.Text = "1";

                    this.txtNeuronToRow.Text = Convert.ToString(numRows);
                    this.txtSmoothToRow.Text = this.txtNeuronToRow.Text;
                    this.txtHybridToRow.Text = this.txtNeuronToRow.Text;

                    if (numColumns == 1)
                    {
                        this.txtNeuronColumnSelected.Enabled = false;
                        this.txtSmoothColumn.Enabled = false;
                        this.txtHybridColumn.Enabled = false;
                    }
                    else
                    {
                        this.txtNeuronColumnSelected.Enabled = true;
                        this.txtSmoothColumn.Enabled = true;
                        this.txtHybridColumn.Enabled = true;
                    }
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

        private void buttonNeuronTrain_Click(object sender, EventArgs e)
        {
            if (radioNeuronBackPropagation.Checked)
            {
                //Back Propagation Training
                double epoch, learningRate, momemtum, residual;
                try
                {
                    epoch = Double.Parse(txtNeuronMaxEpoches.Text);
                    learningRate = Double.Parse(txtNeuronConfig1.Text);
                    momemtum = Double.Parse(txtNeuronConfig2.Text);
                    residual = Double.Parse(txtNeuronDeltaErrors.Text);

                    List<double> sampleForTrain = new List<double>();

                    //load train input
                    System.IO.StreamReader file = null;
                    string line = null;
                    int counter = 0;
                    bool isFormatFileRight = true;
                    int beginRow = Convert.ToInt32(this.txtNeuronFromRow.Text);
                    int endRow = Convert.ToInt32(this.txtNeuronToRow.Text);

                    int columnSelected = Convert.ToInt32(this.txtNeuronColumnSelected.Text);
                    int idxRow = 0;
                    try
                    {
                        file = new System.IO.StreamReader(m_NeuronTrainingFile);
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

                    if (sampleForTrain != null)
                    {
                        Form1.txtLogs.Enabled = true;
                        Form1.txtLogs.Text = "";
                        Form1.txtLogs.AppendText("Begin training....\n");
                        tabControl.SelectedTab = tabLogs;
                        m_NeuronTrainingResult = new TrainingResult(AlgorithmType.BackPropagation);
                        Algorithm.BPropTraining(m_NeuronTrainingResult, m_NeuronNetwork,sampleForTrain, learningRate, momemtum, epoch, residual);
                        m_NeuronTrainingResult.ShowDialog();
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
                    epoch = Double.Parse(txtNeuronMaxEpoches.Text);
                    defaultValue = Double.Parse(txtNeuronConfig1.Text);
                    maxValue = Double.Parse(txtNeuronConfig2.Text);
                    residual = Double.Parse(txtNeuronDeltaErrors.Text);

                    List<double> sampleForTrain = new List<double>();

                    //load train input
                    System.IO.StreamReader file = null;
                    string line = null;
                    int counter = 0;
                    bool isFormatFileRight = true;
                    int beginRow = Convert.ToInt32(this.txtNeuronFromRow.Text);
                    int endRow = Convert.ToInt32(this.txtNeuronToRow.Text);

                    int columnSelected = Convert.ToInt32(this.txtNeuronColumnSelected.Text);
                    int idxRow = 0;
                    try
                    {
                        file = new System.IO.StreamReader(m_NeuronTrainingFile);
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

                    if (sampleForTrain != null)
                    {
                        Form1.txtLogs.Enabled = true;
                        Form1.txtLogs.Text = "";
                        Form1.txtLogs.AppendText("Begin training....\n");
                        tabControl.SelectedTab = tabLogs;
                        m_NeuronTrainingResult = new TrainingResult(AlgorithmType.ResilientPropagation);
                        Algorithm.RPropTraining(m_NeuronTrainingResult, m_NeuronNetwork, sampleForTrain, defaultValue, maxValue, epoch, residual);
                        m_NeuronTrainingResult.ShowDialog();
                    }
                }
                catch (System.Exception excp)
                {
                    MessageBox.Show("Input for Back Propagation Training is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSmoothTrainingFile_MouseClicked(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_NeuronTrainingFile = openDialog.FileName;
                m_SmoothTrainingFile = m_NeuronTrainingFile;
                m_HybridTrainingFile = m_NeuronTrainingFile;
            }
            else
                return;
            if (m_SmoothTrainingFile == null || m_SmoothTrainingFile.Equals(""))
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
                    fPointer = new System.IO.StreamReader(m_SmoothTrainingFile);
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
                    this.txtNeuronTrainingFile.Text = m_NeuronTrainingFile;
                    this.txtSmoothTrainingFile.Text = m_NeuronTrainingFile;
                    this.txtHybridTrainingFile.Text = m_HybridTrainingFile;

                    this.labelNeuronNumColumns.Text = Convert.ToString(numColumns);
                    this.labelSmoothNumColumns.Text = this.labelNeuronNumColumns.Text;
                    this.labelHybridNumColumns.Text = this.labelNeuronNumColumns.Text;

                    this.labelNeuronNumRows.Text = Convert.ToString(numRows);
                    this.labelSmoothNumRows.Text = this.labelNeuronNumRows.Text;
                    this.labelHybridNumRows.Text = this.labelNeuronNumRows.Text;

                    this.txtNeuronColumnSelected.Text = "1";
                    this.txtSmoothColumn.Text = this.txtNeuronColumnSelected.Text;
                    this.txtHybridColumn.Text = this.txtNeuronColumnSelected.Text;

                    this.txtNeuronFromRow.Text = "1";
                    this.txtSmoothFromRow.Text = "1";
                    this.txtHybridFromRow.Text = "1";

                    this.txtNeuronToRow.Text = Convert.ToString(numRows);
                    this.txtSmoothToRow.Text = this.txtNeuronToRow.Text;
                    this.txtHybridToRow.Text = this.txtNeuronToRow.Text;

                    if (numColumns == 1)
                    {
                        this.txtNeuronColumnSelected.Enabled = false;
                        this.txtSmoothColumn.Enabled = false;
                        this.txtHybridColumn.Enabled = false;
                    }
                    else
                    {
                        this.txtNeuronColumnSelected.Enabled = true;
                        this.txtSmoothColumn.Enabled = true;
                        this.txtHybridColumn.Enabled = true;
                    }
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

        private void btnSmoothTrain_Click(object sender, EventArgs e)
        {
            EstimateAlgorithmType type;
            bool additiveModel = false;
            if (this.radioSmoothBruteForce.Checked)
            {
                type = EstimateAlgorithmType.BRUTE_FORCE;
            }
            else if (this.radioSmoothSimulated.Checked)
            {
                type = EstimateAlgorithmType.SIMULATED_ANNEALING_HILL_CLIMBING;
            }
            else if (this.radioSmoothSteepestAscent.Checked)
            {
                type = EstimateAlgorithmType.STEEPEST_ASCENT_HILL_CLIMBING;
            }
            else if (this.radioUseR.Checked)
            {
                type = EstimateAlgorithmType.USE_R_LIB;
            }
            else
            {
                type = EstimateAlgorithmType.BRUTE_FORCE;
            }
            if (this.checkBoxAdditive.Checked)
            {
                additiveModel = true;
            }
            else
            {
                additiveModel = false;
            }

            List<double> sampleForTrain = new List<double>();

            //load train input
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtSmoothFromRow.Text);
            int endRow = Convert.ToInt32(this.txtSmoothToRow.Text);

            int columnSelected = Convert.ToInt32(this.txtSmoothColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_SmoothTrainingFile);
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

            if (sampleForTrain != null)
            {
                int cycle = Convert.ToInt32(txtSmoothCycle.Text);
                if (type == EstimateAlgorithmType.USE_R_LIB)
                {
                    string pathDLL = txtSmoothRPath.Text;
                    string pathData = txtSmoothTrainingFile.Text;
                    m_Smooth = Smoothing.FindSmoothModelWithR(sampleForTrain, pathDLL, pathData, columnSelected, beginRow, endRow, cycle, additiveModel);
                    m_Param = m_Smooth.GetParam();
                }
                else
                {
                    if (m_Smooth == null)
                    {
                        m_Param = new Param(0.0, 0.0, 0.0);
                        m_Smooth = new Smoothing(sampleForTrain, m_Param, cycle, additiveModel);
                    }
                    else
                    {
                        m_Smooth.cycle = cycle;
                        m_Smooth.isAdditiveModel = additiveModel;
                        m_Smooth.SetSeries(sampleForTrain);
                    }
                    double step = Convert.ToDouble(txtSmoothStep.Text);
                    Smoothing.acceleration = step;

                    Form1.txtLogs.Enabled = true;
                    Form1.txtLogs.Text = "";
                    Form1.txtLogs.AppendText("Begin smooth training....\n");
                    tabControl.SelectedTab = tabLogs;

                    m_Param = Smoothing.FindBestParam(type, m_Smooth);
                    m_Smooth.SetParam(m_Param);
                }

                txtSmoothResult.Text = "";
                txtSmoothResult.AppendText("Alpha: " + m_Param.Alpha + "\n");
                txtSmoothResult.AppendText("Beta: " + m_Param.Beta + "\n");
                txtSmoothResult.AppendText("Gamma: " + m_Param.Gamma + "\n");
                txtSmoothResult.AppendText("MSE: " + m_Smooth.GetMSE() + "\n");
            }
        }

        private void txtHybridTrainingFile_MouseClicked(object sender, MouseEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open File";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_HybridTrainingFile = openDialog.FileName;
            }
            else
                return;
            if (m_HybridTrainingFile == null || m_HybridTrainingFile.Equals(""))
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
                    fPointer = new System.IO.StreamReader(m_HybridTrainingFile);
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
                    this.txtHybridTrainingFile.Text = m_HybridTrainingFile;
                    this.labelHybridNumColumns.Text = Convert.ToString(numColumns);
                    this.labelHybridNumRows.Text = Convert.ToString(numRows);

                    this.txtHybridColumn.Text = "1";
                    this.txtHybridFromRow.Text = "1";
                    this.txtHybridToRow.Text = Convert.ToString(numRows);

                    if (numColumns == 1)
                    {
                        this.txtHybridColumn.Enabled = false;
                    }
                    else
                        this.txtHybridColumn.Enabled = true;
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

        private void btnHybridTrain_Click(object sender, EventArgs e)
        {
            List<double> sampleForTrain = new List<double>();

            //load train input
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtHybridFromRow.Text);
            int endRow = Convert.ToInt32(this.txtHybridToRow.Text);

            int columnSelected = Convert.ToInt32(this.txtHybridColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_HybridTrainingFile);
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

            if (sampleForTrain != null)
            {
                m_Hybrid = new Hybrid(m_NeuronNetwork, m_Smooth);
                double alpha = 0.0;
                if (radioHybridEstimateAlpha.Checked)
                {
                    alpha = Hybrid.FindBestAlpha(m_Hybrid, sampleForTrain);
                    if (alpha < 0.0)
                        alpha = 0.0;
                    else if (alpha > 1.0)
                        alpha = 1.0;
                    m_estimateAlpha = alpha;
                }
                else if (radioHybridSetAlpha.Checked)
                {
                    alpha = Convert.ToDouble(txtHybridAlpha.Text);
                }
                m_Hybrid.m_dAlpha = alpha;
                double mse = m_Hybrid.CalMSE(sampleForTrain);
                txtHybridResult.Text = "";
                txtHybridResult.AppendText("Weight : " + alpha + "\n");
                txtHybridResult.AppendText("MSE : "  + mse  + "\n"); 
            }
        }

        private void btnHybridTest_Click(object sender, EventArgs e)
        {
            List<double> sampleForTest = new List<double>();
            List<double> observeData = new List<double>();
            //load train input
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtHybridFromRow.Text);
            int endRow = Convert.ToInt32(this.txtHybridToRow.Text);

            int numTest = Convert.ToInt32(this.txtHybridTestToRow.Text) - Convert.ToInt32(this.txtHybridTestFromRow.Text) + 1;
            int testFrom = Convert.ToInt32(this.txtHybridTestFromRow.Text);
            int testTo = Convert.ToInt32(this.txtHybridTestToRow.Text);

            int cycle = Convert.ToInt32(this.txtSmoothCycle.Text);

            int columnSelected = Convert.ToInt32(this.txtHybridColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_HybridTrainingFile);
                while ((line = file.ReadLine()) != null)
                {
                    idxRow++;
                    char[] delimiterChars = { ' ', ',' };
                    string[] words = line.Split(delimiterChars);
                    if (columnSelected <= words.Length)
                    {
                        if (idxRow < beginRow || idxRow > endRow)
                        {
                            
                        }
                        else
                        {
                            sampleForTest.Add(Double.Parse(words[columnSelected - 1]));
                        }
                        if (idxRow <  testFrom|| idxRow > testTo)
                        {
                            continue;
                        }
                        else
                        {
                            observeData.Add(Double.Parse(words[columnSelected - 1]));
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
                    sampleForTest = null;
                }
            }
            catch (System.OutOfMemoryException outOfMemory)
            {
                sampleForTest = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException io)
            {
                sampleForTest = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception excp)
            {
                sampleForTest = null;
                MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            if (sampleForTest != null && observeData!=null)
            {
                Test_Form form = new Test_Form();
                if (radioHybridEstimateAlpha.Checked)
                    m_Hybrid.m_dAlpha = m_estimateAlpha;
                else if (radioHybridSetAlpha.Checked)
                    m_Hybrid.m_dAlpha = Convert.ToDouble(txtHybridAlpha.Text);
                List<double> focastList = m_Hybrid.DoFocast(sampleForTest, numTest);

                form.chart1.Series["Calculate result"].Color = System.Drawing.Color.Red;
                for (int i = 0; i < focastList.Count(); i++)
                {
                    form.chart1.Series["Calculate result"].Points.AddXY(i + 1, focastList[i]);
                }

                form.chart1.Series["Observations"].Color = System.Drawing.Color.Blue;
                for (int i = 0; i < observeData.Count(); i++)
                {
                    form.chart1.Series["Observations"].Points.AddXY(i + 1, observeData.ElementAt(i));
                }

                double SSE = 0.0;
                double MAE = 0.0;
                double MSE = 0.0;
                double MAPE = 0.0;

                for (int i = 0; i < observeData.Count(); i++)
                {
                    SSE += Math.Pow(observeData[i] - focastList[i], 2);
                    MAE += Math.Abs(observeData[i] - focastList[i]);
                    MAPE += Math.Abs((observeData[i] - focastList[i]) / observeData[i]);
                }
                MAE = MAE / focastList.Count();
                MSE = SSE / focastList.Count();
                MAPE = MAPE / focastList.Count() * 100;
                form.rTxtTestResult.Text = "";
                form.rTxtTestResult.AppendText("MAE: " + MAE + "\n");
                form.rTxtTestResult.AppendText("SSE: " + SSE + "\n");
                form.rTxtTestResult.AppendText("MSE: " + MSE + "\n");
                form.rTxtTestResult.AppendText("MAPE: " + MAPE + "%\n");
                form.ShowDialog();
            }
        }

        private void btnHybridFocast_Click(object sender, EventArgs e)
        {
            if (radioHybridEstimateAlpha.Checked)
                m_Hybrid.m_dAlpha = m_estimateAlpha;
            else if (radioHybridSetAlpha.Checked)
                m_Hybrid.m_dAlpha = Convert.ToDouble(txtHybridAlpha.Text);
            List<double> sampleForFocast = new List<double>();

            //load train input
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtHybridFromRow.Text);
            int endRow = Convert.ToInt32(this.txtHybridToRow.Text);

            int columnSelected = Convert.ToInt32(this.txtHybridColumn.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_HybridTrainingFile);
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
                            sampleForFocast.Add(Double.Parse(words[columnSelected - 1]));
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
                    sampleForFocast = null;
                }
            }
            catch (System.OutOfMemoryException outOfMemory)
            {
                sampleForFocast = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException io)
            {
                sampleForFocast = null;
                MessageBox.Show("File does not found", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception excp)
            {
                sampleForFocast = null;
                MessageBox.Show("Input is wrong format", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            if (sampleForFocast != null)
            {
                int ahead = Convert.ToInt32(txtHybridAHead.Text);
                List<double> focastList = m_Hybrid.DoFocast(sampleForFocast, ahead);

                Forecast_Form form = new Forecast_Form();

                form.chart1.Series["Observations"].Color = System.Drawing.Color.Blue;
                for (int i = 0; i < sampleForFocast.Count(); i++)
                {
                    form.chart1.Series["Observations"].Points.AddXY(i + 1, sampleForFocast.ElementAt(i));
                }

                form.chart1.Series["Forecasts"].Color = System.Drawing.Color.Red;
                form.chart1.Series["Forecasts"].Points.AddXY(sampleForFocast.Count(), sampleForFocast.ElementAt(sampleForFocast.Count() - 1));
                for (int i = 0; i < focastList.Count(); i++)
                {
                    form.chart1.Series["Forecasts"].Points.AddXY(i + sampleForFocast.Count() + 1, focastList.ElementAt(i));
                }

                form.rtxtForecastResult.AppendText("FORECAST:\n\n");
                for (int i = 0; i < ahead; i++) {
                    form.rtxtForecastResult.AppendText(i + 1 + "        " + focastList.ElementAt(i) + "\n");
                }
                form.ShowDialog();
            }
        }

        private void radioUseR_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSmoothRPath.Enabled = true;
            this.txtSmoothStep.Enabled = false;
        }

        private void radioSmoothBruteForce_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSmoothRPath.Enabled = false;
            this.txtSmoothStep.Enabled = true;
        }

        private void radioSmoothSteepestAscent_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSmoothRPath.Enabled = false;
            this.txtSmoothStep.Enabled = true;
        }

        private void radioSmoothSimulated_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSmoothRPath.Enabled = false;
            this.txtSmoothStep.Enabled = true;
        }

        private void txtNeuronNumInputs_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            List<double> sample = new List<double>();
            System.IO.StreamReader file = null;
            string line = null;
            int counter = 0;
            bool isFormatFileRight = true;
            int beginRow = Convert.ToInt32(this.txtNeuronFromRow.Text);
            int endRow = Convert.ToInt32(this.txtNeuronToRow.Text);

            int columnSelected = Convert.ToInt32(this.txtNeuronColumnSelected.Text);
            int idxRow = 0;
            try
            {
                file = new System.IO.StreamReader(m_NeuronTrainingFile);
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
            try
            {
                Plot_Form form = new Plot_Form();
                
                if (sample == null || sample.Count == 0)
                {
                    return;
                }
                form.chart1.Series["Data"].Color = System.Drawing.Color.Blue;
                for (int i = 0; i < sample.Count; i++)
                {
                    form.chart1.Series["Data"].Points.AddXY(i + 1, sample.ElementAt(i));
                }
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in plot the Time Series: " + exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxAdditive_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}
