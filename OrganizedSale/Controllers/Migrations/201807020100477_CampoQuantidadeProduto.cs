namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoQuantidadeProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Quantidade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "Quantidade");
        }
    }
}
