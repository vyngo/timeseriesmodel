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
    public partial class Forecast_Form : Form
    {
        private int widthRate1;
        private int heightRate1;
        private int widthRate2;
        private int heightRate2;
        public Forecast_Form()
        {
            InitializeComponent();
            widthRate1 = this.Width - this.chart1.Width;
            heightRate1 = this.Height - this.chart1.Height;

            widthRate2 = this.Width - this.rtxtForecastResult.Width;
            heightRate2 = this.Height - this.rtxtForecastResult.Height;
        }

        private void Forecast_Form_SizeChanged(object sender, EventArgs e)
        {
            this.chart1.Width = this.Width - this.widthRate1;
            this.chart1.Height = this.Height - this.heightRate1;

            this.rtxtForecastResult.Width = this.Width - this.widthRate2;
            this.rtxtForecastResult.Height = this.Height - this.heightRate2;

        }
    }
}
