using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Klase
{
    class Database
    {
        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public string ConnectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI20_067_DB; User = PI20_067_User; Password = wk--I9k.;";
        public SqlConnection Connection;
        public void Connect()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }
        public void Disconnect()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
        public IDataReader GetDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }
        public object GetValue(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        public int ExecuteCommand(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
