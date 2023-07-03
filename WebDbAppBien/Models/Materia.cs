using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }
        [ForeignKey("Depto")]
        public int DepartamentoId { get; set; }
        public Departamento? Depto { get; set; }
        public string? Descripcion { get; set; }
        public string? NivelASU { get; set; }
        public string? CursosASU { get; set; }
        public string? ObjetivoAprend { get; set; }
        public string? Creditos { get;set; }
        public string? FechaIni { get; set; }
        public string? FechaActualizacion { get; set;}
        public string? Version { get; set; }
        public string? UrlCurso { get; set;}
        public string? UrlDownload { get; set; }
        public string? CodigoClase { get; set; }
        public string? Term { get; set; }
    }
}
