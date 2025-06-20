namespace FinancialOperation
{
    partial class AddPaymentRoutes
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
            accountsBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            accountsBindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(123, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = accountsBindingSource;
            comboBox1.DisplayMember = "Number";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "Account_id";
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Accounts);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = accountsBindingSource1;
            comboBox2.DisplayMember = "Number";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(123, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 2;
            comboBox2.ValueMember = "Account_id";
            // 
            // accountsBindingSource1
            // 
            accountsBindingSource1.DataSource = typeof(Accounts);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(123, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(70, 186);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 186);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 7;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Счет отправитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 10;
            label3.Text = "Счет получатель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Сумма";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата добавления";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 13;
            label6.Text = "Описание";
            // 
            // AddPaymentRoutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 231);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddPaymentRoutes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Платежный маршрут";
            Load += AddPaymentRoutes_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private BindingSource accountsBindingSource;
        private BindingSource accountsBindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}