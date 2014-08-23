namespace TodoApp
{
    partial class todoZorx
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
            this.addTodoButton = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.files = new System.Windows.Forms.ToolStripMenuItem();
            this.todoTitlePicker = new System.Windows.Forms.TextBox();
            this.goalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.todoTitlePickerText = new System.Windows.Forms.TextBox();
            this.goalDatePickerText = new System.Windows.Forms.TextBox();
            this.todoDescriptionText = new System.Windows.Forms.TextBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTodoButton
            // 
            this.addTodoButton.Location = new System.Drawing.Point(12, 541);
            this.addTodoButton.Name = "addTodoButton";
            this.addTodoButton.Size = new System.Drawing.Size(379, 23);
            this.addTodoButton.TabIndex = 0;
            this.addTodoButton.Text = "Add todo!";
            this.addTodoButton.UseVisualStyleBackColor = true;
            this.addTodoButton.Click += new System.EventHandler(this.addTodo_Click);
            // 
            // todoList
            // 
            this.todoList.FormattingEnabled = true;
            this.todoList.Location = new System.Drawing.Point(12, 27);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(379, 329);
            this.todoList.TabIndex = 1;
            this.todoList.SelectedIndexChanged += new System.EventHandler(this.todoList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.files});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // files
            // 
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(42, 20);
            this.files.Text = "Files";
            this.files.Click += new System.EventHandler(this.files_Click);
            // 
            // todoTitlePicker
            // 
            this.todoTitlePicker.Location = new System.Drawing.Point(12, 362);
            this.todoTitlePicker.Name = "todoTitlePicker";
            this.todoTitlePicker.Size = new System.Drawing.Size(379, 20);
            this.todoTitlePicker.TabIndex = 3;
            this.todoTitlePicker.TextChanged += new System.EventHandler(this.todoTitle_TextChanged);
            // 
            // goalDatePicker
            // 
            this.goalDatePicker.Location = new System.Drawing.Point(12, 416);
            this.goalDatePicker.Name = "goalDatePicker";
            this.goalDatePicker.Size = new System.Drawing.Size(379, 20);
            this.goalDatePicker.TabIndex = 4;
            // 
            // todoTitlePickerText
            // 
            this.todoTitlePickerText.BackColor = System.Drawing.SystemColors.Control;
            this.todoTitlePickerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoTitlePickerText.Location = new System.Drawing.Point(291, 365);
            this.todoTitlePickerText.Name = "todoTitlePickerText";
            this.todoTitlePickerText.Size = new System.Drawing.Size(100, 13);
            this.todoTitlePickerText.TabIndex = 5;
            this.todoTitlePickerText.Text = "<- Insert todo title";
            // 
            // goalDatePickerText
            // 
            this.goalDatePickerText.BackColor = System.Drawing.SystemColors.Control;
            this.goalDatePickerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalDatePickerText.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.goalDatePickerText.Location = new System.Drawing.Point(12, 389);
            this.goalDatePickerText.Name = "goalDatePickerText";
            this.goalDatePickerText.Size = new System.Drawing.Size(379, 13);
            this.goalDatePickerText.TabIndex = 6;
            this.goalDatePickerText.Text = "When are you hoping to have this done?";
            // 
            // todoDescriptionText
            // 
            this.todoDescriptionText.Location = new System.Drawing.Point(153, 442);
            this.todoDescriptionText.Multiline = true;
            this.todoDescriptionText.Name = "todoDescriptionText";
            this.todoDescriptionText.Size = new System.Drawing.Size(238, 93);
            this.todoDescriptionText.TabIndex = 7;
            // 
            // priorityBox
            // 
            this.priorityBox.Items.AddRange(new object[] {
            "Priority",
            "High",
            "Low",
            "Medium"});
            this.priorityBox.Location = new System.Drawing.Point(12, 442);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(135, 21);
            this.priorityBox.TabIndex = 8;
            this.priorityBox.SelectedIndexChanged += new System.EventHandler(this.priorityBox_SelectedIndexChanged);
            // 
            // todoZorx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 576);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.todoDescriptionText);
            this.Controls.Add(this.goalDatePickerText);
            this.Controls.Add(this.todoTitlePickerText);
            this.Controls.Add(this.goalDatePicker);
            this.Controls.Add(this.todoTitlePicker);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.addTodoButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "todoZorx";
            this.Text = "TodoZorx";
            this.Load += new System.EventHandler(this.todoZorx_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTodoButton;
        private System.Windows.Forms.ListBox todoList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem files;
        private System.Windows.Forms.TextBox todoTitlePicker;
        private System.Windows.Forms.DateTimePicker goalDatePicker;
        private System.Windows.Forms.TextBox todoTitlePickerText;
        private System.Windows.Forms.TextBox goalDatePickerText;
        private System.Windows.Forms.TextBox todoDescriptionText;
        private System.Windows.Forms.ComboBox priorityBox;

        
    }
}

