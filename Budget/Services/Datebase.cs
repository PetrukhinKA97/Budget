using SQLite;

namespace Service
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
