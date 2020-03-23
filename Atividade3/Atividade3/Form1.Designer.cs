namespace Atividade3
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
            this.mskbxLadoA = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoB = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoC = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LADO A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LADO B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LADO C";
            // 
            // mskbxLadoA
            // 
            this.mskbxLadoA.Location = new System.Drawing.Point(143, 32);
            this.mskbxLadoA.Mask = "000.00";
            this.mskbxLadoA.Name = "mskbxLadoA";
            this.mskbxLadoA.Size = new System.Drawing.Size(155, 20);
            this.mskbxLadoA.TabIndex = 3;
            // 
            // mskbxLadoB
            // 
            this.mskbxLadoB.Location = new System.Drawing.Point(143, 161);
            this.mskbxLadoB.Mask = "000.00";
            this.mskbxLadoB.Name = "mskbxLadoB";
            this.mskbxLadoB.Size = new System.Drawing.Size(155, 20);
            this.mskbxLadoB.TabIndex = 4;
            // 
            // mskbxLadoC
            // 
            this.mskbxLadoC.Location = new System.Drawing.Point(143, 292);
            this.mskbxLadoC.Mask = "000.00";
            this.mskbxLadoC.Name = "mskbxLadoC";
            this.mskbxLadoC.Size = new System.Drawing.Size(155, 20);
            this.mskbxLadoC.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(50, 367);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(104, 53);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(359, 367);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 53);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(650, 367);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 53);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.mskbxLadoC);
            this.Controls.Add(this.mskbxLadoB);
            this.Controls.Add(this.mskbxLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskbxLadoA;
        private System.Windows.Forms.MaskedTextBox mskbxLadoB;
        private System.Windows.Forms.MaskedTextBox mskbxLadoC;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

