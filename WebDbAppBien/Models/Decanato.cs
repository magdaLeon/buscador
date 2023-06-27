using System.ComponentModel.DataAnnotations;

namespace WebDbApp.Models
{
    public class Decanato
    {
        [Key]
        public int DecanatoId { get; set; }
        public string? Descripcion { get; set; }
        public NivelAcad NivelAcadAcademico { get; set; }
        public ICollection<DeptoAcad> Departamentos { get; } = new List<DeptoAcad>();

    }
}