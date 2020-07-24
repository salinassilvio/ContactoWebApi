using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Entidades.Agenda
{
    [Table("Contacto")]
    public class Contacto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(80)]
        public string Apellidos { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public string Telefono { get; set; }
        [Required]
        public decimal Peso { get; set; }
        [Required]
        public decimal Altura { get; set; }
        public List<Direccion> Direcciones { get; set; }

    }
}
