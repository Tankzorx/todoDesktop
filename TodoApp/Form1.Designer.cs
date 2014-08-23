namespace TodoApp
{
    partial class Form1
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
            this.addTodo = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.files = new System.Windows.Forms.ToolStripMenuItem();
            this.todoTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.titleDescription = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTodo
            // 
            this.addTodo.Location = new System.Drawing.Point(12, 541);
            this.addTodo.Name = "addTodo";
            this.addTodo.Size = new System.Drawing.Size(379, 23);
            this.addTodo.TabIndex = 0;
            this.addTodo.Text = "Add todo!";
            this.addTodo.UseVisualStyleBackColor = true;
            this.addTodo.Click += new System.EventHandler(this.addTodo_Click);
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
            // todoTitle
            // 
            this.todoTitle.Location = new System.Drawing.Point(12, 362);
            this.todoTitle.Name = "todoTitle";
            this.todoTitle.Size = new System.Drawing.Size(379, 20);
            this.todoTitle.TabIndex = 3;
            this.todoTitle.TextChanged += new System.EventHandler(this.todoTitle_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 416);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // titleDescription
            // 
            this.titleDescription.BackColor = System.Drawing.SystemColors.Control;
            this.titleDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleDescription.Location = new System.Drawing.Point(291, 365);
            this.titleDescription.Name = "titleDescription";
            this.titleDescription.Size = new System.Drawing.Size(100, 13);
            this.titleDescription.TabIndex = 5;
            this.titleDescription.Text = "<- Insert todo title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBox1.Location = new System.Drawing.Point(12, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "When are you hoping to have this done?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 442);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 93);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High",
            "Low",
            "Medium"});
            this.comboBox1.Location = new System.Drawing.Point(12, 442);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 576);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleDescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.todoTitle);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.addTodo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTodo;
        private System.Windows.Forms.ListBox todoList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem files;
        private System.Windows.Forms.TextBox todoTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox titleDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

