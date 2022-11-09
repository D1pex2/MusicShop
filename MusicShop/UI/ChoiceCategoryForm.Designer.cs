namespace MusicShop.UI
{
    partial class ChoiceCategoryForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.categoryTreeView = new System.Windows.Forms.TreeView();
            this.okBlinkButton = new MusicShop.BlinkButton();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer.Panel2.Controls.Add(this.okBlinkButton);
            this.splitContainer.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer.Size = new System.Drawing.Size(284, 361);
            this.splitContainer.SplitterDistance = 313;
            this.splitContainer.TabIndex = 13;
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
            this.categoryTreeView.Size = new System.Drawing.Size(284, 313);
            this.categoryTreeView.TabIndex = 11;
            // 
            // okBlinkButton
            // 
            this.okBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.okBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.okBlinkButton.FlatAppearance.BorderSize = 0;
            this.okBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBlinkButton.Location = new System.Drawing.Point(104, 9);
            this.okBlinkButton.Name = "okBlinkButton";
            this.okBlinkButton.Size = new System.Drawing.Size(103, 23);
            this.okBlinkButton.TabIndex = 12;
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
            this.cancelButton.Location = new System.Drawing.Point(213, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChoiceCategoryForm
            // 
            this.AcceptButton = this.okBlinkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "ChoiceCategoryForm";
            this.Text = "Категории";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView categoryTreeView;
        private BlinkButton okBlinkButton;
        private System.Windows.Forms.Button cancelButton;
    }
}