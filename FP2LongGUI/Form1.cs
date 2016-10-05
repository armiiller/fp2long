using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP2LongGUI
{
    public partial class Form1 : Form
    {

        private string _path;
        public Form1()
        {
            InitializeComponent();

            _path = null;
        }

        

        private void tb_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_Path.Text = dialog.SelectedPath;
            }
        }

        private async void b_delete_Click(object sender, EventArgs e)
        {
            if (this.tb_Path.Text != null)
            {
                var fp2long = new FP2LongCore.File();
                await fp2long.Delete(this.tb_Path.Text);
            }

        }
    }
}
