using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoItem
    {
        //public TodoItem();

        public string title { get; set; }
        public DateTime deadline { get; set; }
        public string priority { get; set; }
        public string description { get; set; }

        public string toString()
        {
            return "Title: " + title + ", deadline: " + deadline.ToShortDateString() + ", priority: " + priority.ToString() + ", description: " + description;
        }
    }
}
