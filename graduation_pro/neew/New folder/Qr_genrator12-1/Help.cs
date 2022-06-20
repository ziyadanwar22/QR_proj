using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_genrator
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home form05 = new Home();
            form05.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
