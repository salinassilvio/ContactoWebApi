using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos.Models.Agenda.Direccion
{
    public class CrearDireccionViewModel
    {
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int ContactoId { get; set; }
    }
}
