namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCampoUsuariotblVendas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendas", "_UsuarioID_UsuarioID", "dbo.Usuarios");
            DropIndex("dbo.Vendas", new[] { "_UsuarioID_UsuarioID" });
            RenameColumn(table: "dbo.Vendas", name: "_UsuarioID_UsuarioID", newName: "UsuarioID");
            AlterColumn("dbo.Vendas", "UsuarioID", c => c.Int(nullable: false));
            CreateIndex("dbo.Vendas", "UsuarioID");
            AddForeignKey("dbo.Vendas", "UsuarioID", "dbo.Usuarios", "UsuarioID", cascadeDelete: true);
            DropColumn("dbo.Vendas", "Usuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendas", "Usuario", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vendas", "UsuarioID", "dbo.Usuarios");
            DropIndex("dbo.Vendas", new[] { "UsuarioID" });
            AlterColumn("dbo.Vendas", "UsuarioID", c => c.Int());
            RenameColumn(table: "dbo.Vendas", name: "UsuarioID", newName: "_UsuarioID_UsuarioID");
            CreateIndex("dbo.Vendas", "_UsuarioID_UsuarioID");
            AddForeignKey("dbo.Vendas", "_UsuarioID_UsuarioID", "dbo.Usuarios", "UsuarioID");
        }
    }
}
