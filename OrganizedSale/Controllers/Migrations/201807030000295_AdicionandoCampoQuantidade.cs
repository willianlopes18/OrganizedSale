namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoCampoQuantidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendas", "Quantidade", c => c.Int(nullable: false));
            AlterColumn("dbo.Vendas", "ValorVenda", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendas", "ValorVenda", c => c.Single(nullable: false));
            DropColumn("dbo.Vendas", "Quantidade");
        }
    }
}
