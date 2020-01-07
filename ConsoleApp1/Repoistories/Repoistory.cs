using ConsoleApp1._17bang;
using ConsoleApp1.AboutDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Repoistories
{
    //定义一个仓库（Repoistory）类，其中包含：
    //一个int类型的常量version
    //一个静态只读的字符串connection，
    //以后可用于连接数据库,思考Respoitory应该是static类还是实例类更好
    
    public class Repoistory<T> : DbContext
        where T:class
    {
        //const int version = 99;
        //static readonly string connection;

        public DbSet<T> entities { get; set; }

        public DbContext CurrentContext { get; set; }
        public void Flush()
        {
            CurrentContext.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB17bang;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);  
        }

        public void Save(T entity)
        {
            entities.Add(entity);
            Flush();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            Flush();
        }

        public T Get(int id)
        {
            return entities.Find(id) ;
        }


        public void SaveMore(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
                {
                    entities.Add(entity[i]);
                }
            Flush();
        }

        public void DeleteMoe(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                entities.Remove(entity[i]);
            }
            Flush();
        }

        //public SqlDataReader Find()
        //{
        //    SqlDataReader dataReader = _dbHepler.ExecuteReader($"SELET * FROM Student WHERE ID = {Id}");
        //    return dataReader;
        //}

    }
}
