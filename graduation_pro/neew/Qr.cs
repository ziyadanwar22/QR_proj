using System;
using System.Drawing;
using System.Windows.Forms;

namespace Qr_genrator
{
    public partial class Qr : Form
    {
        //int time = 3000;
        public Qr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home form04 = new Home();
            form04.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //private void START_Click(object sender, EventArgs e)
        //{
        //    var g = Guid.NewGuid();
        //    label4.Text = Convert.ToString(g) ;

            
        //    Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
        //    pictureBox7.Image = qrcode.Draw(label4.Text, 50);
        //}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    Home form = new Home();
        //    form.Show();
        //    this.Hide();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    var g = Guid.NewGuid();
        //    label4.Text = Convert.ToString(g);


        //    Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
        //    pictureBox7.Image = qrcode.Draw(label4.Text, 50);
        
        //        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = time;

          

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //timer1.Stop();
            pictureBox7.Visible = false;
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(timer1.Interval < 10)
            //{
            //    timer1.Interval = 1000;//Defualt time is 1 second
            //}
            //else
            //{
            //    timer1.Interval = Convert.ToInt32(textBox1.Text);
            //}

            //setTimer();
            //label4.Visible = false;
            //timer1.Start();
            if (button2.Focused)
            {
                var g = Guid.NewGuid();// guid lab randomis that 64bit mixed digt and nums
                label4.Text = Convert.ToString(g);//that convert the random char and num to string 
                label4.Visible = false;

                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;//bulit in framwork that creat qr
                pictureBox7.Image = qrcode.Draw(label4.Text, 90);//that draw the qr

            }
            pictureBox7.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
        }

       // private void setTimer()
       // {

            //try
            //{
            //    int Newtext;
            //    int.TryParse(textBox1.Text, out Newtext);
              
            //    if (comboBox1.SelectedIndex == 0)
            //    {
            //        Newtext = Newtext * 1000;
            //    }
            //    else if (comboBox1.SelectedIndex == 1)
            //    {
            //        Newtext = Newtext * 1000 * 60;
            //    }
            //    else
            //    {
            //        Newtext = Newtext * 1000;//that is the default of the timer will be by second
            //    }
            //    timer1.Interval = Newtext;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBox1.Focus();
            //}
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            pictureBox7.Visible = false;
        }
    }
    }

