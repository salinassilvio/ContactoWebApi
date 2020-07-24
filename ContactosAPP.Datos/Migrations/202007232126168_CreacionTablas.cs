namespace ContactosAPP.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 80),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        Fechanacimiento = c.DateTime(nullable: false),
                        Telefono = c.String(),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        ContactoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacto", t => t.ContactoId, cascadeDelete: true)
                .Index(t => t.ContactoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Direccion", "ContactoId", "dbo.Contacto");
            DropIndex("dbo.Direccion", new[] { "ContactoId" });
            DropTable("dbo.Direccion");
            DropTable("dbo.Contacto");
        }
    }
}
