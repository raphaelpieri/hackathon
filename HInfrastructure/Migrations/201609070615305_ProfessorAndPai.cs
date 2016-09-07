namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfessorAndPai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbPai",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cpf = c.String(nullable: false, maxLength: 20),
                        nome = c.String(nullable: false, maxLength: 50),
                        email = c.String(maxLength: 50),
                        senha = c.String(nullable: false, maxLength: 50),
                        tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbProfessor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cpf = c.String(nullable: false, maxLength: 20),
                        nome = c.String(nullable: false, maxLength: 50),
                        email = c.String(maxLength: 50),
                        senha = c.String(nullable: false, maxLength: 50),
                        tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbProfessor");
            DropTable("dbo.tbPai");
        }
    }
}
