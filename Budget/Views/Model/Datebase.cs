using Budget_databes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Budget.Views;
using Xamarin.Forms;

namespace Budget.Views.Database
{
    public class Datebase
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();
        public ObservableCollection<BExpenses> Expenses { get; set; }

        public void BExpenses()
        {
            VExpenses_add.GetMenu(App.Current.AutomationId)
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<BExpenses>();
            this.Expenses = new ObservableCollection<BExpenses>(database.Table<BExpenses>());
            // If the table is empty, initialize the collection
            if (!database.Table<BExpenses>().Any())
            {
                AddNewBExpenses();
            }
        }

        private void AddNewBExpenses()
        {
            this.Expenses.
            Add(new BExpenses
            {
                Name = va
                Type_expenses = "Address...",
                Importance = "Country...",
                Data = "Company name...",
                Amount = "Address...",
                Number = "Country...",
                Volume = "Company name..."
            });
        }
    }
}
