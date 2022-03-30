// See https://aka.ms/new-console-template for more information
using TestMysql.Data;

namespace TestMysql
{
    public class TestMysql
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var context = new TestDbContext();

            var emp = new Employee() { Name = "fuzz 234243", Email = "hiiii"};
            context.Employees.Add(emp); 
            context.SaveChanges();

            var list = context.Employees.ToList();
            foreach(var outputEmp in list)
            {
                Console.WriteLine("Employee {0}", emp.Name);
            }
        }
    }
}
    
