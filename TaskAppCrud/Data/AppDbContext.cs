
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskAppCrud.Models;


namespace TaskAppCrud.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<MyTask> MyTask { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }


    }
}
