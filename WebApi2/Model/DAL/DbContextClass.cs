using Microsoft.EntityFrameworkCore;
using WebApi2.Model.Entititees;

namespace WebApi2.Model.DAL
{
    public class DbContextClass : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog =WebAppDB;Integrated Security=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
