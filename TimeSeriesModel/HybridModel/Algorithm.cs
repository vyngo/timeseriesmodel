using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HybridModel
{
    public enum AlgorithmType {BackPropagation, ResilientPropagation};
    class Algorithm
    {
        static private NeuronNetwork s_Network;

        static private double[,] Backup_m_arInputHiddenConn;
        static private double[,] Backup_m_arHiddenOutputConn;
        static private double[] Backup_m_arHiddenBias;
        static private double[] Backup_m_arOutputBias;

        static private double minValue = 0.0;
        static private double maxValue = 0.0;

        static private void InitForTrain()
        {
            Backup_m_arHiddenBias = new double[s_Network.m_iNumHiddenNodes];
            Backup_m_arOutputBias = new double[s_Network.m_iNumOutputNodes];
            Backup_m_arHiddenOutputConn = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
            Backup_m_arInputHiddenConn = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
        }
       
		/**
         * training the network by Backpropogation algorithm with Validate Test
         * sample is data used to train 
         * Author: DataMining-Research08
         */
        static public void BPropTraining(TrainingResult result, NeuronNetwork network, List<double> sample, double learningRate, double momentum, double maxEpoche = 10000, double residual = 1.0E-5)
        {
            s_Network = network;
            // s_LoopType = loopType;
            InitForTrain();
            Bp_run(result, sample, learningRate, momentum, maxEpoche, residual);
        }

		/*
         * Run the BackPropogatinon algorithm with validate series
         * Author: DataMining-Research08
         */
        static public void Bp_run(TrainingResult result, List<double> trainData, double learnRate, double momentum, double theEpoches = 10000, double residual = 1.0E-5)
        {
            try
            {
                int i, j;
                int epoch = 0;
                double MAE = Double.MaxValue;
                double MSE = Double.MaxValue;
                double LastError = Double.MaxValue;
                double[,] deltaInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
                double[,] deltaHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
                double[,] LagdeltaInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
                double[,] LagdeltaHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
                double[] deltaOutputBias = new double[s_Network.m_iNumOutputNodes];
                double[] deltaHiddenBias = new double[s_Network.m_iNumHiddenNodes];
                double[] LagdeltaOutputBias = new double[s_Network.m_iNumOutputNodes];
                double[] LagdeltaHiddenBias = new double[s_Network.m_iNumHiddenNodes];
                double counter = 0;
                for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)    // initialize weight-step of Input Hidden connection
                {
                    for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                    {
                        deltaInputHidden[j, i] = 0.0;
                        LagdeltaInputHidden[j, i] = 0.0;
                    }
                    deltaHiddenBias[i] = 0.0;
                    LagdeltaHiddenBias[i] = 0.0;
                }
                for (i = 0; i < s_Network.m_iNumOutputNodes; i++)   // initialize weight-step of Hidden Output connection
                {
                    for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                    {
                        deltaHiddenOutput[j, i] = 0.0;
                        LagdeltaHiddenOutput[j, i] = 0.0;
                    }
                    deltaOutputBias[i] = 0.0;
                    LagdeltaOutputBias[i] = 0.0;
                }
                getMinMax(trainData); // get min max of training data
                List<double> sample = doScale(trainData); // scale data to [-1;1]
                while (epoch < theEpoches)
                {
                    
                    MAE = 0.0;
                    MSE = 0.0;
                    /*training for each epoch*/
                    for (i = s_Network.GetFirstValueIndex(); i < sample.Count; i++)
                    {
                        //forward
                        double[] lstTemp = new double[s_Network.m_iNumInputNodes];
                        /* calculate output of input nodes*/
                        for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                        {
                            lstTemp[j] = sample[i - s_Network.m_arLags[j]];
                        }
                        /*calculate output*/
                        s_Network.CalculateOutput(lstTemp);

                        /*calculate abs error*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
                            double tmp = Math.Abs(trainData.ElementAt(i + j) - doRevertScale(s_Network.m_arOutputNodes[j].GetOutPut()));
                            MAE += tmp;
                            MSE += tmp * tmp;
                            
                        }
                        // backward
                        /*calculate weight-step for weights connecting from hidden nodes to output nodes*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
                            for (int k = 0; k < s_Network.m_iNumHiddenNodes; k++)
                            {
                                double parDerv = -s_Network.m_arOutputNodes[j].GetOutPut() * (1 - s_Network.m_arOutputNodes[j].GetOutPut()) * s_Network.m_arHiddenNodes[k].GetOutPut() * (sample.ElementAt(i) - s_Network.m_arOutputNodes[j].GetOutPut());
                                deltaHiddenOutput[k, j] = -learnRate * parDerv + momentum * LagdeltaHiddenOutput[k, j];
                                LagdeltaHiddenOutput[k, j] = deltaHiddenOutput[k, j];
                            }
                            double parDervBias = -s_Network.m_arOutputNodes[j].GetOutPut() * (1 - s_Network.m_arOutputNodes[j].GetOutPut()) * (sample.ElementAt(i) - s_Network.m_arOutputNodes[j].GetOutPut());
                            deltaOutputBias[j] = -learnRate * parDervBias + momentum * LagdeltaOutputBias[j];
                            LagdeltaOutputBias[j] = deltaOutputBias[j];
                        }
                        /*calculate weight-step for weights connecting from input nodes to hidden nodes*/
                        for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                        {
                            double temp = 0.0;
                            for (int r = 0; r < s_Network.m_iNumOutputNodes; r++)
                            {
                                temp += -(sample.ElementAt(i) - s_Network.m_arOutputNodes[r].GetOutPut()) * s_Network.m_arOutputNodes[r].GetOutPut() * (1 - s_Network.m_arOutputNodes[r].GetOutPut()) * s_Network.m_arHiddenOutputConn[j, r];
                            }
                            for (int k = 0; k < s_Network.m_iNumInputNodes; k++)
                            {
                                double parDerv = s_Network.m_arHiddenNodes[j].GetOutPut() * (1 - s_Network.m_arHiddenNodes[j].GetOutPut()) * s_Network.m_arInputNodes[k].GetInput() * temp;
                                deltaInputHidden[k, j] = -learnRate * parDerv + momentum * LagdeltaInputHidden[k, j];
                                LagdeltaInputHidden[k, j] = deltaInputHidden[k, j];
                            }
                            double parDervBias = s_Network.m_arHiddenNodes[j].GetOutPut() * (1 - s_Network.m_arHiddenNodes[j].GetOutPut()) * temp;
                            deltaHiddenBias[j] = -learnRate * parDervBias + momentum * LagdeltaHiddenBias[j];
                            LagdeltaHiddenBias[j] = deltaHiddenBias[j];
                        }
                        /*updating weight from Input to Hidden*/
                        for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                        {
                            for (int k = 0; k < s_Network.m_iNumInputNodes; k++)
                            {
                                s_Network.m_arInputHiddenConn[k, j] += deltaInputHidden[k, j];
                            }
                        }
                        /*updating bias of Hidden nodes*/
                        for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                        {
                            s_Network.m_arHiddenBias[j] += deltaHiddenBias[j];
                        }
                        /*updating weight from Hidden to Output*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
                            for (int k = 0; k < s_Network.m_iNumHiddenNodes; k++)
                            {
                                s_Network.m_arHiddenOutputConn[k, j] += deltaHiddenOutput[k, j];
                            }
                        }
                        /* updating bias of Output nodes*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
                            s_Network.m_arOutputBias[j] += deltaOutputBias[j];
                        }

                    } // end outer for
                    Form1.txtLogs.AppendText("Epoch " + epoch + ": \n");
                    MAE = MAE / (sample.Count - s_Network.GetFirstValueIndex()); // caculate mean absolute error
                    MSE = MSE / (sample.Count - s_Network.GetFirstValueIndex()); // caculate mean square error
                    Form1.txtLogs.AppendText("\tMAE: " + MAE + "\n\n");
                    Form1.txtLogs.AppendText("\tMSE: " + MSE + "\n\n");
                    if (Math.Abs(MAE - LastError ) < residual) // if the Error is not improved significantly, halt training process and rollback
                    {
                        break;
                    }
                    else
                    { //else backup the current configuration and continue training
                        LastError = MAE;
                        backup();
                        epoch++;
                        result.SetMAE(MAE);
                        result.setMSE(MSE);
                        result.SetProcessEpoches(epoch);
                    }
                    
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in Bp_run Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* output training result */
        }

        /*
         * rollback weights of neural to last value
         */
        static public void rollback()
        {
            int i, j;
            for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)
            {
                s_Network.m_arHiddenBias[i] = Backup_m_arHiddenBias[i];
            }
            for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
            {
                s_Network.m_arOutputBias[i] = Backup_m_arOutputBias[i];
            }
            for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)
            {
                for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                {
                    s_Network.m_arInputHiddenConn[j, i] = Backup_m_arInputHiddenConn[j, i];
                }
            }
            for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
            {
                for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                {
                    s_Network.m_arHiddenOutputConn[j, i] = Backup_m_arHiddenOutputConn[j, i];
                }
            }
        }

        /*
         * backup weights of neural 
         */
        static public void backup()
        {
            int i, j;
            for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)
            {
                Backup_m_arHiddenBias[i] = s_Network.m_arHiddenBias[i];
            }
            for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
            {
                Backup_m_arOutputBias[i] = s_Network.m_arOutputBias[i];
            }
            for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)
            {
                for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                {
                    Backup_m_arInputHiddenConn[j, i] = s_Network.m_arInputHiddenConn[j, i];
                }
            }
            for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
            {
                for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                {
                    Backup_m_arHiddenOutputConn[j, i] = s_Network.m_arHiddenOutputConn[j, i];
                }
            }
        }

       
		
		/**
        * training the network by Resilient Backpropogation algorithm with validate test
        * sample is data used to train 
        * Author: DataMining-Research08
        */
        static public void RPropTraining(TrainingResult result, NeuronNetwork network, List<double> sample, double min = 0.00001, double max = 50.0, double maxEpoche = 10000, double residual = 1.0E-5)
        {
            s_Network = network;
            //s_LoopType = loopType;
            InitForTrain();
            Rprop_Run(result, sample, min, max, maxEpoche, residual);
        }

		/**
        * training the network by RPROP algorithm
        * sample is data used to train 
        * Author: DataMining-Research08
        */
        static public void Rprop_Run(TrainingResult result, List<double> trainData,double min = 0.00001, double max = 50.0, double theEpoches = 10000, double residual = 1.0E-5)
        {
            try
            {
                int i, j;
                int epoch = 0;
                double MAE = Double.MaxValue;
                double MSE = Double.MaxValue;
                double defaultWeightChange = 0.0;
                //   double defaultDeltaValue = 0.1;
                double defaultDeltaValue = min; // min is the default delta value, naming is not good because of old versions : delta zero (an initial value of learning process)
                double defaultGradientValue = 0.0;
                double maxDelta = max; // max delta to restrict value of delta[i,j]
                // double minDelta = min;
                double minDelta = 1.0E-6; // min delta to restrict value of delta[i,j]
                double maxStep = 1.2; // default constant n+
                double minStep = 0.5; // default constant n-
                double LastError = Double.MaxValue;
                double counter = 0;

                double[,] weightChangeInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
                double[,] deltaInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
                double[,] gradientInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];
                double[,] newGradientInputHidden = new double[s_Network.m_iNumInputNodes, s_Network.m_iNumHiddenNodes];

                double[,] weightChangeHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
                double[,] deltaHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
                double[,] gradientHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];
                double[,] newGradientHiddenOutput = new double[s_Network.m_iNumHiddenNodes, s_Network.m_iNumOutputNodes];

                double[] weightChangeHiddenBias = new double[s_Network.m_iNumHiddenNodes];
                double[] deltaHiddenBias = new double[s_Network.m_iNumHiddenNodes];
                double[] gradientHiddenBias = new double[s_Network.m_iNumHiddenNodes];
                double[] newGradientHiddenBias = new double[s_Network.m_iNumHiddenNodes];

                double[] weightChangeOutputBias = new double[s_Network.m_iNumOutputNodes];
                double[] deltaOutputBias = new double[s_Network.m_iNumOutputNodes];
                double[] gradientOutputBias = new double[s_Network.m_iNumOutputNodes];
                double[] newGradientOutputBias = new double[s_Network.m_iNumOutputNodes];

                // initialize Input Hidden connection
                for (i = 0; i < s_Network.m_iNumHiddenNodes; i++)
                {
                    for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                    {
                        weightChangeInputHidden[j, i] = defaultWeightChange;
                        deltaInputHidden[j, i] = defaultDeltaValue;
                        gradientInputHidden[j, i] = defaultGradientValue;
                        newGradientInputHidden[j, i] = defaultGradientValue;
                    }
                    weightChangeHiddenBias[i] = defaultWeightChange;
                    deltaHiddenBias[i] = defaultDeltaValue;
                    gradientHiddenBias[i] = defaultGradientValue;
                    newGradientHiddenBias[i] = defaultGradientValue;
                }

                // initialize Hidden Output connection
                for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
                {
                    for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                    {
                        weightChangeHiddenOutput[j, i] = defaultWeightChange;
                        deltaHiddenOutput[j, i] = defaultDeltaValue;
                        gradientHiddenOutput[j, i] = defaultGradientValue;
                        newGradientHiddenOutput[j, i] = defaultGradientValue;
                    }
                    weightChangeOutputBias[i] = defaultWeightChange;
                    deltaOutputBias[i] = defaultDeltaValue;
                    gradientOutputBias[i] = defaultGradientValue;
                    newGradientOutputBias[i] = defaultGradientValue;
                }
                getMinMax(trainData); // get minValue and maxValue of training series
                List<double> sample = doScale(trainData);
                while (epoch < theEpoches)
                {
                    
                    MAE = 0.0;
					MSE = 0.0;
                    for (i = 0; i < s_Network.m_iNumHiddenNodes; i++) // reinnitialize value of gradien for new epoch
                    {
                        for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                        {
                            newGradientInputHidden[j, i] = 0.0;
                        }
                        newGradientHiddenBias[i] = 0.0;
                    }
                    for (i = 0; i < s_Network.m_iNumOutputNodes; i++)
                    {
                        for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                        {
                            newGradientHiddenOutput[j, i] = 0.0;
                        }
                        newGradientOutputBias[i] = 0.0;
                    }
                    //training for each epoch
                    for (i = s_Network.GetFirstValueIndex(); i < sample.Count; i++)
                    {
                        //forward
                        double[] lstTemp = new double[s_Network.m_iNumInputNodes];
                        /* calculate output of input nodes*/
                        for (j = 0; j < s_Network.m_iNumInputNodes; j++)
                        {
                            lstTemp[j] = sample[i - s_Network.m_arLags[j]];
                        }
                        /*calculate output*/
                        s_Network.CalculateOutput(lstTemp);
                        /*calculate abs error*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
							double temp = Math.Abs(trainData.ElementAt(i) - doRevertScale(s_Network.m_arOutputNodes[j].GetOutPut()));
                            MAE += temp;
                            MSE += temp*temp;
                        }
                        // backward
                        /*calculate weight-step for weights connecting from hidden nodes to output nodes*/
                        for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                        {
                            for (int k = 0; k < s_Network.m_iNumHiddenNodes; k++)
                            {
                                newGradientHiddenOutput[k, j] += -s_Network.m_arOutputNodes[j].GetOutPut() * (1 - s_Network.m_arOutputNodes[j].GetOutPut()) * s_Network.m_arHiddenNodes[k].GetOutPut() * (sample[i] - s_Network.m_arOutputNodes[j].GetOutPut());
                            }
                            newGradientOutputBias[j] += -s_Network.m_arOutputNodes[j].GetOutPut() * (1 - s_Network.m_arOutputNodes[j].GetOutPut()) * (sample.ElementAt(i) - s_Network.m_arOutputNodes[j].GetOutPut());
                        }
                        /*calculate weight-step for weights connecting from input nodes to hidden nodes*/
                        for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                        {
                            double temp = 0.0;
                            for (int r = 0; r < s_Network.m_iNumOutputNodes; r++)
                            {
                                temp += -(sample.ElementAt(i) - s_Network.m_arOutputNodes[r].GetOutPut()) * s_Network.m_arOutputNodes[r].GetOutPut() * (1 - s_Network.m_arOutputNodes[r].GetOutPut()) * s_Network.m_arHiddenOutputConn[j, r];
                            }
                            for (int k = 0; k < s_Network.m_iNumInputNodes; k++)
                            {
                                newGradientInputHidden[k, j] += s_Network.m_arHiddenNodes[j].GetOutPut() * (1 - s_Network.m_arHiddenNodes[j].GetOutPut()) * s_Network.m_arInputNodes[k].GetInput() * temp;
                            }
                            newGradientHiddenBias[j] += s_Network.m_arHiddenNodes[j].GetOutPut() * (1 - s_Network.m_arHiddenNodes[j].GetOutPut()) * temp;
                        }

                    } // end calculate for gradient

                    int sign;
                    for (j = 0; j < s_Network.m_iNumOutputNodes; j++)
                    {
                        for (int k = 0; k < s_Network.m_iNumHiddenNodes; k++)
                        {
                            sign = Math.Sign(newGradientHiddenOutput[k, j] * gradientHiddenOutput[k, j]);
                            if (sign > 0)
                            {
                                deltaHiddenOutput[k, j] = Math.Min(deltaHiddenOutput[k, j] * maxStep, maxDelta);
                                weightChangeHiddenOutput[k, j] = -Math.Sign(newGradientHiddenOutput[k, j]) * deltaHiddenOutput[k, j];
                                s_Network.m_arHiddenOutputConn[k, j] += weightChangeHiddenOutput[k, j];
                                gradientHiddenOutput[k, j] = newGradientHiddenOutput[k, j];
                            }
                            else if (sign < 0)
                            {
                                deltaHiddenOutput[k, j] = Math.Max(deltaHiddenOutput[k, j] * minStep, minDelta);
                                s_Network.m_arHiddenOutputConn[k, j] -= weightChangeHiddenOutput[k, j]; //restore old value
                                newGradientHiddenOutput[k, j] = 0.0;
                                gradientHiddenOutput[k, j] = newGradientHiddenOutput[k, j];
                            }
                            else
                            {
                                weightChangeHiddenOutput[k, j] = -Math.Sign(newGradientHiddenOutput[k, j]) * deltaHiddenOutput[k, j];
                                s_Network.m_arHiddenOutputConn[k, j] += weightChangeHiddenOutput[k, j];
                                gradientHiddenOutput[k, j] = newGradientHiddenOutput[k, j];
                            }
                            newGradientHiddenOutput[k, j] = 0.0;
                        }

                        sign = Math.Sign(newGradientOutputBias[j] * gradientOutputBias[j]);
                        if (sign > 0)
                        {
                            deltaOutputBias[j] = Math.Min(deltaOutputBias[j] * maxStep, maxDelta);
                            weightChangeOutputBias[j] = -Math.Sign(newGradientOutputBias[j]) * deltaOutputBias[j];
                            s_Network.m_arOutputBias[j] += weightChangeOutputBias[j];
                            gradientOutputBias[j] = newGradientOutputBias[j];
                        }
                        else if (sign < 0)
                        {
                            deltaOutputBias[j] = Math.Max(deltaOutputBias[j] * minStep, minDelta);
                            s_Network.m_arOutputBias[j] -= weightChangeOutputBias[j];
                            newGradientOutputBias[j] = 0.0;
                            gradientOutputBias[j] = newGradientOutputBias[j];
                        }
                        else
                        {
                            weightChangeOutputBias[j] = -Math.Sign(newGradientOutputBias[j]) * deltaOutputBias[j];
                            s_Network.m_arOutputBias[j] += weightChangeOutputBias[j];
                            gradientOutputBias[j] = newGradientOutputBias[j];
                        }
                        newGradientOutputBias[j] = 0.0;
                    }
                    /*calculate weight-step for weights connecting from input nodes to hidden nodes*/
                    for (j = 0; j < s_Network.m_iNumHiddenNodes; j++)
                    {
                        for (int k = 0; k < s_Network.m_iNumInputNodes; k++)
                        {
                            sign = Math.Sign(newGradientInputHidden[k, j] * gradientInputHidden[k, j]);
                            if (sign > 0)
                            {
                                deltaInputHidden[k, j] = Math.Min(deltaInputHidden[k, j] * maxStep, maxDelta);
                                weightChangeInputHidden[k, j] = -Math.Sign(newGradientInputHidden[k, j]) * deltaInputHidden[k, j];
                                s_Network.m_arInputHiddenConn[k, j] += weightChangeInputHidden[k, j];
                                gradientInputHidden[k, j] = newGradientInputHidden[k, j];
                            }
                            else if (sign < 0)
                            {
                                deltaInputHidden[k, j] = Math.Max(deltaInputHidden[k, j] * minStep, minDelta);
                                s_Network.m_arInputHiddenConn[k, j] -= weightChangeInputHidden[k, j];
                                newGradientInputHidden[k, j] = 0.0;
                                gradientInputHidden[k, j] = 0.0;
                            }
                            else
                            {
                                weightChangeInputHidden[k, j] = -Math.Sign(newGradientInputHidden[k, j]) * deltaInputHidden[k, j];
                                s_Network.m_arInputHiddenConn[k, j] += weightChangeInputHidden[k, j];
                                gradientInputHidden[k, j] = newGradientInputHidden[k, j];
                            }
                            newGradientInputHidden[k, j] = 0.0;
                        }

                        sign = Math.Sign(newGradientHiddenBias[j] * gradientHiddenBias[j]);
                        if (sign > 0)
                        {
                            deltaHiddenBias[j] = Math.Min(deltaHiddenBias[j] * maxStep, maxDelta);
                            weightChangeHiddenBias[j] = -Math.Sign(newGradientHiddenBias[j]) * deltaHiddenBias[j];
                            s_Network.m_arHiddenBias[j] += weightChangeHiddenBias[j];
                            gradientHiddenBias[j] = newGradientHiddenBias[j];
                        }
                        else if (sign < 0)
                        {
                            deltaHiddenBias[j] = Math.Max(deltaHiddenBias[j] * minStep, minDelta);
                            s_Network.m_arHiddenBias[j] -= weightChangeHiddenBias[j];
                            newGradientHiddenBias[j] = 0.0;
                            gradientHiddenBias[j] = 0;
                        }
                        else
                        {
                            weightChangeHiddenBias[j] = -Math.Sign(newGradientHiddenBias[j]) * deltaHiddenBias[j];
                            s_Network.m_arHiddenBias[j] += weightChangeHiddenBias[j];
                            gradientHiddenBias[j] = newGradientHiddenBias[j];
                        }
                        newGradientHiddenBias[j] = 0.0;
                    }
                    Form1.txtLogs.AppendText("Epoch " + epoch + ": \n");
                    MAE = MAE / (sample.Count - s_Network.GetFirstValueIndex()); // caculate mean square error
                    MSE = MSE / (sample.Count - s_Network.GetFirstValueIndex()); // caculate mean square error
                    Form1.txtLogs.AppendText("\tMAE: " + MAE + "\n\n");
                    Form1.txtLogs.AppendText("\tMSE: " + MSE + "\n\n");
                    if (Math.Abs(MAE - LastError) < residual) // if the Error is not improved significantly, halt training process and rollback
                    {
                        break;
                    }
                    else
                    { //else backup the current configuration and continue training
                        LastError = MAE;
                        backup();
                        epoch++;
                        result.SetMAE(MAE);
                        result.setMSE(MSE);
                        result.SetProcessEpoches(epoch);
                    }
                }
            }
            catch (Exception e)
            {
                
                 MessageBox.Show("Error in  Rprop_run Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static private void getMinMax(List<double> series){
            try
            {
                double[] minMax = getConfig(); // minMax[0] is maximum, minMax[1] is minimum
                minValue = series.Min();
                maxValue = series.Max();
                if (minValue > minMax[1])
                {
                    minValue = minMax[1];
                }
                if (maxValue < minMax[0])
                {
                    maxValue = minMax[0];
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in getMinMax Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // scale a value to [0.0001,0.9999]
        static private List<double> doScale(List<double> lst) {
            try
            {
                //return (value - minValue) / (maxValue - minValue) * (1.0 + 1.0) - 1.0;
                List<double> ret = new List<double>();
                int count = lst.Count();
                for (int i = 0; i < count; i++)
                {
                    double value = lst.ElementAt(i);
                    double scaleValue = (value - minValue) / (maxValue - minValue) * (0.9999 - (0.0001)) + (0.0001);
                    ret.Add(scaleValue);
                }
                return ret;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error in doScale Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        static private double doScale(double value)
        {
            try
            {
                return (value - minValue) / (maxValue - minValue) * (0.9999 - (0.0001)) + (0.0001);
            }
            catch (Exception)
            {

                MessageBox.Show("Error in doScale for one value Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Double.NaN;
            }
        }

        static private List<double> doRevertScale(List<double> lst) {
            try
            {
                List<double> ret = new List<double>();
                int count = lst.Count();
                for (int i = 0; i < count; i++)
                {
                    double value = lst.ElementAt(i);
                    double revertScaleValue = (value - (0.0001)) / (0.9999 - (0.0001)) * (maxValue - minValue) + minValue;
                    ret.Add(revertScaleValue);
                }
                return ret;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in doRevertScale Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        static private double doRevertScale(double value)
        {
            try
            {
                return (value - (0.0001)) / (0.9999 - (0.0001)) * (maxValue - minValue) + minValue;
            }
            catch (Exception)
            {

                MessageBox.Show("Error in doRevertScale for one value Algorithm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Double.NaN;
            }
        }
        static private double[] getConfig() 
        {
            double[] ret = new double[2];
            ret[0] = 100;
            ret[1] = 100;
            try
            {
                ret[1] = Convert.ToDouble(Form1.txtMinValue.Text);
                ret[0] = Convert.ToDouble(Form1.txtMaxValue.Text);
                return ret;
            }
            catch (Exception)
            {
                Form1.txtLogs.AppendText("Still don't config max,min value at Neuron tab. Please fill it!!!!");
                return ret;
            }
        }

        static public List<double> CalculateOutputList(NeuronNetwork network, List<double> input)
        {
            getMinMax(input);
            List<double> temp = doScale(input);
            return doRevertScale(network.CalculateOutputList(temp));
        }

        static public List<double> CalculateOutputListForTrain(NeuronNetwork network, List<double> input)
        {
            getMinMax(input);
            List<double> temp = doScale(input);
            return doRevertScale(network.CalculateOutputListForTrain(temp));
        }

        static public List<double> CalculateNOutput(NeuronNetwork network, List<double> input, int n)
        {
            getMinMax(input);
            List<double> temp = doScale(input);
            return doRevertScale(network.CalculateNOutput(temp,n));
        }
	}
}
