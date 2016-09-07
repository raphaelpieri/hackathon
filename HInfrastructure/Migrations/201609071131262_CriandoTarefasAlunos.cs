namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoTarefasAlunos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbTarefaAluno",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AlunoID = c.String(nullable: false, maxLength: 128),
                        TarefaID = c.Int(nullable: false),
                        nota = c.String(),
                        naoConformidade = c.Boolean(nullable: false),
                        descricaoNConf = c.Decimal(nullable: false, precision: 18, scale: 2),
                        verificadoPeloPai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbAluno", t => t.AlunoID, cascadeDelete: true)
                .ForeignKey("dbo.tbTarefa", t => t.TarefaID, cascadeDelete: true)
                .Index(t => t.AlunoID)
                .Index(t => t.TarefaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbTarefaAluno", "TarefaID", "dbo.tbTarefa");
            DropForeignKey("dbo.tbTarefaAluno", "AlunoID", "dbo.tbAluno");
            DropIndex("dbo.tbTarefaAluno", new[] { "TarefaID" });
            DropIndex("dbo.tbTarefaAluno", new[] { "AlunoID" });
            DropTable("dbo.tbTarefaAluno");
        }
    }
}
