using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_4_BMI_Calculator_App
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void ImperialradioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Inch";
            WeighUnitLabel.Text = "Pound";
        }

        private void MetricradioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "cm";
            WeighUnitLabel.Text = "kg";
        }
    }
}
