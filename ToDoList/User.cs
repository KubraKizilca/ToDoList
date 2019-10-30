using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class User
    {
        public int userId { get; set; }
        public string registername { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<DoList> doList { get; set; } = new List<DoList>();

    }
}
