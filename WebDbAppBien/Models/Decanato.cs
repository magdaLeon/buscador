namespace WebDbApp.Models
{
    public class Decanato
    {
        public int DecanatoId { get; set; }
        public string? Descripcion { get; set; }
        public ICollection<Materia> Materias { get; } = new List<Materia>(); // Collection navigation containing dependents

    }
}