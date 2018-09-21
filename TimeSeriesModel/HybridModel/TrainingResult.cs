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
    public partial class TrainingResult : Form
    {
        AlgorithmType m_Type;
        double m_ProcessEpoches;
        double m_MAE;
        double m_MSE;
        List<double> m_MAErrorList;
        double m_ValidateMAE;
        List<double> m_ValidateMAErrorList;
		
        public TrainingResult(AlgorithmType type)
        {
            InitializeComponent();
            m_Type = type;
            if (m_Type == AlgorithmType.BackPropagation)
                label_AlgorithmName.Text = "Back Propagation Training";
            else
                label_AlgorithmName.Text = "Resilient Propagation Training";
            m_MAE = 0.0;
            m_ProcessEpoches = 0;
            m_MAErrorList = new List<double>();
            m_ValidateMAE = 0.0;
            m_ValidateMAErrorList = new List<double>();
        }

        public void SetMAE(double mae)
        {
            m_MAE = mae;
            m_MAErrorList.Add(mae);
        }

        public void setMSE(double mse)
        {
            m_MSE = mse;
        }

        public void SetValidateMAE(double mae)
        {
            m_ValidateMAE = mae;
            m_ValidateMAErrorList.Add(mae);
        }

        public void SetProcessEpoches(double epoches)
        {
            m_ProcessEpoches = epoches;
        }

        public void ShowDialog()
        {
            if (m_MAErrorList == null || m_MAErrorList.Count() == 0)
                return;
            chart1.Series["MAE"].Color = System.Drawing.Color.Red;
            for (int i = 0; i < m_MAErrorList.Count; i++)
            {
                chart1.Series["MAE"].Points.AddXY(i + 1, m_MAErrorList.ElementAt(i));
            }

            labelProcessedEpoches.Text = Convert.ToString(m_ProcessEpoches);
            labelMAE.Text = Convert.ToString(m_MAE);
            labelMSE.Text = Convert.ToString(m_MSE);
            base.ShowDialog();
        }
    }
}
