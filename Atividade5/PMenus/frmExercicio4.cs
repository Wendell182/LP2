using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int contador = 0;
            
            for (var x =0; x<= rchtxtTexto.Text.Length-1; x++)
            {
                //if(Char.IsNumber(Convert.ToChar(rchtxtTexto.Text.Substring(x,1))))

                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1;
            }

            MessageBox.Show("Caracteres Numéricos:" + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x < rchtxtTexto.Text.Length)
            {
                //if(rchtxtTexto.Text[x]== ' ')

                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro Caractere Branco:" + (x + 1));
                    break;
                }
                x += 1;
            }
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach(char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }

            MessageBox.Show("Caracteres Alfabétcos:" + contador);
        }
    }
}
