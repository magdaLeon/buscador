using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    public class Departamento
    {
        [Key]
        public int DeptoId { get; set; }
        [ForeignKey("Decanato")] 
        public int DecanatoId { get; set; }
        public Decanato? Decanato { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Materia> Materias { get; } = new List<Materia>();
    }
}
