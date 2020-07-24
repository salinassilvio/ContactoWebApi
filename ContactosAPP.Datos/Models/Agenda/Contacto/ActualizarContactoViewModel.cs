using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos.Models.Agenda.Contacto
{
    public class ActualizarContactoViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 3,
            ErrorMessage = "El nombre no debe de tener más de 50 caracteres, ni menos de 3 caracteres.")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 3,
            ErrorMessage = "El apellido no debe de tener más de 50 caracteres, ni menos de 3 caracteres.")]
        public string Apellidos { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public string Telefono { get; set; }
        [Required]
        public decimal Peso { get; set; }
        [Required]
        public decimal Altura { get; set; }
    }
}
