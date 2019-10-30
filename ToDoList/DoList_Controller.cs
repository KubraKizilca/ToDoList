using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Web;

namespace ToDoList
{
    class DoList_Controller:DoList
    {
        public void AddList(string _name, string _itemname, string _itemdescription, string _deadline, bool _Status)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            UserContext a = new UserContext();
            DoListItemContext dlc = new DoListItemContext();
        
            doList.listname = listname;
            doListItem.itemname = _itemname;
            doListItem.itemdescription = _itemdescription;
            doListItem.deadline = _deadline;
            doListItem.status = _Status;
            doListItem.taskId = StaticVariable.taskId;
           // doList.userId = User_Controller.uId;
            //doList.doListItems.Add(doListItem);
            dlc.DoListItems.Add(doListItem);
            result=dlc.SaveChanges();
            

            if (result > 0)
            {
                MessageBox.Show("Liste Eklendi!");
            }
            else
            {
                MessageBox.Show("Liste Eklenemedi!");
            }
        }
        public void DeleteList(int taskId)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            DoListItemContext contexta = new DoListItemContext();
            UserContext a = new UserContext();
            var data = contexta.DoListItems.Where(i => i.taskId ==StaticVariable.taskId).ToList();

            var deleting = context.DoListss.Where(i => i.taskId == StaticVariable.taskId).ToList();
            foreach (var item in deleting)
            {
                context.DoListss.Remove(item);
            }
            context.SaveChanges();

        }
        public void addItem(string _name)
        {
            var result = 0;
            DoList doList = new DoList();
         
            DoListContext context = new DoListContext();
            UserContext a = new UserContext();

            doList.listname = _name;
          
            doList.userId = User_Controller.uId;
          
            context.DoListss.Add(doList);
            result = context.SaveChanges();


            if (result > 0)
            {
                MessageBox.Show("Item Eklendi!");
            }
            else
            {
                MessageBox.Show("Item Eklenemedi!");
            }
        }
        public void DeleteItem(int taskId)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            DoListItemContext contexta = new DoListItemContext();
            UserContext a = new UserContext();
            var data = contexta.DoListItems.Where(i => i.taskId == StaticVariable.taskId).ToList();

            var deleting = contexta.DoListItems.Where(i => i.taskId == StaticVariable.taskId).ToList();
            foreach (var item in deleting)
            {
                contexta.DoListItems.Remove(item);
            }
            contexta.SaveChanges();

        }
        public void UpdateItem(int taskId)
        {
            var result = 0;
            DoList doList = new DoList();
            ListItem doListItem = new ListItem();
            DoListContext context = new DoListContext();
            DoListItemContext contexta = new DoListItemContext();
            UserContext a = new UserContext();
            var data = contexta.DoListItems.Where(i => i.taskId == StaticVariable.taskId).ToList();

            var updating = contexta.DoListItems.Where(i => i.taskId == StaticVariable.taskId).FirstOrDefault();
            if (updating != null)
            {
                updating.status = true;
                result = contexta.SaveChanges();
            }
        
            if (result > 0)
            {
                MessageBox.Show("Item Güncellendi!");
            }
            else
            {
                MessageBox.Show("Item Güncellenemedi!");
            }

        }

    }
}
