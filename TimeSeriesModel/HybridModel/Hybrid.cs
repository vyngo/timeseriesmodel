using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HybridModel
{
    class Hybrid
    {
        public NeuronNetwork m_Network;
        public Smoothing m_Smooth;
        public double m_dAlpha;

        public Hybrid(NeuronNetwork _network, Smoothing _smooth)
        {
            m_Network = _network;
            m_Smooth = _smooth;
        }

        public double[] FindOuputList(List<double> sample)
        {
            List<double> neuronOutput = Algorithm.CalculateOutputList(m_Network, sample);
            List<double> smoothOutput = m_Smooth.CalOuputList(sample);

            double[] hybridOutput = new double[sample.Count()];
            for (int i = 0; i < sample.Count(); i++)
            {
                hybridOutput[i] = m_dAlpha * neuronOutput.ElementAt(i) + (1 - m_dAlpha) * smoothOutput.ElementAt(i) ;
            }

            return hybridOutput;
        }

        public double CalMSE(List<double> sample)
        {
            List<double> neuronOutput = Algorithm.CalculateOutputListForTrain(m_Network, sample);
            double[] smoothOutput = m_Smooth.CalOuputListForTrain(sample);

            double[] hybridOutput = new double[sample.Count()];
            double tempMSE = 0.0;
            for (int i = 0; i < sample.Count(); i++)
            {
                hybridOutput[i] = m_dAlpha * neuronOutput.ElementAt(i) + (1 - m_dAlpha) * smoothOutput[i];
                tempMSE += (hybridOutput[i] - sample.ElementAt(i)) * (hybridOutput[i] - sample.ElementAt(i));
            }
            return tempMSE / (sample.Count() - m_Network.GetFirstValueIndex());
        }

        static public double FindBestAlpha(Hybrid hybrid, List<double> sample)
        {
            //double minMSE = double.MaxValue;
            //double bestAlpha = 0.0;

            //for (double i = 0.0; i <= 1.0; i = i + 0.01)
            //{
            //    hybrid.m_dAlpha = i;
            //    double tMSE = hybrid.CalMSE(sample);
            //    if (tMSE < minMSE)
            //    {
            //        minMSE = tMSE;
            //        bestAlpha = i;
            //    }
            //}

            //return bestAlpha;
            List<double> neuronOutput = Algorithm.CalculateOutputListForTrain(hybrid.m_Network, sample);
            double[] smoothOutput = hybrid.m_Smooth.CalOuputListForTrain(sample);

            double aTemp = 0.0;
            double bTemp = 0.0;
            for (int i = 0; i < sample.Count(); i++)
            {
                aTemp += (neuronOutput.ElementAt(i) - smoothOutput[i]) * (sample.ElementAt(i) - smoothOutput[i]);
                bTemp += (neuronOutput.ElementAt(i) - smoothOutput[i]) * (neuronOutput.ElementAt(i) - smoothOutput[i]);
            }
            return (aTemp) / bTemp;
        }

        public List<double> DoFocast(List<double> sample, int aHead)
        {
            List<double> sampleClone = Utility.clone(sample);
            List<double> neuronFocast = Algorithm.CalculateNOutput(m_Network, sampleClone, aHead);

            double[] smoothFocast = m_Smooth.doForecast(sampleClone, aHead);

            List<double> hybridFocast = new List<double>();
            for (int i = 0; i < aHead; i++)
            {
                double temp = m_dAlpha * neuronFocast[i] + (1 - m_dAlpha) * smoothFocast[i];
                hybridFocast.Add(temp);
            }
            return hybridFocast;
        }
    }
}
