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
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();
            string list = "";

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            foreach (string c in alunos)
            {
                list = c + "\n" + list;
            }

            MessageBox.Show("antes de remover: " + list);

            list = "";

            alunos.Remove("Otávio");

            foreach (string c in alunos)
            {
                list = c + "\n" + list;
            }

            MessageBox.Show("depois de remover: " + list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o número:", "Entrada de dados");
                if (valor == "")
                    break;
                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString;
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;

                }
                else
                {
                    MessageBox.Show("Numeroinválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (var x = 0; x < 0; x++)
            {
                valor = Interaction.InputBox("Digite dado da posição:" + (x + 1),
                "Entrada de dados");
                if (valor == "")
                    break;
                if (!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Numero Invalido!");
                    x--;
                }

            }
            Array.Reverse(Vetor);
            for (var x = 0; x < 20; x++)
                auxiliar = auxiliar + "\n" + Vetor[x];
            MessageBox.Show(auxiliar);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[] VetPreco = new double[10];
            int[] VetQtd = new int[10];

            string valor = "";
            double total = 0;

            for (var x = 0; x < 10; x++)
            {
                valor = "";
                while (!(VetQtd[x] > 0))
                {
                    valor = Interaction.InputBox("Digite a quantia de itens vendidos da mercadoria" +
                        (x + 1) + ":");

                    if (!int.TryParse(valor, out VetQtd[x]) && VetQtd[x] > 0)
                    {
                        MessageBox.Show("Digite um número válido! (Maior que 0)");
                        valor = "";
                    }
                }

                valor = "";

                while (!(VetPreco[x] > 0))
                {
                    valor = Interaction.InputBox("Digite o valor do item" + (x + 1) + ":");
                    if (!double.TryParse(valor, out VetPreco[x]) && VetPreco[x] > 0)
                    {
                        MessageBox.Show("Digite um número válido!(Maior que 0)");
                        valor = "";
                    }
                }

                total += VetQtd[x] * VetPreco[x];
            }

            MessageBox.Show("Faturamento é de: R$" + total.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] alunos = {"Viviane","André","Hélio","Denise","Júnior","Leonardo","Jose",
            "Nelma","Tobby"};
            Int32 i, Total = 0;
            Int32 n = alunos.Length;

            for (i = 0; i < n - 1; i++)
            {
                Total += alunos[i].Length;
            }

            MessageBox.Show("Total:" + Total.ToString());
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            double[] media = new double[30];
            double[,] notas = new double[2, 3];
            int linha, coluna;
            bool test=true;
            string aux="";
            linha = notas.GetLength(0);
            coluna = notas.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                double cont = 0;
                for (int j = 0; j < coluna; j++)
                {
                    do
                    {
                       
                        aux = (Interaction.InputBox(
                            "Digite a nota:"+ (j + 1) + " do aluno " + (i + 1),"Entrada das notas"));
                        if(!double.TryParse(aux,out notas[i, j]))
                        {
                            MessageBox.Show("Dados inválidos");
                            aux = "";
                            test = true;
                        }
           
                        else if (notas[i, j] < 0)
                        {
                            MessageBox.Show("Digite uma nota maior ou igual a 0");
              
                            test = true;
                        }
                        else if (notas[i, j] > 10)
                        {
                            MessageBox.Show("A nota não pode ser maior que 10");
                           
                            test = true;
                        }
                        else
                        {
                            cont += notas[i, j];
                            test = false;
                        } 
                       
                    } while (test);

                }
                media[i] = cont / 3.0;
                MessageBox.Show("A média do aluno " + (i + 1) + "é: " + media[i].ToString("N2"));

                    
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           

            frmEx7 frm2 = new frmEx7();
            frm2.Show();
        }
    }
}