namespace Prova1
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
            foodRB = new RadioButton();
            healthRB = new RadioButton();
            cpfLabel = new Label();
            valorLabel = new Label();
            codigoLabel = new Label();
            cpfTB = new TextBox();
            valorTB = new TextBox();
            codigoTB = new TextBox();
            descricaoestabelecimentoTB = new TextBox();
            label1 = new Label();
            cadastroListView = new ListView();
            label3 = new Label();
            gravarBT = new Button();
            limparBT = new Button();
            SuspendLayout();
            // 
            // foodRB
            // 
            foodRB.AutoSize = true;
            foodRB.Location = new Point(26, 23);
            foodRB.Name = "foodRB";
            foodRB.Size = new Size(92, 19);
            foodRB.TabIndex = 0;
            foodRB.TabStop = true;
            foodRB.Text = "Alimentação";
            foodRB.UseVisualStyleBackColor = true;
            foodRB.CheckedChanged += foodRB_CheckedChanged;
            // 
            // healthRB
            // 
            healthRB.AutoSize = true;
            healthRB.Location = new Point(251, 23);
            healthRB.Name = "healthRB";
            healthRB.Size = new Size(57, 19);
            healthRB.TabIndex = 1;
            healthRB.TabStop = true;
            healthRB.Text = "Saúde";
            healthRB.UseVisualStyleBackColor = true;
            healthRB.CheckedChanged += healthRB_CheckedChanged;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new Point(25, 71);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(31, 15);
            cpfLabel.TabIndex = 2;
            cpfLabel.Text = "CPF:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new Point(25, 99);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(36, 15);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "Valor:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new Point(25, 127);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(49, 15);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Código:";
            // 
            // cpfTB
            // 
            cpfTB.Location = new Point(83, 68);
            cpfTB.Name = "cpfTB";
            cpfTB.Size = new Size(225, 23);
            cpfTB.TabIndex = 5;
            // 
            // valorTB
            // 
            valorTB.Location = new Point(83, 96);
            valorTB.Name = "valorTB";
            valorTB.Size = new Size(225, 23);
            valorTB.TabIndex = 6;
            // 
            // codigoTB
            // 
            codigoTB.Location = new Point(83, 124);
            codigoTB.Name = "codigoTB";
            codigoTB.Size = new Size(225, 23);
            codigoTB.TabIndex = 7;
            // 
            // descricaoestabelecimentoTB
            // 
            descricaoestabelecimentoTB.Location = new Point(127, 152);
            descricaoestabelecimentoTB.Name = "descricaoestabelecimentoTB";
            descricaoestabelecimentoTB.Size = new Size(181, 23);
            descricaoestabelecimentoTB.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 155);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Descrição:";
            // 
            // cadastroListView
            // 
            cadastroListView.Location = new Point(25, 225);
            cadastroListView.Name = "cadastroListView";
            cadastroListView.Size = new Size(417, 140);
            cadastroListView.TabIndex = 12;
            cadastroListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 13;
            label3.Text = "Items cadastrados:";
            // 
            // gravarBT
            // 
            gravarBT.Location = new Point(338, 68);
            gravarBT.Name = "gravarBT";
            gravarBT.Size = new Size(104, 69);
            gravarBT.TabIndex = 14;
            gravarBT.Text = "Gravar";
            gravarBT.UseVisualStyleBackColor = true;
            gravarBT.Click += gravarBT_Click;
            // 
            // limparBT
            // 
            limparBT.Location = new Point(338, 138);
            limparBT.Name = "limparBT";
            limparBT.Size = new Size(104, 32);
            limparBT.TabIndex = 15;
            limparBT.Text = "Limpar";
            limparBT.UseVisualStyleBackColor = true;
            limparBT.Click += limparBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 377);
            Controls.Add(limparBT);
            Controls.Add(gravarBT);
            Controls.Add(label3);
            Controls.Add(cadastroListView);
            Controls.Add(descricaoestabelecimentoTB);
            Controls.Add(label1);
            Controls.Add(codigoTB);
            Controls.Add(valorTB);
            Controls.Add(cpfTB);
            Controls.Add(codigoLabel);
            Controls.Add(valorLabel);
            Controls.Add(cpfLabel);
            Controls.Add(healthRB);
            Controls.Add(foodRB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton foodRB;
        private RadioButton healthRB;
        private Label cpfLabel;
        private Label valorLabel;
        private Label codigoLabel;
        private TextBox cpfTB;
        private TextBox valorTB;
        private TextBox codigoTB;
        private TextBox descricaoestabelecimentoTB;
        private Label label1;
        private ListView cadastroListView;
        private Label label3;
        private Button gravarBT;
        private Button limparBT;
    }
}