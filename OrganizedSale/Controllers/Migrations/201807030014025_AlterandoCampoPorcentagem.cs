namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCampoPorcentagem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Lucro", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "Lucro", c => c.Double(nullable: false));
        }
    }
}
