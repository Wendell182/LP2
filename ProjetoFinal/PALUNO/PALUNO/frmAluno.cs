using PCidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmAluno : Form
    {

        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();


        public frmAluno()
        {
            InitializeComponent();
        }

        public static FormWindowState WindowsState { get; internal set; }

       

        private void frmAluno_Load(object sender, EventArgs e)
        {
            try
            {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TbAluno"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRa.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidade.DataSource = dsCidade.Tables["TbCidade"];

                //campo que será mostrado para o usuario
                cbxCidade.DisplayMember = "nome_cidade";

                //campo que é a chave da tabela cidade e que liga com a tabela do aluno
                cbxCidade.ValueMember = "id_cidade";

                //no momento de loinkar os componentes com o Binding Source linkar tbm o combobox
                cbxCidade.DataBindings.Add("SelectedValue", bnAluno, "cidade_id_cidade");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoRegistro_Click_1(object sender, EventArgs e)
        {
            if (tabControlAluno.SelectedIndex == 0)
            {
                tabControlAluno.SelectTab(1);
            }

            bnAluno.AddNew();
            txtNomeAluno.Enabled = true;
            txtRa.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (tabControlAluno.SelectedIndex == 0)
            {
                tabControlAluno.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Aluno RegAlu = new Aluno();

                RegAlu.RaAluno = Convert.ToInt16(txtRa.Text);
                RegAlu.NomeAluno = txtNomeAluno.Text;
                MessageBox.Show(cbxCidade.SelectedItem.ToString());
                RegAlu.CidadeIdCidade = Convert.ToInt16(cbxCidade.SelectedValue);

                if (RegAlu.Excluir() > 0)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    Cidade R = new Cidade();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(R.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBAluno"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Nome inválido!");
            }
            else
            {
                Aluno RegAlu = new Aluno();

                RegAlu.RaAluno = Convert.ToInt32(txtRa.Text);
                RegAlu.NomeAluno = txtNomeAluno.Text;
                RegAlu.CidadeIdCidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (bInclusao)
                {
                    if (RegAlu.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBaluno"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }
                }
                else
                {
                    if (RegAlu.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterado com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        txtNomeAluno.Enabled = false;
                        txtRa.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }

                }
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (tabControlAluno.SelectedIndex == 0)
            {
                tabControlAluno.SelectTab(1);
            }

            txtRa.Enabled = false;
            cbxCidade.Enabled = true;
            txtNomeAluno.Enabled = true;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            bnAluno.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidade.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }








}

