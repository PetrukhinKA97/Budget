namespace Service
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();

    }

}