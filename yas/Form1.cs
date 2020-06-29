using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yas
{
    public partial class Form1 : Form
    {
        public static TcpListener server;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text);
            IPAddress direccion = IPAddress.Parse(textBox1.Text);

            server = new TcpListener(direccion, puerto);
            server.Start();
            rtblogs.Text = "iniciando";
            while (true)
            {
                rtblogs.AppendText("\n esperando cliente");
                TcpClient cliente = await server.AcceptTcpClientAsync();
                rtblogs.AppendText("\nconectando");
                cliente.Close();

            }

        }
    }
}
