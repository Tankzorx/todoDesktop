using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TodoApp
{
    public class TodoItemList
    {
        public static List<TodoItem> todoItemList = new List<TodoItem>();

        List<TodoItem> getTodoItemList()
        {
            return todoItemList;
        }

        public static void addItem(TodoItem item)
        {
            todoItemList.Add(item);
        }

        public static string toString()
        {
            string list = "";
            foreach (TodoItem item in todoItemList)
            {
                list = list + item.toString() + "::::";

            }
            return list;
        }

        public static void removeItem(TodoItem item)
        {
            todoItemList.Remove(item);
        }
        


    }
}
