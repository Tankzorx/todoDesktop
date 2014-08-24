namespace TodoApp
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.addTodoButton = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.files = new System.Windows.Forms.ToolStripMenuItem();
            this.todoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.goalDatePickerText = new System.Windows.Forms.TextBox();
            this.todoDescriptionPicker = new System.Windows.Forms.TextBox();
            this.todoPriorityPicker = new System.Windows.Forms.ComboBox();
            this.todoTitlePicker = new System.Windows.Forms.TextBox();
            this.testBox = new System.Windows.Forms.TextBox();
            this.testBox2 = new System.Windows.Forms.TextBox();
            this.todoItemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addTodoButton
            // 
            this.addTodoButton.Location = new System.Drawing.Point(12, 506);
            this.addTodoButton.Name = "addTodoButton";
            this.addTodoButton.Size = new System.Drawing.Size(379, 58);
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
            this.todoList.SelectedIndexChanged += new System.EventHandler(this.todoList_SelectedIndexChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.files});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
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
            // todoDatePicker
            // 
            this.todoDatePicker.Location = new System.Drawing.Point(218, 388);
            this.todoDatePicker.Name = "todoDatePicker";
            this.todoDatePicker.Size = new System.Drawing.Size(135, 20);
            this.todoDatePicker.TabIndex = 4;
            // 
            // goalDatePickerText
            // 
            this.goalDatePickerText.BackColor = System.Drawing.SystemColors.Control;
            this.goalDatePickerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalDatePickerText.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.goalDatePickerText.Location = new System.Drawing.Point(12, 388);
            this.goalDatePickerText.Name = "goalDatePickerText";
            this.goalDatePickerText.Size = new System.Drawing.Size(200, 13);
            this.goalDatePickerText.TabIndex = 6;
            this.goalDatePickerText.Text = "When are you hoping to have this done?";
            // 
            // todoDescriptionPicker
            // 
            this.todoDescriptionPicker.Location = new System.Drawing.Point(153, 407);
            this.todoDescriptionPicker.Multiline = true;
            this.todoDescriptionPicker.Name = "todoDescriptionPicker";
            this.todoDescriptionPicker.Size = new System.Drawing.Size(238, 93);
            this.todoDescriptionPicker.TabIndex = 7;
            this.todoDescriptionPicker.Enter += new System.EventHandler(this.todoDescriptionPicker_Enter);
            this.todoDescriptionPicker.Leave += new System.EventHandler(this.todoDescriptionPicker_Leave);
            // 
            // todoPriorityPicker
            // 
            this.todoPriorityPicker.Items.AddRange(new object[] {
            "Priority",
            "High",
            "Low",
            "Medium"});
            this.todoPriorityPicker.Location = new System.Drawing.Point(12, 407);
            this.todoPriorityPicker.Name = "todoPriorityPicker";
            this.todoPriorityPicker.Size = new System.Drawing.Size(135, 21);
            this.todoPriorityPicker.TabIndex = 8;
            this.todoPriorityPicker.SelectedIndexChanged += new System.EventHandler(this.priorityBox_SelectedIndexChanged);
            // 
            // todoTitlePicker
            // 
            this.todoTitlePicker.ForeColor = System.Drawing.SystemColors.InfoText;
            this.todoTitlePicker.Location = new System.Drawing.Point(12, 362);
            this.todoTitlePicker.Name = "todoTitlePicker";
            this.todoTitlePicker.Size = new System.Drawing.Size(379, 20);
            this.todoTitlePicker.TabIndex = 3;
            this.todoTitlePicker.TextChanged += new System.EventHandler(this.todoTitle_TextChanged);
            this.todoTitlePicker.Enter += new System.EventHandler(this.todoTitlePicker_Enter);
            this.todoTitlePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.todoTitlePicker_KeyPress);
            this.todoTitlePicker.Leave += new System.EventHandler(this.todoTitlePicker_Leave);
            // 
            // testBox
            // 
            this.testBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.testBox.Location = new System.Drawing.Point(397, 27);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(242, 142);
            this.testBox.TabIndex = 9;
            // 
            // testBox2
            // 
            this.testBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.testBox2.Location = new System.Drawing.Point(397, 175);
            this.testBox2.Multiline = true;
            this.testBox2.Name = "testBox2";
            this.testBox2.Size = new System.Drawing.Size(242, 142);
            this.testBox2.TabIndex = 10;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 576);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.testBox2);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.todoPriorityPicker);
            this.Controls.Add(this.todoDescriptionPicker);
            this.Controls.Add(this.goalDatePickerText);
            this.Controls.Add(this.todoDatePicker);
            this.Controls.Add(this.todoTitlePicker);
            this.Controls.Add(this.addTodoButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "TodoZorx";
            this.Load += new System.EventHandler(this.todoZorx_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTodoButton;
        private System.Windows.Forms.ListBox todoList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem files;
        private System.Windows.Forms.DateTimePicker todoDatePicker;
        private System.Windows.Forms.TextBox goalDatePickerText;
        private System.Windows.Forms.TextBox todoDescriptionPicker;
        private System.Windows.Forms.ComboBox todoPriorityPicker;
        private System.Windows.Forms.TextBox todoTitlePicker;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.BindingSource todoItemListBindingSource;
        private System.Windows.Forms.TextBox testBox2;
        
    }
}

