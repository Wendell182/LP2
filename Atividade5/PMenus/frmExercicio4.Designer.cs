namespace PMenus
{
    partial class frmExercicio4
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
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(82, 57);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(472, 148);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(43, 261);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(117, 86);
            this.btnNumerico.TabIndex = 1;
            this.btnNumerico.Text = "Caracteres Numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(264, 261);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(117, 86);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(480, 261);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(117, 86);
            this.btnAlfabetico.TabIndex = 3;
            this.btnAlfabetico.Text = "Caracteres Alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumerico);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabetico;
    }
}