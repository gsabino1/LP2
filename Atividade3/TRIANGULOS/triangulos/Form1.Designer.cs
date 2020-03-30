namespace triangulos
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
            this.lblLadoA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnValida = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(12, 15);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(100, 13);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Tamanho do lado A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(137, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(68, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(12, 41);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(100, 13);
            this.lblLadoB.TabIndex = 2;
            this.lblLadoB.Text = "Tamanho do lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(12, 67);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(100, 13);
            this.lblLadoC.TabIndex = 3;
            this.lblLadoC.Text = "Tamanho do lado C";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(137, 64);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(68, 20);
            this.txtC.TabIndex = 3;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(137, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(68, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // btnValida
            // 
            this.btnValida.Location = new System.Drawing.Point(211, 12);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(75, 72);
            this.btnValida.TabIndex = 4;
            this.btnValida.Text = "Valida";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(15, 106);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(190, 20);
            this.txtRes.TabIndex = 0;
            this.txtRes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 144);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnValida);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblLadoA);
            this.Name = "Form1";
            this.Text = "Validação de trinangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.TextBox txtRes;
    }
}

