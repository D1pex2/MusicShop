namespace MusicShop.UI
{
    partial class EditCategoryForm
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
            this.okBlinkButton = new MusicShop.BlinkButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.choiceCateogoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okBlinkButton
            // 
            this.okBlinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBlinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.okBlinkButton.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.okBlinkButton.FlatAppearance.BorderSize = 0;
            this.okBlinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBlinkButton.Location = new System.Drawing.Point(209, 66);
            this.okBlinkButton.Name = "okBlinkButton";
            this.okBlinkButton.Size = new System.Drawing.Size(103, 23);
            this.okBlinkButton.TabIndex = 3;
            this.okBlinkButton.Text = "ОК";
            this.okBlinkButton.UseVisualStyleBackColor = false;
            this.okBlinkButton.Click += new System.EventHandler(this.OkBlinkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(318, 66);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Главная категория:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 12);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Название:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(127, 39);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(215, 21);
            this.categoryComboBox.TabIndex = 1;
            // 
            // choiceCateogoryButton
            // 
            this.choiceCateogoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choiceCateogoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.choiceCateogoryButton.FlatAppearance.BorderSize = 0;
            this.choiceCateogoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceCateogoryButton.Location = new System.Drawing.Point(348, 38);
            this.choiceCateogoryButton.Name = "choiceCateogoryButton";
            this.choiceCateogoryButton.Size = new System.Drawing.Size(29, 23);
            this.choiceCateogoryButton.TabIndex = 2;
            this.choiceCateogoryButton.Text = "...";
            this.choiceCateogoryButton.UseVisualStyleBackColor = false;
            this.choiceCateogoryButton.Click += new System.EventHandler(this.ChoiceCateogoryButton_Click);
            // 
            // EditCategoryForm
            // 
            this.AcceptButton = this.okBlinkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(389, 96);
            this.Controls.Add(this.choiceCateogoryButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.okBlinkButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditCategoryForm";
            this.Text = "Добавить категорию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlinkButton okBlinkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button choiceCateogoryButton;
    }
}