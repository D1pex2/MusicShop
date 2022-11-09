namespace MusicShop.UI
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addToCartBlinkButton = new MusicShop.BlinkButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.avgRatingLabel = new System.Windows.Forms.Label();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.imagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.imagesColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.selectedPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesSplitContainer)).BeginInit();
            this.imagesSplitContainer.Panel1.SuspendLayout();
            this.imagesSplitContainer.Panel2.SuspendLayout();
            this.imagesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.splitContainer.Panel1.Controls.Add(this.ratingLabel);
            this.splitContainer.Panel1.Controls.Add(this.ratingComboBox);
            this.splitContainer.Panel1.Controls.Add(this.closePictureBox);
            this.splitContainer.Panel1.Controls.Add(this.descriptionRichTextBox);
            this.splitContainer.Panel1.Controls.Add(this.addToCartBlinkButton);
            this.splitContainer.Panel1.Controls.Add(this.priceLabel);
            this.splitContainer.Panel1.Controls.Add(this.categoryLabel);
            this.splitContainer.Panel1.Controls.Add(this.productNameLabel);
            this.splitContainer.Panel1.Controls.Add(this.avgRatingLabel);
            this.splitContainer.Panel1.Controls.Add(this.inStockLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.imagesSplitContainer);
            this.splitContainer.Size = new System.Drawing.Size(628, 385);
            this.splitContainer.SplitterDistance = 309;
            this.splitContainer.TabIndex = 0;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(12, 308);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(95, 13);
            this.ratingLabel.TabIndex = 35;
            this.ratingLabel.Text = "Оставьте оценку";
            this.ratingLabel.Visible = false;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ratingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ratingComboBox.Location = new System.Drawing.Point(113, 305);
            this.ratingComboBox.MaxDropDownItems = 11;
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(41, 21);
            this.ratingComboBox.TabIndex = 1;
            this.ratingComboBox.Visible = false;
            this.ratingComboBox.SelectedValueChanged += new System.EventHandler(this.RatingComboBox_SelectedValueChanged);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::MusicShop.Properties.Resources.close;
            this.closePictureBox.Location = new System.Drawing.Point(10, 8);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(16, 16);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePictureBox.TabIndex = 33;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descriptionRichTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(15, 95);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(281, 204);
            this.descriptionRichTextBox.TabIndex = 32;
            this.descriptionRichTextBox.Text = resources.GetString("descriptionRichTextBox.Text");
            // 
            // addToCartBlinkButton
            // 
            this.addToCartBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.addToCartBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addToCartBlinkButton.FlatAppearance.BorderSize = 0;
            this.addToCartBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBlinkButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToCartBlinkButton.Image = global::MusicShop.Properties.Resources.cart;
            this.addToCartBlinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToCartBlinkButton.Location = new System.Drawing.Point(15, 333);
            this.addToCartBlinkButton.Name = "addToCartBlinkButton";
            this.addToCartBlinkButton.Size = new System.Drawing.Size(139, 40);
            this.addToCartBlinkButton.TabIndex = 2;
            this.addToCartBlinkButton.Text = "В корзину";
            this.addToCartBlinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToCartBlinkButton.UseVisualStyleBackColor = false;
            this.addToCartBlinkButton.Click += new System.EventHandler(this.AddToCartBlinkButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(160, 342);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(136, 23);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "999999,99 р.";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.categoryLabel.Location = new System.Drawing.Point(30, 9);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(266, 13);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Категория";
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.Location = new System.Drawing.Point(8, 28);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(288, 23);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Template Name";
            // 
            // avgRatingLabel
            // 
            this.avgRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgRatingLabel.AutoSize = true;
            this.avgRatingLabel.Location = new System.Drawing.Point(12, 58);
            this.avgRatingLabel.Name = "avgRatingLabel";
            this.avgRatingLabel.Size = new System.Drawing.Size(80, 13);
            this.avgRatingLabel.TabIndex = 1;
            this.avgRatingLabel.Text = "Оценка: 10/10";
            // 
            // inStockLabel
            // 
            this.inStockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.inStockLabel.Location = new System.Drawing.Point(12, 79);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(58, 13);
            this.inStockLabel.TabIndex = 2;
            this.inStockLabel.Text = "В наличии";
            // 
            // imagesSplitContainer
            // 
            this.imagesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.imagesSplitContainer.IsSplitterFixed = true;
            this.imagesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.imagesSplitContainer.Name = "imagesSplitContainer";
            // 
            // imagesSplitContainer.Panel1
            // 
            this.imagesSplitContainer.Panel1.Controls.Add(this.imagesDataGridView);
            // 
            // imagesSplitContainer.Panel2
            // 
            this.imagesSplitContainer.Panel2.Controls.Add(this.selectedPictureBox);
            this.imagesSplitContainer.Size = new System.Drawing.Size(315, 385);
            this.imagesSplitContainer.SplitterDistance = 101;
            this.imagesSplitContainer.TabIndex = 0;
            // 
            // imagesDataGridView
            // 
            this.imagesDataGridView.AllowUserToAddRows = false;
            this.imagesDataGridView.AllowUserToDeleteRows = false;
            this.imagesDataGridView.AllowUserToResizeColumns = false;
            this.imagesDataGridView.AllowUserToResizeRows = false;
            this.imagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.imagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.imagesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.imagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGridView.ColumnHeadersVisible = false;
            this.imagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagesColumn});
            this.imagesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesDataGridView.GridColor = System.Drawing.Color.White;
            this.imagesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.imagesDataGridView.MultiSelect = false;
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.ReadOnly = true;
            this.imagesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.imagesDataGridView.RowHeadersVisible = false;
            this.imagesDataGridView.RowHeadersWidth = 100;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.imagesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.imagesDataGridView.RowTemplate.Height = 100;
            this.imagesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.imagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagesDataGridView.Size = new System.Drawing.Size(101, 385);
            this.imagesDataGridView.TabIndex = 0;
            this.imagesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImagesDataGridView_CellClick);
            // 
            // imagesColumn
            // 
            this.imagesColumn.HeaderText = "";
            this.imagesColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagesColumn.Name = "imagesColumn";
            this.imagesColumn.ReadOnly = true;
            this.imagesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // selectedPictureBox
            // 
            this.selectedPictureBox.BackColor = System.Drawing.Color.White;
            this.selectedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPictureBox.Location = new System.Drawing.Point(0, 0);
            this.selectedPictureBox.Name = "selectedPictureBox";
            this.selectedPictureBox.Size = new System.Drawing.Size(210, 385);
            this.selectedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedPictureBox.TabIndex = 0;
            this.selectedPictureBox.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 385);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(644, 424);
            this.Name = "ProductForm";
            this.Text = "Товар";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.imagesSplitContainer.Panel1.ResumeLayout(false);
            this.imagesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesSplitContainer)).EndInit();
            this.imagesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox selectedPictureBox;
        private System.Windows.Forms.SplitContainer imagesSplitContainer;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn imagesColumn;
        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.Label avgRatingLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private BlinkButton addToCartBlinkButton;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
    }
}