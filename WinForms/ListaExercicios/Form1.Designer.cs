namespace ListaExercicios
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
            btSecretaria = new Button();
            label1 = new Label();
            label2 = new Label();
            btRH = new Button();
            btProfessores = new Button();
            btCoord = new Button();
            btAlunos = new Button();
            SuspendLayout();
            // 
            // btSecretaria
            // 
            btSecretaria.Location = new Point(53, 70);
            btSecretaria.Name = "btSecretaria";
            btSecretaria.Size = new Size(116, 23);
            btSecretaria.TabIndex = 0;
            btSecretaria.Text = "Secretaria";
            btSecretaria.UseVisualStyleBackColor = true;
            btSecretaria.Click += btSecretaria_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "TELA INICIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 39);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 2;
            label2.Text = "Acesse o software como";
            // 
            // btRH
            // 
            btRH.Location = new Point(53, 100);
            btRH.Name = "btRH";
            btRH.Size = new Size(116, 23);
            btRH.TabIndex = 3;
            btRH.Text = "RH";
            btRH.UseVisualStyleBackColor = true;
            btRH.Click += btRH_Click;
            // 
            // btProfessores
            // 
            btProfessores.Location = new Point(187, 100);
            btProfessores.Name = "btProfessores";
            btProfessores.Size = new Size(116, 23);
            btProfessores.TabIndex = 6;
            btProfessores.Text = "Professores";
            btProfessores.UseVisualStyleBackColor = true;
            btProfessores.Click += btProfessores_Click;
            // 
            // btCoord
            // 
            btCoord.Location = new Point(187, 70);
            btCoord.Name = "btCoord";
            btCoord.Size = new Size(116, 23);
            btCoord.TabIndex = 7;
            btCoord.Text = "Coordenadores";
            btCoord.UseVisualStyleBackColor = true;
            btCoord.Click += btCoord_Click;
            // 
            // btAlunos
            // 
            btAlunos.Location = new Point(53, 128);
            btAlunos.Name = "btAlunos";
            btAlunos.Size = new Size(250, 23);
            btAlunos.TabIndex = 8;
            btAlunos.Text = "Aluno";
            btAlunos.UseVisualStyleBackColor = true;
            btAlunos.Click += btAlunos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 165);
            Controls.Add(btAlunos);
            Controls.Add(btCoord);
            Controls.Add(btProfessores);
            Controls.Add(btRH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSecretaria);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSecretaria;
        private Label label1;
        private Label label2;
        private Button btRH;
        private Button button3;
        private Button button4;
        private Button btProfessores;
        private Button btCoord;
        private Button btAlunos;
    }
}