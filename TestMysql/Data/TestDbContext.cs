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
    }
}
