using ConsoleApp1._17bang;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp1.AboutDB
{
    public class Student
    {
        //string dbPath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17BANG;Integrated Security=True;";

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal DBhepler _dbHepler;
        public Student()
        {
            if (_dbHepler == null)
            {
                _dbHepler = new DBhepler();
            }
        }

        public void Save()
        {
            _dbHepler.ExecuteNonQuery(
                $"INSERT Student VALUES({Id}, N'{Name}',{Age})");
        }

        public void SaveMore(params Student[] students)
        {
            using(DbConnection connection=new DBhepler().LongConnection)
            {
                for(int i = 0; i < students.Length; i++)
                {
                    students[i].Save();
                }
            }
        }

        public void Delete()
        {
            _dbHepler.ExecuteNonQuery(
                $"DELETE Student WHERE ID = {Id}");
        }

        public SqlDataReader Find()
        {
            SqlDataReader dataReader= _dbHepler.ExecuteReader($"SELET * FROM Student WHERE ID = {Id}");
            return dataReader;
        }
    }
}
