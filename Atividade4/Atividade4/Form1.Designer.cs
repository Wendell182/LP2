namespace Atividade4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskbxAli_Inss = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAli_Irpf = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSal_Familia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSal_Liquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDesc_Inss = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDesc_Irpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de filhos";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(132, 77);
            this.mskbxSalBruto.Mask = "0000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalBruto.TabIndex = 4;
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Location = new System.Drawing.Point(132, 119);
            this.mskbxNumFilhos.Mask = "00";
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskbxNumFilhos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFem);
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Location = new System.Drawing.Point(459, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(58, 19);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(31, 17);
            this.rbtnFem.TabIndex = 7;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(58, 60);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasc.TabIndex = 0;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(499, 164);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 7;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(116, 164);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(144, 45);
            this.btnVerifica.TabIndex = 8;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alíquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alíquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salário Família";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salário Líquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Desconto IRPF";
            // 
            // mskbxAli_Inss
            // 
            this.mskbxAli_Inss.Enabled = false;
            this.mskbxAli_Inss.Location = new System.Drawing.Point(132, 278);
            this.mskbxAli_Inss.Name = "mskbxAli_Inss";
            this.mskbxAli_Inss.Size = new System.Drawing.Size(100, 20);
            this.mskbxAli_Inss.TabIndex = 16;
            // 
            // mskbxAli_Irpf
            // 
            this.mskbxAli_Irpf.Enabled = false;
            this.mskbxAli_Irpf.Location = new System.Drawing.Point(132, 325);
            this.mskbxAli_Irpf.Name = "mskbxAli_Irpf";
            this.mskbxAli_Irpf.Size = new System.Drawing.Size(100, 20);
            this.mskbxAli_Irpf.TabIndex = 17;
            // 
            // mskbxSal_Familia
            // 
            this.mskbxSal_Familia.Enabled = false;
            this.mskbxSal_Familia.Location = new System.Drawing.Point(132, 364);
            this.mskbxSal_Familia.Name = "mskbxSal_Familia";
            this.mskbxSal_Familia.Size = new System.Drawing.Size(100, 20);
            this.mskbxSal_Familia.TabIndex = 18;
            // 
            // mskbxSal_Liquido
            // 
            this.mskbxSal_Liquido.Enabled = false;
            this.mskbxSal_Liquido.Location = new System.Drawing.Point(132, 421);
            this.mskbxSal_Liquido.Name = "mskbxSal_Liquido";
            this.mskbxSal_Liquido.Size = new System.Drawing.Size(100, 20);
            this.mskbxSal_Liquido.TabIndex = 19;
            this.mskbxSal_Liquido.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // mskbxDesc_Inss
            // 
            this.mskbxDesc_Inss.Enabled = false;
            this.mskbxDesc_Inss.Location = new System.Drawing.Point(517, 282);
            this.mskbxDesc_Inss.Name = "mskbxDesc_Inss";
            this.mskbxDesc_Inss.Size = new System.Drawing.Size(100, 20);
            this.mskbxDesc_Inss.TabIndex = 20;
            this.mskbxDesc_Inss.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // mskbxDesc_Irpf
            // 
            this.mskbxDesc_Irpf.Enabled = false;
            this.mskbxDesc_Irpf.Location = new System.Drawing.Point(517, 321);
            this.mskbxDesc_Irpf.Name = "mskbxDesc_Irpf";
            this.mskbxDesc_Irpf.Size = new System.Drawing.Size(100, 20);
            this.mskbxDesc_Irpf.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskbxDesc_Irpf);
            this.Controls.Add(this.mskbxDesc_Inss);
            this.Controls.Add(this.mskbxSal_Liquido);
            this.Controls.Add(this.mskbxSal_Familia);
            this.Controls.Add(this.mskbxAli_Irpf);
            this.Controls.Add(this.mskbxAli_Inss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskbxAli_Inss;
        private System.Windows.Forms.MaskedTextBox mskbxAli_Irpf;
        private System.Windows.Forms.MaskedTextBox mskbxSal_Familia;
        private System.Windows.Forms.MaskedTextBox mskbxSal_Liquido;
        private System.Windows.Forms.MaskedTextBox mskbxDesc_Inss;
        private System.Windows.Forms.MaskedTextBox mskbxDesc_Irpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

