using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using PCidade;


namespace PALUNO
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //LAPTOP-OB0QTL54\SQLEXPRESS 
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-OB0QTL54\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }
        
        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.WindowState = FormWindowState.Maximized;
            frmCid.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno fmAluno = new frmAluno();
            fmAluno.MdiParent = this;
            fmAluno.WindowState = FormWindowState.Maximized;
            fmAluno.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre fmSobre = new frmSobre();
            fmSobre.MdiParent = this;
            fmSobre.WindowState = FormWindowState.Maximized;
            fmSobre.Show();
        }
    }
}
