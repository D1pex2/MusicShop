namespace MusicShop.UI
{
    partial class CatalogForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все товары");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.categoryTreeView = new System.Windows.Forms.TreeView();
            this.catalogSplitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.firstPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.previousPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nextPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addProductToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteProductToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.imageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgRatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.openProductBlinkButton = new MusicShop.BlinkButton();
            this.filterBlinkButton = new MusicShop.BlinkButton();
            this.catalogPictureBox = new System.Windows.Forms.PictureBox();
            this.isStockCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.maxPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogSplitContainer)).BeginInit();
            this.catalogSplitContainer.Panel1.SuspendLayout();
            this.catalogSplitContainer.Panel2.SuspendLayout();
            this.catalogSplitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.categoryTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.catalogSplitContainer);
            this.splitContainer.Size = new System.Drawing.Size(828, 389);
            this.splitContainer.SplitterDistance = 171;
            this.splitContainer.TabIndex = 19;
            // 
            // categoryTreeView
            // 
            this.categoryTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.categoryTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTreeView.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryTreeView.Location = new System.Drawing.Point(0, 0);
            this.categoryTreeView.Name = "categoryTreeView";
            treeNode1.Name = "AllProducts";
            treeNode1.Text = "Все товары";
            this.categoryTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.categoryTreeView.ShowNodeToolTips = true;
            this.categoryTreeView.Size = new System.Drawing.Size(171, 389);
            this.categoryTreeView.TabIndex = 10;
            this.categoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CategoryTreeView_AfterSelect);
            // 
            // catalogSplitContainer
            // 
            this.catalogSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.catalogSplitContainer.IsSplitterFixed = true;
            this.catalogSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.catalogSplitContainer.Name = "catalogSplitContainer";
            this.catalogSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // catalogSplitContainer.Panel1
            // 
            this.catalogSplitContainer.Panel1.Controls.Add(this.toolStrip);
            this.catalogSplitContainer.Panel1.Controls.Add(this.catalogDataGridView);
            // 
            // catalogSplitContainer.Panel2
            // 
            this.catalogSplitContainer.Panel2.Controls.Add(this.sortComboBox);
            this.catalogSplitContainer.Panel2.Controls.Add(this.manufacturerComboBox);
            this.catalogSplitContainer.Panel2.Controls.Add(this.openProductBlinkButton);
            this.catalogSplitContainer.Panel2.Controls.Add(this.filterBlinkButton);
            this.catalogSplitContainer.Panel2.Controls.Add(this.catalogPictureBox);
            this.catalogSplitContainer.Panel2.Controls.Add(this.isStockCheckBox);
            this.catalogSplitContainer.Panel2.Controls.Add(this.resetButton);
            this.catalogSplitContainer.Panel2.Controls.Add(this.maxPriceNumericUpDown);
            this.catalogSplitContainer.Panel2.Controls.Add(this.minPriceNumericUpDown);
            this.catalogSplitContainer.Panel2.Controls.Add(this.label4);
            this.catalogSplitContainer.Panel2.Controls.Add(this.label3);
            this.catalogSplitContainer.Panel2.Controls.Add(this.label2);
            this.catalogSplitContainer.Panel2.Controls.Add(this.label1);
            this.catalogSplitContainer.Panel2.Controls.Add(this.productNameTextBox);
            this.catalogSplitContainer.Size = new System.Drawing.Size(653, 389);
            this.catalogSplitContainer.SplitterDistance = 304;
            this.catalogSplitContainer.TabIndex = 18;
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
            this.lastPageToolStripButton,
            this.toolStripSeparator1,
            this.refreshToolStripButton,
            this.addProductToolStripButton,
            this.editPageToolStripButton,
            this.deleteProductToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 279);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(653, 25);
            this.toolStrip.TabIndex = 0;
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
            this.previousPageToolStripButton.Click += new System.EventHandler(this.PreviousPageToolStripSplitButton_ButtonClick);
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
            this.nextPageToolStripButton.Click += new System.EventHandler(this.NextPageToolStripSplitButton_ButtonClick);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.refreshToolStripButton.Text = "Обновить";
            this.refreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // addProductToolStripButton
            // 
            this.addProductToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addProductToolStripButton.Image = global::MusicShop.Properties.Resources.add;
            this.addProductToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProductToolStripButton.Name = "addProductToolStripButton";
            this.addProductToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addProductToolStripButton.Text = "Добавить товар";
            this.addProductToolStripButton.Click += new System.EventHandler(this.AddProductToolStripButton_Click);
            // 
            // editPageToolStripButton
            // 
            this.editPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editPageToolStripButton.Image")));
            this.editPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPageToolStripButton.Name = "editPageToolStripButton";
            this.editPageToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editPageToolStripButton.Text = "Редактировать товар";
            this.editPageToolStripButton.Click += new System.EventHandler(this.EditPageToolStripButton_Click);
            // 
            // deleteProductToolStripButton
            // 
            this.deleteProductToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteProductToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductToolStripButton.Image")));
            this.deleteProductToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteProductToolStripButton.Name = "deleteProductToolStripButton";
            this.deleteProductToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteProductToolStripButton.Text = "Удалить товар";
            this.deleteProductToolStripButton.Click += new System.EventHandler(this.DeleteProductToolStripButton_Click);
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.AllowUserToAddRows = false;
            this.catalogDataGridView.AllowUserToDeleteRows = false;
            this.catalogDataGridView.AllowUserToResizeColumns = false;
            this.catalogDataGridView.AllowUserToResizeRows = false;
            this.catalogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.catalogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalogDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.catalogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageColumn,
            this.nameColumn,
            this.manufacturerColumn,
            this.countryColumn,
            this.priceColumn,
            this.avgRatingColumn,
            this.quantityColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catalogDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.catalogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catalogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.catalogDataGridView.MultiSelect = false;
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.ReadOnly = true;
            this.catalogDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.catalogDataGridView.RowHeadersVisible = false;
            this.catalogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catalogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.catalogDataGridView.RowTemplate.Height = 80;
            this.catalogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catalogDataGridView.Size = new System.Drawing.Size(653, 304);
            this.catalogDataGridView.TabIndex = 11;
            // 
            // imageColumn
            // 
            this.imageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageColumn.DataPropertyName = "LastPicture";
            this.imageColumn.HeaderText = "Изображение";
            this.imageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageColumn.Name = "imageColumn";
            this.imageColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // manufacturerColumn
            // 
            this.manufacturerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturerColumn.DataPropertyName = "manufacturerName";
            this.manufacturerColumn.HeaderText = "Производитель";
            this.manufacturerColumn.Name = "manufacturerColumn";
            this.manufacturerColumn.ReadOnly = true;
            // 
            // countryColumn
            // 
            this.countryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryColumn.DataPropertyName = "country";
            this.countryColumn.FillWeight = 75F;
            this.countryColumn.HeaderText = "Страна";
            this.countryColumn.Name = "countryColumn";
            this.countryColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceColumn.DataPropertyName = "price";
            this.priceColumn.FillWeight = 75F;
            this.priceColumn.HeaderText = "Цена руб.";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // avgRatingColumn
            // 
            this.avgRatingColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.avgRatingColumn.DataPropertyName = "avgRating";
            this.avgRatingColumn.FillWeight = 50F;
            this.avgRatingColumn.HeaderText = "Оценка";
            this.avgRatingColumn.Name = "avgRatingColumn";
            this.avgRatingColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityColumn.DataPropertyName = "quantity";
            this.quantityColumn.FillWeight = 75F;
            this.quantityColumn.HeaderText = "В наличии";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Сортировка",
            "По рейтингу",
            "Сначала дешевые",
            "Сначала дорогие"});
            this.sortComboBox.Location = new System.Drawing.Point(273, 52);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(134, 21);
            this.sortComboBox.TabIndex = 6;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturerComboBox.DisplayMember = "name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(140, 52);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(127, 21);
            this.manufacturerComboBox.TabIndex = 4;
            // 
            // openProductBlinkButton
            // 
            this.openProductBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openProductBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.openProductBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.openProductBlinkButton.FlatAppearance.BorderSize = 0;
            this.openProductBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProductBlinkButton.Location = new System.Drawing.Point(582, 51);
            this.openProductBlinkButton.Name = "openProductBlinkButton";
            this.openProductBlinkButton.Size = new System.Drawing.Size(61, 23);
            this.openProductBlinkButton.TabIndex = 9;
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
            this.filterBlinkButton.Location = new System.Drawing.Point(414, 51);
            this.filterBlinkButton.Name = "filterBlinkButton";
            this.filterBlinkButton.Size = new System.Drawing.Size(102, 23);
            this.filterBlinkButton.TabIndex = 7;
            this.filterBlinkButton.Text = "Отфильтровать";
            this.filterBlinkButton.UseVisualStyleBackColor = false;
            this.filterBlinkButton.Click += new System.EventHandler(this.FilterBlinkButton_Click);
            // 
            // catalogPictureBox
            // 
            this.catalogPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.catalogPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogPictureBox.Image = global::MusicShop.Properties.Resources.arrow;
            this.catalogPictureBox.Location = new System.Drawing.Point(5, 5);
            this.catalogPictureBox.Name = "catalogPictureBox";
            this.catalogPictureBox.Size = new System.Drawing.Size(16, 16);
            this.catalogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catalogPictureBox.TabIndex = 29;
            this.catalogPictureBox.TabStop = false;
            this.catalogPictureBox.Click += new System.EventHandler(this.CatalogPictureBox_Click);
            // 
            // isStockCheckBox
            // 
            this.isStockCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isStockCheckBox.AutoSize = true;
            this.isStockCheckBox.Location = new System.Drawing.Point(274, 29);
            this.isStockCheckBox.Name = "isStockCheckBox";
            this.isStockCheckBox.Size = new System.Drawing.Size(103, 17);
            this.isStockCheckBox.TabIndex = 5;
            this.isStockCheckBox.Text = "Есть в наличии";
            this.isStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(521, 51);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(55, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // maxPriceNumericUpDown
            // 
            this.maxPriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxPriceNumericUpDown.DecimalPlaces = 2;
            this.maxPriceNumericUpDown.Location = new System.Drawing.Point(55, 52);
            this.maxPriceNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.maxPriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxPriceNumericUpDown.Name = "maxPriceNumericUpDown";
            this.maxPriceNumericUpDown.Size = new System.Drawing.Size(78, 21);
            this.maxPriceNumericUpDown.TabIndex = 2;
            this.maxPriceNumericUpDown.Value = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            // 
            // minPriceNumericUpDown
            // 
            this.minPriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minPriceNumericUpDown.DecimalPlaces = 2;
            this.minPriceNumericUpDown.Location = new System.Drawing.Point(55, 26);
            this.minPriceNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.minPriceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minPriceNumericUpDown.Name = "minPriceNumericUpDown";
            this.minPriceNumericUpDown.Size = new System.Drawing.Size(78, 21);
            this.minPriceNumericUpDown.TabIndex = 1;
            this.minPriceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "От:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Фильтр по цене: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Поиск по названию:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productNameTextBox.Location = new System.Drawing.Point(140, 26);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(128, 21);
            this.productNameTextBox.TabIndex = 3;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 389);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(844, 428);
            this.Name = "CatalogForm";
            this.Text = "Каталог";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.catalogSplitContainer.Panel1.ResumeLayout(false);
            this.catalogSplitContainer.Panel1.PerformLayout();
            this.catalogSplitContainer.Panel2.ResumeLayout(false);
            this.catalogSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogSplitContainer)).EndInit();
            this.catalogSplitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer catalogSplitContainer;
        private System.Windows.Forms.TreeView categoryTreeView;
        private System.Windows.Forms.DataGridView catalogDataGridView;
        private System.Windows.Forms.CheckBox isStockCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown maxPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown minPriceNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox catalogPictureBox;
        private BlinkButton filterBlinkButton;
        private BlinkButton openProductBlinkButton;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton firstPageToolStripButton;
        private System.Windows.Forms.ToolStripButton previousPageToolStripButton;
        private System.Windows.Forms.ToolStripLabel pageToolStripLabel;
        private System.Windows.Forms.ToolStripButton nextPageToolStripButton;
        private System.Windows.Forms.ToolStripButton lastPageToolStripButton;
        private System.Windows.Forms.ToolStripButton addProductToolStripButton;
        private System.Windows.Forms.ToolStripButton editPageToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteProductToolStripButton;
        private System.Windows.Forms.DataGridViewImageColumn imageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgRatingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
    }
}