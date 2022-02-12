using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Budget.Views;
using Xamarin.Forms;
using Budget.Views.Model;
using System.Threading.Tasks;

namespace Budget.Views.Service
{
    public class Datebase
    {
        private SQLiteAsyncConnection database;

        public Datebase(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

       


    }
}
