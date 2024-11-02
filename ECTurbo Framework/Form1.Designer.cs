namespace ECTurbo_Framework
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
            this.ecTurbo_TextBox1 = new ECTurbo_Framework.Controles.ECTurbo_TextBox();
            this.ecTurbo_Datas1 = new ECTurbo_Framework.Controles.ECTurbo_Datas();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ecTurbo_TextBox1
            // 
            this.ecTurbo_TextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ecTurbo_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ecTurbo_TextBox1.Location = new System.Drawing.Point(147, 82);
            this.ecTurbo_TextBox1.Name = "ecTurbo_TextBox1";
            this.ecTurbo_TextBox1.Size = new System.Drawing.Size(209, 37);
            this.ecTurbo_TextBox1.TabIndex = 0;
            // 
            // ecTurbo_Datas1
            // 
            this.ecTurbo_Datas1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ecTurbo_Datas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ecTurbo_Datas1.Location = new System.Drawing.Point(147, 152);
            this.ecTurbo_Datas1.Name = "ecTurbo_Datas1";
            this.ecTurbo_Datas1.Size = new System.Drawing.Size(209, 37);
            this.ecTurbo_Datas1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ecTurbo_Datas1);
            this.Controls.Add(this.ecTurbo_TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ECTurbo_TextBox ecTurbo_TextBox1;
        private Controles.ECTurbo_Datas ecTurbo_Datas1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

