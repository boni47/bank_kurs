namespace FinancialOperation
{
    partial class UserControlPaymentRoutes
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            paymentRouteidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountFromidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            accountsBindingSource = new BindingSource(components);
            accountToidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            additionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentRoutesBindingSource = new BindingSource(components);
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRoutesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.ForeColor = Color.Black;
            toolStripButton1.Image = Properties.Resources.business_network_globe_money_international_transfer_icon_188755;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(245, 22);
            toolStripButton1.Text = "Осуществить платежный маршрут";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { paymentRouteidDataGridViewTextBoxColumn, accountFromidDataGridViewTextBoxColumn, accountToidDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, additionDateDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = paymentRoutesBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 402);
            dataGridView1.TabIndex = 1;
            // 
            // paymentRouteidDataGridViewTextBoxColumn
            // 
            paymentRouteidDataGridViewTextBoxColumn.DataPropertyName = "PaymentRoute_id";
            paymentRouteidDataGridViewTextBoxColumn.FillWeight = 30F;
            paymentRouteidDataGridViewTextBoxColumn.HeaderText = "№";
            paymentRouteidDataGridViewTextBoxColumn.Name = "paymentRouteidDataGridViewTextBoxColumn";
            paymentRouteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountFromidDataGridViewTextBoxColumn
            // 
            accountFromidDataGridViewTextBoxColumn.DataPropertyName = "AccountFrom_id";
            accountFromidDataGridViewTextBoxColumn.DataSource = accountsBindingSource;
            accountFromidDataGridViewTextBoxColumn.DisplayMember = "Number";
            accountFromidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            accountFromidDataGridViewTextBoxColumn.HeaderText = "Отправитель";
            accountFromidDataGridViewTextBoxColumn.Name = "accountFromidDataGridViewTextBoxColumn";
            accountFromidDataGridViewTextBoxColumn.ReadOnly = true;
            accountFromidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            accountFromidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            accountFromidDataGridViewTextBoxColumn.ValueMember = "Account_id";
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Accounts);
            // 
            // accountToidDataGridViewTextBoxColumn
            // 
            accountToidDataGridViewTextBoxColumn.DataPropertyName = "AccountTo_id";
            accountToidDataGridViewTextBoxColumn.DataSource = accountsBindingSource;
            accountToidDataGridViewTextBoxColumn.DisplayMember = "Number";
            accountToidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            accountToidDataGridViewTextBoxColumn.HeaderText = "Получатель";
            accountToidDataGridViewTextBoxColumn.Name = "accountToidDataGridViewTextBoxColumn";
            accountToidDataGridViewTextBoxColumn.ReadOnly = true;
            accountToidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            accountToidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            accountToidDataGridViewTextBoxColumn.ValueMember = "Account_id";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionDateDataGridViewTextBoxColumn
            // 
            additionDateDataGridViewTextBoxColumn.DataPropertyName = "AdditionDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            additionDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            additionDateDataGridViewTextBoxColumn.HeaderText = "Добавление";
            additionDateDataGridViewTextBoxColumn.Name = "additionDateDataGridViewTextBoxColumn";
            additionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentRoutesBindingSource
            // 
            paymentRoutesBindingSource.DataSource = typeof(PaymentRoutes);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(50, 22);
            toolStripLabel1.Text = "Поиск:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(200, 25);
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // UserControlPaymentRoutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "UserControlPaymentRoutes";
            Size = new Size(900, 430);
            Load += UserControlPaymentRoutes_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRoutesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView dataGridView1;
        private BindingSource paymentRoutesBindingSource;
        private ToolStripButton toolStripButton1;
        private BindingSource accountsBindingSource;
        private DataGridViewTextBoxColumn paymentRouteidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn accountFromidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn accountToidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
    }
}
