using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class frmEx7 : Form
    {
        public frmEx7()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            string[] cont = new string[10];
            int total = 0;

            for(var x = 0; x < 10; x++)
            {
                nomes[x] = Interaction.InputBox("Digite o nome: " + (x + 1), "Entrada dos nomes");
                cont[x] = nomes[x].Replace(" ", "");
                total = cont[x].Length;

                listBox1.Items.Add("O nome " + nomes[x] + " tem " + total + " caracteres");
                total = 0;
            }
        }
    }
}
