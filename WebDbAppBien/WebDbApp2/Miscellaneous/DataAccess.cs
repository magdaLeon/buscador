using Models;

namespace WebDbApp.Miscellaneous;

using Microsoft.EntityFrameworkCore;

public class DataAccess : DbContext
{
    protected readonly IConfiguration Configuration;

    //public DataAccess(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        // options.UseInMemoryDatabase("TestDb");
        //options.UseSqlite(Configuration.GetConnectionString("MyDatabase"));
        options.UseSqlite("Data Source=training.sqlite");
    }

    public DbSet<Course>? Courses { get; set; }
    public DbSet<Materia>? Materia { get; set; }
    public DbSet<NivelAcademico> NivelAcademico { get; set; }
    public DbSet<Decanato>? Decanato { get; set; }
    public DbSet<Departamento> Departamento { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Nivel Academico 

        var educacionBasica = new NivelAcademico { NivelId = 1, Descripcion = "EDUCACION BASICA" };
        var educacionMedia = new NivelAcademico { NivelId = 2, Descripcion = "EDUCACION MEDIA" };
        var educacionSuperior = new NivelAcademico { NivelId = 3, Descripcion = "EDUCACION SUPERIOR" };

        modelBuilder.Entity<NivelAcademico>()
            .HasMany<Decanato>(nivel => nivel.Decanatos)
            .WithOne()
            .HasForeignKey(decanato => decanato.NivelId);
        
        modelBuilder.Entity<NivelAcademico>()
            .HasData(educacionBasica, educacionMedia, educacionSuperior);

        //Decanatos
        //var decanatoDCyT = new Decanato { DecanatoId = 1, Nivel = educacionSuperior, Descripcion = "DCyT" };
        //modelBuilder.Entity<Decanato>().HasData(decanatoDCyT);
        //
        // modelBuilder.Entity<Post>().HasData(
        //     new { BlogId = 1, PostId = 2, Title = "Second post", Content = "Test 2" });
        //
        // modelBuilder.Entity<Post>().OwnsOne(p => p.AuthorName).HasData(
        //     new { PostId = 1, First = "Andriy", Last = "Svyryd" },
        //     new { PostId = 2, First = "Diego", Last = "Vega" });

        //this.SaveChanges();
    }
}