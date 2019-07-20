using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name : Chuyun Yang
 * Student : 301038102
 * Date : 2019/07/17
 * Description : BMI calculator app that allows users to enter their weight and height and 
 *               whether they are entering these values in Imperial or Metric units, then calculates 
 *               and displays the user's body mass index (BMI)
 * Vision : Ver_01-GUI
 */

namespace COMP123_S2019_Assignment_4_BMI_Calculator_App
{
    static class Program
    {
        //declare Splash startForm
        public static StartForm startForm;
        public static BMICalculator bMICalculator;
        /// <summary>
        /// A Splash Screen that is displayed for 3 seconds and then displays the BMI App
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //create instance
            startForm = new StartForm();
            bMICalculator = new BMICalculator();
            Application.Run(new StartForm());
        }
    }
}
