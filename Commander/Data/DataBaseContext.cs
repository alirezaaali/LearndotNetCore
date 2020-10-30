using System.Data;
namespace Data
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataBaseContext(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Command> Commands { get; set; }

    }

}