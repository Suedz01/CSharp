namespace CadastroPessoas
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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            radioButton1 = new RadioButton();
            labelCPF = new Label();
            textBoxCPF = new TextBox();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            labelSalario = new Label();
            labelFilhos = new Label();
            textBoxNome = new TextBox();
            textBoxQtdFilhos = new TextBox();
            textBoxCidade = new TextBox();
            textBoxSalario = new TextBox();
            textBoxCNPJ = new TextBox();
            labelCNPJ = new Label();
            textBoxNomeFantasia = new TextBox();
            textBoxFaturamento = new TextBox();
            textBoxFuncionarios = new TextBox();
            labelNomeFantasia = new Label();
            labelFaturamento = new Label();
            labelFuncionarios = new Label();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(61, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(37, 57);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(28, 15);
            labelCPF.TabIndex = 1;
            labelCPF.Text = "CPF";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(105, 54);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(100, 23);
            textBoxCPF.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(191, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pessoa Jurídica";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 110);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Cidade";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(40, 162);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(42, 15);
            labelSalario.TabIndex = 7;
            labelSalario.Text = "Salario";
            // 
            // labelFilhos
            // 
            labelFilhos.AutoSize = true;
            labelFilhos.Location = new Point(38, 136);
            labelFilhos.Name = "labelFilhos";
            labelFilhos.Size = new Size(61, 15);
            labelFilhos.TabIndex = 6;
            labelFilhos.Text = "Qtd Filhos";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(105, 81);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(222, 23);
            textBoxNome.TabIndex = 8;
            // 
            // textBoxQtdFilhos
            // 
            textBoxQtdFilhos.Location = new Point(105, 133);
            textBoxQtdFilhos.Name = "textBoxQtdFilhos";
            textBoxQtdFilhos.Size = new Size(222, 23);
            textBoxQtdFilhos.TabIndex = 10;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(105, 107);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(222, 23);
            textBoxCidade.TabIndex = 9;
            // 
            // textBoxSalario
            // 
            textBoxSalario.Location = new Point(105, 159);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(222, 23);
            textBoxSalario.TabIndex = 11;
            // 
            // textBoxCNPJ
            // 
            textBoxCNPJ.Location = new Point(105, 54);
            textBoxCNPJ.Name = "textBoxCNPJ";
            textBoxCNPJ.Size = new Size(222, 23);
            textBoxCNPJ.TabIndex = 13;
            // 
            // labelCNPJ
            // 
            labelCNPJ.AutoSize = true;
            labelCNPJ.Location = new Point(37, 57);
            labelCNPJ.Name = "labelCNPJ";
            labelCNPJ.Size = new Size(34, 15);
            labelCNPJ.TabIndex = 12;
            labelCNPJ.Text = "CNPJ";
            // 
            // textBoxNomeFantasia
            // 
            textBoxNomeFantasia.Location = new Point(144, 194);
            textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            textBoxNomeFantasia.Size = new Size(183, 23);
            textBoxNomeFantasia.TabIndex = 23;
            // 
            // textBoxFaturamento
            // 
            textBoxFaturamento.Location = new Point(144, 165);
            textBoxFaturamento.Name = "textBoxFaturamento";
            textBoxFaturamento.Size = new Size(183, 23);
            textBoxFaturamento.TabIndex = 22;
            // 
            // textBoxFuncionarios
            // 
            textBoxFuncionarios.Location = new Point(144, 136);
            textBoxFuncionarios.Name = "textBoxFuncionarios";
            textBoxFuncionarios.Size = new Size(183, 23);
            textBoxFuncionarios.TabIndex = 21;
            // 
            // labelNomeFantasia
            // 
            labelNomeFantasia.AutoSize = true;
            labelNomeFantasia.Location = new Point(40, 188);
            labelNomeFantasia.Name = "labelNomeFantasia";
            labelNomeFantasia.Size = new Size(86, 15);
            labelNomeFantasia.TabIndex = 19;
            labelNomeFantasia.Text = "Nome Fantasia";
            // 
            // labelFaturamento
            // 
            labelFaturamento.AutoSize = true;
            labelFaturamento.Location = new Point(40, 165);
            labelFaturamento.Name = "labelFaturamento";
            labelFaturamento.Size = new Size(75, 15);
            labelFaturamento.TabIndex = 18;
            labelFaturamento.Text = "Faturamento";
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Location = new Point(40, 139);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(98, 15);
            labelFuncionarios.TabIndex = 17;
            labelFuncionarios.Text = "Qtd Funcionarios";
            // 
            // button1
            // 
            button1.Location = new Point(26, 231);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 24;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 231);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 25;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listView1.Location = new Point(12, 269);
            listView1.Name = "listView1";
            listView1.Size = new Size(315, 88);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listView2
            // 
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup2";
            listView2.Groups.AddRange(new ListViewGroup[] { listViewGroup3, listViewGroup4 });
            listView2.Location = new Point(15, 363);
            listView2.Name = "listView2";
            listView2.Size = new Size(315, 53);
            listView2.TabIndex = 27;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 439);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxNomeFantasia);
            Controls.Add(textBoxFaturamento);
            Controls.Add(textBoxFuncionarios);
            Controls.Add(labelNomeFantasia);
            Controls.Add(labelFaturamento);
            Controls.Add(labelFuncionarios);
            Controls.Add(textBoxCNPJ);
            Controls.Add(labelCNPJ);
            Controls.Add(textBoxSalario);
            Controls.Add(textBoxQtdFilhos);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxNome);
            Controls.Add(labelSalario);
            Controls.Add(labelFilhos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(textBoxCPF);
            Controls.Add(labelCPF);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private Label label1;
        private TextBox textBoxCPF;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNome;
        private TextBox textBoxQtdFilhos;
        private TextBox textBoxCidade;
        private TextBox textBoxSalario;
        private TextBox textBoxCNPJ;
        private Label labelCNPJ;
        private TextBox textBoxNomeFantasia;
        private TextBox textBoxFaturamento;
        private TextBox textBoxFuncionarios;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label labelCPF;
        private Label labelSalario;
        private Label labelFilhos;
        private Label labelNomeFantasia;
        private Label labelFaturamento;
        private Label labelFuncionarios;
        private ListView listView1;
        private ListView listView2;
    }
}