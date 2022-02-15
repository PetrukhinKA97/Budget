using SQLite;
using System.IO;
using Budget.Droid.Views;
using Service;

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