using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Entidades.Agenda
{
    [Table("Direccion")]
    public class Direccion
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int ContactoId { get; set; }
        [ForeignKey("ContactoId")]
        public Contacto Contacto { get; set; }

    }
}
