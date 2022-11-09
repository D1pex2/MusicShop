namespace MusicShop.UI
{
    partial class CartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.idProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStockQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decreaseQuantityColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.increaseQuantityColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addOrderBlinkButton = new MusicShop.BlinkButton();
            this.deliveryAddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductColumn,
            this.imageColumn,
            this.nameColumn,
            this.priceColumn,
            this.InStockQuantityColumn,
            this.decreaseQuantityColumn,
            this.quantityColumn,
            this.increaseQuantityColumn,
            this.removeColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cartDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cartDataGridView.MultiSelect = false;
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cartDataGridView.RowHeadersVisible = false;
            this.cartDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.cartDataGridView.RowTemplate.Height = 80;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(747, 292);
            this.cartDataGridView.TabIndex = 0;
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGridView_CellContentClick);
            this.cartDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGridView_CellDoubleClick);
            // 
            // idProductColumn
            // 
            this.idProductColumn.DataPropertyName = "idProduct";
            this.idProductColumn.HeaderText = "idProduct";
            this.idProductColumn.Name = "idProductColumn";
            this.idProductColumn.ReadOnly = true;
            this.idProductColumn.Visible = false;
            // 
            // imageColumn
            // 
            this.imageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imageColumn.DataPropertyName = "image";
            this.imageColumn.FillWeight = 178.9922F;
            this.imageColumn.HeaderText = "Изображение";
            this.imageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageColumn.Name = "imageColumn";
            this.imageColumn.ReadOnly = true;
            this.imageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.FillWeight = 144.267F;
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceColumn.DataPropertyName = "price";
            this.priceColumn.FillWeight = 144.267F;
            this.priceColumn.HeaderText = "Цена руб.";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // InStockQuantityColumn
            // 
            this.InStockQuantityColumn.DataPropertyName = "InStockQuantity";
            this.InStockQuantityColumn.FillWeight = 105.2895F;
            this.InStockQuantityColumn.HeaderText = "В наличии";
            this.InStockQuantityColumn.Name = "InStockQuantityColumn";
            this.InStockQuantityColumn.ReadOnly = true;
            // 
            // decreaseQuantityColumn
            // 
            this.decreaseQuantityColumn.FillWeight = 17.81037F;
            this.decreaseQuantityColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseQuantityColumn.HeaderText = "";
            this.decreaseQuantityColumn.Name = "decreaseQuantityColumn";
            this.decreaseQuantityColumn.ReadOnly = true;
            this.decreaseQuantityColumn.Text = "-";
            this.decreaseQuantityColumn.UseColumnTextForButtonValue = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityColumn.FillWeight = 80F;
            this.quantityColumn.HeaderText = "Количество";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // increaseQuantityColumn
            // 
            this.increaseQuantityColumn.FillWeight = 17.3701F;
            this.increaseQuantityColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseQuantityColumn.HeaderText = "";
            this.increaseQuantityColumn.Name = "increaseQuantityColumn";
            this.increaseQuantityColumn.ReadOnly = true;
            this.increaseQuantityColumn.Text = "+";
            this.increaseQuantityColumn.UseColumnTextForButtonValue = true;
            // 
            // removeColumn
            // 
            this.removeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.removeColumn.FillWeight = 72.13351F;
            this.removeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeColumn.HeaderText = "Убрать";
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.ReadOnly = true;
            this.removeColumn.Text = "Убрать";
            this.removeColumn.UseColumnTextForButtonValue = true;
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(111, 303);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(152, 21);
            this.deliveryDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата доставки:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Адрес доставки:";
            // 
            // addOrderBlinkButton
            // 
            this.addOrderBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.addOrderBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addOrderBlinkButton.FlatAppearance.BorderSize = 0;
            this.addOrderBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrderBlinkButton.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderBlinkButton.Location = new System.Drawing.Point(580, 347);
            this.addOrderBlinkButton.Name = "addOrderBlinkButton";
            this.addOrderBlinkButton.Size = new System.Drawing.Size(155, 30);
            this.addOrderBlinkButton.TabIndex = 3;
            this.addOrderBlinkButton.Text = "Оформить заказ";
            this.addOrderBlinkButton.UseVisualStyleBackColor = false;
            this.addOrderBlinkButton.Click += new System.EventHandler(this.AddOrderBlinkButton_Click);
            // 
            // deliveryAddressRichTextBox
            // 
            this.deliveryAddressRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deliveryAddressRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryAddressRichTextBox.Location = new System.Drawing.Point(111, 333);
            this.deliveryAddressRichTextBox.MaxLength = 300;
            this.deliveryAddressRichTextBox.Name = "deliveryAddressRichTextBox";
            this.deliveryAddressRichTextBox.Size = new System.Drawing.Size(323, 44);
            this.deliveryAddressRichTextBox.TabIndex = 2;
            this.deliveryAddressRichTextBox.Text = "";
            // 
            // costLabel
            // 
            this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(443, 301);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(292, 23);
            this.costLabel.TabIndex = 33;
            this.costLabel.Text = "Стоимость: 99999999.99 р.";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 389);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.deliveryAddressRichTextBox);
            this.Controls.Add(this.addOrderBlinkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.cartDataGridView);
            this.MinimumSize = new System.Drawing.Size(763, 428);
            this.Name = "CartForm";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BlinkButton addOrderBlinkButton;
        private System.Windows.Forms.RichTextBox deliveryAddressRichTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStockQuantityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn decreaseQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn increaseQuantityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeColumn;
    }
}