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
    public partial class Manual : Form
    {
        Home home;
        public Manual(Home ho)
        {
            InitializeComponent();
            this.home = ho;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.dataGridView1.Rows.Add(Txt01.Text, textBox1.Text);
            Txt01.Clear();
            textBox1.Clear();

            //MessageBox.Show("تم تحضير الطالب احمد محمد حسين بنجاح ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Home form04 = new Home();
            //form04.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
