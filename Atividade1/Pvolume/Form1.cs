using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtVolume.Clear();
            txtAltura.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double verify1, verify2;

            if ((double.TryParse(txtRaio.Text, out verify1) &&
                double.TryParse(txtAltura.Text, out verify2)))
            {
                double vol = Math.PI * (verify1 * verify1) * verify2;
                txtVolume.Text = vol.ToString("N2");
            }
            else
                MessageBox.Show("Dados Inválidos!");
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            txtVolume.Enabled = false;
        }
    }
}
