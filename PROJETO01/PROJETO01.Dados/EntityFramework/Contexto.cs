using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93; 
                                     Database = GabrielBorges; 
                                     User ID = RA040847; 
                                     Password = 040847";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<CadastroFesta> CadastroFesta { get; set; }
        public DbSet<Convite> Convite { get; set; }

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property("UF")
                .HasColumnName("Sigla_Est")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("Nome_Est")
                .HasColumnType("varchar(100)")
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        
        
        
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasKey("UsuarioID");

            modelBuilder.Entity<Usuario>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            modelBuilder.Entity<Usuario>()
                .Property("DataNascimento")
                .HasColumnName("DataNascimento")
                .HasColumnType("varchar(200)")
                .IsRequired();
            
            modelBuilder.Entity<Usuario>()
                .Property("Telefone")
                .HasColumnName("Telefone")
                .HasColumnType("varchar(11)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Email")
                .HasColumnName("Email")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Bairro")
                .HasColumnName("Bairro")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Sexo")
                .HasColumnName("Sexo")
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("CEP")
                .HasColumnName("CEP")
                .HasColumnType("char(9)")
                .IsRequired();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organizador>()
                    .ToTable("Organizador")
                    .HasKey("OrganizadorID");

            modelBuilder.Entity<Organizador>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("Telefone")
                .HasColumnName("Telefone")
                .HasColumnType("varchar(11)")
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CadastroFesta>()
                .ToTable("CadastroFesta")
                .HasKey("FestaID");

            modelBuilder.Entity<CadastroFesta>()
                .Property("FestaID")
                .HasColumnName("FestaID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("Estado")
                .HasColumnName("Estado")
                .HasColumnType("char(2)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("DataFesta")
                .HasColumnName("DateFesta")
                .HasColumnType("Date")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("Bairro")
                .HasColumnName("Bairro")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("PrecoIngresso")
                .HasColumnName("PrecoIngresso")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Convite>()
                .ToTable("Convite")
                .HasKey("ConviteID");

            modelBuilder.Entity<Convite>()
                .Property("ConviteID")
                .HasColumnName("ConviteID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("FestaID")
                .HasColumnName("FestaID")
                .HasColumnType("int")
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);






        }






    }
}
