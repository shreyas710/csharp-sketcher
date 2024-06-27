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

            dialog.Filter = "DWG|*.dwg";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Form main = new Main(dialog);
                this.Hide();
                main.Show();
            }   
        }

        private void newFileClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "DWG|*.dwg";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form main = new Main(saveFileDialog1);
                this.Hide();
                main.Show();
            }
        }

        private static bool _isMainClosed;
        public static bool IsMainClosed
        {
            get
            {
                return _isMainClosed;
            }
            set
            {
                _isMainClosed = value;

                if (value)
                {
                    Application.Exit();
                }
            }
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
