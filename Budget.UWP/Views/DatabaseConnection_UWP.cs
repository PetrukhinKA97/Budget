using SQLite;
using Xamarin.Forms;
using Windows.Storage;
using System.IO;
using Budget.UWP.Views;
using Service;

[assembly: Dependency(typeof(DatabaseConnection_UWP))]

namespace Budget.UWP.Views
{
    internal class DatabaseConnection_UWP : IDatabaseConnection
    {
            public SQLiteConnection DbConnection()
            {
                var dbName = "Database.db";
                var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
                return new SQLiteConnection(path);
            }
    }
}
