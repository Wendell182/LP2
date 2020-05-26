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
    public partial class frmexercicio3 : Form
    {
        public frmexercicio3()
        {
            InitializeComponent();
        }

        private void btnPalin_Click(object sender, EventArgs e)
        {
            string palavra = txtPalin.Text;
            palavra = palavra.Replace(" ", "");
            palavra = palavra.ToUpper();

            char[] test = palavra.ToCharArray();
            Array.Reverse(test);
            string test2 = new string(test);
           

            if(String.Equals(palavra,test2))
            {
                MessageBox.Show("É palíndromo:" + test2);
            }
            else
            {
                MessageBox.Show("Não é palíndromo:" + test2);
            }

        }
    }
}
