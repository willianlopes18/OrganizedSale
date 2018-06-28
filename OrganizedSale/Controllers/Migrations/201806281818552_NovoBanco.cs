namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Permissaos",
                c => new
                    {
                        PermissaoID = c.Int(nullable: false, identity: true),
                        TipoPermissao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PermissaoID);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        CategoriaID = c.Int(nullable: false),
                        Marca = c.String(nullable: false, maxLength: 50),
                        Modelo = c.String(nullable: false),
                        ValorCompra = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Senha = c.String(nullable: false, maxLength: 20),
                        DataNascimento = c.DateTime(nullable: false),
                        PermissaoID = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .ForeignKey("dbo.Permissaos", t => t.PermissaoID, cascadeDelete: true)
                .Index(t => t.PermissaoID);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        ProdutoID = c.Int(nullable: false),
                        ValorVenda = c.Single(nullable: false),
                        Usuario = c.Int(nullable: false),
                        _Usuario_UsuarioID = c.Int(),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoID, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t._Usuario_UsuarioID)
                .Index(t => t.ProdutoID)
                .Index(t => t._Usuario_UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "_Usuario_UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Vendas", "ProdutoID", "dbo.Produtoes");
            DropForeignKey("dbo.Usuarios", "PermissaoID", "dbo.Permissaos");
            DropForeignKey("dbo.Produtoes", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Vendas", new[] { "_Usuario_UsuarioID" });
            DropIndex("dbo.Vendas", new[] { "ProdutoID" });
            DropIndex("dbo.Usuarios", new[] { "PermissaoID" });
            DropIndex("dbo.Produtoes", new[] { "CategoriaID" });
            DropTable("dbo.Vendas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Permissaos");
            DropTable("dbo.Categorias");
        }
    }
}
