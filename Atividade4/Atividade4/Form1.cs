using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double salLiqui=0, salBruto, descInss = 0, descIrpf, salFamilia;
            int numFilhos;
            String estadoCivil;

            if ((double.TryParse(mskbxSalBruto.Text, out salBruto)))
            {
                if (salBruto <= 800.47)
                {
                    mskbxAli_Inss.Text = "7,65%";
                    descInss = 7.65 / 100 * salBruto;
                    mskbxDesc_Inss.Text = descInss.ToString();
                }
                else if (salBruto <= 1050)
                {
                    mskbxAli_Inss.Text = "8,65%";
                    descInss = 8.65 / 100 * salBruto;
                    mskbxDesc_Inss.Text = descInss.ToString();
                }
                else if (salBruto <= 1400.77)
                {
                    mskbxAli_Inss.Text = "9,00%";
                    descInss = 9.00 / 100 * salBruto;
                    mskbxDesc_Inss.Text = descInss.ToString();
                }
                else if (salBruto <= 2801.56)
                {
                    mskbxAli_Inss.Text = "11,00%";
                    descInss = 11.00 / 100 * salBruto;
                    mskbxDesc_Inss.Text = descInss.ToString();
                }
                else
                {
                    descInss = 308.17;
                    mskbxDesc_Inss.Text = descInss.ToString();
                    mskbxAli_Inss.Text = descInss.ToString();
                }
            }
            else
            {
                MessageBox.Show("Dados do salário inválidos!");
            }

            if (salBruto <= 1257.12)
            {
                mskbxAli_Irpf.Text = "0";
                descIrpf = 0;
                mskbxDesc_Irpf.Text = descIrpf.ToString();
            }
            else if (salBruto <= 2512.08)
            {
                mskbxAli_Irpf.Text = "15,00%";
                descIrpf = 15.00 / 100 * salBruto;
                mskbxDesc_Irpf.Text = descIrpf.ToString();
            }
            else
            {
                mskbxAli_Irpf.Text = "27,5%";
                descIrpf = 27.5 / 100 * salBruto;
                mskbxDesc_Irpf.Text = descIrpf.ToString();
            }

            int.TryParse(mskbxNumFilhos.Text, out numFilhos);

            if (salBruto <= 435.52)
            {
                salFamilia = 22.33 * numFilhos;
                mskbxSal_Familia.Text = salFamilia.ToString();
            }
            else if (salBruto <= 654.61)
            {
                salFamilia = 15.74 * numFilhos;
                mskbxSal_Familia.Text = salFamilia.ToString();
            }
            else
            {
                salFamilia = 0.00;
                mskbxSal_Familia.Text = salFamilia.ToString();
            }

            salLiqui = salBruto - descIrpf - descInss  + salFamilia;
            mskbxSal_Liquido.Text = salLiqui.ToString();

            if (ckbxCasado.Checked)
            {
                estadoCivil = "Casado(a)";
            }
            else
            {
                estadoCivil = "Solteiro(a)";
            }

            if (rbtnFem.Checked)
            {
                label4.Text = "Os descontos do salário da Sra. " + txtNome.Text + " que é "+"\n" + estadoCivil +
                    " e que tem " + numFilhos.ToString() + " filhos(a) são:";
            }
            else
            {
                label4.Text = "Os descontos do salário do Sr. " + txtNome.Text + " que é "+"\n" + estadoCivil +
                   " e que tem " + numFilhos.ToString() + " filhos(a) são:";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalBruto.Clear();
            mskbxNumFilhos.Clear();
            mskbxAli_Inss.Clear();
            mskbxAli_Irpf.Clear();
            mskbxDesc_Inss.Clear();
            mskbxDesc_Irpf.Clear();
            mskbxSal_Familia.Clear();
            mskbxSal_Liquido.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
