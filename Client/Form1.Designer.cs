namespace Client
{
    partial class Client
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btCadastro = new System.Windows.Forms.Button();
            this.lbSayHello = new System.Windows.Forms.Label();
            this.lbGetTime = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(12, 11);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nome:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(60, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 20);
            this.tbName.TabIndex = 1;
            // 
            // btCadastro
            // 
            this.btCadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.btCadastro.Location = new System.Drawing.Point(161, 38);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(75, 23);
            this.btCadastro.TabIndex = 2;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtCadastro_MouseClick);
            // 
            // lbSayHello
            // 
            this.lbSayHello.Location = new System.Drawing.Point(12, 64);
            this.lbSayHello.Name = "lbSayHello";
            this.lbSayHello.Size = new System.Drawing.Size(224, 26);
            this.lbSayHello.TabIndex = 0;
            this.lbSayHello.Text = "xxxxx";
            this.lbSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSayHello.Visible = false;
            // 
            // lbGetTime
            // 
            this.lbGetTime.Location = new System.Drawing.Point(35, 105);
            this.lbGetTime.Name = "lbGetTime";
            this.lbGetTime.Size = new System.Drawing.Size(133, 26);
            this.lbGetTime.TabIndex = 0;
            this.lbGetTime.Text = "Horário do ultimo cadastro:";
            this.lbGetTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGetTime.Visible = false;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(174, 112);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(55, 13);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "xx : xx : xx";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHora.Visible = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 158);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbGetTime);
            this.Controls.Add(this.lbSayHello);
            this.Controls.Add(this.lbName);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Label lbSayHello;
        private System.Windows.Forms.Label lbGetTime;
        private System.Windows.Forms.Label lbHora;
    }
}

