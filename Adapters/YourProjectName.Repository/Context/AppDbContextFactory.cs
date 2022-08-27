using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace YourProjectName.Repository.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder
                .UseSqlServer("Data Source=DSKUSRWIN01\\SQLEXPRESS;Initial Catalog=TemplateDB;Integrated Security=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
