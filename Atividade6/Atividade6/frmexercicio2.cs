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
    public partial class frmexercicio2 : Form
    {
        public frmexercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarNum_Click(object sender, EventArgs e)
        {
            double n, h = 0;

            if (double.TryParse(txtNum.Text, out n))
            {
                if (n > 0)
                {
                    for (double x = 1; x <= n; x++)
                    {
                        h = h + (1 / x);
                    }

                    MessageBox.Show("O número H gerado é:" + h.ToString("N2"));
                }
                else
                {
                    MessageBox.Show("Digite um número maior que 0");
                }
            }

        }
    }
}

