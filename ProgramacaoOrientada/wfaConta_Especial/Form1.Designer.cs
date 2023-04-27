namespace wfaConta_Especial
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
            label1 = new Label();
            textBoxNConta = new TextBox();
            radioButtonConta = new RadioButton();
            buttonGravar = new Button();
            radioButtonContaEspecial = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            textBoxSaldo = new TextBox();
            textBoxLimite = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero da Conta:";
            // 
            // textBoxNConta
            // 
            textBoxNConta.Location = new Point(123, 49);
            textBoxNConta.Name = "textBoxNConta";
            textBoxNConta.Size = new Size(199, 23);
            textBoxNConta.TabIndex = 1;
            // 
            // radioButtonConta
            // 
            radioButtonConta.AutoSize = true;
            radioButtonConta.Location = new Point(60, 12);
            radioButtonConta.Name = "radioButtonConta";
            radioButtonConta.Size = new Size(57, 19);
            radioButtonConta.TabIndex = 2;
            radioButtonConta.TabStop = true;
            radioButtonConta.Text = "Conta";
            radioButtonConta.UseVisualStyleBackColor = true;
            radioButtonConta.CheckedChanged += radioButtonConta_CheckedChanged;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(12, 176);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(310, 49);
            buttonGravar.TabIndex = 3;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // radioButtonContaEspecial
            // 
            radioButtonContaEspecial.AutoSize = true;
            radioButtonContaEspecial.Location = new Point(179, 12);
            radioButtonContaEspecial.Name = "radioButtonContaEspecial";
            radioButtonContaEspecial.Size = new Size(102, 19);
            radioButtonContaEspecial.TabIndex = 4;
            radioButtonContaEspecial.TabStop = true;
            radioButtonContaEspecial.Text = "Conta Especial";
            radioButtonContaEspecial.UseVisualStyleBackColor = true;
            radioButtonContaEspecial.CheckedChanged += radioButtonContaEspecial_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Saldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Limite:";
            // 
            // textBoxSaldo
            // 
            textBoxSaldo.Location = new Point(72, 87);
            textBoxSaldo.Name = "textBoxSaldo";
            textBoxSaldo.Size = new Size(250, 23);
            textBoxSaldo.TabIndex = 7;
            // 
            // textBoxLimite
            // 
            textBoxLimite.Location = new Point(72, 134);
            textBoxLimite.Name = "textBoxLimite";
            textBoxLimite.Size = new Size(250, 23);
            textBoxLimite.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 248);
            Controls.Add(textBoxLimite);
            Controls.Add(textBoxSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButtonContaEspecial);
            Controls.Add(buttonGravar);
            Controls.Add(radioButtonConta);
            Controls.Add(textBoxNConta);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNConta;
        private RadioButton radioButtonConta;
        private Button buttonGravar;
        private RadioButton radioButtonContaEspecial;
        private Label label2;
        private Label label3;
        private TextBox textBoxSaldo;
        private TextBox textBoxLimite;
    }
}