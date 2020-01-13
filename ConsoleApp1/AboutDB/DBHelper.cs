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
        public const string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17BANG;Integrated Security=True;";
        
        public SqlConnection Connection
        {
            get
            {
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();
                return Connection;
            }
        }

        public int ExecuteNonQuery(string cmdText , params DbParameter[] parameters)
        {
            //using (DbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    DbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = cmdText;
            //    command.Parameters.AddRange(parameters);
            //    return command.ExecuteNonQuery();
            //}
            using (DbCommand command = new SqlCommand(connectionString))
            {
                command.CommandText = cmdText;
                command.Connection = Connection;
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }

        }

        public object ExecuteScalar(string cmdText, params DbParameter[] parameters)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DbCommand command = new SqlCommand();
                command.CommandText = cmdText;
                command.Connection = connection;
                command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }
        public DbDataReader ExecuteReader(string cmdText , params DbParameter[] parameters)
        {
            //using (DbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    DbCommand command = new SqlCommand();
            //    command.CommandText = cmdText;
            //    command.Connection = connection;
            //    command.Parameters.AddRange(parameters);
            //    return command.ExecuteReader();
            //}
            
                //Connection.Open();
                using (DbCommand command = new SqlCommand())
                {
                    command.CommandText = cmdText;
                    command.Connection = Connection;
                    command.Parameters.AddRange(parameters);
                    DbDataReader reader = command.ExecuteReader();
                    return reader;
                }
        }
    }
}
