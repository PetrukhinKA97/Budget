using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Budget.Views.Model;
using Budget.Views.Service;
using SQLite;
using Xamarin.Forms;

namespace Budget.Views.ViewModel
{
    public class VMExpenses : INotifyPropertyChanged
    {
        private SQLiteConnection database;
        public event PropertyChangedEventHandler PropertyChanged;
        private MExpenses VM_Expenses;
        private List <MExpenses> VM_List_Expenses;

        public VMExpenses()
        {
            VM_Expenses = new MExpenses();
        }

        public VMExpenses(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<MExpenses>();
        }
        public void SaveItem(MExpenses V_Expenses)
        {
            database.Insert(V_Expenses); 
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public List<MExpenses> Update()
        {
            return database.Table<MExpenses>().ToList();
        }
    }
}
