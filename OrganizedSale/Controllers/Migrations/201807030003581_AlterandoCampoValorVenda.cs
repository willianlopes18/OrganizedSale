namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCampoValorVenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Lucro", c => c.Double(nullable: false));
            DropColumn("dbo.Produtoes", "ValorVenda");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "ValorVenda", c => c.Double(nullable: false));
            DropColumn("dbo.Produtoes", "Lucro");
        }
    }
}
