using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesModel
{
    public enum ActionvationFunction
    {
        SIGMOID_FUNCTION = 0x01,
    }

    public enum PerceptionType
    {
        PERCEPTION_INPUT,
        PERCEPTION_HIDDEN,
        PERCEPTION_OUTPUT,
    }

    class Perceptron
    {
        private double m_dInput;
        private double m_dOutput = 0.0;
        public ActionvationFunction m_activeFuncType;

        public Perceptron(ActionvationFunction activeType)
        {
            m_activeFuncType = activeType;
        }

        public void SetInput(double input)
        {
            m_dInput = input;
        }

        public double GetInput()
        {
            return m_dInput;
        }

        public double GetOutPut()
        {
            return CalOutput();
        }

        /**
         * Function: Calculate output of the Perceptron
         * Parameter: net input
         * Author: DataMining-Research08
         */
        private double CalOutput()
        {
            if (m_activeFuncType == ActionvationFunction.SIGMOID_FUNCTION)
            {
                m_dOutput = (1) / (1 + Math.Exp(-m_dInput));
            }
            return m_dOutput;
        }
    }
}
