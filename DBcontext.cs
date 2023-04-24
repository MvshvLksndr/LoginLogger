using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace LoginLogger
{
    internal class DBcontext : DbContext
    {
        
        string cs = "FileName = logs.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(cs);
        }
        public DbSet<Log> logs { get; set; }
    }

    

    public class Log
    {
        [Key]
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime Date { get; set; }
        public string Ip { get; set; }
        public string Host { get; set; }
        public bool Successful { get; set; }

    }
}