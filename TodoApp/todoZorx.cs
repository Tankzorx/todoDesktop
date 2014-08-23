using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class todoZorx : Form
    {
        public todoZorx()
        {
            InitializeComponent();
        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTodo_Click(object sender, EventArgs e)
        {

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
            priorityBox.SelectedIndex = 0;
            priorityBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
