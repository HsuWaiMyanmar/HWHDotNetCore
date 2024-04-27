using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWHDotNetCore.ConsoleApp.Dtos;
using HWHDotNetCore.ConsoleApp.Services;

namespace HWHDotNetCore.ConsoleApp.EFCoreExamples
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
        }
        public DbSet<BlogDto> Blog { get; set; }

    }
}
