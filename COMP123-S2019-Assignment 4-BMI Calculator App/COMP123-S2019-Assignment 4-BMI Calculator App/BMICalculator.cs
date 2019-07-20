using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace COMP123_S2019_Assignment_4_BMI_Calculator_App
{
    public partial class BMICalculator : Form
    {
        public double height { get; set; }
        public double weight { get; set; }
        public double bmi { get; set; }
        public string result { get; set; }

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
            HeightUnitLabel.Text = "metre";
            WeighUnitLabel.Text = "kg";
        }
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ImperialradioButton.Checked = true;
        }






        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (!(HeighttextBox.Text == "") && !(WeighttextBox.Text == ""))
            {
                height = Convert.ToDouble(HeighttextBox.Text);
                weight = Convert.ToDouble(WeighttextBox.Text);
                if (ImperialradioButton.Checked)
                {
                    bmi = (weight * 703) / (height * height);
                }
                else
                {
                    bmi = weight / (height * height);
                }
                BMItextBox.Text = bmi.ToString("f2");
                if (bmi <= 18.5)
                {
                    ResulttextBox.Text = "BMI SCALE : Underweight\r\nResult :\r\nless than 18.5";
                    ResulttextBox.ForeColor = Color.Fuchsia;
                    BMItextBox.ForeColor = Color.Fuchsia;
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    ResulttextBox.Text = "BMI SCALE : Normal\r\nResult :\r\nbetween18.5 and 24.9";
                    ResulttextBox.ForeColor = Color.DodgerBlue;
                    BMItextBox.ForeColor = Color.DodgerBlue;
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    ResulttextBox.Text = "BMI SCALE : Overweight\r\nResult :\r\nbetween25 and 29.9";
                    ResulttextBox.ForeColor = Color.DarkOrange;
                    BMItextBox.ForeColor = Color.DarkOrange;
                }
                else
                {
                    ResulttextBox.Text = "BMI SCALE : Obese\r\nResult :\r\n30 or greater";
                    ResulttextBox.ForeColor = Color.Crimson;
                    BMItextBox.ForeColor = Color.Crimson;
                }
            }
            else
            {
                ResulttextBox.Text = "Please enter your information";
                ResulttextBox.ForeColor = Color.Red;
            }

            
        }

        private void HeighttextBox_TextChanged(object sender, EventArgs e)
        {
            //heightDecimalExistence = false;
            //string input = HeighttextBox.Text;
            //Regex rg = new Regex(".");
            //MatchCollection matchCollection = rg.Matches(input);
            ////ResulttextBox.Text = matchCollection.Count.ToString();
            //if (matchCollection.Count > 1)
            //    heightDecimalExistence = true;
        }

        private void inputtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TheInputtextBox = sender as TextBox;
            //ResulttextBox.Text = ((TextBox)sender).Text.IndexOf(".").ToString();

            if (Char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8 || (int)e.KeyChar == 46)
            {
                if ((int)e.KeyChar == 46 && ((TextBox)TheInputtextBox).Text.IndexOf(".") >= 0)
                {
                    //if (weightDecimalExistence)
                    //{
                    e.Handled = true;
                    //}
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialradioButton.Checked = true;
            MetricradioButton.Checked = false;
            HeighttextBox.Text = "";
            WeighttextBox.Text = "";
            ResulttextBox.Text = "";
            BMItextBox.Text = "";
        }
    }
}
