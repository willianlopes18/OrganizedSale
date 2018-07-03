namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCampoUsuarioIDtblVendas : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Vendas", name: "_Usuario_UsuarioID", newName: "_UsuarioID_UsuarioID");
            RenameIndex(table: "dbo.Vendas", name: "IX__Usuario_UsuarioID", newName: "IX__UsuarioID_UsuarioID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Vendas", name: "IX__UsuarioID_UsuarioID", newName: "IX__Usuario_UsuarioID");
            RenameColumn(table: "dbo.Vendas", name: "_UsuarioID_UsuarioID", newName: "_Usuario_UsuarioID");
        }
    }
}
