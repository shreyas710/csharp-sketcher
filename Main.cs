using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main(FileDialog fileDialog)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.Text = Path.GetFileName(fileDialog.FileName);
            this.FormClosing += Main_FormClosing;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sketcher.IsMainClosed = true;
        }
    }
}
