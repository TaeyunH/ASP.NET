using System.Collections.Generic;

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public List<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}
