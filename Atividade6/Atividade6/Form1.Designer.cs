namespace Atividade6
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
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx3
            // 
            this.btnEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx3.Location = new System.Drawing.Point(64, 245);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(142, 98);
            this.btnEx3.TabIndex = 0;
            this.btnEx3.Text = "Exercício 3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx4.Location = new System.Drawing.Point(336, 245);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(142, 98);
            this.btnEx4.TabIndex = 1;
            this.btnEx4.Text = "Exercício 4";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // btnEx1
            // 
            this.btnEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx1.Location = new System.Drawing.Point(64, 99);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(142, 98);
            this.btnEx1.TabIndex = 2;
            this.btnEx1.Text = "Exercício 1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx2.Location = new System.Drawing.Point(327, 99);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(142, 98);
            this.btnEx2.TabIndex = 3;
            this.btnEx2.Text = "Exercício 2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Atividade 6";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(586, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 44);
            this.btnSair.TabIndex = 6;
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
    }
}

