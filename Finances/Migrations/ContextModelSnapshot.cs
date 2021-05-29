﻿// <auto-generated />
using System;
using Finances.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Finances.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Finances.Models.Ativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int?>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<bool>("Recorrente")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rendimento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("MovimentacaoId");

                    b.ToTable("Ativos");
                });

            modelBuilder.Entity("Finances.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Finances.Models.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int?>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<bool>("Recorrente")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("MovimentacaoId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Finances.Models.Saida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int?>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<bool>("Recorrente")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("MovimentacaoId");

                    b.ToTable("Saidas");
                });

            modelBuilder.Entity("Finances.Models.TipoConta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposConta");
                });

            modelBuilder.Entity("Finances.Models.TipoMovimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposMovimentacao");
                });

            modelBuilder.Entity("Finances.Models.Ativo", b =>
                {
                    b.HasOne("Finances.Models.TipoConta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId");

                    b.HasOne("Finances.Models.TipoMovimentacao", "Movimentacao")
                        .WithMany()
                        .HasForeignKey("MovimentacaoId");

                    b.Navigation("Conta");

                    b.Navigation("Movimentacao");
                });

            modelBuilder.Entity("Finances.Models.Conta", b =>
                {
                    b.HasOne("Finances.Models.TipoConta", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Finances.Models.Entrada", b =>
                {
                    b.HasOne("Finances.Models.TipoConta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId");

                    b.HasOne("Finances.Models.TipoMovimentacao", "Movimentacao")
                        .WithMany()
                        .HasForeignKey("MovimentacaoId");

                    b.Navigation("Conta");

                    b.Navigation("Movimentacao");
                });

            modelBuilder.Entity("Finances.Models.Saida", b =>
                {
                    b.HasOne("Finances.Models.TipoConta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId");

                    b.HasOne("Finances.Models.TipoMovimentacao", "Movimentacao")
                        .WithMany()
                        .HasForeignKey("MovimentacaoId");

                    b.Navigation("Conta");

                    b.Navigation("Movimentacao");
                });
#pragma warning restore 612, 618
        }
    }
}