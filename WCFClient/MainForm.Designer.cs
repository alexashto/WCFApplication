namespace WCFClient
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewCompanies = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefreshCompanies = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonWatchEmployee = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonDeleteCompany = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCompanies
            // 
            this.listViewCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderPhone});
            this.listViewCompanies.FullRowSelect = true;
            this.listViewCompanies.Location = new System.Drawing.Point(0, 27);
            this.listViewCompanies.MultiSelect = false;
            this.listViewCompanies.Name = "listViewCompanies";
            this.listViewCompanies.Size = new System.Drawing.Size(595, 314);
            this.listViewCompanies.TabIndex = 0;
            this.listViewCompanies.UseCompatibleStateImageBehavior = false;
            this.listViewCompanies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 171;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Адрес";
            this.columnHeaderAddress.Width = 341;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Телефон";
            this.columnHeaderPhone.Width = 73;
            // 
            // buttonRefreshCompanies
            // 
            this.buttonRefreshCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshCompanies.Location = new System.Drawing.Point(515, 345);
            this.buttonRefreshCompanies.Name = "buttonRefreshCompanies";
            this.buttonRefreshCompanies.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshCompanies.TabIndex = 1;
            this.buttonRefreshCompanies.Text = "Обновить";
            this.buttonRefreshCompanies.UseVisualStyleBackColor = true;
            this.buttonRefreshCompanies.Click += new System.EventHandler(this.buttonRefreshCompanies_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonWatchEmployee
            // 
            this.buttonWatchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWatchEmployee.Location = new System.Drawing.Point(257, 345);
            this.buttonWatchEmployee.Name = "buttonWatchEmployee";
            this.buttonWatchEmployee.Size = new System.Drawing.Size(142, 23);
            this.buttonWatchEmployee.TabIndex = 3;
            this.buttonWatchEmployee.Text = "Просмотр сотрудников";
            this.buttonWatchEmployee.UseVisualStyleBackColor = true;
            this.buttonWatchEmployee.Click += new System.EventHandler(this.buttonWatchEmployee_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCompany.Location = new System.Drawing.Point(6, 345);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(125, 23);
            this.buttonAddCompany.TabIndex = 5;
            this.buttonAddCompany.Text = "Добавить компанию";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // buttonDeleteCompany
            // 
            this.buttonDeleteCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteCompany.Location = new System.Drawing.Point(137, 345);
            this.buttonDeleteCompany.Name = "buttonDeleteCompany";
            this.buttonDeleteCompany.Size = new System.Drawing.Size(114, 23);
            this.buttonDeleteCompany.TabIndex = 6;
            this.buttonDeleteCompany.Text = "Удалить компанию";
            this.buttonDeleteCompany.UseVisualStyleBackColor = true;
            this.buttonDeleteCompany.Click += new System.EventHandler(this.buttonDeleteCompany_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 394);
            this.Controls.Add(this.buttonDeleteCompany);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonWatchEmployee);
            this.Controls.Add(this.buttonRefreshCompanies);
            this.Controls.Add(this.listViewCompanies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(611, 433);
            this.Name = "MainForm";
            this.Text = "Список компаний";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCompanies;
        private System.Windows.Forms.Button buttonRefreshCompanies;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button buttonWatchEmployee;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonDeleteCompany;
    }
}

