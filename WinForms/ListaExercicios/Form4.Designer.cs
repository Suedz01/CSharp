namespace ListaExercicios
{
    partial class Form4
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
            button1 = new Button();
            btLimpar = new Button();
            btCadastrar = new Button();
            btVoltar = new Button();
            label6 = new Label();
            cbTurmasCoord = new ComboBox();
            label2 = new Label();
            cbProfessoresCoord = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(178, 242);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 19;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(93, 242);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(82, 23);
            btLimpar.TabIndex = 18;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(8, 242);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(82, 23);
            btCadastrar.TabIndex = 17;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 12);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(49, 23);
            btVoltar.TabIndex = 16;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 16);
            label6.Name = "label6";
            label6.Size = new Size(166, 15);
            label6.TabIndex = 45;
            label6.Text = "ALOCAÇÃO DE PROFESSORES";
            // 
            // cbTurmasCoord
            // 
            cbTurmasCoord.FormattingEnabled = true;
            cbTurmasCoord.Location = new Point(115, 141);
            cbTurmasCoord.Name = "cbTurmasCoord";
            cbTurmasCoord.Size = new Size(144, 23);
            cbTurmasCoord.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 43;
            label2.Text = "Turma:";
            // 
            // cbProfessoresCoord
            // 
            cbProfessoresCoord.FormattingEnabled = true;
            cbProfessoresCoord.Location = new Point(115, 64);
            cbProfessoresCoord.Name = "cbProfessoresCoord";
            cbProfessoresCoord.Size = new Size(144, 23);
            cbProfessoresCoord.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 41;
            label1.Text = "Professor:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 277);
            Controls.Add(label6);
            Controls.Add(cbTurmasCoord);
            Controls.Add(label2);
            Controls.Add(cbProfessoresCoord);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(btVoltar);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btLimpar;
        private Button btCadastrar;
        private Button btVoltar;
        private Label label6;
        private ComboBox cbTurmasCoord;
        private Label label2;
        private ComboBox cbProfessoresCoord;
        private Label label1;
    }
}