using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;
        public MainWindow()
        {

            InitializeComponent();
            UserContext db = new UserContext();
            User user = new User();

           //user.username = "kubra";
           // user.password = "kizilca";
           // db.Users.Add(user);
           // db.SaveChanges();
           // Console.WriteLine("okey");
           // Console.ReadLine();

            //DoListContext d = new DoListContext();
            //DoList a = new DoList();
            //a.taskId = 1;
            //a.userId = user.userId;
            //a.listname = "list";
            //DoListItem z = new DoListItem();
            //z.taskId = 1;
            //z.itemname =" a";
    
            //z.itemdescription = "jdh";
            //z.status = true;
            //z.deadline = DateTime.Now;
            //d.DoListItems.Add(z);
            //d.DoLists.Add(a);
           
            //d.SaveChanges();

        }
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
        


                User_Controller userz = new User_Controller();
                string _username = ID.Text;
                string _password = Pass.Password;
                var result = userz.Login(_username, _password);

                if (result == true)
                {
                    this.Hide();
                TodoList todoList = new TodoList();
                todoList.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User/Password Error!");
                }

            
            }


        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.ShowDialog();
            this.Close();
        }



    }
}
    

