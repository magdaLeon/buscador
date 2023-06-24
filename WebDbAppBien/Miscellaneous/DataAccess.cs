namespace WebDbApp.Miscellaneous;

using Microsoft.EntityFrameworkCore;
using WebDbApp.Models;

public class DataAccess : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataAccess(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        // options.UseInMemoryDatabase("TestDb");
        options.UseSqlite(Configuration.GetConnectionString("MyDatabase"));
    }

    public DbSet<Course>? Courses{ get; set; }

    public DbSet<Materia>? Materia { get; set; }

    public DbSet<Decanato>? Decanato { get; set; }


      
}