/*using System.Data.SQLite;
using System.IO;

class database
{
    public SQLiteConnection myconnection;

    public database()
    {
         myconnection = new SQLiteConnection("Data Source=hospitalms.sqlite3");
         myconnection.Open();
    }
    public void open()
    {
        if (myconnection.State != System.Data.ConnectionState.Open)
        {
            myconnection.Open();
        }
    }
    public void close()
    {
        if (myconnection.State == System.Data.ConnectionState.Open)
        {
            myconnection.Close();
        }

    }
}*/