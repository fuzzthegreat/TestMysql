using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMysql.Data
{
    public class TestDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=10.0.55.176;user=root;password=t81vDl9RjD;database=testing";

            var version = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connectionString, version);
        }
    }
}
