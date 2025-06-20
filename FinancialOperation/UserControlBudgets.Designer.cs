namespace FinancialOperation
{
    partial class UserControlBudgets
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            budgetidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            clientsBindingSource = new BindingSource(components);
            budgetTypeidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            budgetTypesBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currencyidDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            currenciesBindingSource = new BindingSource(components);
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            additionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            budgetsBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)budgetsBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { budgetidDataGridViewTextBoxColumn, clientidDataGridViewTextBoxColumn, budgetTypeidDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, currencyidDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, additionDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = budgetsBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 402);
            dataGridView1.TabIndex = 0;
            // 
            // budgetidDataGridViewTextBoxColumn
            // 
            budgetidDataGridViewTextBoxColumn.DataPropertyName = "Budget_id";
            budgetidDataGridViewTextBoxColumn.FillWeight = 30F;
            budgetidDataGridViewTextBoxColumn.HeaderText = "№";
            budgetidDataGridViewTextBoxColumn.Name = "budgetidDataGridViewTextBoxColumn";
            budgetidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            clientidDataGridViewTextBoxColumn.DataPropertyName = "Client_id";
            clientidDataGridViewTextBoxColumn.DataSource = clientsBindingSource;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            clientidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            clientidDataGridViewTextBoxColumn.DisplayMember = "SurName";
            clientidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            clientidDataGridViewTextBoxColumn.HeaderText = "Клиент";
            clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            clientidDataGridViewTextBoxColumn.ReadOnly = true;
            clientidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            clientidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            clientidDataGridViewTextBoxColumn.ValueMember = "Client_id";
            // 
            // clientsBindingSource
            // 
            clientsBindingSource.DataSource = typeof(Clients);
            // 
            // budgetTypeidDataGridViewTextBoxColumn
            // 
            budgetTypeidDataGridViewTextBoxColumn.DataPropertyName = "BudgetType_id";
            budgetTypeidDataGridViewTextBoxColumn.DataSource = budgetTypesBindingSource;
            budgetTypeidDataGridViewTextBoxColumn.DisplayMember = "Name";
            budgetTypeidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            budgetTypeidDataGridViewTextBoxColumn.HeaderText = "Тип";
            budgetTypeidDataGridViewTextBoxColumn.Name = "budgetTypeidDataGridViewTextBoxColumn";
            budgetTypeidDataGridViewTextBoxColumn.ReadOnly = true;
            budgetTypeidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            budgetTypeidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            budgetTypeidDataGridViewTextBoxColumn.ValueMember = "BudgetType_id";
            // 
            // budgetTypesBindingSource
            // 
            budgetTypesBindingSource.DataSource = typeof(BudgetTypes);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyidDataGridViewTextBoxColumn
            // 
            currencyidDataGridViewTextBoxColumn.DataPropertyName = "Currency_id";
            currencyidDataGridViewTextBoxColumn.DataSource = currenciesBindingSource;
            currencyidDataGridViewTextBoxColumn.DisplayMember = "Symbol";
            currencyidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            currencyidDataGridViewTextBoxColumn.HeaderText = "Валюта";
            currencyidDataGridViewTextBoxColumn.Name = "currencyidDataGridViewTextBoxColumn";
            currencyidDataGridViewTextBoxColumn.ReadOnly = true;
            currencyidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            currencyidDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            currencyidDataGridViewTextBoxColumn.ValueMember = "Currency_id";
            // 
            // currenciesBindingSource
            // 
            currenciesBindingSource.DataSource = typeof(Currencies);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            startDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            startDateDataGridViewTextBoxColumn.HeaderText = "Начало";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            endDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            endDateDataGridViewTextBoxColumn.HeaderText = "Конец";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionDateDataGridViewTextBoxColumn
            // 
            additionDateDataGridViewTextBoxColumn.DataPropertyName = "AdditionDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            additionDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            additionDateDataGridViewTextBoxColumn.HeaderText = "Добавление";
            additionDateDataGridViewTextBoxColumn.Name = "additionDateDataGridViewTextBoxColumn";
            additionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetsBindingSource
            // 
            budgetsBindingSource.DataSource = typeof(Budgets);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripLabel1, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(900, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.ForeColor = Color.Black;
            toolStripButton1.Image = Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(88, 22);
            toolStripButton1.Text = "Добавить";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.ForeColor = Color.Black;
            toolStripButton2.Image = Properties.Resources._1486504369_change_edit_options_pencil_settings_tools_write_81307;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(122, 22);
            toolStripButton2.Text = "Редактировать";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.ForeColor = Color.Black;
            toolStripButton3.Image = Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(78, 22);
            toolStripButton3.Text = "Удалить";
            toolStripButton3.Click += toolStripButton3_Click;
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
            // UserControlBudgets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "UserControlBudgets";
            Size = new Size(900, 430);
            Load += UserControlBudgets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)currenciesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)budgetsBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource budgetsBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private BindingSource clientsBindingSource;
        private BindingSource budgetTypesBindingSource;
        private BindingSource currenciesBindingSource;
        private DataGridViewTextBoxColumn budgetidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn clientidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn budgetTypeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn currencyidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionDateDataGridViewTextBoxColumn;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
    }
}
