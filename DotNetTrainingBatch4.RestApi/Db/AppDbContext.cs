using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch4.RestApi.Models;


namespace DotNetTrainingBatch4.RestApi.Db
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
        }
        public DbSet<BlogModel> Blog { get; set; }

    }
}
