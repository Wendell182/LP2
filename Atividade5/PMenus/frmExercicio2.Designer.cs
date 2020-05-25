namespace PMenus
{
    partial class frmExercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnTesta = new System.Windows.Forms.Button();
            this.btnInsere1 = new System.Windows.Forms.Button();
            this.btnInsere2 = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(96, 54);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(96, 98);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnTesta
            // 
            this.btnTesta.Location = new System.Drawing.Point(47, 176);
            this.btnTesta.Name = "btnTesta";
            this.btnTesta.Size = new System.Drawing.Size(75, 62);
            this.btnTesta.TabIndex = 2;
            this.btnTesta.Text = "testa se são iguais";
            this.btnTesta.UseVisualStyleBackColor = true;
            this.btnTesta.Click += new System.EventHandler(this.btnTesta_Click);
            // 
            // btnInsere1
            // 
            this.btnInsere1.Location = new System.Drawing.Point(153, 176);
            this.btnInsere1.Name = "btnInsere1";
            this.btnInsere1.Size = new System.Drawing.Size(61, 62);
            this.btnInsere1.TabIndex = 3;
            this.btnInsere1.Text = "Insere Palavra1 na Palavra2";
            this.btnInsere1.UseVisualStyleBackColor = true;
            this.btnInsere1.Click += new System.EventHandler(this.btnInsere1_Click);
            // 
            // btnInsere2
            // 
            this.btnInsere2.Location = new System.Drawing.Point(243, 176);
            this.btnInsere2.Name = "btnInsere2";
            this.btnInsere2.Size = new System.Drawing.Size(75, 62);
            this.btnInsere2.TabIndex = 4;
            this.btnInsere2.Text = "insere ** na Palavra1";
            this.btnInsere2.UseVisualStyleBackColor = true;
            this.btnInsere2.Click += new System.EventHandler(this.btnInsere2_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(39, 60);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(38, 105);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 283);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInsere2);
            this.Controls.Add(this.btnInsere1);
            this.Controls.Add(this.btnTesta);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnTesta;
        private System.Windows.Forms.Button btnInsere1;
        private System.Windows.Forms.Button btnInsere2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}