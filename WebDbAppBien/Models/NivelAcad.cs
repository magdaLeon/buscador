using System.ComponentModel.DataAnnotations;

namespace WebDbApp.Models
{
    using System;
    using System.Collections.Generic;


    public class NivelAcad
    {
        [Key]
        public int NivelId { get; set; }
        public string? Descripcion { get; set; }
        public virtual ICollection<Decanato>? Decanatos { get; set; }
    }
}
