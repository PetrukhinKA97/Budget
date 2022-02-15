using System.Collections.Generic;
using System.ComponentModel;
using Model;
using SQLite;

namespace ViewModel
{
    public class VMExpenses : INotifyPropertyChanged
    {
        private SQLiteConnection database;
        public event PropertyChangedEventHandler PropertyChanged;
        private MExpenses VM_Expenses;
        private List<MExpenses> List_;

        public List<MExpenses> List_Expenses
        {
            get
            { return database.Table<MExpenses>().ToList(); }
            set { List_ = value; }
        }

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

        public void Delete(object i)
        {
            database.Delete(i);
        }
        public void Update(object i)
        {

            database.Update(i);
        }
    }
}
