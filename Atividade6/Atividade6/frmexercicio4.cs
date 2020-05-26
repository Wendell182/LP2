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
    public partial class frmexercicio4 : Form
    {
        public frmexercicio4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "" || txtGrat.Text == "" || txtInscricao.Text == "" || txtNome.Text == "" ||
                txtProd.Text == "" || txtSal.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                double salBruto = 0, b, c, d, prod, grat, sal;

                if (double.TryParse(txtSal.Text, out sal) &&
                double.TryParse(txtProd.Text, out prod) &&
                double.TryParse(txtGrat.Text, out grat))
                {
                    if (prod >= 100)
                    {
                        b = 1;
                    }
                    else
                    {
                        b = 0;
                    }
                    if (prod >= 120)
                    {
                        c = 1;
                    }
                    else
                    {
                        c = 0;
                    }
                    if (prod >= 150)
                    {
                        d = 1;
                    }
                    else
                    {
                        d = 0;
                    }

                    salBruto = sal + sal * (0.05 * b + 0.1 * c + 0.1 * d) + grat;

                    if (salBruto > 7000)
                    {
                        if (prod >= 150 && grat > 0)
                        {
                            salBruto = salBruto + 0;
                        }
                        else
                        {
                            salBruto = 7000;
                        }
                    }

                    MessageBox.Show("O Funcionário:" + txtNome.Text + ',' + txtCargo.Text + ',' +
                        "da inscrição:" + txtInscricao.Text + "\n" + "Receberá:" + salBruto.ToString());
                }
                else
                {
                    MessageBox.Show("Dados Inválidos!"+"\n"+"Por favor,verifique os campos e tente novamente");
                }
            }
        }
    }
}
