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
        const string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bangDB;Integrated Security=True;";

        public DbSet<HelpMoney> HelpMoney { get; set; }
        public DbSet<Suggest> Suggest { get; set; }
        public DbSet<Comment> Comment { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<HelpMoney>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<ArticleKind>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<Article>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<Keyword>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<Problem>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<Suggest>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<Comment>()
            //    .HasKey(k => k.Id);
            //modelBuilder.Entity<User>()
            //    .HasKey(k => k.Id);

            modelBuilder.Entity<ArticleAndKeyword>()
                .HasKey(k => new { k.ArticleId, k.KeywordId})
                ;
            modelBuilder.Entity<ArticleAndKeyword>()
                .HasOne(a=>a.Article)
                .WithMany(k=>k.KeyWords)
                .HasForeignKey(f=>f.ArticleId)
                ;
            modelBuilder.Entity<ArticleAndKeyword>()
                .HasOne(k => k.Keyword)
                .WithMany(a=>a.Articles)
                .HasForeignKey(f => f.KeywordId)
                ;

            modelBuilder.Entity<ProblemAndKeyword>()
                .HasKey(k => new { k.ProblemId, k.KeywordId })
                ;
            modelBuilder.Entity<ProblemAndKeyword>()
                .HasOne(p=>p.Problem)
                .WithMany(k=>k.keyWords)
                .HasForeignKey(f => f.ProblemId)
                ;
            modelBuilder.Entity<ProblemAndKeyword>()
                .HasOne(k=>k.Keyword)
                .WithMany(p=>p.Problems)
                .HasForeignKey(f => f.KeywordId)
                ;
        }

        public void Save(T entity)
        {
            Set<T>().Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            Set<T>().Remove(entity);
            SaveChanges();
        }

        public T Get(int id)
        {
            return Set<T>().Find(id) ;
        }


        public void SaveMore(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
                {
                Set<T>().Add(entity[i]);
                }
            SaveChanges();
        }

        public void DeleteMoe(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                Set<T>().Remove(entity[i]);
            }
            SaveChanges();
        }

        //public SqlDataReader Find()
        //{
        //    SqlDataReader dataReader = _dbHepler.ExecuteReader($"SELET * FROM Student WHERE ID = {Id}");
        //    return dataReader;
        //}

    }
}
