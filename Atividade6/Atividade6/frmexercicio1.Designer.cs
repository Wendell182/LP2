namespace Atividade6
{
    partial class frmexercicio1
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(85, 55);
            this.rchtxtTexto.MaxLength = 100;
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(483, 139);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(12, 257);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(113, 81);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Contar Espaços em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(282, 257);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(113, 81);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Número de Ocorrência da letra \"R\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParLetra
            // 
            this.btnParLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParLetra.Location = new System.Drawing.Point(544, 257);
            this.btnParLetra.Name = "btnParLetra";
            this.btnParLetra.Size = new System.Drawing.Size(113, 81);
            this.btnParLetra.TabIndex = 3;
            this.btnParLetra.Text = "Contar Pares de Letras";
            this.btnParLetra.UseVisualStyleBackColor = true;
            this.btnParLetra.Click += new System.EventHandler(this.btnParLetra_Click);
            // 
            // frmexercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetra);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmexercicio1";
            this.Text = "frmexercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParLetra;
    }
}