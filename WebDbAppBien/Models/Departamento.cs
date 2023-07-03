using System.ComponentModel.DataAnnotations;

namespace Models
{

    public class Departamento
    {
        [Key]
        public int DeptoId { get; set; }
        public Decanato? Decanato { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Materia> Materias { get; } = new List<Materia>();
    }
}
