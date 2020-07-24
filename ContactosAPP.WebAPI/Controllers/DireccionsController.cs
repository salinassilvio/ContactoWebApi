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
using ContactosAPP.Datos.Models.Agenda.Direccion;
using ContactosAPP.Entidades.Agenda;

namespace ContactosAPP.WebAPI.Controllers
{
    [RoutePrefix("api/Direccion")]
    public class DireccionsController : ApiController
    {
        private RepositorioContactosAPP _repo;

        public DireccionsController()
        {
            _repo = new RepositorioContactosAPP();
        }

        // POST: api/Direccion/Crear
        [Route("CrearDireccion")]
        [HttpPost]
        public async Task<Resultado> CrearDireccion([FromBody] CrearDireccionViewModel Direccion) => await Task.FromResult(_repo.crearDireccion(Direccion));

        // PUT: api/Direccion/Actualizar
        [Route("ActualizarContacto")]
        [HttpPut]
        public async Task<Resultado> ActualizarDireccion([FromUri] int id,[FromBody] ActulizarDireccionViewModel Direccion) => await Task.FromResult(_repo.actualizarDireccion(id,Direccion));


    }
}