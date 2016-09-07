namespace HInfrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTarefa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbTarefa", "nota", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbTarefa", "nota");
        }
    }
}
