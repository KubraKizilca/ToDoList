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
    /// Interaction logic for TodoList.xaml
    /// </summary>
    public partial class TodoList : Window
    {
     
        public static string listname="";
        public TodoList()
        {
            InitializeComponent();
         
        DoListContext context = new DoListContext();
            var listeler = context.DoListss.ToList();

            foreach (var liste in listeler)
            {
                lbxTasks.Items.Add(liste.listname).ToString();
            }
        }
        private void addToListBox(string item)

        {
          
            lbxTasks.Items.Add(item);
            txbInput.Text = "";
        }
        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {

            if (txbInput.Text.Length == 0)
            {
                btnAdd.IsEnabled = false;
            }
            else
            {
                btnAdd.IsEnabled = true;
                if (e.Key == Key.Enter)
                {
                    addToListBox(txbInput.Text);

                }
            }
        }
        private void ListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DoListContext context = new DoListContext();

            var position = lbxTasks.SelectedIndex;
            var listeler = context.DoListss.Find(position);
            if (listeler == null)
            {
                StaticVariable.taskId = 1;
            }
            else
            {
                listeler.taskId++;
               StaticVariable.taskId = listeler.taskId;
               
            }

        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DoList_Controller DK = new DoList_Controller();
           

            string _Name = txbInput.Text;
          
            DK.addItem(_Name);
           
            addToListBox(txbInput.Text);
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DoList_Controller DK = new DoList_Controller();
            DoListContext context = new DoListContext();
            var position = lbxTasks.SelectedIndex;
            if (position == 0)
            {
                position = 1;
            }
            var listeler = context.DoListss.Find(position);

            StaticVariable.taskId = listeler.taskId;
            DK.DeleteList(StaticVariable.taskId);
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
        }
        private void ac(object sender, RoutedEventArgs e)
        {
            DoListItem todo = new DoListItem();
            listname = lbxTasks.SelectedItem.ToString();
            this.Hide();
            todo.Show();
        }
    }
}
