namespace ListaExercicios
{
    partial class Form8
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 54);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 9;
            label3.Text = "Informações: Todas do Aluno";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(433, 193);
            dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Aluno:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(383, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Histórico Escolar";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 342);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
    }
}