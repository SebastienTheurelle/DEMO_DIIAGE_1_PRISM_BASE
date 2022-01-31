using SQLite;

namespace DemoDiiage.Repositories.Interface
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}