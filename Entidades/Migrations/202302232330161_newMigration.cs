namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                        HabitacionId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Habitaciones", t => t.HabitacionId, cascadeDelete: true)
                .ForeignKey("dbo.Medicos", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.MedicoId)
                .Index(t => t.HabitacionId);
            
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
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropTable("dbo.Medicos");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Habitaciones");
        }
    }
}
