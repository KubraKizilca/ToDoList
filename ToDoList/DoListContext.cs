using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class DoListContext:DbContext
    {
        public DoListContext() : base("toDoListDB")
        {

        }
        public DbSet<DoList> DoListss { get; set; }
        //public DbSet<DoListItem> DoListItems { get; set; }
        //public DbSet<User> users { get; set; }
    }
}
