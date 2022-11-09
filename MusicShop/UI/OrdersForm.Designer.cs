namespace MusicShop.UI
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.firstPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.previousPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nextPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openProductBlinkButton = new MusicShop.BlinkButton();
            this.filterBlinkButton = new MusicShop.BlinkButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameColumn,
            this.phoneColumn,
            this.deliveryAddressColumn,
            this.sumColumn,
            this.orderDateColumn,
            this.deliveryDateColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ordersDataGridView.RowTemplate.Height = 80;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(747, 328);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameColumn.DataPropertyName = "FullName";
            this.fullNameColumn.HeaderText = "ФИО";
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "Номер телефона";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // deliveryAddressColumn
            // 
            this.deliveryAddressColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressColumn.HeaderText = "Адрес доставки";
            this.deliveryAddressColumn.Name = "deliveryAddressColumn";
            this.deliveryAddressColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            this.sumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumColumn.DataPropertyName = "Sum";
            this.sumColumn.FillWeight = 50F;
            this.sumColumn.HeaderText = "Сумма";
            this.sumColumn.Name = "sumColumn";
            this.sumColumn.ReadOnly = true;
            // 
            // orderDateColumn
            // 
            this.orderDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDateColumn.DataPropertyName = "OrderDate";
            this.orderDateColumn.FillWeight = 75F;
            this.orderDateColumn.HeaderText = "Дата заказа";
            this.orderDateColumn.Name = "orderDateColumn";
            this.orderDateColumn.ReadOnly = true;
            // 
            // deliveryDateColumn
            // 
            this.deliveryDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliveryDateColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateColumn.FillWeight = 75F;
            this.deliveryDateColumn.HeaderText = "Дата доставки";
            this.deliveryDateColumn.Name = "deliveryDateColumn";
            this.deliveryDateColumn.ReadOnly = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer.Panel1.Controls.Add(this.ordersDataGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.openProductBlinkButton);
            this.splitContainer.Panel2.Controls.Add(this.filterBlinkButton);
            this.splitContainer.Panel2.Controls.Add(this.resetButton);
            this.splitContainer.Panel2.Controls.Add(this.endDateTimePicker);
            this.splitContainer.Panel2.Controls.Add(this.beginDateTimePicker);
            this.splitContainer.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Size = new System.Drawing.Size(747, 389);
            this.splitContainer.SplitterDistance = 328;
            this.splitContainer.TabIndex = 5;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPageToolStripButton,
            this.previousPageToolStripButton,
            this.pageToolStripLabel,
            this.nextPageToolStripButton,
            this.lastPageToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 303);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(747, 25);
            this.toolStrip.TabIndex = 1;
            // 
            // firstPageToolStripButton
            // 
            this.firstPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstPageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("firstPageToolStripButton.Image")));
            this.firstPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstPageToolStripButton.Name = "firstPageToolStripButton";
            this.firstPageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.firstPageToolStripButton.Text = "Первая страница";
            this.firstPageToolStripButton.Click += new System.EventHandler(this.FirstPageToolStripButton_Click);
            // 
            // previousPageToolStripButton
            // 
            this.previousPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousPageToolStripButton.Image = global::MusicShop.Properties.Resources.left;
            this.previousPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousPageToolStripButton.Name = "previousPageToolStripButton";
            this.previousPageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.previousPageToolStripButton.Text = "Предыдущая страница";
            this.previousPageToolStripButton.Click += new System.EventHandler(this.PreviousPageToolStripButton_Click);
            // 
            // pageToolStripLabel
            // 
            this.pageToolStripLabel.Name = "pageToolStripLabel";
            this.pageToolStripLabel.Size = new System.Drawing.Size(93, 22);
            this.pageToolStripLabel.Text = "Страница 1 из 1";
            // 
            // nextPageToolStripButton
            // 
            this.nextPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextPageToolStripButton.Image = global::MusicShop.Properties.Resources.right;
            this.nextPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextPageToolStripButton.Name = "nextPageToolStripButton";
            this.nextPageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nextPageToolStripButton.Text = "Следующая страница";
            this.nextPageToolStripButton.Click += new System.EventHandler(this.NextPageToolStripButton_Click);
            // 
            // lastPageToolStripButton
            // 
            this.lastPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastPageToolStripButton.Image = global::MusicShop.Properties.Resources.lastPage;
            this.lastPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastPageToolStripButton.Name = "lastPageToolStripButton";
            this.lastPageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.lastPageToolStripButton.Text = "Последняя страница";
            this.lastPageToolStripButton.Click += new System.EventHandler(this.LastPageToolStripButton_Click);
            // 
            // openProductBlinkButton
            // 
            this.openProductBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openProductBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.openProductBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.openProductBlinkButton.FlatAppearance.BorderSize = 0;
            this.openProductBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProductBlinkButton.Location = new System.Drawing.Point(673, 23);
            this.openProductBlinkButton.Name = "openProductBlinkButton";
            this.openProductBlinkButton.Size = new System.Drawing.Size(62, 23);
            this.openProductBlinkButton.TabIndex = 7;
            this.openProductBlinkButton.Text = "Открыть";
            this.openProductBlinkButton.UseVisualStyleBackColor = false;
            this.openProductBlinkButton.Click += new System.EventHandler(this.OpenProductBlinkButton_Click);
            // 
            // filterBlinkButton
            // 
            this.filterBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.filterBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.filterBlinkButton.FlatAppearance.BorderSize = 0;
            this.filterBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBlinkButton.Location = new System.Drawing.Point(513, 23);
            this.filterBlinkButton.Name = "filterBlinkButton";
            this.filterBlinkButton.Size = new System.Drawing.Size(103, 23);
            this.filterBlinkButton.TabIndex = 5;
            this.filterBlinkButton.Text = "Отфильтровать";
            this.filterBlinkButton.UseVisualStyleBackColor = false;
            this.filterBlinkButton.Click += new System.EventHandler(this.FilterBlinkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(622, 23);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(45, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endDateTimePicker.Location = new System.Drawing.Point(367, 24);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(140, 21);
            this.endDateTimePicker.TabIndex = 4;
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.beginDateTimePicker.Location = new System.Drawing.Point(221, 24);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(140, 21);
            this.beginDateTimePicker.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fullNameTextBox.Location = new System.Drawing.Point(12, 24);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(203, 21);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конечная дата:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальная дата:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 389);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(763, 428);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton firstPageToolStripButton;
        private System.Windows.Forms.ToolStripButton previousPageToolStripButton;
        private System.Windows.Forms.ToolStripLabel pageToolStripLabel;
        private System.Windows.Forms.ToolStripButton nextPageToolStripButton;
        private System.Windows.Forms.ToolStripButton lastPageToolStripButton;
        private BlinkButton filterBlinkButton;
        private System.Windows.Forms.Button resetButton;
        private BlinkButton openProductBlinkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateColumn;
    }
}