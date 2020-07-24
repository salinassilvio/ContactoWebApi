using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos.Models.Agenda.Contacto
{
    public class ContactosViewModel
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public string Telefono { get; set; }
    }
}
