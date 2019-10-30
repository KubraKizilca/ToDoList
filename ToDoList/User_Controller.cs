using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoList
{
    class User_Controller : User
    {
        public static int uId;
        public string G_username;
       
        public void setUsername(string username)
        {
            G_username = username;
        }
        public void AddUser(string _name, string _username, string _password)
        {
            var result = 0;
            User user = new User();
            UserContext context = new UserContext();
            user.registername = _name;
            user.username = _username;
            user.password = _password;
            context.Users.Add(user);
            result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Successful!");
            }
            else
            {
                MessageBox.Show("Register Failed!");
            }
        }

        public bool Login(string _username, string _password)
        {
           
            UserContext context = new UserContext();
            User user = new User();
           
            user.username = _username;
            user.password = _password;
            var get = context.Users.Where(u => u.username == _username).FirstOrDefault<User>();
            uId = get.userId;
            if (get != null)
            {
                if (get.password == _password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
