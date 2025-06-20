namespace FinancialOperation
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            budgetTypesBindingSource = new BindingSource(components);
            accountTypesBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            типСчетаToolStripMenuItem = new ToolStripMenuItem();
            типыБюджетовToolStripMenuItem = new ToolStripMenuItem();
            типыВалютToolStripMenuItem = new ToolStripMenuItem();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            счетаToolStripMenuItem = new ToolStripMenuItem();
            бюджетыToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            журналToolStripMenuItem = new ToolStripMenuItem();
            транзакцииToolStripMenuItem = new ToolStripMenuItem();
            платежныеМаршрутыToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountTypesBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // budgetTypesBindingSource
            // 
            budgetTypesBindingSource.DataSource = typeof(BudgetTypes);
            // 
            // accountTypesBindingSource
            // 
            accountTypesBindingSource.DataSource = typeof(AccountTypes);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 192, 255);
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, правкаToolStripMenuItem, пользователиToolStripMenuItem, операцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(900, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuItem1.Image = Properties.Resources.circle_customer_help_info_information_service_support_icon_123208;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(28, 21);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { типСчетаToolStripMenuItem, типыБюджетовToolStripMenuItem, типыВалютToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(66, 21);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // типСчетаToolStripMenuItem
            // 
            типСчетаToolStripMenuItem.Name = "типСчетаToolStripMenuItem";
            типСчетаToolStripMenuItem.Size = new Size(177, 22);
            типСчетаToolStripMenuItem.Text = "Типы счетов";
            типСчетаToolStripMenuItem.Click += типСчетаToolStripMenuItem_Click;
            // 
            // типыБюджетовToolStripMenuItem
            // 
            типыБюджетовToolStripMenuItem.Name = "типыБюджетовToolStripMenuItem";
            типыБюджетовToolStripMenuItem.Size = new Size(177, 22);
            типыБюджетовToolStripMenuItem.Text = "Типы бюджетов";
            типыБюджетовToolStripMenuItem.Click += типыБюджетовToolStripMenuItem_Click;
            // 
            // типыВалютToolStripMenuItem
            // 
            типыВалютToolStripMenuItem.Name = "типыВалютToolStripMenuItem";
            типыВалютToolStripMenuItem.Size = new Size(177, 22);
            типыВалютToolStripMenuItem.Text = "Типы валют";
            типыВалютToolStripMenuItem.Click += типыВалютToolStripMenuItem_Click;
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, счетаToolStripMenuItem, бюджетыToolStripMenuItem });
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(108, 21);
            пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(136, 22);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // счетаToolStripMenuItem
            // 
            счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            счетаToolStripMenuItem.Size = new Size(136, 22);
            счетаToolStripMenuItem.Text = "Счета";
            счетаToolStripMenuItem.Click += счетаToolStripMenuItem_Click;
            // 
            // бюджетыToolStripMenuItem
            // 
            бюджетыToolStripMenuItem.Name = "бюджетыToolStripMenuItem";
            бюджетыToolStripMenuItem.Size = new Size(136, 22);
            бюджетыToolStripMenuItem.Text = "Бюджеты";
            бюджетыToolStripMenuItem.Click += бюджетыToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { журналToolStripMenuItem, транзакцииToolStripMenuItem, платежныеМаршрутыToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(84, 21);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // журналToolStripMenuItem
            // 
            журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            журналToolStripMenuItem.Size = new Size(219, 22);
            журналToolStripMenuItem.Text = "Журнал";
            журналToolStripMenuItem.Click += журналToolStripMenuItem_Click;
            // 
            // транзакцииToolStripMenuItem
            // 
            транзакцииToolStripMenuItem.Name = "транзакцииToolStripMenuItem";
            транзакцииToolStripMenuItem.Size = new Size(219, 22);
            транзакцииToolStripMenuItem.Text = "Транзакции";
            транзакцииToolStripMenuItem.Click += транзакцииToolStripMenuItem_Click;
            // 
            // платежныеМаршрутыToolStripMenuItem
            // 
            платежныеМаршрутыToolStripMenuItem.Name = "платежныеМаршрутыToolStripMenuItem";
            платежныеМаршрутыToolStripMenuItem.Size = new Size(219, 22);
            платежныеМаршрутыToolStripMenuItem.Text = "Платежные маршруты";
            платежныеМаршрутыToolStripMenuItem.Click += платежныеМаршрутыToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 461);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление финансовыми операциями";
            ((System.ComponentModel.ISupportInitialize)budgetTypesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountTypesBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn budgetTypesidDataGridViewTextBoxColumn;
        private BindingSource budgetTypesBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem типСчетаToolStripMenuItem;
        private BindingSource accountTypesBindingSource;
        private ToolStripMenuItem типыБюджетовToolStripMenuItem;
        private ToolStripMenuItem типыВалютToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem счетаToolStripMenuItem;
        private ToolStripMenuItem бюджетыToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem журналToolStripMenuItem;
        private ToolStripMenuItem транзакцииToolStripMenuItem;
        private ToolStripMenuItem платежныеМаршрутыToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
