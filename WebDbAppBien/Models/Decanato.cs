namespace WebDbApp.Models
{
    public class Decanato
    {
        public int DecanatoId { get; set; }
        public string? Descripcion { get; set; }
        public Nivel Nivel { get; set; }
        public ICollection<Deptos> Departamentos { get; } = new List<Deptos>();

    }
}