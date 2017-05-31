using ControleCompra.Storage.Interfaces;
using SQLite;
using Xamarin.Forms;
using ControleCompra.Droid.Storage;

[assembly: Dependency( typeof( SQLiteAndroid ) )]

namespace ControleCompra.Droid.Storage
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "DataBase.db3";
            string documentsPath = System.Environment.GetFolderPath( System.Environment.SpecialFolder.Personal );
            var path = System.IO.Path.Combine( documentsPath , sqliteFileName );
            var conn = new SQLiteConnection( path );
            return conn;
        }
    }
}