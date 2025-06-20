namespace FinancialOperation
{
    partial class AddBudgets
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
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            clientsBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            budgetTypesBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            currenciesBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(121, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = clientsBindingSource;
            comboBox1.DisplayMember = "SurName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "Client_id";
            // 
            // clientsBindingSource
            // 
            clientsBindingSource.DataSource = typeof(Clients);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = budgetTypesBindingSource;
            comboBox2.DisplayMember = "Name";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(120, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 2;
            comboBox2.ValueMember = "BudgetType_id";
            // 
            // budgetTypesBindingSource
            // 
            budgetTypesBindingSource.DataSource = typeof(BudgetTypes);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.DataSource = currenciesBindingSource;
            comboBox3.DisplayMember = "Symbol";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(121, 157);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(199, 23);
            comboBox3.TabIndex = 5;
            comboBox3.ValueMember = "Currency_id";
            // 
            // currenciesBindingSource
            // 
            currenciesBindingSource.DataSource = typeof(Currencies);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(120, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(121, 215);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Enabled = false;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(121, 244);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(70, 273);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 273);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 10;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(70, 273);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 11;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 12;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 14;
            label3.Text = "Тип бюджета";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 15;
            label4.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 16;
            label5.Text = "Сумма";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 17;
            label6.Text = "Валюта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 186);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 18;
            label7.Text = "Дата начала";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 215);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 19;
            label8.Text = "Дата окончания";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(12, 244);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 20;
            label9.Text = "Дата добавления";
            // 
            // AddBudgets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 311);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AddBudgets";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Бюджет";
            Load += AddBudgets_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource clientsBindingSource;
        private BindingSource budgetTypesBindingSource;
        private BindingSource currenciesBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}