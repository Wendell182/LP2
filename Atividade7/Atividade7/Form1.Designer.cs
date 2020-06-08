namespace Atividade7
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "ler 20 números e inverter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ler 20números e Inverter(Reverse)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(286, 254);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(112, 59);
            this.btnArrayList.TabIndex = 2;
            this.btnArrayList.Text = "array list";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Contando Caracteres";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(554, 107);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(112, 60);
            this.btnEx3.TabIndex = 4;
            this.btnEx3.Text = "ler quantidade e preço mercadorias";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(554, 254);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(112, 60);
            this.btnMatriz.TabIndex = 5;
            this.btnMatriz.Text = "Media Alunos";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Contar carcteres";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button button3;
    }
}

