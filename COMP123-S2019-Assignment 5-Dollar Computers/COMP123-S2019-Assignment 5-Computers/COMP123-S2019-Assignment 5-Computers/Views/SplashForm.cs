﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_5_Computers.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is a event Handler for SplashForm Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTime.Enabled = true;
        }

        /// <summary>
        /// This is a event Handler for SplashTime Tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTime_Tick(object sender, EventArgs e)
        {
            SplashTime.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
