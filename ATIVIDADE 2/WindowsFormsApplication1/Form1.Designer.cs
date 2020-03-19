namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtSitu = new System.Windows.Forms.TextBox();
            this.lblSitu = new System.Windows.Forms.Label();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 13);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFem);
            this.gpbSexo.Controls.Add(this.rdbMasc);
            this.gpbSexo.Location = new System.Drawing.Point(15, 62);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(91, 55);
            this.gpbSexo.TabIndex = 2;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(6, 32);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(67, 17);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(6, 13);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(111, 67);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(51, 50);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calcula";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 39);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // txtSitu
            // 
            this.txtSitu.Location = new System.Drawing.Point(12, 192);
            this.txtSitu.Name = "txtSitu";
            this.txtSitu.ReadOnly = true;
            this.txtSitu.Size = new System.Drawing.Size(165, 20);
            this.txtSitu.TabIndex = 8;
            // 
            // lblSitu
            // 
            this.lblSitu.AutoSize = true;
            this.lblSitu.Location = new System.Drawing.Point(12, 176);
            this.lblSitu.Name = "lblSitu";
            this.lblSitu.Size = new System.Drawing.Size(52, 13);
            this.lblSitu.TabIndex = 7;
            this.lblSitu.Text = "Situação:";
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Location = new System.Drawing.Point(92, 146);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.ReadOnly = true;
            this.txtPesoIdeal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPesoIdeal.Size = new System.Drawing.Size(70, 20);
            this.txtPesoIdeal.TabIndex = 6;
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(12, 149);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(56, 13);
            this.lblPesoIdeal.TabIndex = 5;
            this.lblPesoIdeal.Text = "Peso ideal";
            // 
            // txtAltura
            // 
            this.txtAltura.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtAltura.Location = new System.Drawing.Point(92, 10);
            this.txtAltura.Mask = "0,00";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(70, 20);
            this.txtAltura.TabIndex = 9;
            this.txtAltura.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtPeso
            // 
            this.txtPeso.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtPeso.Location = new System.Drawing.Point(92, 36);
            this.txtPeso.Mask = "000,00";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(70, 20);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 227);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtSitu);
            this.Controls.Add(this.lblSitu);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtSitu;
        private System.Windows.Forms.Label lblSitu;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.MaskedTextBox txtPeso;
    }
}

