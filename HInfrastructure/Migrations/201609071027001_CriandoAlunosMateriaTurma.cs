namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoAlunosMateriaTurma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbAlunoMateiraTurma",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TurmaMateriaId = c.Int(nullable: false),
                        AlunoID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbAluno", t => t.AlunoID, cascadeDelete: true)
                .ForeignKey("dbo.tbTurmaMateria", t => t.TurmaMateriaId, cascadeDelete: true)
                .Index(t => t.TurmaMateriaId)
                .Index(t => t.AlunoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbAlunoMateiraTurma", "TurmaMateriaId", "dbo.tbTurmaMateria");
            DropForeignKey("dbo.tbAlunoMateiraTurma", "AlunoID", "dbo.tbAluno");
            DropIndex("dbo.tbAlunoMateiraTurma", new[] { "AlunoID" });
            DropIndex("dbo.tbAlunoMateiraTurma", new[] { "TurmaMateriaId" });
            DropTable("dbo.tbAlunoMateiraTurma");
        }
    }
}
