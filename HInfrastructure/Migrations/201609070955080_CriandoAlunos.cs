namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoAlunos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbAluno",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        nome = c.String(maxLength: 50),
                        PaiID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbPai", t => t.PaiID, cascadeDelete: true)
                .Index(t => t.PaiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbAluno", "PaiID", "dbo.tbPai");
            DropIndex("dbo.tbAluno", new[] { "PaiID" });
            DropTable("dbo.tbAluno");
        }
    }
}
