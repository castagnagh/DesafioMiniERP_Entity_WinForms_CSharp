using Microsoft.EntityFrameworkCore;
using MiniERP_Entity.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_Entity
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ClienteProduto> ClientesProdutos { get; set; }
        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=miniERP_Entity;User ID=usuario;Password=senha123");
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //aqui eu modelo a tabela entidade relacionamento Cliente_Produto (n:n)
            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Produtos)
                .WithMany(e => e.Clientes)
                //conforme documentação, orienta a utilizar uma data, para registro
                .UsingEntity<ClienteProduto>(
                    j => j.Property(e => e.Data).HasDefaultValueSql("CURRENT_TIMESTAMP"));

            //aqui faço a relação de 1:n 1 fornecedor pode ter muitos produtos, criando a FK de fornecedor na tabela produtos
            modelBuilder.Entity<Produto>()
                .HasOne(c => c.Fornecedor)
                .WithMany(f => f.Produtos)
                .OnDelete(DeleteBehavior.ClientCascade);

            //declaro a propriedade decimal
            modelBuilder.Entity<ClienteProduto>()
                .Property(c => c.PrecoTotal)
                .HasColumnType("decimal(18,2)");

            //declaro a propriedade decimal
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");
        }

    }
}
