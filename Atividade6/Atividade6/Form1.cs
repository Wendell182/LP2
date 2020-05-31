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
            Form fc = Aplication.OpenForms["frmexercicio2"];
            
            if(fc != null)
                fc.close();
            frmexercicio2 frm2 = new frmexercicio2();
            frm2.Show();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Form fc = Aplication.OpenForms["frmexercicio1"];
            
            if(fc != null)
                fc.close();
            frmexercicio1 frm1 = new frmexercicio1();
            frm1.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Form fc = Aplication.OpenForms["frmexercicio3"];
            
            if(fc != null)
                fc.close();
            frmexercicio3 frm3 = new frmexercicio3();
            frm3.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Form fc = Aplication.OpenForms["frmexercicio4"];
            
            if(fc != null)
                fc.close();
            frmexercicio4 frm4 = new frmexercicio4();
            frm4.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
