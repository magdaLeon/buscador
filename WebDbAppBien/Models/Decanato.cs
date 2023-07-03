using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    [PrimaryKey(nameof(DecanatoId))]
    public class Decanato
    {
        [Key] 
        public int DecanatoId { get; set; }
        public string? Descripcion { get; set; }
        [ForeignKey("NivelAcademico")] 
        public int NivelId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }
        public ICollection<Departamento> Departamentos { get; } = new List<Departamento>();
    }
}