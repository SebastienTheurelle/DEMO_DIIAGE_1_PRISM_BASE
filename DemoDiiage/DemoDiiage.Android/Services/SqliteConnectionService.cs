using System.IO;
using System.Runtime.CompilerServices;
using DemoDiiage.Android.Services;
using DemoDiiage.Repositories.Interface;
using DemoDiiage.Services.Interfaces;
using SQLite;


namespace DemoDiiage.Android.Services
{
    public class SqliteConnectionService : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "DemoDiiage.db";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}