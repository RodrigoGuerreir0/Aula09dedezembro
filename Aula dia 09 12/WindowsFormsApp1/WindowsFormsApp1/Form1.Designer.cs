namespace WindowsFormsApp1
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
            this.botao1 = new System.Windows.Forms.Button();
            this.menssagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.ForeColor = System.Drawing.Color.Black;
            this.botao1.Location = new System.Drawing.Point(42, 105);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(168, 63);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Clique Aqui";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // menssagem1
            // 
            this.menssagem1.AutoSize = true;
            this.menssagem1.Location = new System.Drawing.Point(39, 185);
            this.menssagem1.Name = "menssagem1";
            this.menssagem1.Size = new System.Drawing.Size(35, 13);
            this.menssagem1.TabIndex = 1;
            this.menssagem1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 746);
            this.Controls.Add(this.menssagem1);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label menssagem1;
    }
}

