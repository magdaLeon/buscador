using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("NivelAcademico")]
    public class NivelAcademico
    {
        [Key]
        public int NivelId { get; set; }
        public string? Descripcion { get; set; }
        public virtual ICollection<Decanato>? Decanatos { get; set; }
    }
}
