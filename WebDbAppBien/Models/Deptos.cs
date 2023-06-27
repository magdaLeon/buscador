namespace WebDbApp.Models
{

    public class Deptos
    {
        public int DeptoID { get; set; }
        public Decanato Decanato { get; set; }
        public ICollection<Materia> Materias { get; } = new List<Materia>();
        public string? Descripcion { get; set; }


    }
}
