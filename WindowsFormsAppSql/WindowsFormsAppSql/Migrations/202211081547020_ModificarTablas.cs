namespace WindowsFormsAppSql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
            AddColumn("dbo.Profesor", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesor", "Titulo");
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
