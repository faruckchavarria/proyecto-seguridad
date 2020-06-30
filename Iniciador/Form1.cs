using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iniciador
{
    public partial class Form1 : Form
    {
        public object Public { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text);
            string nombre = textBox1.Text;
            rtblogs.Text = "iniciando";
            TcpClient cliente = new TcpClient(nombre, puerto);



            if (cliente.Connected)
            {
                rtblogs.AppendText("conectando");
                var destino = txtdestino.Text;
                var numero = Int32.Parse (txtnumero.Text);

                NetworkStream stream = cliente.GetStream();

                Byte[] mensaje = System.Text.Encoding.ASCII.GetBytes(txtdestino.Text);

                MessageBox.Show(mensaje.Length.ToString());
                stream.Write(mensaje, 0, mensaje.Length);
                rtblogs.AppendText("\n" + ByteArrayToString(mensaje));

                cliente.Close();
            }

        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length + 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvvista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rtblogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_puerto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KDC_Click(object sender, EventArgs e)
        {

        }
    }
}
