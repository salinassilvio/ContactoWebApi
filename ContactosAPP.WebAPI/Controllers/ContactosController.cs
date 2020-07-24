using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ContactosAPP.Datos;
using ContactosAPP.Datos.Helpers;
using ContactosAPP.Datos.Models.Agenda.Contacto;
using ContactosAPP.Entidades.Agenda;

namespace ContactosAPP.WebAPI.Controllers
{
    [RoutePrefix("api/Contacto")]
    public class ContactosController : ApiController
    {
        private RepositorioContactosAPP _repo;

        public ContactosController()
        {
            _repo = new RepositorioContactosAPP();
        }
        // GET: api/Contactoes/listar
        [Route("ListarContactos")]
        [HttpGet]
        public async Task<IEnumerable<ContactosViewModel>> ListarContactos() => await Task.FromResult(_repo.obtenerTodos());

        // POST: api/Contactos/Crear
        [Route("CrearContacto")]
        [HttpPost]
        public async Task<Resultado> CrearContacto([FromBody] CrearContactoViewModel Contacto) => await Task.FromResult(_repo.crearContacto(Contacto));

        // PUT: api/Contactos/Actualizar
        [Route("ActualizarContacto")]
        [HttpPut]
        public async Task<Resultado> ActualizarContacto([FromBody] ActualizarContactoViewModel Contacto) => await Task.FromResult(_repo.actualizarContacto(Contacto));

        // DELETE: api/Contactos/EliminarContacto Id=5
        [Route("EliminarContacto")]
        [HttpDelete]
        public async Task<Resultado> EliminarContacto([FromUri] int id) => await Task.FromResult(_repo.eliminarContacto(id));

    }
}