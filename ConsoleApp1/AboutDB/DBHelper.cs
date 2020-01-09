using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp1.AboutDB
{
    //构建一个DBHelper，可以提供：
    //封装过后的ExecuteNonQuery()/ExecuteScalar()/ExecuteReader()方法
    //由外部控制开闭（Open()/Close()）的长连接（LongConnection）
    //ExecuteNonQuery()使用长连接的重载

    public class DBhepler
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17BANG;Integrated Security=True;";

        private SqlConnection _connection;
        public SqlConnection Connection
        {
            get
            {
                _connection = _connection ?? new SqlConnection(connectionString);
                return _connection;
            }
            
        }

        private SqlConnection _longConnection;
        public SqlConnection LongConnection
        {
            get
            {
                _longConnection = _longConnection ?? new SqlConnection(connectionString);
                return _longConnection; 
            }
        }
        public int ExecuteNonQuery(string cmdText)
        {
            if (new DBhepler().LongConnection.State==ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            command.Connection = LongConnection;
            int AffectedRows = command.ExecuteNonQuery();
            return AffectedRows;
        }

        public object ExecuteScalar(string cmdText)
        {

            if (new DBhepler().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            command.Connection = LongConnection;
            object obj = command.ExecuteScalar();
            return obj;
            
            
        }
        public SqlDataReader ExecuteReader(string cmdText)
        {
            if (new DBhepler().LongConnection.State==ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandText = cmdText;
            command.Connection = LongConnection;
            SqlDataReader sqlConnection = command.ExecuteReader();
            return sqlConnection;
        }
    }
}
