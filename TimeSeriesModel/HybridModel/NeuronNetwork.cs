using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace HybridModel
{
    class NeuronNetwork
    {
        public int m_iNumInputNodes;
        public int m_iNumHiddenNodes;
        public int m_iNumOutputNodes;
        public int[] m_arLags;

        public Perceptron[] m_arInputNodes;
        public Perceptron[] m_arHiddenNodes;
        public Perceptron[] m_arOutputNodes;

        public double[,] m_arInputHiddenConn;
        public double[,] m_arHiddenOutputConn;

        public double[] m_arHiddenBias;
        public double[] m_arOutputBias;

        public NeuronNetwork()
        { 
        }

        public NeuronNetwork(int inputNodes, int hiddenNodes, int outputNodes, string lags)
        {
            m_iNumInputNodes = inputNodes;
            m_iNumHiddenNodes = hiddenNodes;
            m_iNumOutputNodes = outputNodes;
            m_arLags = this.GetLagsFromString(lags);
            if (m_arLags.Count() != m_iNumInputNodes)
                throw new FormatException();

            m_arInputNodes = new Perceptron[m_iNumInputNodes];
            for (int i = 0; i < m_iNumInputNodes; i++)
            {
                m_arInputNodes[i] = new Perceptron(ActionvationFunction.SIGMOID_FUNCTION);
            }
            m_arHiddenNodes = new Perceptron[m_iNumHiddenNodes];
            for (int i = 0; i < m_iNumHiddenNodes; i++)
            {
                m_arHiddenNodes[i] = new Perceptron(ActionvationFunction.SIGMOID_FUNCTION);
            }
            m_arOutputNodes = new Perceptron[m_iNumOutputNodes];
            for (int i = 0; i < m_iNumOutputNodes; i++)
            {
                m_arOutputNodes[i] = new Perceptron(ActionvationFunction.SIGMOID_FUNCTION);
            }

            m_arInputHiddenConn = new double[m_iNumInputNodes, m_iNumHiddenNodes];
            m_arHiddenOutputConn = new double[m_iNumHiddenNodes, m_iNumOutputNodes];
            m_arHiddenBias = new double[m_iNumHiddenNodes];
            m_arOutputBias = new double[m_iNumOutputNodes];
            Random rand = new Random();
            for (int i = 0; i < m_iNumInputNodes; i++)
            {
                for (int j = 0; j < m_iNumHiddenNodes; j++)
                {
                    m_arInputHiddenConn[i, j] = rand.NextDouble();
                }
            }
            for (int i = 0; i < m_iNumHiddenNodes; i++)
            {
                for (int j = 0; j < m_iNumOutputNodes; j++)
                {
                    m_arHiddenOutputConn[i, j] = rand.NextDouble();
                }
            }
            for (int i = 0; i < m_iNumHiddenNodes; i++)
            {
                m_arHiddenBias[i] = rand.NextDouble();
            }
            for (int i = 0; i < m_iNumOutputNodes; i++)
            {
                m_arOutputBias[i] = rand.NextDouble();
            }
        }

        public int GetFirstValueIndex()
        {
            return Utility.FindMaxFromList(m_arLags);
        }

        public void CalculateOutput(double[] input)
        {
            try
            {
                if (input.Length != m_iNumInputNodes)
                    throw new FormatException();
                for (int i = 0; i < m_iNumInputNodes; i++)
                    m_arInputNodes[i].SetInput(input[i]);
                for (int j = 0; j < m_iNumHiddenNodes; j++)
                {
                    double temp = 0.0;
                    for (int i = 0; i < m_iNumInputNodes; i++)
                    {
                        temp += m_arInputHiddenConn[i, j] * m_arInputNodes[i].GetInput();
                    }
                    m_arHiddenNodes[j].SetInput(temp);
                }
                for (int j = 0; j < m_iNumOutputNodes; j++)
                {
                    double temp = 0;
                    for (int i = 0; i < m_iNumHiddenNodes; i++)
                    {
                        temp += m_arHiddenOutputConn[i, j] * m_arHiddenNodes[i].GetOutPut();
                    }
                    m_arOutputNodes[j].SetInput(temp);
                }
            }
            catch (Exception)
            {
                
                 MessageBox.Show("Error in CalculateOutput NeuronNetWorks", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<double> CalculateOutputList(List<double> input)
        {
            try
            {
                List<double> result = new List<double>();
                for (int i = 0; i < GetFirstValueIndex(); i++)
                {
                    result.Add(input.ElementAt(i));
                }
                for (int i = GetFirstValueIndex(); i < input.Count; i++)
                {
                    double[] lstTemp = new double[m_iNumInputNodes];
                    for (int j = 0; j < m_iNumInputNodes; j++)
                    {
                        //lstTemp[j] = input[i - m_arLags[j]];
                        lstTemp[j] = result[i - m_arLags[j]];
                    }
                    CalculateOutput(lstTemp);
                    result.Add(m_arOutputNodes[0].GetOutPut());
                }
                return result;
            }
            catch (Exception)
            {

                MessageBox.Show("Error in CalculateOutputList NeuronNetWorks", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<double> CalculateOutputListForTrain(List<double> input)
        {
            try
            {
                List<double> result = new List<double>();
                for (int i = 0; i < GetFirstValueIndex(); i++)
                {
                    result.Add(input.ElementAt(i));
                }
                for (int i = GetFirstValueIndex(); i < input.Count; i++)
                {
                    double[] lstTemp = new double[m_iNumInputNodes];
                    for (int j = 0; j < m_iNumInputNodes; j++)
                    {
                        lstTemp[j] = input[i - m_arLags[j]];
                        //lstTemp[j] = result[i - m_arLags[j]];
                    }
                    CalculateOutput(lstTemp);
                    result.Add(m_arOutputNodes[0].GetOutPut());
                }
                return result;
            }
            catch (Exception)
            {

                MessageBox.Show("Error in CalculateOutputList NeuronNetWorks", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<double> CalculateNOutput(List<double> input, int n)
        {
            try
            {
                List<double> result = new List<double>();
                for (int i = 0; i < n; i++)
                {
                    double[] lstTemp = new double[m_iNumInputNodes];
                    int inputCount = input.Count();
                    for (int j = 0; j < m_iNumInputNodes; j++)
                    {
                        lstTemp[j] = input.ElementAt(inputCount - 1 - j);
                    }
                    CalculateOutput(lstTemp);
                    input.Add(m_arOutputNodes[0].GetOutPut());
                    result.Add(m_arOutputNodes[0].GetOutPut());
                }
                return result;
            }
            catch (Exception)
            {

                MessageBox.Show("Error in CalculateNOutput NeuronNetWorks", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int[] GetLagsFromString(string inputLags)
        { 
            char[] delimiterChars = {','};
            string[] words = inputLags.Split(delimiterChars);
            int[] result = new int[words.Count()];
            for (int i = 0; i < words.Count(); i++)
            {
                result[i] = Int32.Parse(words[i]);
            }
            result = Utility.SortDescendList(result);
            return result;
        }

        public int[] GetLags()
        {
            return m_arLags;
        }

        public string GetStringLags()
        {
            string temp = "";
            for (int i = 1; i < m_arLags.Count(); i++)
            {
                temp += "," + m_arLags[i];
            }
            temp = m_arLags[0] + temp;
            return temp;
        }

        static public NeuronNetwork Import(string pathFile)
        {
            XmlDocument input = new XmlDocument();
            NeuronNetwork loadedNetwork = null;
            try
            {
                input.Load(pathFile);
                XmlNode root = input.FirstChild;
                //Get number of input, hidden, output nodes
                int numInputNodes = Int32.Parse(root.SelectSingleNode("descendant::numInputNodes").InnerText);
                int numHiddenNodes = Int32.Parse(root.SelectSingleNode("descendant::numHiddenNodes").InnerText);
                int numOutputNodes = Int32.Parse(root.SelectSingleNode("descendant::numOutputNodes").InnerText);
                string lags =root.SelectSingleNode("descendant::Lag").InnerText;
                //create a network
                loadedNetwork = new NeuronNetwork(numInputNodes, numHiddenNodes, numOutputNodes, lags);
                //Get Input Nodes
                for (int i = 0; i < loadedNetwork.m_iNumInputNodes; i++)
                {
                    //get a input node
                    XmlNode tempNode = root.SelectSingleNode("descendant::Input" + Convert.ToString(i + 1));
                    //get activation function type
                    string activationFunc = tempNode.SelectSingleNode("descendant::activateFunc").InnerText;
                    if (activationFunc.Equals("SIGMOID_FUNCTION"))
                    {
                        loadedNetwork.m_arInputNodes[i].m_activeFuncType = ActionvationFunction.SIGMOID_FUNCTION;
                    }
                    //get weight
                    for (int j = 0; j < loadedNetwork.m_iNumHiddenNodes; j++)
                    {
                        loadedNetwork.m_arInputHiddenConn[i,j] = Convert.ToDouble(tempNode.SelectSingleNode("descendant::InHid" + Convert.ToString(i + 1) + Convert.ToString(j + 1)).InnerText);
                    }
                }
                //Get Hidden Nodes
                for (int i = 0; i < loadedNetwork.m_iNumHiddenNodes; i++)
                {
                    //get a hidden node
                    XmlNode tempNode = root.SelectSingleNode("descendant::Hidden" + Convert.ToString(i + 1));
                    //get activation function type
                    string activationFunc = tempNode.SelectSingleNode("descendant::activateFunc").InnerText;
                    if (activationFunc.Equals("SIGMOID_FUNCTION"))
                    {
                        loadedNetwork.m_arHiddenNodes[i].m_activeFuncType = ActionvationFunction.SIGMOID_FUNCTION;
                    }
                    //get bias
                    loadedNetwork.m_arHiddenBias[i] = Convert.ToDouble(tempNode.SelectSingleNode("descendant::bias").InnerText);
                    //get weight
                    for (int j = 0; j < loadedNetwork.m_iNumOutputNodes; j++)
                    {
                        loadedNetwork.m_arHiddenOutputConn[i, j] = Convert.ToDouble(tempNode.SelectSingleNode("descendant::HidOut" + Convert.ToString(i + 1) + Convert.ToString(j + 1)).InnerText);
                    }
                }
                //Get Output Nodes
                for (int i = 0; i < loadedNetwork.m_iNumOutputNodes; i++)
                {
                    //get a output node
                    XmlNode tempNode = root.SelectSingleNode("descendant::Output" + Convert.ToString(i + 1));
                    //get activation function type
                    string activationFunc = tempNode.SelectSingleNode("descendant::activateFunc").InnerText;
                    if (activationFunc.Equals("SIGMOID_FUNCTION"))
                    {
                        loadedNetwork.m_arOutputNodes[i].m_activeFuncType = ActionvationFunction.SIGMOID_FUNCTION;
                    }
                    //get bias
                    loadedNetwork.m_arOutputBias[i] = Convert.ToDouble(tempNode.SelectSingleNode("descendant::bias").InnerText);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return loadedNetwork;
        }

        static public bool Export(NeuronNetwork network, string pathFile)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Network");
            doc.AppendChild(root);
            //save number of Input, Hidden, Output Nodes
            XmlElement numInput = doc.CreateElement("numInputNodes");
            numInput.InnerText = Convert.ToString(network.m_iNumInputNodes);
            XmlElement numHidden = doc.CreateElement("numHiddenNodes");
            numHidden.InnerText = Convert.ToString(network.m_iNumHiddenNodes);
            XmlElement numOutput = doc.CreateElement("numOutputNodes");
            numOutput.InnerText = Convert.ToString(network.m_iNumOutputNodes);
            XmlElement numLag = doc.CreateElement("Lag");
            numLag.InnerText = network.GetStringLags();
            root.AppendChild(numInput);
            root.AppendChild(numHidden);
            root.AppendChild(numOutput);
            root.AppendChild(numLag);
            //save input nodes
            XmlElement InputNodes = doc.CreateElement("InputNodes");
            for (int i = 0; i < network.m_iNumInputNodes; i++)
            {
                XmlElement aInputNode = doc.CreateElement("Input" + Convert.ToString(i + 1));
                //save activation func
                if (network.m_arInputNodes[i].m_activeFuncType == ActionvationFunction.SIGMOID_FUNCTION)
                {
                    XmlElement actFunc = doc.CreateElement("activateFunc");
                    actFunc.InnerText = "SIGMOID_FUNCTION";
                    aInputNode.AppendChild(actFunc);
                }

                //save weight for in-hid connection
                for (int j = 0; j < network.m_iNumHiddenNodes; j++)
                {
                    XmlElement aWeight = doc.CreateElement("InHid" + Convert.ToString(i + 1) + Convert.ToString(j + 1));
                    aWeight.InnerText = Convert.ToString(network.m_arInputHiddenConn[i, j]);
                    aInputNode.AppendChild(aWeight);
                }
                InputNodes.AppendChild(aInputNode);
            }
            root.AppendChild(InputNodes);

            //save hidden nodes
            XmlElement HiddenNodes = doc.CreateElement("HiddenNodes");
            for (int i = 0; i < network.m_iNumHiddenNodes; i++)
            {
                XmlElement aHiddenNode = doc.CreateElement("Hidden" + Convert.ToString(i + 1));
                //save activation func
                if (network.m_arHiddenNodes[i].m_activeFuncType == ActionvationFunction.SIGMOID_FUNCTION)
                {
                    XmlElement actFunc = doc.CreateElement("activateFunc");
                    actFunc.InnerText = "SIGMOID_FUNCTION";
                    aHiddenNode.AppendChild(actFunc);
                }

                //save bias
                XmlElement bias = doc.CreateElement("bias");
                bias.InnerText = Convert.ToString(network.m_arHiddenBias[i]);
                aHiddenNode.AppendChild(bias);

                //save weight for hid-out connection
                for (int j = 0; j < network.m_iNumOutputNodes; j++)
                {
                    XmlElement aWeight = doc.CreateElement("HidOut" + Convert.ToString(i + 1) + Convert.ToString(j + 1));
                    aWeight.InnerText = Convert.ToString(network.m_arHiddenOutputConn[i, j]);
                    aHiddenNode.AppendChild(aWeight);
                }
                HiddenNodes.AppendChild(aHiddenNode);
            }
            root.AppendChild(HiddenNodes);

            //save output nodes
            XmlElement OutputNodes = doc.CreateElement("OutputNodes");
            for (int i = 0; i < network.m_iNumOutputNodes; i++)
            {
                XmlElement aOutputNode = doc.CreateElement("Output" + Convert.ToString(i + 1));
                //save activation func
                if (network.m_arOutputNodes[i].m_activeFuncType == ActionvationFunction.SIGMOID_FUNCTION)
                {
                    XmlElement actFunc = doc.CreateElement("activateFunc");
                    actFunc.InnerText = "SIGMOID_FUNCTION";
                    aOutputNode.AppendChild(actFunc);
                }

                //save bias
                XmlElement bias = doc.CreateElement("bias");
                bias.InnerText = Convert.ToString(network.m_arOutputBias[i]);
                aOutputNode.AppendChild(bias);

                OutputNodes.AppendChild(aOutputNode);
            }
            root.AppendChild(OutputNodes);
            doc.Save(pathFile);
            return true;
        }
    }
}
