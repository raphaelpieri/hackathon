namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoTarefa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbTarefa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TurmaMateriaID = c.Int(nullable: false),
                        titulo = c.String(maxLength: 50),
                        descricao = c.String(maxLength: 250),
                        dataInicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        dataFinal = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbTurmaMateria", t => t.TurmaMateriaID, cascadeDelete: true)
                .Index(t => t.TurmaMateriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbTarefa", "TurmaMateriaID", "dbo.tbTurmaMateria");
            DropIndex("dbo.tbTarefa", new[] { "TurmaMateriaID" });
            DropTable("dbo.tbTarefa");
        }
    }
}
