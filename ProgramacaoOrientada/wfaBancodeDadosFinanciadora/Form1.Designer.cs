namespace wfaBancodeDadosFinanciadora
{
    partial class dgvContas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(115, 125);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(77, 23);
            this.btInserir.TabIndex = 3;
            this.btInserir.Text = "INSERIR";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(30, 125);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(77, 23);
            this.btExibir.TabIndex = 4;
            this.btExibir.Text = "EXIBIR";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(198, 125);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(77, 23);
            this.btAtualizar.TabIndex = 5;
            this.btAtualizar.Text = "ATUALIZAR";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(281, 125);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(77, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(86, 56);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(271, 20);
            this.tbNome.TabIndex = 8;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(86, 89);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(271, 20);
            this.tbSalario.TabIndex = 9;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(32, 154);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(326, 105);
            this.dGV.TabIndex = 11;
            this.dGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseDoubleClick_1);
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(86, 22);
            this.tbCPF.Mask = "000,000,000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(271, 20);
            this.tbCPF.TabIndex = 12;
            // 
            // dgvContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 270);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dgvContas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.MaskedTextBox tbCPF;
    }
}

