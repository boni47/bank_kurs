namespace FinancialOperation
{
    partial class AddAccounts
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
            accountsBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            accountTypesBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            currenciesBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountTypesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(138, 16);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(229, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = clientsBindingSource;
            comboBox1.DisplayMember = "SurName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 55);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "Client_id";
            // 
            // clientsBindingSource
            // 
            clientsBindingSource.DataSource = typeof(Clients);
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Accounts);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(151, 248);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DataSource = accountTypesBindingSource;
            comboBox2.DisplayMember = "Name";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(138, 93);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 28);
            comboBox2.TabIndex = 3;
            comboBox2.ValueMember = "AccountType_id";
            // 
            // accountTypesBindingSource
            // 
            accountTypesBindingSource.DataSource = typeof(AccountTypes);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 132);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 171);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.DataSource = currenciesBindingSource;
            comboBox3.DisplayMember = "Symbol";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(137, 209);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(229, 28);
            comboBox3.TabIndex = 6;
            comboBox3.ValueMember = "Currency_id";
            // 
            // currenciesBindingSource
            // 
            currenciesBindingSource.DataSource = typeof(Currencies);
            // 
            // button1
            // 
            button1.Location = new Point(80, 287);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(201, 287);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 40);
            button2.TabIndex = 8;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(80, 287);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 40);
            button3.TabIndex = 9;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 10;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(14, 93);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 12;
            label3.Text = "Тип счета";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(14, 132);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 13;
            label4.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(14, 171);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Баланс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 209);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 15;
            label6.Text = "Тип валюты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(14, 248);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 16;
            label7.Text = "Дата добавления";
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 361);
            ControlBox = false;
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
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAccounts";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Счет";
            Load += AddAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountTypesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private BindingSource clientsBindingSource;
        private BindingSource accountsBindingSource;
        private BindingSource accountTypesBindingSource;
        private BindingSource currenciesBindingSource;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}