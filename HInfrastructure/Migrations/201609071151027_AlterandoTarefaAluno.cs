namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTarefaAluno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbTarefaAluno", "descricaoNConf", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbTarefaAluno", "descricaoNConf", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
