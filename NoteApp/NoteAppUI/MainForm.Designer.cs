namespace NoteAppUI
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListNotes = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Created = new System.Windows.Forms.Label();
            this.Modified = new System.Windows.Forms.Label();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.headderLabel = new System.Windows.Forms.Label();
            this.headderCategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(94, 28);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategory
            // 
            this.ShowCategory.AutoSize = true;
            this.ShowCategory.Location = new System.Drawing.Point(12, 31);
            this.ShowCategory.Name = "ShowCategory";
            this.ShowCategory.Size = new System.Drawing.Size(82, 13);
            this.ShowCategory.TabIndex = 2;
            this.ShowCategory.Text = "Show Category:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ListNotes
            // 
            this.ListNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListNotes.FormattingEnabled = true;
            this.ListNotes.Location = new System.Drawing.Point(9, 66);
            this.ListNotes.Name = "ListNotes";
            this.ListNotes.Size = new System.Drawing.Size(206, 329);
            this.ListNotes.TabIndex = 4;
            this.ListNotes.SelectedIndexChanged += new System.EventHandler(this.ListNotes_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add.Location = new System.Drawing.Point(12, 401);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(34, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit.Location = new System.Drawing.Point(52, 401);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(38, 23);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Remove.Location = new System.Drawing.Point(96, 401);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(47, 23);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "delete";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(223, 68);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(44, 13);
            this.Created.TabIndex = 9;
            this.Created.Text = "Created";
            // 
            // Modified
            // 
            this.Modified.AutoSize = true;
            this.Modified.Location = new System.Drawing.Point(421, 69);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(47, 13);
            this.Modified.TabIndex = 10;
            this.Modified.Text = "Modified";
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Location = new System.Drawing.Point(273, 66);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.createdDateTimePicker.TabIndex = 11;
            // 
            // updatedDateTimePicker
            // 
            this.updatedDateTimePicker.Location = new System.Drawing.Point(474, 66);
            this.updatedDateTimePicker.Name = "updatedDateTimePicker";
            this.updatedDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.updatedDateTimePicker.TabIndex = 12;
            // 
            // headderLabel
            // 
            this.headderLabel.AutoSize = true;
            this.headderLabel.Location = new System.Drawing.Point(223, 50);
            this.headderLabel.Name = "headderLabel";
            this.headderLabel.Size = new System.Drawing.Size(52, 13);
            this.headderLabel.TabIndex = 13;
            this.headderLabel.Text = "Category:";
            // 
            // headderCategoryLabel
            // 
            this.headderCategoryLabel.AutoSize = true;
            this.headderCategoryLabel.Location = new System.Drawing.Point(270, 50);
            this.headderCategoryLabel.Name = "headderCategoryLabel";
            this.headderCategoryLabel.Size = new System.Drawing.Size(33, 13);
            this.headderCategoryLabel.TabIndex = 14;
            this.headderCategoryLabel.Text = "Work";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(223, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 13);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Tema";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Enabled = false;
            this.noteTextBox.Location = new System.Drawing.Point(226, 92);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(378, 303);
            this.noteTextBox.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 427);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.headderCategoryLabel);
            this.Controls.Add(this.headderLabel);
            this.Controls.Add(this.updatedDateTimePicker);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.Modified);
            this.Controls.Add(this.Created);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListNotes);
            this.Controls.Add(this.ShowCategory);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(630, 466);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label ShowCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox ListNotes;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label Modified;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.DateTimePicker updatedDateTimePicker;
        private System.Windows.Forms.Label headderLabel;
        private System.Windows.Forms.Label headderCategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}

