using System.Data;
namespace Data
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Command> Commands { get; set; }

    }

}