namespace NoteAppUI
{
    partial class AddEdit
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
            this.Title = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Created = new System.Windows.Forms.Label();
            this.Modified = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title:";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(12, 33);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(52, 13);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category:";
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(12, 63);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(47, 13);
            this.Created.TabIndex = 2;
            this.Created.Text = "Created:";
            // 
            // Modified
            // 
            this.Modified.AutoSize = true;
            this.Modified.Location = new System.Drawing.Point(216, 63);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(50, 13);
            this.Modified.TabIndex = 3;
            this.Modified.Text = "Modified:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(69, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(719, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(69, 57);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.CreatedDateTimePicker.TabIndex = 8;
            // 
            // UpdatedDateTimePicker
            // 
            this.UpdatedDateTimePicker.Location = new System.Drawing.Point(272, 57);
            this.UpdatedDateTimePicker.Name = "UpdatedDateTimePicker";
            this.UpdatedDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.UpdatedDateTimePicker.TabIndex = 9;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(632, 418);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 11;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(713, 418);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(70, 33);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 14;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Location = new System.Drawing.Point(12, 83);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(776, 329);
            this.noteTextBox.TabIndex = 15;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.UpdatedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.Modified);
            this.Controls.Add(this.Created);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddEdit";
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label Modified;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker UpdatedDateTimePicker;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}