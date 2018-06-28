﻿using Modelos;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            // Padrao (se nao existir base de dados, cria)
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            // Apaga e recria a base toda vez que o projeto eh executado
            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            // Apaga e recria a base de dados se houver alteracoes nas modelos
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());


        }

        public DbSet<Permissao> Permissoes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }
    }
}
