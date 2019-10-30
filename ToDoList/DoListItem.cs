using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public  class ListItem
    {
        [Key]
        public int taskItemId { get; set; }
        public int taskId { get; set; }
        public string itemname { get; set; }
        public string itemdescription { get; set; }
        public string deadline { get; set; }
        public Boolean status { get; set; }
      
    }
}
