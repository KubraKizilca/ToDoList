using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class DoListItemContext:DbContext
    {
     
    
        public DoListItemContext() : base("toDoListDB")
        {

        }

        public DbSet<ListItem> DoListItems { get; set; }
    }
}
