using System.ComponentModel.DataAnnotations;

namespace WebDbApp.Models
{

    public class DeptoAcad
    {
        [Key]
        public int DeptoId { get; set; }
        public Decanato DecanatoId { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Materia> Materias { get; } = new List<Materia>();
    }
}
