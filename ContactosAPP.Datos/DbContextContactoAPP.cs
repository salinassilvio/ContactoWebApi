using ContactosAPP.Entidades.Agenda;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosAPP.Datos
{
    public class DbContextContactoAPP:DbContext
    {
        //constructor
        public DbContextContactoAPP() 
            : base("name=ContactoDB")
        {
        }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
