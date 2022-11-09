namespace MusicShop.UI
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.choiceCateogoryButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.okBlinkButton = new MusicShop.BlinkButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.imagesColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.choiceCateogoryButton);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer.Panel1.Controls.Add(this.okBlinkButton);
            this.splitContainer.Panel1.Controls.Add(this.cancelButton);
            this.splitContainer.Panel1.Controls.Add(this.categoryComboBox);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.manufacturerComboBox);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.quantityNumericUpDown);
            this.splitContainer.Panel1.Controls.Add(this.label4);
            this.splitContainer.Panel1.Controls.Add(this.descriptionRichTextBox);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.priceNumericUpDown);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.nameTextBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.imagesDataGridView);
            this.splitContainer.Size = new System.Drawing.Size(747, 389);
            this.splitContainer.SplitterDistance = 584;
            this.splitContainer.TabIndex = 42;
            // 
            // choiceCateogoryButton
            // 
            this.choiceCateogoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.choiceCateogoryButton.FlatAppearance.BorderSize = 0;
            this.choiceCateogoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceCateogoryButton.Location = new System.Drawing.Point(372, 59);
            this.choiceCateogoryButton.Name = "choiceCateogoryButton";
            this.choiceCateogoryButton.Size = new System.Drawing.Size(29, 23);
            this.choiceCateogoryButton.TabIndex = 53;
            this.choiceCateogoryButton.Text = "...";
            this.choiceCateogoryButton.UseVisualStyleBackColor = false;
            this.choiceCateogoryButton.Click += new System.EventHandler(this.ChoiceCateogoryButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageToolStripButton,
            this.deleteImageToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(560, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(24, 389);
            this.toolStrip.TabIndex = 6;
            // 
            // addImageToolStripButton
            // 
            this.addImageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addImageToolStripButton.Image = global::MusicShop.Properties.Resources.add;
            this.addImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addImageToolStripButton.Name = "addImageToolStripButton";
            this.addImageToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.addImageToolStripButton.Text = "Добавить изображение";
            this.addImageToolStripButton.Click += new System.EventHandler(this.AddImageToolStripButton_Click);
            // 
            // deleteImageToolStripButton
            // 
            this.deleteImageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteImageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteImageToolStripButton.Image")));
            this.deleteImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteImageToolStripButton.Name = "deleteImageToolStripButton";
            this.deleteImageToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.deleteImageToolStripButton.Text = "Удалить изображение";
            this.deleteImageToolStripButton.Click += new System.EventHandler(this.DeleteImageToolStripButton_Click);
            // 
            // okBlinkButton
            // 
            this.okBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.okBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.okBlinkButton.FlatAppearance.BorderSize = 0;
            this.okBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBlinkButton.Location = new System.Drawing.Point(377, 354);
            this.okBlinkButton.Name = "okBlinkButton";
            this.okBlinkButton.Size = new System.Drawing.Size(103, 23);
            this.okBlinkButton.TabIndex = 8;
            this.okBlinkButton.Text = "ОК";
            this.okBlinkButton.UseVisualStyleBackColor = false;
            this.okBlinkButton.Click += new System.EventHandler(this.OkBlinkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(486, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(102, 60);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(264, 21);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Категория:";
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DisplayMember = "name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(102, 33);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(299, 21);
            this.manufacturerComboBox.TabIndex = 1;
            this.manufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.ManufacturerComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Производитель:";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(319, 87);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(82, 21);
            this.quantityNumericUpDown.TabIndex = 4;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Количество:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(102, 114);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(443, 234);
            this.descriptionRichTextBox.TabIndex = 5;
            this.descriptionRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Описание:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(102, 87);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(105, 21);
            this.priceNumericUpDown.TabIndex = 3;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(102, 6);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(299, 21);
            this.nameTextBox.TabIndex = 0;
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            this.imagesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.imagesDataGridView.RowTemplate.Height = 100;
            this.imagesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.imagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagesDataGridView.Size = new System.Drawing.Size(159, 389);
            this.imagesDataGridView.TabIndex = 7;
            // 
            // imagesColumn
            // 
            this.imagesColumn.DataPropertyName = "Image";
            this.imagesColumn.HeaderText = "";
            this.imagesColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagesColumn.Name = "imagesColumn";
            this.imagesColumn.ReadOnly = true;
            this.imagesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 389);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(763, 428);
            this.Name = "EditProductForm";
            this.Text = "Добавить товар";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private BlinkButton okBlinkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addImageToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteImageToolStripButton;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn imagesColumn;
        private System.Windows.Forms.Button choiceCateogoryButton;
    }
}