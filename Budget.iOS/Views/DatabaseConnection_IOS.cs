using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using SQLite;
using System;
using System.IO;
using Budget.iOS.Views;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_IOS))]

namespace Budget.iOS.Views
{
    internal class DatabaseConnection_IOS
    {
            public SQLiteConnection DbConnection()
            {
                var dbName = "Database.db";
                string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string libraryFolder = Path.Combine(personalFolder, "..", "Library");
                var path = Path.Combine(libraryFolder, dbName);
                return new SQLiteConnection(path);
            }
    }
}