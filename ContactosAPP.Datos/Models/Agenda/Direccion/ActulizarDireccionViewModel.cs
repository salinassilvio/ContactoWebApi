using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos.Models.Agenda.Direccion
{
    public class ActulizarDireccionViewModel
    {
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int ContactoId { get; set; }

    }
}
