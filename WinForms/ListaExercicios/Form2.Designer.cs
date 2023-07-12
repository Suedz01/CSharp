namespace ListaExercicios
{
    partial class Form2
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
            btVoltar = new Button();
            rbCadastrarCursos = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            cbSecretaria = new ComboBox();
            btCadastrar = new Button();
            btLimpar = new Button();
            rbDisciplinas = new RadioButton();
            rbAlunos = new RadioButton();
            labelXXX = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            rbTurmas = new RadioButton();
            labelXXXXX = new Label();
            rbAlocacaoAlunos = new RadioButton();
            cbTurmaAloc = new ComboBox();
            rbSituacaoAlunos = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            btDiario = new Button();
            btHistorico = new Button();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 17);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(49, 23);
            btVoltar.TabIndex = 0;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += button1_Click;
            // 
            // rbCadastrarCursos
            // 
            rbCadastrarCursos.AutoSize = true;
            rbCadastrarCursos.Location = new Point(305, 67);
            rbCadastrarCursos.Name = "rbCadastrarCursos";
            rbCadastrarCursos.Size = new Size(56, 19);
            rbCadastrarCursos.TabIndex = 1;
            rbCadastrarCursos.TabStop = true;
            rbCadastrarCursos.Text = "Curso";
            rbCadastrarCursos.UseVisualStyleBackColor = true;
            rbCadastrarCursos.CheckedChanged += rbCadastrarCursos_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Descrição:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Coordenadores:";
            // 
            // cbSecretaria
            // 
            cbSecretaria.FormattingEnabled = true;
            cbSecretaria.Location = new Point(120, 120);
            cbSecretaria.Name = "cbSecretaria";
            cbSecretaria.Size = new Size(146, 23);
            cbSecretaria.TabIndex = 8;
            cbSecretaria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(14, 288);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(123, 23);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(143, 288);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(123, 23);
            btLimpar.TabIndex = 10;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // rbDisciplinas
            // 
            rbDisciplinas.AutoSize = true;
            rbDisciplinas.Location = new Point(305, 92);
            rbDisciplinas.Name = "rbDisciplinas";
            rbDisciplinas.Size = new Size(81, 19);
            rbDisciplinas.TabIndex = 11;
            rbDisciplinas.TabStop = true;
            rbDisciplinas.Text = "Disciplinas";
            rbDisciplinas.UseVisualStyleBackColor = true;
            rbDisciplinas.CheckedChanged += rbDisciplinas_CheckedChanged;
            // 
            // rbAlunos
            // 
            rbAlunos.AutoSize = true;
            rbAlunos.Location = new Point(305, 41);
            rbAlunos.Name = "rbAlunos";
            rbAlunos.Size = new Size(62, 19);
            rbAlunos.TabIndex = 12;
            rbAlunos.TabStop = true;
            rbAlunos.Text = "Alunos";
            rbAlunos.UseVisualStyleBackColor = true;
            rbAlunos.CheckedChanged += rbAlunos_CheckedChanged;
            // 
            // labelXXX
            // 
            labelXXX.AutoSize = true;
            labelXXX.Location = new Point(293, 17);
            labelXXX.Name = "labelXXX";
            labelXXX.Size = new Size(76, 15);
            labelXXX.TabIndex = 13;
            labelXXX.Text = "CADASTROS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 16;
            label4.Text = "Coordenadores:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 17;
            label5.Text = "Coordenadores:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 214);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 18;
            label6.Text = "Coordenadores:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 244);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 19;
            label7.Text = "Coordenadores:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(120, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(120, 240);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 23;
            // 
            // rbTurmas
            // 
            rbTurmas.AutoSize = true;
            rbTurmas.Location = new Point(305, 120);
            rbTurmas.Name = "rbTurmas";
            rbTurmas.Size = new Size(64, 19);
            rbTurmas.TabIndex = 24;
            rbTurmas.TabStop = true;
            rbTurmas.Text = "Turmas";
            rbTurmas.UseVisualStyleBackColor = true;
            rbTurmas.CheckedChanged += rbTurmas_CheckedChanged;
            // 
            // labelXXXXX
            // 
            labelXXXXX.AutoSize = true;
            labelXXXXX.Location = new Point(293, 184);
            labelXXXXX.Name = "labelXXXXX";
            labelXXXXX.Size = new Size(74, 15);
            labelXXXXX.TabIndex = 25;
            labelXXXXX.Text = "ALOCAÇÃO:";
            // 
            // rbAlocacaoAlunos
            // 
            rbAlocacaoAlunos.AutoSize = true;
            rbAlocacaoAlunos.Location = new Point(306, 204);
            rbAlocacaoAlunos.Name = "rbAlocacaoAlunos";
            rbAlocacaoAlunos.Size = new Size(62, 19);
            rbAlocacaoAlunos.TabIndex = 26;
            rbAlocacaoAlunos.TabStop = true;
            rbAlocacaoAlunos.Text = "Alunos";
            rbAlocacaoAlunos.UseVisualStyleBackColor = true;
            rbAlocacaoAlunos.CheckedChanged += rbAlocacaoAlunos_CheckedChanged;
            // 
            // cbTurmaAloc
            // 
            cbTurmaAloc.FormattingEnabled = true;
            cbTurmaAloc.Location = new Point(120, 181);
            cbTurmaAloc.Name = "cbTurmaAloc";
            cbTurmaAloc.Size = new Size(146, 23);
            cbTurmaAloc.TabIndex = 28;
            // 
            // rbSituacaoAlunos
            // 
            rbSituacaoAlunos.AutoSize = true;
            rbSituacaoAlunos.Location = new Point(305, 275);
            rbSituacaoAlunos.Name = "rbSituacaoAlunos";
            rbSituacaoAlunos.Size = new Size(62, 19);
            rbSituacaoAlunos.TabIndex = 30;
            rbSituacaoAlunos.TabStop = true;
            rbSituacaoAlunos.Text = "Alunos";
            rbSituacaoAlunos.UseVisualStyleBackColor = true;
            rbSituacaoAlunos.CheckedChanged += rbSituacaoAlunos_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(293, 248);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 29;
            label8.Text = "SITUAÇÃO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(99, 21);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 31;
            label9.Text = "MENU SECRETARIA";
            // 
            // btDiario
            // 
            btDiario.Location = new Point(14, 317);
            btDiario.Name = "btDiario";
            btDiario.Size = new Size(123, 30);
            btDiario.TabIndex = 32;
            btDiario.Text = "Diário de Classe";
            btDiario.UseVisualStyleBackColor = true;
            btDiario.Click += btDiario_Click;
            // 
            // btHistorico
            // 
            btHistorico.Location = new Point(143, 317);
            btHistorico.Name = "btHistorico";
            btHistorico.Size = new Size(123, 30);
            btHistorico.TabIndex = 33;
            btHistorico.Text = "Histórico Escolar";
            btHistorico.UseVisualStyleBackColor = true;
            btHistorico.Click += btHistorico_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 359);
            Controls.Add(btHistorico);
            Controls.Add(btDiario);
            Controls.Add(label9);
            Controls.Add(rbSituacaoAlunos);
            Controls.Add(label8);
            Controls.Add(cbTurmaAloc);
            Controls.Add(rbAlocacaoAlunos);
            Controls.Add(labelXXXXX);
            Controls.Add(rbTurmas);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelXXX);
            Controls.Add(rbAlunos);
            Controls.Add(rbDisciplinas);
            Controls.Add(btLimpar);
            Controls.Add(btCadastrar);
            Controls.Add(cbSecretaria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(rbCadastrarCursos);
            Controls.Add(btVoltar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVoltar;
        private RadioButton rbCadastrarCursos;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox cbSecretaria;
        private Button btCadastrar;
        private Button btLimpar;
        private RadioButton rbDisciplinas;
        private RadioButton rbAlunos;
        private Label labelXXX;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton rbTurmas;
        private Label labelXXXXX;
        private RadioButton rbAlocacaoAlunos;
        private ComboBox cbTurmaAloc;
        private RadioButton rbSituacaoAlunos;
        private Label label8;
        private Label label9;
        private Button btDiario;
        private Button btHistorico;
    }
}