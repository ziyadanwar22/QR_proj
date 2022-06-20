using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using System.Net;


using System.IO;


namespace Qr_genrator
{
    public partial class Home : Form
    {
        //Declare and Initialize the IP Adress
        static IPAddress ipAd = IPAddress.Any;

        //Declare and Initilize the Port Number;
        static int PortNumber = 8080;

        /* Initializes the Listener */
        TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
        TcpClient clientSocket = default(TcpClient);
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Thread ThreadingServer = new Thread(StartServer);
            ThreadingServer.Start();
        }
        private void THREAD_MOD(string teste)
        {
            //  txtStatus.Text += Environment.NewLine + teste;
            dataGridView1.Rows.Add(teste);
        }

        private void StartServer()
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            ServerListener.Start();
            // Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
            clientSocket = ServerListener.AcceptTcpClient();
            //Invoke(DelegateTeste_ModifyText, "Server ready!");

            while (true)
            {
                try
                {

                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[20];
                    networkStream.Read(bytesFrom, 0, 20);
                    //string x = bytesFrom.ToString();
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    // dataGridView1.Rows.Add(dataFromClient);   
                    //StreamReader reader = new StreamReader(System.Text.Encoding.ASCII.GetString(bytesFrom));
                    // textBox1.Text = (string)Invoke(DelegateTeste_ModifyText, dataFromClient);
                    dataGridView1.Rows.Add((string)Invoke(DelegateTeste_ModifyText, dataFromClient));
                    //string serverResponse = "Received!";
                    //Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    //networkStream.Write(sendBytes, 0, sendBytes.Length);
                    //networkStream.Flush();
                    // textBox1.Text = dataFromClient;



                }
                catch
                {
                    ServerListener.Stop();
                    ServerListener.Start();
                    //Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
                    clientSocket = ServerListener.AcceptTcpClient();
                    //Invoke(DelegateTeste_ModifyText, "Server ready!");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Thread th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openForm1()
        {
            Application.Run(new Qr());
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manual form03 = new Manual(this);
            form03.Show();
            //this.Hide();
        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAttendenceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            excel.Workbook workbook = app.Workbooks.Add();
            excel.Worksheet worksheet = null;
            app.Visible = true;
            //worksheet = workbook.Sheets["Shhet 1"];
            worksheet = workbook.ActiveSheet;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[j + 2, i + 1] = dataGridView1.Rows[j].Cells[i].Value.ToString();
                }
            }
        }

        private void manualToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //Manual form03 = new Manual(this);
            //form03.Show();
            //this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help F05 = new Help();
            F05.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Qr form01 = new Qr();
            form01.Show();
            this.Hide();

        }
    }
}
