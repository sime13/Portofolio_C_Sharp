namespace ProjetoPesoIdeal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textAltura = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btnPesoIdeal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textAltura
            // 
            this.textAltura.BackColor = System.Drawing.Color.NavajoWhite;
            this.textAltura.Location = new System.Drawing.Point(43, 210);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(226, 32);
            this.textAltura.TabIndex = 1;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminin",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(47, 285);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(148, 33);
            this.cmbSexo.TabIndex = 2;
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.NavajoWhite;
            this.textNome.Location = new System.Drawing.Point(47, 147);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(224, 32);
            this.textNome.TabIndex = 3;
            // 
            // btnPesoIdeal
            // 
            this.btnPesoIdeal.BackColor = System.Drawing.Color.Gray;
            this.btnPesoIdeal.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPesoIdeal.Location = new System.Drawing.Point(47, 360);
            this.btnPesoIdeal.Name = "btnPesoIdeal";
            this.btnPesoIdeal.Size = new System.Drawing.Size(148, 36);
            this.btnPesoIdeal.TabIndex = 4;
            this.btnPesoIdeal.Text = "&Peso Ideal";
            this.btnPesoIdeal.UseVisualStyleBackColor = false;
            this.btnPesoIdeal.Click += new System.EventHandler(this.btnPesoIdeal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLimpar.Location = new System.Drawing.Point(65, 403);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 37);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSair.Location = new System.Drawing.Point(64, 446);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Nome.Location = new System.Drawing.Point(46, 119);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(63, 25);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Altura.Location = new System.Drawing.Point(46, 182);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(63, 25);
            this.Altura.TabIndex = 7;
            this.Altura.Text = "Altura";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.BackColor = System.Drawing.Color.DarkGray;
            this.Sexo.ForeColor = System.Drawing.Color.Black;
            this.Sexo.Location = new System.Drawing.Point(47, 257);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(52, 25);
            this.Sexo.TabIndex = 7;
            this.Sexo.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 648);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesoIdeal);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.textAltura);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btnPesoIdeal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtAltura;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}
