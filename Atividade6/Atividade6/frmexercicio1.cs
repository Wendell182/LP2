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
    public partial class frmexercicio1 : Form
    {
        public frmexercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            int cont = 0;
            while (x < rchtxtTexto.Text.Length)
            {
                if (rchtxtTexto.Text[x] == ' ')
                {
                    cont += 1;
                }

                x += 1;
            }

            MessageBox.Show("Existem"+' ' +cont +' '+ "espaços em branco");
            
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int cont = 0;

            for(var x=0; x <= rchtxtTexto.Text.Length - 1; x++)
            {
                if (rchtxtTexto.Text[x] == 'r' || rchtxtTexto.Text[x] == 'R')
                    cont += 1;
            }

            MessageBox.Show("Existem" +' '+ cont +' '+ "letras R");
        }

        private void btnParLetra_Click(object sender, EventArgs e)
        {
            int cont = 0;
            
            for(int x =1; x < rchtxtTexto.Text.Length; x++)
            {
                if (rchtxtTexto.Text[x] == rchtxtTexto.Text[x - 1])
                    cont += 1;
            }
           

            MessageBox.Show("Existem" + ' ' + cont + ' ' + "pares");
        }
    }
}
