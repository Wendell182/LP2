using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(rbtnFeminino.Checked)
            {
                double verify1, verify2;

                if ((double.TryParse(mskbxAltura.Text, out verify1) &&
                    double.TryParse(mskbxPeso.Text, out verify2)))
                {
                    double pesoIdeal = (62.1 * verify1) - 44.7;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    if (verify2 > pesoIdeal) 
                    {
                        MessageBox.Show("Seu peso ideal é:" + pesoIdeal + "\n" + "Regime Obrigatório!");
                    }else if(verify2 == pesoIdeal){
                        MessageBox.Show("Seu peso ideal é:" + pesoIdeal + "\n" + "Você está com o peso ideal!");
                    }
                    else
                    {
                        MessageBox.Show("Seu peso ideal é:" + pesoIdeal + "\n" + "Coma bastante massas e doces!");
                    }
                    
                }
                else
                    MessageBox.Show("Dados Inválidos!");
            }

            if (rbtnMaaculino.Checked)
            {
                double verify1, verify2;

                if ((double.TryParse(mskbxAltura.Text, out verify1) &&
                    double.TryParse(mskbxPeso.Text, out verify2)))
                {
                    double pesoIdeal = (72.7 * verify1) - 58 ;
                    pesoIdeal = Math.Round(pesoIdeal, 2);

                    if (verify2 > pesoIdeal)
                    {
                        MessageBox.Show("Seu peso ideal é:"+pesoIdeal+"\n" + "Regime Obrigatório!");
                    }
                    else if (verify2 == pesoIdeal)
                    {
                        MessageBox.Show("Seu peso ideal é:" + pesoIdeal + "\n"+"Você está com o peso ideal!");
                    }
                    else
                    {
                        MessageBox.Show("Seu peso ideal é:" + pesoIdeal + "\n"+"Coma bastante massas e doces!");
                    }

                }
                else
                    MessageBox.Show("Dados Inválidos!");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoCalc_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }
    }
}
