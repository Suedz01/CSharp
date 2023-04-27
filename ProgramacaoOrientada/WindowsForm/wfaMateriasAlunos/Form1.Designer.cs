namespace wfaMateriasAlunos
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
            tabMATRICULA = new TabPage();
            buttonRelatorioMatricula = new Button();
            buttonGravarMatricula = new Button();
            groupBoxListaAlunos = new GroupBox();
            groupBoxListaMaterias = new GroupBox();
            textBoxAlunoMatricula = new TextBox();
            textBoxMateriaMatricula = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabALUNO = new TabPage();
            buttonAluno = new Button();
            textBoxPeriodo = new TextBox();
            textBoxNumeroMatricula = new TextBox();
            textBoxNomeAluno = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabMateria = new TabPage();
            buttonMateria = new Button();
            textBoxCodigoMateria = new TextBox();
            textBoxNomeMateria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabControlAlunoMateria = new TabControl();
            tabMATRICULA.SuspendLayout();
            tabALUNO.SuspendLayout();
            tabMateria.SuspendLayout();
            tabControlAlunoMateria.SuspendLayout();
            SuspendLayout();
            // 
            // tabMATRICULA
            // 
            tabMATRICULA.Controls.Add(buttonRelatorioMatricula);
            tabMATRICULA.Controls.Add(buttonGravarMatricula);
            tabMATRICULA.Controls.Add(groupBoxListaAlunos);
            tabMATRICULA.Controls.Add(groupBoxListaMaterias);
            tabMATRICULA.Controls.Add(textBoxAlunoMatricula);
            tabMATRICULA.Controls.Add(textBoxMateriaMatricula);
            tabMATRICULA.Controls.Add(label7);
            tabMATRICULA.Controls.Add(label6);
            tabMATRICULA.Location = new Point(4, 24);
            tabMATRICULA.Name = "tabMATRICULA";
            tabMATRICULA.Size = new Size(608, 241);
            tabMATRICULA.TabIndex = 2;
            tabMATRICULA.Text = "Matrícula";
            tabMATRICULA.UseVisualStyleBackColor = true;
            // 
            // buttonRelatorioMatricula
            // 
            buttonRelatorioMatricula.Location = new Point(479, 37);
            buttonRelatorioMatricula.Name = "buttonRelatorioMatricula";
            buttonRelatorioMatricula.Size = new Size(75, 67);
            buttonRelatorioMatricula.TabIndex = 7;
            buttonRelatorioMatricula.Text = "Relatório";
            buttonRelatorioMatricula.UseVisualStyleBackColor = true;
            buttonRelatorioMatricula.Click += buttonRelatorioMatricula_Click;
            // 
            // buttonGravarMatricula
            // 
            buttonGravarMatricula.Location = new Point(389, 37);
            buttonGravarMatricula.Name = "buttonGravarMatricula";
            buttonGravarMatricula.Size = new Size(75, 67);
            buttonGravarMatricula.TabIndex = 4;
            buttonGravarMatricula.Text = "Gravar";
            buttonGravarMatricula.UseVisualStyleBackColor = true;
            buttonGravarMatricula.Click += buttonGravarMatricula_Click;
            // 
            // groupBoxListaAlunos
            // 
            groupBoxListaAlunos.Location = new Point(354, 123);
            groupBoxListaAlunos.Name = "groupBoxListaAlunos";
            groupBoxListaAlunos.Size = new Size(200, 100);
            groupBoxListaAlunos.TabIndex = 6;
            groupBoxListaAlunos.TabStop = false;
            groupBoxListaAlunos.Text = "Lista de Alunos:";
            groupBoxListaAlunos.Enter += groupBoxListaAlunos_Enter;
            // 
            // groupBoxListaMaterias
            // 
            groupBoxListaMaterias.Location = new Point(70, 123);
            groupBoxListaMaterias.Name = "groupBoxListaMaterias";
            groupBoxListaMaterias.Size = new Size(200, 100);
            groupBoxListaMaterias.TabIndex = 5;
            groupBoxListaMaterias.TabStop = false;
            groupBoxListaMaterias.Text = "Lista de Materias";
            // 
            // textBoxAlunoMatricula
            // 
            textBoxAlunoMatricula.Location = new Point(186, 37);
            textBoxAlunoMatricula.Name = "textBoxAlunoMatricula";
            textBoxAlunoMatricula.Size = new Size(170, 23);
            textBoxAlunoMatricula.TabIndex = 3;
            textBoxAlunoMatricula.TextChanged += textBoxAlunoMatricula_TextChanged;
            // 
            // textBoxMateriaMatricula
            // 
            textBoxMateriaMatricula.Location = new Point(186, 81);
            textBoxMateriaMatricula.Name = "textBoxMateriaMatricula";
            textBoxMateriaMatricula.Size = new Size(170, 23);
            textBoxMateriaMatricula.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 84);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 1;
            label7.Text = "Nome da Matéria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 40);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 0;
            label6.Text = "Nome do Aluno:";
            // 
            // tabALUNO
            // 
            tabALUNO.Controls.Add(buttonAluno);
            tabALUNO.Controls.Add(textBoxPeriodo);
            tabALUNO.Controls.Add(textBoxNumeroMatricula);
            tabALUNO.Controls.Add(textBoxNomeAluno);
            tabALUNO.Controls.Add(label5);
            tabALUNO.Controls.Add(label4);
            tabALUNO.Controls.Add(label3);
            tabALUNO.Location = new Point(4, 24);
            tabALUNO.Name = "tabALUNO";
            tabALUNO.Padding = new Padding(3);
            tabALUNO.Size = new Size(608, 241);
            tabALUNO.TabIndex = 1;
            tabALUNO.Text = "Aluno";
            tabALUNO.UseVisualStyleBackColor = true;
            // 
            // buttonAluno
            // 
            buttonAluno.Location = new Point(422, 58);
            buttonAluno.Name = "buttonAluno";
            buttonAluno.Size = new Size(120, 61);
            buttonAluno.TabIndex = 6;
            buttonAluno.Text = "Gravar";
            buttonAluno.UseVisualStyleBackColor = true;
            buttonAluno.Click += buttonAluno_Click;
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.Location = new Point(131, 120);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.Size = new Size(239, 23);
            textBoxPeriodo.TabIndex = 5;
            // 
            // textBoxNumeroMatricula
            // 
            textBoxNumeroMatricula.Location = new Point(131, 78);
            textBoxNumeroMatricula.Name = "textBoxNumeroMatricula";
            textBoxNumeroMatricula.Size = new Size(239, 23);
            textBoxNumeroMatricula.TabIndex = 4;
            // 
            // textBoxNomeAluno
            // 
            textBoxNomeAluno.Location = new Point(131, 36);
            textBoxNomeAluno.Name = "textBoxNomeAluno";
            textBoxNomeAluno.Size = new Size(239, 23);
            textBoxNomeAluno.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 123);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 2;
            label5.Text = "Período:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 81);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 1;
            label4.Text = "Nº matrícula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 39);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // tabMateria
            // 
            tabMateria.Controls.Add(buttonMateria);
            tabMateria.Controls.Add(textBoxCodigoMateria);
            tabMateria.Controls.Add(textBoxNomeMateria);
            tabMateria.Controls.Add(label2);
            tabMateria.Controls.Add(label1);
            tabMateria.Location = new Point(4, 24);
            tabMateria.Name = "tabMateria";
            tabMateria.Padding = new Padding(3);
            tabMateria.Size = new Size(608, 241);
            tabMateria.TabIndex = 0;
            tabMateria.Text = "Matéria";
            tabMateria.UseVisualStyleBackColor = true;
            // 
            // buttonMateria
            // 
            buttonMateria.Location = new Point(425, 54);
            buttonMateria.Name = "buttonMateria";
            buttonMateria.Size = new Size(140, 49);
            buttonMateria.TabIndex = 4;
            buttonMateria.Text = "Gravar";
            buttonMateria.UseVisualStyleBackColor = true;
            buttonMateria.Click += buttonMateria_Click;
            // 
            // textBoxCodigoMateria
            // 
            textBoxCodigoMateria.Location = new Point(91, 98);
            textBoxCodigoMateria.Name = "textBoxCodigoMateria";
            textBoxCodigoMateria.Size = new Size(307, 23);
            textBoxCodigoMateria.TabIndex = 3;
            // 
            // textBoxNomeMateria
            // 
            textBoxNomeMateria.Location = new Point(91, 38);
            textBoxNomeMateria.Name = "textBoxNomeMateria";
            textBoxNomeMateria.Size = new Size(307, 23);
            textBoxNomeMateria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tabControlAlunoMateria
            // 
            tabControlAlunoMateria.Controls.Add(tabMateria);
            tabControlAlunoMateria.Controls.Add(tabALUNO);
            tabControlAlunoMateria.Controls.Add(tabMATRICULA);
            tabControlAlunoMateria.Location = new Point(12, 12);
            tabControlAlunoMateria.Name = "tabControlAlunoMateria";
            tabControlAlunoMateria.SelectedIndex = 0;
            tabControlAlunoMateria.Size = new Size(616, 269);
            tabControlAlunoMateria.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 293);
            Controls.Add(tabControlAlunoMateria);
            Name = "Form1";
            Text = "Cadastro de Alunos e Matérias";
            tabMATRICULA.ResumeLayout(false);
            tabMATRICULA.PerformLayout();
            tabALUNO.ResumeLayout(false);
            tabALUNO.PerformLayout();
            tabMateria.ResumeLayout(false);
            tabMateria.PerformLayout();
            tabControlAlunoMateria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabMATRICULA;
        private Button buttonRelatorioMatricula;
        private Button buttonGravarMatricula;
        private GroupBox groupBoxListaAlunos;
        private GroupBox groupBoxListaMaterias;
        private TextBox textBoxAlunoMatricula;
        private TextBox textBoxMateriaMatricula;
        private Label label7;
        private Label label6;
        private TabPage tabALUNO;
        private Button buttonAluno;
        private TextBox textBoxPeriodo;
        private TextBox textBoxNumeroMatricula;
        private TextBox textBoxNomeAluno;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabMateria;
        private Button buttonMateria;
        private TextBox textBoxCodigoMateria;
        private TextBox textBoxNomeMateria;
        private Label label2;
        private Label label1;
        private TabControl tabControlAlunoMateria;
    }
}