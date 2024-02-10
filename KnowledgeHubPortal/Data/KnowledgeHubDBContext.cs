using KnowledgeHubPortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace KnowledgeHubPortal.Data
{
    public class KnowledgeHubDBContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog =WebAppDB;Integrated Security=True");
        }

        public DbSet<Category> categories { get; set; }
    }
}
