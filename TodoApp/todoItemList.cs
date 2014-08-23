using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoItemList
    {
        List<TodoItem> todoItemList { get; set; }

        void addItem(TodoItem item)
        {
            todoItemList.Add(item);
        }

        string toString()
        {
            return todoItemList.ToString();
        }
        


    }
}
