﻿// <auto-generated />
using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibrarySystem.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Planoid")
                        .HasColumnType("int");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rg")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Planoid");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Colaborador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rg")
                        .HasColumnType("int");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("preco")
                        .HasColumnType("real");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Movimentacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("livroid")
                        .HasColumnType("int");

                    b.Property<int>("movimento")
                        .HasColumnType("int");

                    b.Property<float>("preco")
                        .HasColumnType("real");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("livroid");

                    b.ToTable("Movimentacoes");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Plano", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("porcen_desconto")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.HasOne("LibrarySystem.Models.Dominio.Plano", "Plano")
                        .WithMany("cliente")
                        .HasForeignKey("Planoid");

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Movimentacao", b =>
                {
                    b.HasOne("LibrarySystem.Models.Dominio.Cliente", "cliente")
                        .WithMany("movimentacao")
                        .HasForeignKey("clienteid");

                    b.HasOne("LibrarySystem.Models.Dominio.Livro", "livro")
                        .WithMany("movimentacao")
                        .HasForeignKey("livroid");

                    b.Navigation("cliente");

                    b.Navigation("livro");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Cliente", b =>
                {
                    b.Navigation("movimentacao");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Livro", b =>
                {
                    b.Navigation("movimentacao");
                });

            modelBuilder.Entity("LibrarySystem.Models.Dominio.Plano", b =>
                {
                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
