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
        /// <summary>
        /// This is the contructor for the BMICalculatorForm.
        /// </summary>
        public double height;
        public double weight;
        public double bmi;
        public string result;

        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is a shared event handler for the Imperial radioButton CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialradioButton_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            HeightUnitLabel.Text = "Inch";
            WeighUnitLabel.Text = "Pound";
        }

        /// <summary>
        /// This is a shared event handler for the Metric radioButton CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricradioButton_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            HeightUnitLabel.Text = "metre";
            WeighUnitLabel.Text = "kg";
        }

        /// <summary>
        /// This is a shared event handler for the BMICalculator Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ImperialradioButton.Checked = true;
        }





        /// <summary>
        /// This is a shared event handler for the CalculateBMI Button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    ResulttextBox.Text = "BMI SCALE : Underweight\r\nless than 18.5";
                    ResulttextBox.ForeColor = Color.Fuchsia;
                    BMItextBox.ForeColor = Color.Fuchsia;
                    BMIprogressBar.Value = 25;
                    
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    ResulttextBox.Text = "BMI SCALE : Normal\r\nbetween 18.5 and 24.9";
                    ResulttextBox.ForeColor = Color.DodgerBlue;
                    BMItextBox.ForeColor = Color.DodgerBlue;
                    BMIprogressBar.Value = 50;
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    ResulttextBox.Text = "BMI SCALE : Overweight\r\nbetween 25 and 29.9";
                    ResulttextBox.ForeColor = Color.DarkOrange;
                    BMItextBox.ForeColor = Color.DarkOrange;
                    BMIprogressBar.Value = 75;
                }
                else
                {
                    ResulttextBox.Text = "BMI SCALE : Obese\r\n30 or greater";
                    ResulttextBox.ForeColor = Color.Crimson;
                    BMItextBox.ForeColor = Color.Crimson;
                    BMIprogressBar.Value = 100;
                }
            }
            else
            {
                ResulttextBox.Text = "Please enter your information";
                ResulttextBox.ForeColor = Color.Red;
            }

            
        }


        /// <summary>
        /// This is a shared event handler for the inputtextBox KeyPress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        ///  This is a shared event handler for the ResetButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialradioButton.Checked = true;
            MetricradioButton.Checked = false;
            Clear();
            //HeighttextBox.Text = string.Empty;
            //WeighttextBox.Text = string.Empty;
            //ResulttextBox.Text = string.Empty;
            //BMItextBox.Text = string.Empty;
            //BMIprogressBar.Value = 0;
        }
        private void Clear()
        {
            HeighttextBox.Text = string.Empty;
            WeighttextBox.Text = string.Empty;
            ResulttextBox.Text = string.Empty;
            BMItextBox.Text = string.Empty;
            BMIprogressBar.Value = 0;
        }
    }
}
