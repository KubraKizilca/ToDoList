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
    /// Interaction logic for DoListItem.xaml
    /// </summary>
    public partial class DoListItem : Window
    {

        bool isUserInteraction;
        public DoListItem()
        {


            InitializeComponent();

            DoListItemContext context = new DoListItemContext();
            var data = context.DoListItems.Where(i => i.taskId == StaticVariable.taskId).ToList();



            foreach (var liste in data)
            {
                lbx.Items.Add(liste.itemname + " " + liste.itemdescription + " " + liste.status + " " + liste.deadline).ToString();
            }

        }
    
        private void addToListBox(string item)

        {

            lbx.Items.Add(item);
         
        }
        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {

          
                if (e.Key == Key.Enter)
                {
                    addToListBox(txt_name.Text+""+txt_description);

                }
            
        }

        private void kaydet(object sender, RoutedEventArgs e)
        {

            DoList_Controller DK = new DoList_Controller();


            string _Name ="" ;
            string _itemname = txt_name.Text;
            string _itemdescription = txt_description.Text;
            bool _status = false;
            string _deadline = txt_deadline.Text;
            DK.AddList(_Name, _itemname, _itemdescription, _deadline, _status);
            lbx.Items.Add(_Name).ToString();

        }
        private void ListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
            //string sMessageBoxText = "What do you want?";
            //string sCaption = "My Test Application";

            //MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
            //MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            //MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            //switch (rsltMessageBox)
            //{
            //    case MessageBoxResult.Yes:
            //        /* ... */
            //        break;

            //    case MessageBoxResult.No:
            //        /* ... */
            //        break;

            //    case MessageBoxResult.Cancel:
            //        /* ... */
            //        break;
            //}
            DoListContext context = new DoListContext();

                var position = lbx.SelectedIndex;
                var listeler = context.DoListss.Find(position);
            if (listeler==null)
            {
                StaticVariable.taskId = 1;
            }
            else
            {
              
                StaticVariable.taskId = listeler.taskId;
            }

                
        }
   
        private void sil(object sender, RoutedEventArgs e)
        {
            DoList_Controller DK = new DoList_Controller();
            DoListContext context = new DoListContext();
            var position = lbx.SelectedIndex;
            if (position == 0)
            {
                position = 1;
            }
            var listeler = context.DoListss.Find(position);

            StaticVariable.taskId = listeler.taskId;
            DK.DeleteItem(StaticVariable.taskId);

        }

        private void guncelle(object sender, RoutedEventArgs e)
        {
            DoList_Controller DK = new DoList_Controller();
            DoListContext context = new DoListContext();
            var position = lbx.SelectedIndex;
            if (position == 0)
            {
                position = 1;
            }
            var listeler = context.DoListss.Find(position);
            if (complete.IsChecked==true){
                StaticVariable.taskId = listeler.taskId;
                DK.UpdateItem(StaticVariable.taskId);
            }
            
           
        }

        private void name_Checked(object sender, RoutedEventArgs e)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            DoListItemContext contexta = new DoListItemContext();
            UserContext a = new UserContext();
            var ordering = contexta.DoListItems.OrderBy(i =>i.itemname).ToList();
            lbx.Items.Clear();
            foreach (var item in ordering)
            {
                
                lbx.Items.Add(item.itemname + " " + item.itemdescription).ToString();
            }
            context.SaveChanges();

        }

        private void status_Checked(object sender, RoutedEventArgs e)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            DoListItemContext contexta = new DoListItemContext();
            UserContext a = new UserContext();
            var ordering = contexta.DoListItems.OrderBy(i => i.status).Where(i=>i.status==true).ToList();
            lbx.Items.Clear();
            foreach (var item in ordering)
            {

                lbx.Items.Add("Tamamlandı"+item.itemname + " " + item.itemdescription).ToString();
            }
            context.SaveChanges();
        }
    }
    }

