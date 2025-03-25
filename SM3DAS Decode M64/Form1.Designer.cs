namespace SM3DAS_Decode_M64
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
            this.button_Decode = new System.Windows.Forms.Button();
            this.button_Encode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Decode
            // 
            this.button_Decode.Location = new System.Drawing.Point(12, 12);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(75, 23);
            this.button_Decode.TabIndex = 0;
            this.button_Decode.Text = "Decode";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // button_Encode
            // 
            this.button_Encode.Enabled = false;
            this.button_Encode.Location = new System.Drawing.Point(93, 12);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(75, 23);
            this.button_Encode.TabIndex = 1;
            this.button_Encode.Text = "Encode";
            this.button_Encode.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1641, 702);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 756);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Encode);
            this.Controls.Add(this.button_Decode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM3DAS Decode M64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Decode;
        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.TextBox textBox1;
    }
}

