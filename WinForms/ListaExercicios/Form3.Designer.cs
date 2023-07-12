namespace ListaExercicios
{
    partial class Form3
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
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cbCursoRH = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            btLimpar = new Button();
            btCadastrar = new Button();
            btVoltar = new Button();
            cbTitulacaoRH = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 30;
            label5.Text = "Titulação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 29;
            label4.Text = "Telefone:";
            // 
            // cbCursoRH
            // 
            cbCursoRH.FormattingEnabled = true;
            cbCursoRH.Location = new Point(122, 117);
            cbCursoRH.Name = "cbCursoRH";
            cbCursoRH.Size = new Size(144, 23);
            cbCursoRH.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 27;
            label3.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 26;
            label2.Text = "Endereço:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 24;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(182, 222);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 38;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(97, 222);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(82, 23);
            btLimpar.TabIndex = 37;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 222);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(82, 23);
            btCadastrar.TabIndex = 36;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 12);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(49, 23);
            btVoltar.TabIndex = 35;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // cbTitulacaoRH
            // 
            cbTitulacaoRH.FormattingEnabled = true;
            cbTitulacaoRH.Items.AddRange(new object[] { "Graduado", "Especialização", "Mestrado", "Doutorado" });
            cbTitulacaoRH.Location = new Point(122, 178);
            cbTitulacaoRH.Name = "cbTitulacaoRH";
            cbTitulacaoRH.Size = new Size(144, 23);
            cbTitulacaoRH.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 16);
            label6.Name = "label6";
            label6.Size = new Size(170, 15);
            label6.TabIndex = 40;
            label6.Text = "CADASTRANDO PROFESSORES";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 268);
            Controls.Add(label6);
            Controls.Add(cbTitulacaoRH);
            Controls.Add(button1);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(btVoltar);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbCursoRH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbCursoRH;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button btLimpar;
        private Button btCadastrar;
        private Button btVoltar;
        private ComboBox cbTitulacaoRH;
    }
}