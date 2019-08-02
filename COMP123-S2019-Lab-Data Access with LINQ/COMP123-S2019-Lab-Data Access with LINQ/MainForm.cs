using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab_Data_Access_with_LINQ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the MainForm's FormClosing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for the exitToolStripMenuItem Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the aboutToolStripMenuItem Click evnet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'sectionCDatabaseDataSet2.StudentTable' 資料表。您可以視需要進行移動或移除。
            this.studentTableTableAdapter.Fill(this.sectionCDatabaseDataSet2.StudentTable);

        }
        /// <summary>
        /// This is the event handler for the helpToolStripButton Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        /// <summary>
        /// This is the handler for ShowDataButton Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            var StudentList =
                from student in this.sectionCDatabaseDataSet2.StudentTable
                select student;
            foreach (var student in StudentList.ToList())
            {
                Debug.WriteLine("Student ID: " + student.StudentID +
                    " Last Name: " + student.LastName);
            }
        }
    }
}
