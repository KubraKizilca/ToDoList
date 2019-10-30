using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow Main = new MainWindow();
            Main.ShowDialog();
            this.Close();
        }
        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            User_Controller user = new User_Controller();
            MainWindow main = new MainWindow();

            string _Name = Txt_Name.Text;
            string _Username = Txt_Username.Text;
            string _Password = Txt_Password.Password;

            user.AddUser(_Name, _Username, _Password);

            this.Hide();
            main.Show();
            this.Close();
        }
    }
}
