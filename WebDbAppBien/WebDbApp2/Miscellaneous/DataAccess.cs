using Models;

namespace WebDbApp2.Miscellaneous;

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

    public DbSet<Materia> Materia { get; set; }
    public DbSet<Decanato> Decanato { get; set; }
    public DbSet<Departamento> Departamento { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Data Seeding
        //Decanatos
        var decanatoDCyT = new Decanato { DecanatoId = 1, Descripcion = "Diseño, Ciencia y Tecnología" };
        var decanatoSociales = new Decanato { DecanatoId = 2, Descripcion = "CIENCIAS SOCIALES ECONÓMICA Y ADMINISTRATIVAS" };
        var decanatoSalud = new Decanato { DecanatoId = 3, Descripcion = "CIENCIAS DE LA SALUD" };
        var decanatoPosgrado = new Decanato { DecanatoId = 4, Descripcion = "POSGRADO" };
        var decanatoEducon = new Decanato { DecanatoId = 5, Descripcion = "EDUCACIÓN CONTINUA" };
        var decanatoMediaSuperior = new Decanato { DecanatoId = 6, Descripcion = "EDUCACIÓN MEDIA SUPERIOR" };
        var decanatoBasico = new Decanato { DecanatoId = 7, Descripcion = "EDUCACIÓN BÁSICA" };
        var decanatoEnLinea = new Decanato { DecanatoId = 8, Descripcion = "PROGRAMAS EN LINEA" };

        modelBuilder.Entity<Decanato>().HasData(
            decanatoDCyT,
            decanatoSociales,
            decanatoSalud,
            decanatoPosgrado,
            decanatoEducon,
            decanatoMediaSuperior,
            decanatoBasico,
            decanatoEnLinea);

        //Departamentos
        /*
            DCyT:
            RVC_ARDI DEPARTAMENTO ACADEMICO DE ARTE Y DISEÑO
            RVC_BIAM DEPTO. ACADEMICO DE BIOTECNOLOGICAS Y AMBIENTALES
            RVC_COIN Departamento Académico de Computación e Industrial
            RVC_DICO DEPARTAMENTO ACADEMICO DE DISEÑO Y CONSTRUCCION
            RVC_ELME DEPARTAMENTO ACADEMICO DE ELECTROMECANICA
            RVC_INSO DEPTO. ACADÉMICO DE INNOVACIÓN SOSTENIBLE
         */
        var arte = new Departamento { DeptoId = 1, DecanatoId = 1, Descripcion = "ARTE Y DISEÑO" };
        var biotec = new Departamento { DeptoId = 2, DecanatoId = 1, Descripcion = "BIOTECNOLOGICAS Y AMBIENTALES" };
        var computo = new Departamento { DeptoId = 3, DecanatoId = 1, Descripcion = "Computación e Industrial" };
        var diseno = new Departamento { DeptoId = 4, DecanatoId = 1, Descripcion = "DISEÑO Y CONSTRUCCION" };
        var electro = new Departamento { DeptoId = 5, DecanatoId = 1, Descripcion = "ELECTROMECANICA" };
        var innovacion = new Departamento { DeptoId = 6, DecanatoId = 1, Descripcion = "INNOVACIÓN SOSTENIBLE" };

        modelBuilder.Entity<Departamento>().HasData(arte, biotec, computo, diseno, electro, innovacion);

        //Materias
        var creatividad = new Materia { MateriaId = 1, DepartamentoId = 1, Descripcion = "Creatividad para el diseño - 7032, SM: 2022, Jul – Dic", Periodo = "2222",
            CodigoClase = "7032", UrlCurso = "https://uag.instructure.com/courses/5021", UrlDownload = "https://uag.instructure.com/courses/5021/content_exports"};
        
        var redes = new Materia { MateriaId = 2, DepartamentoId = 2, Descripcion = "Taller de Eval de Form Term - 840, CT: 2021, May – Ago", Periodo = "2132",
            CodigoClase = "840", UrlCurso = "https://uag.instructure.com/courses/21786", UrlDownload = "https://uag.instructure.com/courses/21786/content_exports"};
        
        var taller = new Materia { MateriaId = 3, DepartamentoId = 3, Descripcion = "Creatividad para el diseño - 7032, SM: 2022, Jul – Dic", Periodo = "2221",
            CodigoClase = "4406", UrlCurso = "https://uag.instructure.com/courses/2115", UrlDownload = "https://uag.instructure.com/courses/2115/content_exports"};

        modelBuilder.Entity<Materia>().HasData(creatividad, redes, taller);
    }
}