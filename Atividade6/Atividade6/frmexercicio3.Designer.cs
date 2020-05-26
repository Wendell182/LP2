namespace Atividade6
{
    partial class frmexercicio3
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
            this.txtPalin = new System.Windows.Forms.TextBox();
            this.btnPalin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalin
            // 
            this.txtPalin.Location = new System.Drawing.Point(40, 59);
            this.txtPalin.MaxLength = 50;
            this.txtPalin.Name = "txtPalin";
            this.txtPalin.Size = new System.Drawing.Size(263, 20);
            this.txtPalin.TabIndex = 0;
            // 
            // btnPalin
            // 
            this.btnPalin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalin.Location = new System.Drawing.Point(40, 118);
            this.btnPalin.Name = "btnPalin";
            this.btnPalin.Size = new System.Drawing.Size(120, 79);
            this.btnPalin.TabIndex = 1;
            this.btnPalin.Text = "Verificar se é Palíndromo";
            this.btnPalin.UseVisualStyleBackColor = true;
            this.btnPalin.Click += new System.EventHandler(this.btnPalin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a frase ou palavra:";
            // 
            // frmexercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPalin);
            this.Controls.Add(this.txtPalin);
            this.Name = "frmexercicio3";
            this.Text = "frmexercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalin;
        private System.Windows.Forms.Button btnPalin;
        private System.Windows.Forms.Label label1;
    }
}