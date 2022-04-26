namespace WF_Pasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCriar = new System.Windows.Forms.Label();
            this.lblDeletar = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtCriar = new System.Windows.Forms.TextBox();
            this.txtDeletar = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCriar
            // 
            this.lblCriar.AutoSize = true;
            this.lblCriar.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriar.Location = new System.Drawing.Point(53, 18);
            this.lblCriar.Name = "lblCriar";
            this.lblCriar.Size = new System.Drawing.Size(167, 28);
            this.lblCriar.TabIndex = 0;
            this.lblCriar.Text = "Nome da Pasta a ser Criada";
            // 
            // lblDeletar
            // 
            this.lblDeletar.AutoSize = true;
            this.lblDeletar.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletar.Location = new System.Drawing.Point(53, 103);
            this.lblDeletar.Name = "lblDeletar";
            this.lblDeletar.Size = new System.Drawing.Size(179, 28);
            this.lblDeletar.TabIndex = 0;
            this.lblDeletar.Text = "Nome da Pasta a ser Deletada";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(52, 216);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(166, 28);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Nome do Arquivo Origem";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(53, 293);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(165, 28);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Nome do Arquivo Destino";
            // 
            // txtCriar
            // 
            this.txtCriar.Location = new System.Drawing.Point(58, 49);
            this.txtCriar.Name = "txtCriar";
            this.txtCriar.Size = new System.Drawing.Size(158, 20);
            this.txtCriar.TabIndex = 1;
            // 
            // txtDeletar
            // 
            this.txtDeletar.Location = new System.Drawing.Point(58, 134);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(158, 20);
            this.txtDeletar.TabIndex = 1;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(58, 247);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(158, 20);
            this.txtOrigem.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 20);
            this.textBox4.TabIndex = 1;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(249, 44);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 30);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(249, 129);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 30);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMover.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(249, 269);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 30);
            this.btnMover.TabIndex = 4;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 385);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.txtCriar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblDeletar);
            this.Controls.Add(this.lblCriar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriar;
        private System.Windows.Forms.Label lblDeletar;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtCriar;
        private System.Windows.Forms.TextBox txtDeletar;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnMover;
    }
}

