using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class Sketcher : Form
    {
        public Sketcher()
        {
            InitializeComponent();
        }

        private void openFileClicked(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                label2.Text = filePath;
            }   

        }

        private void newFileClicked(object sender, EventArgs e)
        {

        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
