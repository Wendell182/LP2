using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmexercicio2 frm2 = new frmexercicio2();
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            frmexercicio1 frm1 = new frmexercicio1();
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            frmexercicio3 frm3 = new frmexercicio3();
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            frmexercicio4 frm4 = new frmexercicio4();
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
