using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSeriesModel
{
    public partial class Test_Form : Form
    {
        private int widthRate;
        private int heightRate;
        private int widthRate2;
        private int heightRate2;
        public Test_Form()
        {
            InitializeComponent();
            widthRate = this.Width - this.chart1.Width;
            heightRate = this.Height - this.chart1.Height;
            widthRate2 = this.Width - this.rTxtTestResult.Width;
            heightRate2 = this.Height - this.rTxtTestResult.Height;
        }

        private void Test_Form_SizeChanged(object sender, EventArgs e)
        {
            this.chart1.Width = this.Width - this.widthRate;
            this.chart1.Height = this.Height - this.heightRate;

            this.rTxtTestResult.Width = this.Width - this.widthRate2;
            this.rTxtTestResult.Height = this.Height - this.heightRate2;
        }
    }
}
