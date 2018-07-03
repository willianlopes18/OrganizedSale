namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoCampoValorVenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "ValorVenda", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "ValorVenda");
        }
    }
}
