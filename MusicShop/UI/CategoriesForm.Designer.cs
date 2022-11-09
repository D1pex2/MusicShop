namespace MusicShop.UI
{
    partial class CategoriesForm
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
            this.categoryTreeView = new System.Windows.Forms.TreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editBlinkButton = new MusicShop.BlinkButton();
            this.addBlinkButton = new MusicShop.BlinkButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.categoryTreeView.ShowNodeToolTips = true;
            this.categoryTreeView.Size = new System.Drawing.Size(800, 401);
            this.categoryTreeView.TabIndex = 11;
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
            this.splitContainer.Panel1.Controls.Add(this.categoryTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer.Panel2.Controls.Add(this.editBlinkButton);
            this.splitContainer.Panel2.Controls.Add(this.addBlinkButton);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 401;
            this.splitContainer.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(723, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editBlinkButton
            // 
            this.editBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.editBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editBlinkButton.FlatAppearance.BorderSize = 0;
            this.editBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBlinkButton.Location = new System.Drawing.Point(622, 10);
            this.editBlinkButton.Name = "editBlinkButton";
            this.editBlinkButton.Size = new System.Drawing.Size(95, 23);
            this.editBlinkButton.TabIndex = 6;
            this.editBlinkButton.Text = "Редактировать";
            this.editBlinkButton.UseVisualStyleBackColor = false;
            this.editBlinkButton.Click += new System.EventHandler(this.EditBlinkButton_Click);
            // 
            // addBlinkButton
            // 
            this.addBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.addBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addBlinkButton.FlatAppearance.BorderSize = 0;
            this.addBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlinkButton.Location = new System.Drawing.Point(549, 10);
            this.addBlinkButton.Name = "addBlinkButton";
            this.addBlinkButton.Size = new System.Drawing.Size(67, 23);
            this.addBlinkButton.TabIndex = 5;
            this.addBlinkButton.Text = "Добавить";
            this.addBlinkButton.UseVisualStyleBackColor = false;
            this.addBlinkButton.Click += new System.EventHandler(this.AddBlinkButton_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "CategoriesForm";
            this.Text = "Категории";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView categoryTreeView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button deleteButton;
        private BlinkButton editBlinkButton;
        private BlinkButton addBlinkButton;
    }
}