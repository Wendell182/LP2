namespace Atividade2
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
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMaaculino = new System.Windows.Forms.RadioButton();
            this.btnNovoCalc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(147, 24);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskbxAltura.TabIndex = 1;
            this.mskbxAltura.ValidatingType = typeof(int);
            this.mskbxAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso Atual";
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(147, 107);
            this.mskbxPeso.Mask = "000.00";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(100, 20);
            this.mskbxPeso.TabIndex = 3;
            this.mskbxPeso.ValidatingType = typeof(int);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(171, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(306, 57);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMaaculino);
            this.groupBox1.Controls.Add(this.rbtnFeminino);
            this.groupBox1.Location = new System.Drawing.Point(403, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(22, 37);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMaaculino
            // 
            this.rbtnMaaculino.AutoSize = true;
            this.rbtnMaaculino.Checked = true;
            this.rbtnMaaculino.Location = new System.Drawing.Point(22, 122);
            this.rbtnMaaculino.Name = "rbtnMaaculino";
            this.rbtnMaaculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMaaculino.TabIndex = 1;
            this.rbtnMaaculino.TabStop = true;
            this.rbtnMaaculino.Text = "Masculino";
            this.rbtnMaaculino.UseVisualStyleBackColor = true;
            // 
            // btnNovoCalc
            // 
            this.btnNovoCalc.Location = new System.Drawing.Point(55, 360);
            this.btnNovoCalc.Name = "btnNovoCalc";
            this.btnNovoCalc.Size = new System.Drawing.Size(161, 64);
            this.btnNovoCalc.TabIndex = 6;
            this.btnNovoCalc.Text = "Novo Cálculo";
            this.btnNovoCalc.UseVisualStyleBackColor = true;
            this.btnNovoCalc.Click += new System.EventHandler(this.btnNovoCalc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(403, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(166, 64);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovoCalc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskbxAltura);
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
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMaaculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Button btnNovoCalc;
        private System.Windows.Forms.Button btnSair;
    }
}

