namespace ListaExercicios
{
    partial class Form6
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
            cbAlunoProf = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            btVoltar = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            rbAprovado = new RadioButton();
            rbReprovado = new RadioButton();
            SuspendLayout();
            // 
            // cbAlunoProf
            // 
            cbAlunoProf.FormattingEnabled = true;
            cbAlunoProf.Location = new Point(93, 57);
            cbAlunoProf.Name = "cbAlunoProf";
            cbAlunoProf.Size = new Size(173, 23);
            cbAlunoProf.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 33;
            label3.Text = "Aluno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 16);
            label7.Name = "label7";
            label7.Size = new Size(140, 15);
            label7.TabIndex = 36;
            label7.Text = "ANÁLISE DE AVALIAÇÕES";
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
            // textBox4
            // 
            textBox4.Location = new Point(93, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 23);
            textBox4.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 192);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 42;
            label6.Text = "Frequência:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 164);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 40;
            label5.Text = "Prova Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 39;
            label4.Text = "P1/P2:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 23);
            textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 37;
            // 
            // rbAprovado
            // 
            rbAprovado.AutoCheck = false;
            rbAprovado.AutoSize = true;
            rbAprovado.Location = new Point(63, 228);
            rbAprovado.Name = "rbAprovado";
            rbAprovado.Size = new Size(77, 19);
            rbAprovado.TabIndex = 44;
            rbAprovado.TabStop = true;
            rbAprovado.Text = "Aprovado";
            rbAprovado.UseVisualStyleBackColor = true;
            // 
            // rbReprovado
            // 
            rbReprovado.AutoCheck = false;
            rbReprovado.AutoSize = true;
            rbReprovado.Location = new Point(164, 228);
            rbReprovado.Name = "rbReprovado";
            rbReprovado.Size = new Size(82, 19);
            rbReprovado.TabIndex = 45;
            rbReprovado.TabStop = true;
            rbReprovado.Text = "Reprovado";
            rbReprovado.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 270);
            Controls.Add(rbReprovado);
            Controls.Add(rbAprovado);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btVoltar);
            Controls.Add(cbAlunoProf);
            Controls.Add(label3);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAlunoProf;
        private Label label3;
        private Label label7;
        private Button btVoltar;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton rbAprovado;
        private RadioButton rbReprovado;
    }
}