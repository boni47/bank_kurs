namespace FinancialOperation
{
    partial class UserControlLogs
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
            dataGridView1 = new DataGridView();
            logidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            additionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            accountsBindingSource = new BindingSource(components);
            operationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logsBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logsBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { logidDataGridViewTextBoxColumn, additionDateDataGridViewTextBoxColumn, accountidDataGridViewTextBoxColumn, operationDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = logsBindingSource;
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
            // logidDataGridViewTextBoxColumn
            // 
            logidDataGridViewTextBoxColumn.DataPropertyName = "Log_id";
            logidDataGridViewTextBoxColumn.FillWeight = 30F;
            logidDataGridViewTextBoxColumn.HeaderText = "№";
            logidDataGridViewTextBoxColumn.Name = "logidDataGridViewTextBoxColumn";
            logidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // accountidDataGridViewTextBoxColumn
            // 
            accountidDataGridViewTextBoxColumn.DataPropertyName = "Account_id";
            accountidDataGridViewTextBoxColumn.DataSource = accountsBindingSource;
            accountidDataGridViewTextBoxColumn.DisplayMember = "Number";
            accountidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            accountidDataGridViewTextBoxColumn.HeaderText = "Счет";
            accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            accountidDataGridViewTextBoxColumn.ReadOnly = true;
            accountidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            accountidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            accountidDataGridViewTextBoxColumn.ValueMember = "Account_id";
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Accounts);
            // 
            // operationDataGridViewTextBoxColumn
            // 
            operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            operationDataGridViewTextBoxColumn.HeaderText = "Операция";
            operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            operationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logsBindingSource
            // 
            logsBindingSource.DataSource = typeof(Logs);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
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
            // UserControlLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "UserControlLogs";
            Size = new Size(900, 430);
            Load += UserControlLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)logsBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource logsBindingSource;
        private BindingSource accountsBindingSource;
        private DataGridViewTextBoxColumn logidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionDateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn accountidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
    }
}
