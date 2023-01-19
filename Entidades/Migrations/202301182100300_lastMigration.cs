namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Matricula = c.String(nullable: false, maxLength: 50, unicode: false),
                        Especialidad = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        PostGrado = c.String(maxLength: 50, unicode: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Pacientes", "MedicoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pacientes", "MedicoId");
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropColumn("dbo.Pacientes", "MedicoId");
            DropTable("dbo.Medicos");
        }
    }
}
