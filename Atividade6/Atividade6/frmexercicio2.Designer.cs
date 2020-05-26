namespace Atividade6
{
    partial class frmexercicio2
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnGerarNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(232, 94);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(202, 20);
            this.txtNum.TabIndex = 0;
            // 
            // btnGerarNum
            // 
            this.btnGerarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarNum.Location = new System.Drawing.Point(232, 164);
            this.btnGerarNum.Name = "btnGerarNum";
            this.btnGerarNum.Size = new System.Drawing.Size(207, 85);
            this.btnGerarNum.TabIndex = 1;
            this.btnGerarNum.Text = "Gerar Número H";
            this.btnGerarNum.UseVisualStyleBackColor = true;
            this.btnGerarNum.Click += new System.EventHandler(this.btnGerarNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um valor N (maior que 0)";
            // 
            // frmexercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarNum);
            this.Controls.Add(this.txtNum);
            this.Name = "frmexercicio2";
            this.Text = "frmexercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnGerarNum;
        private System.Windows.Forms.Label label1;
    }
}