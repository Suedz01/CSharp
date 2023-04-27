namespace CadastroDeMateriais
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
            buttonGravar = new Button();
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            textBoxCodigo = new TextBox();
            textBoxTerminal = new TextBox();
            buttonRelatorio = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(26, 83);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(136, 23);
            buttonGravar.TabIndex = 0;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(89, 15);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(158, 23);
            textBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(89, 44);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(158, 23);
            textBoxCodigo.TabIndex = 4;
            // 
            // textBoxTerminal
            // 
            textBoxTerminal.Location = new Point(26, 135);
            textBoxTerminal.Multiline = true;
            textBoxTerminal.Name = "textBoxTerminal";
            textBoxTerminal.Size = new Size(221, 165);
            textBoxTerminal.TabIndex = 5;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Location = new Point(172, 83);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(75, 23);
            buttonRelatorio.TabIndex = 6;
            buttonRelatorio.Text = "Relatório";
            buttonRelatorio.UseVisualStyleBackColor = true;
            buttonRelatorio.Click += buttonRelatorio_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 117);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Terminal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 324);
            Controls.Add(label3);
            Controls.Add(buttonRelatorio);
            Controls.Add(textBoxTerminal);
            Controls.Add(textBoxCodigo);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(buttonGravar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGravar;
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxCodigo;
        private TextBox textBoxTerminal;
        private Button buttonRelatorio;
        private Label label3;
    }
}