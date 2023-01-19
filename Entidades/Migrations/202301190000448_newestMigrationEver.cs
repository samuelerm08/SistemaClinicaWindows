namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newestMigrationEver : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Medicos", "PostGrado");
            DropColumn("dbo.Medicos", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicos", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Medicos", "PostGrado", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
