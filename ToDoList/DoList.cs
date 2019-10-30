using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class DoList
    {
        [Key]
        public int taskId { get; set; }
        public int userId { get; set; }
        public string listname { get; set; }
        public List<ListItem> doListItems { get; set; } = new List<ListItem>();

    }
    
}
