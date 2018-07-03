namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCamposdeValor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "ValorCompra", c => c.Double(nullable: false));
            AlterColumn("dbo.Produtoes", "ValorVenda", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "ValorVenda", c => c.String(nullable: false));
            AlterColumn("dbo.Produtoes", "ValorCompra", c => c.String(nullable: false));
        }
    }
}
