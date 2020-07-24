using ContactosAPP.Datos.Helpers;
using ContactosAPP.Datos.Models.Agenda.Contacto;
using ContactosAPP.Datos.Models.Agenda.Direccion;
using ContactosAPP.Entidades.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos
{
    public class RepositorioContactosAPP
    {
        #region CONTACTOS 
        public IEnumerable<ContactosViewModel> obtenerTodos()
        {
            using (var db = new DbContextContactoAPP())
            {
                var contactos = db.Contactos.ToList();

                return contactos.Select(C => new ContactosViewModel
                {
                    Id = C.Id,
                    Nombres = C.Nombres,
                    Apellidos = C.Apellidos,
                    Telefono = C.Telefono,
                    Fechanacimiento = C.Fechanacimiento
                });
            }
        }

        public Resultado crearContacto(CrearContactoViewModel model)
        {

            Contacto contacto = new Contacto
            {
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                Fechanacimiento = model.Fechanacimiento,
                Telefono = model.Telefono,
                Peso = model.Peso,
                Altura = model.Altura
            };
            using (var db = new DbContextContactoAPP())
            {
                db.Contactos.Add(contacto);
                try
                {
                    db.SaveChanges();
                    return Resultado.SendSuccess("Contacto creado correctamente");
                }
                catch (Exception ex)
                {
                    return Resultado.SendError(ex.Message);
                }
            }

        }

        public Resultado actualizarContacto(ActualizarContactoViewModel model)
        {
            if(model.Id <= 0)
            {
                return Resultado.SendError("IdContacto no exites.");
            }
            using (var db = new DbContextContactoAPP())
            {
                var Contacto = db.Contactos.FirstOrDefault(c => c.Id == model.Id);
                if(Contacto == null)
                {
                    return Resultado.SendError("Contacto no existe");
                }

                Contacto.Id = model.Id;
                Contacto.Nombres = model.Nombres;
                Contacto.Apellidos = model.Apellidos;
                Contacto.Telefono = model.Telefono;
                Contacto.Fechanacimiento = model.Fechanacimiento;
                Contacto.Peso = model.Peso;
                Contacto.Altura = model.Altura;

                try
                {
                    db.SaveChanges();
                    return Resultado.SendSuccess("Contacto Actulizado correctamente.");
                }
                catch (Exception ex)
                {
                    return Resultado.SendError(ex.Message);
                }
            }          
        }

        public Resultado eliminarContacto(int id)
        {
            if (id <= 0)
            {
                return Resultado.SendError("IdContacto no exite.");
            }
            using (var db = new DbContextContactoAPP())
            {

                var Contacto = db.Contactos.Find(id);
                if (Contacto == null)
                {
                    return Resultado.SendError("Contacto no existe");
                }
                db.Contactos.Remove(Contacto);
                try
                {
                    db.SaveChanges();
                    return Resultado.SendSuccess("Contacto Eliminado Correctamente.");
                }
                catch(Exception ex)
                {
                    return Resultado.SendError(ex.Message);
                }
               
            }
        }
        #endregion

        #region DIRECCION
        public Resultado crearDireccion(CrearDireccionViewModel model)
        {

           
            Direccion direccion = new Direccion
            {
                Descripcion = model.Descripcion,
                ContactoId = model.ContactoId,

            };
            using (var db = new DbContextContactoAPP())
            {
                var Contacto = db.Contactos.Find(model.ContactoId);
                if (Contacto == null)
                {
                    return Resultado.SendError("Contacto no existe");
                }
                db.Direcciones.Add(direccion);
                try
                {
                    db.SaveChanges();
                    return Resultado.SendSuccess("Direccion de contacro creada correctamente");
                }
                catch (Exception ex)
                {
                    return Resultado.SendError(ex.Message);
                }
            }

        }

        public Resultado actualizarDireccion(int id,ActulizarDireccionViewModel model)
        {
            if (id <= 0)
            {
                return Resultado.SendError("IdDireccion no exite.");
            }
            using (var db = new DbContextContactoAPP())
            {
                var Direccion = db.Direcciones.FirstOrDefault(d => d.Id == id);
                if (Direccion == null)
                {
                    return Resultado.SendError("IdDireccion no existe");
                }
                var Contacto = db.Contactos.FirstOrDefault(c => c.Id == model.ContactoId);
                if (Contacto == null)
                {
                    return Resultado.SendError("Contacto no existe");
                }

                Direccion.Id = id;
                Direccion.Descripcion = model.Descripcion;
                Direccion.ContactoId = model.ContactoId;        

                try
                {
                    db.SaveChanges();
                    return Resultado.SendSuccess("Direccion Actulizada correctamente.");
                }
                catch (Exception ex)
                {
                    return Resultado.SendError(ex.Message);
                }
            }
        }

        #endregion
    }
}
