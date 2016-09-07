namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoMateriaTurmaETurmaMateria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbMateria",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 50),
                        cargaHoraria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbTurmaMateria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfessorId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbMateria", t => t.MateriaId, cascadeDelete: true)
                .ForeignKey("dbo.tbProfessor", t => t.ProfessorId, cascadeDelete: true)
                .ForeignKey("dbo.tbTurma", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.ProfessorId)
                .Index(t => t.MateriaId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.tbTurma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbTurmaMateria", "TurmaId", "dbo.tbTurma");
            DropForeignKey("dbo.tbTurmaMateria", "ProfessorId", "dbo.tbProfessor");
            DropForeignKey("dbo.tbTurmaMateria", "MateriaId", "dbo.tbMateria");
            DropIndex("dbo.tbTurmaMateria", new[] { "TurmaId" });
            DropIndex("dbo.tbTurmaMateria", new[] { "MateriaId" });
            DropIndex("dbo.tbTurmaMateria", new[] { "ProfessorId" });
            DropTable("dbo.tbTurma");
            DropTable("dbo.tbTurmaMateria");
            DropTable("dbo.tbMateria");
        }
    }
}
