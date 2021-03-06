﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Default app size: 419; 614
namespace TodoApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTodo_Click(object sender, EventArgs e)
        {
            TodoItem item = new TodoItem();
            item.title = todoTitlePicker.Text;
            item.deadline = todoDatePicker.Value.Date;
            item.priority = todoPriorityPicker.Text;
            item.description = todoDescriptionPicker.Text;

            TodoItemList.addItem(item);
            testBox.Text = item.toString();
            testBox2.Text = TodoItemList.toString();
            todoList.DataSource = null;
            todoList.DataSource = TodoItemList.todoItemList;
      }

        private void todoTitle_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void files_Click(object sender, EventArgs e)
        {

        }

        private void priorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void todoZorx_Load(object sender, EventArgs e)
        {            
            // Init the priority box
            todoPriorityPicker.SelectedIndex = 0;
            todoPriorityPicker.DropDownStyle = ComboBoxStyle.DropDownList;

            // Init the title box
            todoTitlePicker.ForeColor = System.Drawing.SystemColors.GrayText;
            todoTitlePicker.Text = "What item do you wanna add to the todolist?";

            // Init the description box
            todoDescriptionPicker.ForeColor = System.Drawing.SystemColors.GrayText;
            todoDescriptionPicker.Text = "Add a description to the todo if you want";

            //List<string> _items = new List<string>();
            //_items.Add("One"); // <-- Add these
            //_items.Add("Two");
            //_items.Add("Three");

            //todoList.DataSource = _items;
            todoList.ItemHeight = 50;


            testBox.Text = "loaded form.";
            //todoList.DrawItem += new DrawItemEventHandler(todoList_DrawItem);
        }

        private void todoTitlePicker_Enter(object sender, EventArgs e)
        {
            if (todoTitlePicker.Text == "What item do you wanna add to the todolist?")
            {
                todoTitlePicker.ForeColor = System.Drawing.SystemColors.ControlText;
                todoTitlePicker.Text = "";
            }
            else
            {

            }
        }

        private void todoTitlePicker_Leave(object sender, EventArgs e)
        {
            if (todoTitlePicker.Text != "")
            {
                return;
            }
            else
            {
                todoTitlePicker.ForeColor = System.Drawing.SystemColors.GrayText;
                todoTitlePicker.Text = "What item do you wanna add to the todolist?";
            }
        }



        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Focus())
            //{

            //}

            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void todoTitlePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)27)
            //{
            //    todoTitlePicker.Enabled = false;
            //    todoTitlePicker.Enabled = true;
            //}
        }

        private void todoDescriptionPicker_Leave(object sender, EventArgs e)
        {
            if (todoDescriptionPicker.Text != "")
            {
                return;
            }
            else
            {
                todoDescriptionPicker.ForeColor = System.Drawing.SystemColors.GrayText;
                todoDescriptionPicker.Text = "Add a description to the todo if you want";
            }
        }

        private void todoDescriptionPicker_Enter(object sender, EventArgs e)
        {
            if (todoDescriptionPicker.Text == "Add a description to the todo if you want")
            {
                todoDescriptionPicker.ForeColor = System.Drawing.SystemColors.ControlText;
                todoDescriptionPicker.Text = "";
            }
            else
            {

            }
            
        }



        private void todoList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font dateFont = new Font(this.Font.FontFamily, 13);
            Font titleFont = new Font(this.Font.FontFamily, 12);
            //Font titleFont = new Font(this.Font, FontStyle.Bold);
            
            
            
            int index = e.Index;
            string title = TodoItemList.todoItemList[index].title;
            string priority = TodoItemList.todoItemList[index].priority;
            DateTime deadline = TodoItemList.todoItemList[index].deadline;
            string description = TodoItemList.todoItemList[index].description;

            
            StringFormat alignment = new StringFormat();

            Rectangle titleBounds = new Rectangle(e.Bounds.X,
                                                  e.Bounds.Y,
                                                  e.Bounds.Width-150,
                                                  (int)titleFont.GetHeight() + 2);

            Rectangle dateBounds = new Rectangle(e.Bounds.Width-145,
                                                   e.Bounds.Y,
                                                   98,
                                                   (int)dateFont.GetHeight() +2);

            Rectangle priorityBounds = new Rectangle(e.Bounds.Width-50,
                                                     e.Bounds.Y,
                                                     48,
                                                     48);

            //RectangleF rec = dateBounds;
            //RectangleF recf = titleBounds;

            //Rectangle titleBoundsRec = new Rectangle(e.Bounds.X,
            //                                      e.Bounds.Y,
            //                                      e.Bounds.Width,
            //                                      (int)titleFont.GetHeight() + 2);

            //Rectangle dateBoundsRec = new Rectangle(e.Bounds.X,
            //                                       e.Bounds.Y + (int)titleFont.GetHeight() + 2,
            //                                       e.Bounds.Width / 2 + 1,
            //                                       (int)titleFont.GetHeight() *2+4);

            testBox3.Text = "Draw item fired!" + e.Bounds.ToString() + titleBounds.ToString() + dateBounds.ToString();
            
            //Point uL = e.Bounds.Location;
            //Point uR = new Point(uL.X,e.Bounds.Right);
            //Point lL = new Point(uL.X, e.Bounds.Y + 50);
            //Point lR = new Point(e.Bounds.Right, e.Bounds.Y + e.Bounds.Height);
            //e.Graphics.DrawLine(new Pen(Brushes.Black, 6.0F),titleBoundsRec);
            //e.Graphics.DrawLine(new Pen(Brushes.Black, 6.0F), lL, lR);
             
            e.DrawBackground();
            todoList.BackColor = Color.Azure;
            e.Graphics.DrawString(title,titleFont,Brushes.Black,titleBounds,alignment);
            e.Graphics.DrawString(deadline.ToShortDateString(), dateFont, Brushes.Black, dateBounds, alignment);
            e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1.0F), titleBounds);
            e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1.0F), dateBounds);
            //e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1.0F), priorityBounds);
            e.Graphics.FillRectangle(Brushes.LightCoral, priorityBounds);
            
            //e.Graphics.DrawString("Date",titleFont,Brushes.Black,dateBounds,alignment);

        }



    }
}
