namespace PMenus
{
    partial class frmExercicio5
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
            this.lblPrimeiroNum = new System.Windows.Forms.Label();
            this.lblSegundoNum = new System.Windows.Forms.Label();
            this.txtPrimeiroNum = new System.Windows.Forms.TextBox();
            this.txtSegundoNum = new System.Windows.Forms.TextBox();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNum
            // 
            this.lblPrimeiroNum.AutoSize = true;
            this.lblPrimeiroNum.Location = new System.Drawing.Point(38, 37);
            this.lblPrimeiroNum.Name = "lblPrimeiroNum";
            this.lblPrimeiroNum.Size = new System.Drawing.Size(84, 13);
            this.lblPrimeiroNum.TabIndex = 0;
            this.lblPrimeiroNum.Text = "Primeiro Número";
            // 
            // lblSegundoNum
            // 
            this.lblSegundoNum.AutoSize = true;
            this.lblSegundoNum.Location = new System.Drawing.Point(41, 92);
            this.lblSegundoNum.Name = "lblSegundoNum";
            this.lblSegundoNum.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNum.TabIndex = 1;
            this.lblSegundoNum.Text = "Segundo Número";
            // 
            // txtPrimeiroNum
            // 
            this.txtPrimeiroNum.Location = new System.Drawing.Point(153, 37);
            this.txtPrimeiroNum.Name = "txtPrimeiroNum";
            this.txtPrimeiroNum.Size = new System.Drawing.Size(117, 20);
            this.txtPrimeiroNum.TabIndex = 2;
            // 
            // txtSegundoNum
            // 
            this.txtSegundoNum.Location = new System.Drawing.Point(153, 89);
            this.txtSegundoNum.Name = "txtSegundoNum";
            this.txtSegundoNum.Size = new System.Drawing.Size(117, 20);
            this.txtSegundoNum.TabIndex = 3;
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(127, 204);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(152, 64);
            this.btnSorteio.TabIndex = 4;
            this.btnSorteio.Text = " Realizar Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtSegundoNum);
            this.Controls.Add(this.txtPrimeiroNum);
            this.Controls.Add(this.lblSegundoNum);
            this.Controls.Add(this.lblPrimeiroNum);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNum;
        private System.Windows.Forms.Label lblSegundoNum;
        private System.Windows.Forms.TextBox txtPrimeiroNum;
        private System.Windows.Forms.TextBox txtSegundoNum;
        private System.Windows.Forms.Button btnSorteio;
    }
}