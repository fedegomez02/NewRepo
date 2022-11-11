namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        legajo = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Departamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_Id)
                .Index(t => t.Departamento_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Departamento_Id", "dbo.Departamentoes");
            DropIndex("dbo.Empleadoes", new[] { "Departamento_Id" });
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Departamentoes");
        }
    }
}
