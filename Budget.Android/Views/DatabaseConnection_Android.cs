using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Budget_databes;
using System.IO;
using Budget.Droid.Views;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]

namespace Budget.Droid.Views
{
    internal class DatabaseConnection_Android : IDatabaseConnection
    {
            public SQLiteConnection DbConnection()
            {
                var dbName = "Database.db";
                var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
                return new SQLiteConnection(path);
            }
    }   
}