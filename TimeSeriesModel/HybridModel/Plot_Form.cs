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
    public partial class Plot_Form : Form
    {
        private int widthRate;
        private int heightRate;
        public Plot_Form()
        {
            InitializeComponent();
            widthRate = this.Width - this.chart1.Width;
            heightRate = this.Height - this.chart1.Height;
        }

        private void Plot_Form_SizeChanged(object sender, EventArgs e)
        {
            this.chart1.Width = this.Width - this.widthRate;
            this.chart1.Height = this.Height - this.heightRate;

        }
    }
}
