using SQLite;

namespace Budget.Views.Service
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();

    }

}