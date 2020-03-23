using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if((double.TryParse(mskbxLadoA.Text,out ladoA)&&
                double.TryParse(mskbxLadoB.Text,out ladoB)&&
                double.TryParse(mskbxLadoC.Text,out ladoC)))
            {
              if((Math.Abs(ladoB-ladoC)) < ladoA && ladoA < (ladoB+ladoC) &&
                    (Math.Abs(ladoA-ladoC)) < ladoB && ladoB < (ladoA+ladoC) &&
                    (Math.Abs(ladoA-ladoB))<ladoC && ladoC < (ladoA + ladoB))
                {
                    if((ladoA == ladoB) && (ladoB == ladoC))
                    {
                        MessageBox.Show("Triângulo Equilátero!");
                    }else if ((ladoA == ladoB)||(ladoB == ladoC)||(ladoA == ladoC))
                    {
                        MessageBox.Show("Triângulo Isósceles!");
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Escaleno!");
                    }
                }
                else
                {
                    MessageBox.Show("Não é triângulo!");
                }
            }
            else
            {
                MessageBox.Show("Dados de entrada inválidos");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxLadoA.Clear();
            mskbxLadoB.Clear();
            mskbxLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
