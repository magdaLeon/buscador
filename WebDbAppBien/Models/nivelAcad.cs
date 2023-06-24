namespace WebDbApp.Models
{
    using System;
    using System.Collections.Generic;


    public class Nivel
    {
        public int NivelID { get; set; }
        public string? Descripcion { get; set; }
        

        public virtual ICollection<Decanato>? Decanatos { get; set; }
    }
}
